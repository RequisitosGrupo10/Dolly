using System;
using System.Drawing;
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
            tAforo.Enabled = false;
            tDisponible.Text = Disponible();
            tDisponible.Enabled = false;
            tResponsableDeSede.Text = sede.Responsable.Username;
            tResponsableDeSede.Enabled = false;
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

        private String Disponible()
        {
            int rows = dataGridView.RowCount;
            int disponible = int.Parse(tAforo.Text);
            //disponible -= (int)dataGridView1.SelectedRows[i].Cells[1].Value; //seleccionar numero estudiantes de un centro
            return disponible.ToString();
        }

        private void bInsertarAula_Click(object sender, EventArgs e)
        {
            Aula aula = new Aula("Nueva aula",0, sede.IdSede);
            AulaTab ventana = new AulaTab(aula); //Crear tab insertar aula
            ventana.ShowDialog();
            Mostrar();
        }

        private void bModificarAula_Click(object sender, EventArgs e)
        {

            if (seleccionado != null)
            {
                AulaTab ventana = new AulaTab(seleccionado); //Crear tab insertar aula
                ventana.ShowDialog();
                Mostrar();
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
                toggleButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void toggleButton()
        {
            if (seleccionado != null)
            {
                bModificarAula.Enabled = true;
                bModificarAula.BackColor = SystemColors.Control;
                bEliminarAula.Enabled = true;
                bEliminarAula.BackColor = SystemColors.Control;
            }
            else
            {
                bModificarAula.Enabled = false;
                bModificarAula.BackColor = SystemColors.ControlDark;
                bEliminarAula.Enabled = false;
                bEliminarAula.BackColor = SystemColors.ControlDark;
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
