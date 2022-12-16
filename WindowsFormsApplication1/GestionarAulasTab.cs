using BDLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GestionarAulasTab : Form
    {
        private static MySqlBD miBD = new MySqlBD();
        private Usuario responsableDeSede;
        private FranjaHoraria franja;
        Object[] seleccionado;

        public GestionarAulasTab(Usuario usuario, string aforo)
        {
            InitializeComponent();
            this.responsableDeSede = usuario;
            this.textAforo.Text = aforo;
            this.textResponsable.Text = usuario.Username;
            this.comboFranja.DataSource = FranjaHoraria.ListarFranjas();
            this.comboFranja.SelectedIndex = 1;
            franja = (FranjaHoraria)this.comboFranja.Items[1];
            Mostrar();
        }

        private void Mostrar()
        {
            dataGridListaAulas.Rows.Clear();
            dataGridListaAulas.Refresh();
            seleccionado = null;
            toggleButton(bModificar);
            List<Object[]> listaAulas = ObtenerDatos();
            foreach (Object[] aula in listaAulas)
            {
                string nombreDeResponsable = null;
                if (aula[2].ToString().Length != 0)
                    nombreDeResponsable = new Usuario((int)aula[2]).Username;                
                dataGridListaAulas.Rows.Add(new object[] { aula[0], aula[1], nombreDeResponsable, aula[3] });
            }
        }

        private void comboFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            franja = (FranjaHoraria) this.comboFranja.Items[comboFranja.SelectedIndex];
            lFranjaSeleccionada.Text = franja.ToString();
            Mostrar();
        }

        private void dataGridListaAulas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridListaAulas.SelectedRows.Count > 0)
            {
                seleccionado = new Object[4];
                seleccionado[0] = dataGridListaAulas.SelectedRows[0].Cells[0].Value;
                seleccionado[1] = dataGridListaAulas.SelectedRows[0].Cells[1].Value;
                seleccionado[2] = dataGridListaAulas.SelectedRows[0].Cells[2].Value;
                seleccionado[3] = dataGridListaAulas.SelectedRows[0].Cells[3].Value;
                toggleButton(bModificar);
            }
            else
            {
                seleccionado = null;
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            if (seleccionado[0] != null)
            {
                Usuario responsableDeAula = null;
                if(seleccionado[2] != null)
                    responsableDeAula = new Usuario(seleccionado[2].ToString());                
                Aula aula = new Aula((string)seleccionado[0], responsableDeSede.TrabajaEn.IdSede);
                ModificarAulaTab modificarAulaTab = new ModificarAulaTab(aula, responsableDeAula, franja);
                modificarAulaTab.ShowDialog();
                Mostrar();
            }
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Object[]> ObtenerDatos()
        {
            string sel = "select distinct A.nombre, A.aforo, D.responsable, AA.nombre " +
                        "from Aula A join DisponibilidadAulas D on (A.idAula = D.idAula) " +
                        "join Examen E on (E.franja = D.franja) " +
                        "join Asignatura AA on (E.idAsignatura = AA.idAsignatura) " +
                        "where idSede = " + responsableDeSede.TrabajaEn.IdSede +
                        " and D.franja = '" + franja.ToString() + "';";
            return miBD.Select(sel);
        }


        private List<string> ListaFranjas()
        {
            List<string> result = new List<string>();
            MySqlBD bd = new MySqlBD();
            List<Object[]> lista = bd.Select("Select * from FranjaHoraria;");
            foreach(Object[] obj in lista)
            {
                result.Add(obj[0].ToString());
            }

            return result;
        }

        private void toggleButton(Button button)
        {
            if (seleccionado != null)
            {
                button.Enabled = true;
                button.BackColor = SystemColors.Control;
            }
            else
            {
                button.Enabled = false;
                button.BackColor = SystemColors.ControlDark;
            }
        }

    }
}
