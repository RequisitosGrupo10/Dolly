using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdminSedeTab : Form
    {
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
            dataGridView1.DataSource = Centro.ListaCentro();
            lSede.Text = sede.Nombre;
            tAforo.Text = Aforo();
            tDisponible.Text = Disponible();
            tResponsable.Text = Responsable();
            listResponsable.DataSource = Usuario.ListaResponsablesDisponibles();
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
            int rows = dataGridView1.RowCount;
            int disponible = int.Parse(tAforo.Text);
            for (int i = 0; i < rows; i++)
            {
                //disponible -= (int)dataGridView1.SelectedRows[i].Cells[1].Value; //seleccionar numero estudiantes de un centro
            }
            return disponible.ToString();
        }

        private String Responsable()
        {
            if (sede.Responsable == null)
            {
                return "";
            }
            return sede.Responsable.Username;
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int idSede = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    String nombre = (String)dataGridView1.SelectedRows[0].Cells[1].Value;
                    int idCentro = (int)dataGridView1.SelectedRows[0].Cells[2].Value;
                    centroSeleccionado = new Centro(idCentro);
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

        private void lResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listResponsable.SelectedItem != null)
                {
                    responsableSeleccionado = (Usuario)listResponsable.SelectedItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bInserResponsable_Click(object sender, EventArgs e)
        {
            if (responsableSeleccionado != null)
            {
                Console.WriteLine("Añadiendo a " + responsableSeleccionado);
                sede.Responsable = responsableSeleccionado;
                Mostrar();
            }
        }

        private void bBorrarResponsable_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminando a " + sede.Responsable);
            sede.Responsable = null;
            Mostrar();
        }
    }
}
