using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdminSedeTab : Form
    {
        //FALTA HACER ASIGNAR CENTROS
        Centro centroSedeSeleccionado;
        Centro centroSeleccionado;
        Usuario responsableSeleccionado;
        Sede sede;
        public AdminSedeTab(Sede sede)
        {
            this.sede = sede;
            InitializeComponent();
            Mostrar();
            responsableSeleccionado = null;
            centroSeleccionado = null;
        }

        private void Mostrar()
        {
            dataGridView.DataSource = Centro.ListaCentro(sede);
            lNombreSede.Text = sede.Nombre;
            tAforo.Text = Aforo();
            tDisponible.Text = Disponible();
            tResponsableDeSede.Text = Responsable();
            listResponsableDeSede.DataSource = Usuario.ListaResponsablesDisponibles();
            listCentros.DataSource = Centro.ListaCentrosDisponibles();
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

        private String Responsable()
        {
            if (sede.Responsable == null)
                return "";
            else
                return sede.Responsable.Username;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int idCentro = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                    String nombre = (String)dataGridView.SelectedRows[0].Cells[1].Value;
                    //int idSede = (int)dataGridView.SelectedRows[0].Cells[2].Value;
                    centroSedeSeleccionado = new Centro(idCentro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bAsignarResponsableDeSede_Click(object sender, EventArgs e)
        {
            if (responsableSeleccionado != null)
            {
                Console.WriteLine("Añadiendo a " + responsableSeleccionado);
                sede.Responsable = responsableSeleccionado;
                Mostrar();
            }
        }

        private void bQuitarResponsableDeSede_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminando a " + sede.Responsable);
            sede.Responsable = null;
            Mostrar();
        }

        private void lResponsableDeSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listResponsableDeSede.SelectedItem != null)
                {
                    responsableSeleccionado = (Usuario)listResponsableDeSede.SelectedItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bAsignarCentro_Click(object sender, EventArgs e)
        {
            if (centroSeleccionado != null)
            {
                Console.WriteLine("Añadiendo a " + centroSeleccionado);
                centroSeleccionado.Sede = sede;
                Mostrar();
            }
        }

        private void bQuitarCentro_Click(object sender, EventArgs e)
        {
            if (centroSedeSeleccionado != null)
            {
                Console.WriteLine("Eliminando " + centroSedeSeleccionado);
                centroSedeSeleccionado.Sede = null;
                Mostrar();
            }
        }

        private void listCentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listCentros.SelectedItem != null)
                {
                    centroSeleccionado = (Centro)listCentros.SelectedItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
