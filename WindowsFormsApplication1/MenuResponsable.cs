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
    public partial class MenuResponsable : Form
    {
        Usuario responsableDeSede;
        public MenuResponsable(Usuario usuario)
        {
            this.responsableDeSede = usuario;
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            lNombreSede.Text = responsableDeSede.TrabajaEn.Nombre;
            tAforo.Text = Aforo();
            tAforo.Enabled = false;
            tResponsableDeSede.Text = responsableDeSede.Username;
            tResponsableDeSede.Enabled = false;
        }

        private void lResponsableDeSede_Enter(object sender, EventArgs e)
        {
            Mostrar();
        }

        private String Aforo()
        {
            int aforo = 0;
            foreach (Aula aula in Aula.ListaAula(responsableDeSede.TrabajaEn))
            {
                aforo += aula.Aforo;
            }
            return aforo.ToString();
        }

        private void bGestionarSede_Click(object sender, EventArgs e)
        {
            GestionarSedeTab gestionarSedeTab = new GestionarSedeTab(responsableDeSede);
            gestionarSedeTab.ShowDialog();
        }

        private void bGestionarAulas_Click(object sender, EventArgs e)
        {
            GestionarAulasTab gestionarAulasTab = new GestionarAulasTab(responsableDeSede, tAforo.Text);
            gestionarAulasTab.ShowDialog();
        }

        private void bGestionarProfesores_Click(object sender, EventArgs e)
        {
            GestionarProfesoresTab gestionarProfesoresTab = new GestionarProfesoresTab(responsableDeSede);
            gestionarProfesoresTab.ShowDialog();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
