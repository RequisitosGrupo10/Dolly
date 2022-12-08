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
        Object[] seleccionado;

        public GestionarAulasTab(Usuario usuario, string aforo)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.textAforo.Text = aforo;
            this.textResponsable.Text = usuario.Username;
            Mostrar();
        }

        private void Mostrar()
        {
            List<Object[]> listaAulas = ObtenerDatos();
            foreach (Object[] aula in listaAulas)
            {
                dataGridListaAulas.Rows.Add(new object[] { aula[0], aula[1], aula[2], aula[3] });
            }
        }


        private void bModificar_Click(object sender, EventArgs e)
        {
            ModificarAulaTab modificarAulaTab = new ModificarAulaTab(new Aula((int)seleccionado[0]), usuario, seleccionado[2]);
            modificarAulaTab.ShowDialog();
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<object[]> ObtenerDatos()
        {
            MySqlBD bd = new MySqlBD();
            string sel = "select distinct A.idAula, A.nombre, D.responsable, AA.nombre " +
                        "from Aula A join DisponibilidadAulas D on(A.idAula = D.idAula) " +
                        "join Prueba P on(A.idAula = P.idAula) " +
                        "join Examen E on(P.idExamen = E.idExamen) " +
                        "join Asignatura AA on(E.idAsignatura = AA.idAsignatura) " +
                        "where idSede = " + usuario.TrabajaEn.IdSede + ";";
            return bd.Select(sel);
        }

    }
}
