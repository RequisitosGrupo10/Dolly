using BDLibrary;
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
        Sede sede;
        Usuario responsableDeAula;
        FranjaHoraria franja;

        List<Usuario> profesorSeleccionado;

        public ModificarAulaTab(Aula aula, Usuario responsableDeAula, FranjaHoraria franja)
        {
            InitializeComponent();
            this.sede = aula.Sede;
            this.franja= franja;
            this.aula = aula;
            if (responsableDeAula != null)
                this.responsableDeAula = responsableDeAula;            
            tFranja.Text = franja.ToString(); //Invariable, así que lo pongo aquí

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
            List<Usuario> profesoresLibres = Usuario.ListaProfesoresLibres(sede,franja);
            foreach (Usuario u in profesoresLibres)
            {
                listProfesores.Items.Add(u);
            }
            MySqlBD bd = new MySqlBD();
            List<Usuario> vigilantes = new List<Usuario>();
            foreach (Object[] v in bd.Select("SELECT idVigilante from vigilante INNER JOIN DisponibilidadAulas WHERE franja = '" + franja + "';"))
            {
                vigilantes.Add(new Usuario((int) v[0]));
            }
            dataGridVigilantes.DataSource = vigilantes;
        }

        private void bAsignarResponsable_Click(object sender, EventArgs e)
        {
            if (profesorSeleccionado.Count>0)
            {
                if (!tResponsableAula.Text.Equals(""))
                    listProfesores.Items.Add(new Usuario(tResponsableAula.Text));
                tResponsableAula.Text = profesorSeleccionado[0].Username;
                listProfesores.Items.Remove(profesorSeleccionado[0]);
            }
        }

        private void bEliminarResponsable_Click(object sender, EventArgs e)
        {
            if (!tResponsableAula.Text.Equals(""))
            {
                listProfesores.Items.Add(new Usuario(tResponsableAula.Text));
            }
            tResponsableAula.Text = "";
        }

        private void listProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            profesorSeleccionado = new List<Usuario>();
            foreach (Usuario u in listProfesores.SelectedItems){
                profesorSeleccionado.Add(u);
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            MySqlBD bd = new MySqlBD();
            //Comprobar cambio responsable
            if (responsableDeAula == null && !tResponsableAula.Text.Equals(""))
            {
                responsableDeAula = new Usuario(tResponsableAula.Text);
                bd.Insert("UPDATE DisponibilidadAulas SET responsable = "+responsableDeAula.IdUsuario+" WHERE idAula = " + aula.IdAula+" AND franja = '"+franja+"';");
            }
            else if (!responsableDeAula.Username.Equals(tResponsableAula.Text))
            {
                if (!tResponsableAula.Text.Equals(""))
                {
                    responsableDeAula = new Usuario(tResponsableAula.Text);
                    bd.Update("UPDATE DisponibilidadAulas SET responsable = " + responsableDeAula.IdUsuario + " WHERE franja = '" + franja + "' AND idAula = " + aula.IdAula + ";");
                }
                else
                {
                    responsableDeAula = null;
                    bd.Update("UPDATE DisponibilidadAulas SET responsable = null WHERE franja = '" + franja + "' AND idAula = " + aula.IdAula + ";");
                }
            }

            //Comprobar cambios en vigilantes
            this.Close();
        }

        private void bAsignarVigilante_Click(object sender, EventArgs e)
        {
            if(listProfesores.SelectedItems.Count > 0)
            {
                var profesoresSeleccionados = listProfesores.SelectedItems;

            }
        }
    }
}
