﻿using BDLibrary;
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
        string franja;

        Usuario profesorSeleccionado;

        public ModificarAulaTab(Aula aula, string idResponsableDeAula, String franja)
        {
            InitializeComponent();
            this.sede = aula.Sede;
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
            List<Usuario> profesoresLibres = Usuario.ListaProfesoresLibres(sede,new FranjaHoraria(franja));
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
            if (profesorSeleccionado!=null)
            {
                tResponsableAula.Text = profesorSeleccionado.Username;
            }
            listProfesores.Items.Remove(profesorSeleccionado);
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
            profesorSeleccionado = (Usuario)listProfesores.SelectedItem;
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            MySqlBD bd = new MySqlBD();
            //Comprobar cambio responsable
            if (responsableDeAula == null && !tResponsableAula.Text.Equals(""))
            {
                responsableDeAula = new Usuario(tResponsableAula.Text);
                bd.Insert("INSERT INTO DisponibilidadAulas (idAula,franja,responsable) VALUES ("+aula.IdAula+", '"+franja+"',"+ responsableDeAula.IdUsuario+ " )");
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
        }
    }
}
