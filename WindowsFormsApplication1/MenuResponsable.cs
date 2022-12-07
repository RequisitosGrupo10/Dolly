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
        Sede sede;
        public MenuResponsable(Sede sede)
        {
            this.sede = sede;
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            lNombreSede.Text = sede.Nombre;
            tAforo.Text = Aforo();
            tAforo.Enabled = false;
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

        private void bGestionarSede_Click(object sender, EventArgs e)
        {
            GestionarSedeTab gestionarSedeTab = new GestionarSedeTab(sede);
            gestionarSedeTab.ShowDialog();
            this.Close();
        }

        private void bGestionarAulas_Click(object sender, EventArgs e)
        {
            GestionarAulasTab gestionarAulasTab = new GestionarAulasTab();
            gestionarAulasTab.ShowDialog();
            this.Close();
        }

        private void bGestionarProfesores_Click(object sender, EventArgs e)
        {
            GestionarProfesoresTab gestionarProfesoresTab = new GestionarProfesoresTab(sede);
            gestionarProfesoresTab.ShowDialog();
            this.Close();
        }

        private void bGestionarExamenes_Click(object sender, EventArgs e)
        {
            GestionarExamenesTab gestionarExamenesTab = new GestionarExamenesTab();
            gestionarExamenesTab.ShowDialog();
            this.Close();
        }
    }
}
