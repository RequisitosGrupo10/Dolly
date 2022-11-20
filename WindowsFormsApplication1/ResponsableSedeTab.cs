using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ResponsableSedeTab : Form
    {
        Aula seleccionado;
        Sede sede; 
            //Obtener el Usuario que está conectado, hace falta login. De ahí obtener la sede a la que está asignado
        public ResponsableSedeTab(Sede sede)
        {
            this.sede = sede;
            InitializeComponent();
            Mostrar();
            seleccionado = null;
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = Aula.ListaAula(sede);
            lSede.Text = sede.Nombre;
            tAforo.Text = Aforo();
            tResponsable.Text = sede.Responsable.Username;
        }
        private String Aforo()
        {
            int aforo = 0;
            foreach (Aula aula in Aula.ListaAula(sede))
            {
                aforo += aula.Aforo;
            }
            return aforo.ToString();
        }

        private void bInsertarAula_Click(object sender, EventArgs e)
        {
            //AdminSedeTab ventana = new AdminSedeTab(seleccionado); //Crear tab insertar aula
            //ventana.ShowDialog();
        }

        private void bModificarAula_Click(object sender, EventArgs e)
        {

            if (seleccionado != null)
            {
                //AdminSedeTab ventana = new AdminSedeTab(seleccionado); //Crear tab modificar aula
                //ventana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un aula para modificar", "Error", MessageBoxButtons.OK);
            }
        }

        private void bBorrarAula_Click(object sender, EventArgs e)
        {

            if (seleccionado != null)
            {
                seleccionado.borrarAula();
                seleccionado = null;
                Mostrar();
            }
            else
            {
                MessageBox.Show("Selecciona un aula para borrar", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int idAula = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    seleccionado = new Aula(idAula);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
