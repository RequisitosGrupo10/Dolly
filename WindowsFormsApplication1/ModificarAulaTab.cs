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
    public partial class ModificarAulaTab : Form
    {
        Aula aula;
        Usuario responsableDeSede;
        Usuario responsableDeAula;
        public ModificarAulaTab(Aula aula, Usuario responsableDeSede, string idResponsableDeAula)
        {
            InitializeComponent();
            this.aula = aula;
            this.responsableDeSede = responsableDeSede;
            if (idResponsableDeAula.Length > 0 )
            {
                this.responsableDeAula = new Usuario(int.Parse(idResponsableDeAula));
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
