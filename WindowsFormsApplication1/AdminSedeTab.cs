using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdminSedeTab : Form
    {
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
            tAforo.Enabled = false;
            tDisponible.Text = Disponible();
            tDisponible.Enabled = false;
            tResponsableDeSede.Text = Responsable();
            tResponsableDeSede.Enabled = false;
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

            int disponible = int.Parse(Aforo());
            int rows = dataGridView.RowCount;
            for (int i = 0; i < rows; i++)
            {
                int idCentro = (int)dataGridView.Rows[i].Cells[0].Value;
                Centro aux = new Centro(idCentro);
                disponible = disponible - aux.aforoCentro();
            }
            return disponible.ToString();
        }

        private String Responsable()
        {
            if (sede.ResponsableSede() == null)
                return "";
            else
                return sede.ResponsableSede().Username;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int idCentro = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                    String nombre = (String)dataGridView.SelectedRows[0].Cells[1].Value;
                    centroSedeSeleccionado = new Centro(idCentro);
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
            if (centroSedeSeleccionado != null)
            {
                bQuitarCentro.Enabled = true;
                bQuitarCentro.BackColor = SystemColors.Control;
            }
            else
            {
                bQuitarCentro.Enabled = false;
                bQuitarCentro.BackColor = SystemColors.ControlDark;
            }
        }

        private void bAsignarResponsableDeSede_Click(object sender, EventArgs e)
        {
            if (responsableSeleccionado != null)
            {
                Console.WriteLine("Añadiendo a " + responsableSeleccionado);
                responsableSeleccionado.TrabajaEn = sede;
                Mostrar();
            }
        }

        private void bQuitarResponsableDeSede_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminando a " + sede.ResponsableSede());
            sede.ResponsableSede().TrabajaEn = null;
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
