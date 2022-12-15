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
        MySqlBD bd;

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
            bd = new MySqlBD();
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
            foreach(Usuario u in Usuario.ListaVigilantes(franja,aula))
            {
                dataGridVigilantes.Rows.Add(u);
            }
            dataGridVigilantes.ClearSelection();
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
            //Comprobar cambio responsable
            if(responsableDeAula != null)
            {
                if (tResponsableAula.Text.Equals("")) // responsable eliminado
                {
                    responsableDeAula = null;
                    bd.Update("UPDATE DisponibilidadAulas SET responsable = null WHERE franja = '" + franja.ToString() + "' AND idAula = " + aula.IdAula + ";");
                }
                else if (!responsableDeAula.Username.Equals(tResponsableAula.Text)) // responsable cambiado
                {
                    responsableDeAula = new Usuario(tResponsableAula.Text);
                    bd.Update("UPDATE DisponibilidadAulas SET responsable = " + responsableDeAula.IdUsuario + " WHERE franja = '" + franja.ToString() + "' AND idAula = " + aula.IdAula + ";");
                }
            }
            else if (!tResponsableAula.Text.Equals("")) // nuevo responsable
            {
                responsableDeAula = new Usuario(tResponsableAula.Text);
                bd.Insert("UPDATE DisponibilidadAulas SET responsable = " + responsableDeAula.IdUsuario + " WHERE idAula = " + aula.IdAula + " AND franja = '" + franja.ToString() + "';");
            }
            //Comprobar cambios en vigilantes
            int idDisponibilidad = (int) bd.SelectScalar("Select idDisponibilidad from DisponibilidadAulas where franja = '" + franja.ToString() + "' and idAula = " + aula.IdAula + ";");
            bd.Delete("delete from vigilante where disponibilidad = " + idDisponibilidad + ";");
            string vigilantes = GuardarVigilantesAsignados(idDisponibilidad);
            if(vigilantes.Length > 0)
                MessageBox.Show("Agregado\n" + vigilantes + "como vigilante/s");
            this.Close();
        }

        private string GuardarVigilantesAsignados(int idDisponibilidad)
        {
            string nobmres = "";
            for(int i = 0; i < dataGridVigilantes.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridVigilantes.Rows[i];
                Usuario u = (Usuario)row.Cells[0].Value;
                bd.Insert("insert into vigilante(idVigilante, disponibilidad) values(" + u.IdUsuario + ", " + idDisponibilidad + ");");
                nobmres += u.Username + "\n";
            }
            return nobmres;
        }

        private void bAsignarVigilante_Click(object sender, EventArgs e)
        {
            if(listProfesores.SelectedItems.Count > 0)
            {
                foreach(Usuario u in listProfesores.SelectedItems)
                {
                    dataGridVigilantes.Rows.Add(u);
                }
                foreach(DataGridViewRow r in dataGridVigilantes.Rows)
                {
                    listProfesores.Items.Remove(r.Cells[0].Value);
                }
            }
            dataGridVigilantes.ClearSelection();
        }

        private void bEliminarVigilante_Click(object sender, EventArgs e)
        {
            if(dataGridVigilantes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dataGridVigilantes.SelectedRows)
                {
                    listProfesores.Items.Add(r.Cells[0].Value);
                }
                var rows = dataGridVigilantes.SelectedRows;
                foreach (DataGridViewRow row in rows)
                {
                    dataGridVigilantes.Rows.Remove(row);
                }
            }
            dataGridVigilantes.ClearSelection();
        }
    }
}
