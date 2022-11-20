using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ResponsableSedeTab : Form
    {
        //FALTA HACER MODIFICAR AULA Y RELLENAR DISPONIBLE
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
            dataGridView.DataSource = Aula.ListaAula(sede);
            lNombreSede.Text = sede.Nombre;
            tAforo.Text = Aforo();
            tResponsableDeSede.Text = sede.Responsable.Username;
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
            AulaTab ventana = new AulaTab(new Aula("Nueva Aula")); //Crear tab insertar aula
            ventana.ShowDialog();
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

        private void bEliminarAula_Click(object sender, EventArgs e)
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

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int idAula = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                    seleccionado = new Aula(idAula);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
