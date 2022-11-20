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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsignaturaTab ventana = new AsignaturaTab();
            ventana.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstudianteTab ventana = new EstudianteTab();
            ventana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SedeTab ventana = new SedeTab();
            ventana.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            UsersTab ventana = new UsersTab();
            ventana.ShowDialog();
        }

        private void btnFranjas_Click(object sender, EventArgs e)
        {
            FranjasTab ventana = new FranjasTab();
            ventana.ShowDialog();
        }
    }
}
