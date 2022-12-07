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
    public partial class GestionarAulasTab : Form
    {
        public GestionarAulasTab()
        {
            InitializeComponent();
        }

        private void lResponsable_Click(object sender, EventArgs e)
        {

        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModificarAulaTab modificarAulaTab = new ModificarAulaTab();
            modificarAulaTab.ShowDialog();
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
