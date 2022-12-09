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
        Usuario responsableDeAula;
        string franja;
        public ModificarAulaTab(Aula aula, string idResponsableDeAula, String franja)
        {
            InitializeComponent();
            this.franja= franja;
            this.aula = aula;
            if (idResponsableDeAula.Length > 0 )
            {
                this.responsableDeAula = new Usuario(int.Parse(idResponsableDeAula));
            }
            tFranja.Text = franja; //Invariable, así que lo pongo aquí

            mostrar();
        }

        private void mostrar()
        {
            if (responsableDeAula != null)
            {
                tResponsableAula.Text = responsableDeAula.Username;
            }else
            {
                tResponsableAula.Text = "";
            }

            listProfesores.Items.Clear();
            List<Usuario> profesoresLibres = Usuario.ListaProfesoresLibres(new FranjaHoraria(franja));
            foreach (Usuario u in profesoresLibres)
            {
                listProfesores.Items.Add(u);
            }

            //TODO Datagridvigilantes

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
