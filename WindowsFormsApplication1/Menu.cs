using System;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bGestionarAsignaturas_Click(object sender, EventArgs e)
        {
            AsignaturaTab ventana = new AsignaturaTab();
            ventana.ShowDialog();
        }

        private void bGestionarEstudiantes_Click(object sender, EventArgs e)
        {
            EstudianteTab ventana = new EstudianteTab();
            ventana.ShowDialog();
        }

        private void bGestionarSedes_Click(object sender, EventArgs e)
        {
            SedeTab ventana = new SedeTab();
            ventana.ShowDialog();
        }

        private void bGestionarFranjasHorarias_Click(object sender, EventArgs e)
        {
            FranjasTab ventana = new FranjasTab();
            ventana.ShowDialog();
        }

        private void bGestionarUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosTab ventana = new UsuariosTab();
            ventana.ShowDialog();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bExamen_Click(object sender, EventArgs e)
        {
            ExamenTab ventana = new ExamenTab();
            ventana.ShowDialog();
        }
    }
}
