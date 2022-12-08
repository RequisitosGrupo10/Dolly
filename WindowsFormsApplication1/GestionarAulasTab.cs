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
        private Usuario usuario;
        private string franja;
        Object[] seleccionado;

        public GestionarAulasTab(Usuario usuario, string aforo)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.textAforo.Text = aforo;
            this.textResponsable.Text = usuario.Username;
            this.comboFranja.DataSource = ListaFranjas();
            this.comboFranja.SelectedIndex = 1;
            franja = this.comboFranja.Items[1].ToString();
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
                dataGridListaAulas.Rows.Add(new object[] { aula[0], aula[1], aula[2], aula[3] });
            }

        }

        private void comboFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            franja = this.comboFranja.Items[comboFranja.SelectedIndex].ToString();
            lFranjaSeleccionada.Text = franja;
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
        }

        private void bModificar_Click(object sender, EventArgs e)
        {

            ModificarAulaTab modificarAulaTab = new ModificarAulaTab(new Aula((int)seleccionado[0]), usuario, seleccionado[2].ToString());
            modificarAulaTab.ShowDialog();
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<object[]> ObtenerDatos()
        {
            MySqlBD bd = new MySqlBD();
            string sel = "select distinct A.idAula, A.nombre, D.responsable, AA.nombre, D.franja " +
                        "from Aula A join DisponibilidadAulas D on (A.idAula = D.idAula) " +
                        "join Examen E on (E.franja = D.franja) " +
                        "join Asignatura AA on (E.idAsignatura = AA.idAsignatura) " +
                        "where idSede = " + usuario.TrabajaEn.IdSede +
                        " and D.franja = '" + franja + "';" ;
            return bd.Select(sel);
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
