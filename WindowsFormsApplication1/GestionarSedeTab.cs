﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GestionarSedeTab : Form
    {
        //FALTA HACER MODIFICAR AULA Y RELLENAR DISPONIBLE
        Aula seleccionado;
        Usuario usuario;
        //Obtener el Usuario que está conectado, hace falta login. De ahí obtener la sede a la que está asignado
        public GestionarSedeTab(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            Mostrar();
            seleccionado = null;
        }

        private void Mostrar()
        {
            dataGridView.DataSource = Aula.ListaAula(usuario.TrabajaEn);
            lNombreSede.Text = usuario.TrabajaEn.Nombre;
            tAforo.Text = Aforo();
            tAforo.Enabled = false;
            tDisponible.Text = Disponible();
            tDisponible.Enabled = false;
            tResponsableDeSede.Text = usuario.Username;
            tResponsableDeSede.Enabled = false;
        }

        private String Aforo()
        {
            int aforo = 0;
            foreach (Aula aula in Aula.ListaAula(usuario.TrabajaEn))
            {
                aforo += aula.Aforo;
            }
            return aforo.ToString();
        }

        private String Disponible()
        {
            int disponible = int.Parse(Aforo());
            int rows = dataGridView.RowCount;
            for (int i = 0; i < rows; i++)
            {
                int idCentro = (int)dataGridView.Rows[i].Cells[0].Value;
                Centro aux = new Centro(idCentro);
                disponible = disponible - aux.aforoCentro();
            }
            return disponible.ToString();
        }

        private void bInsertarAula_Click(object sender, EventArgs e)
        {
            Aula aula = new Aula("Aula " + DateTime.Now.ToString(), 0, usuario.TrabajaEn.IdSede);
            AulaTab ventana = new AulaTab(aula); //Crear tab insertar aula
            ventana.ShowDialog();
            Mostrar();
        }

        private void bModificarAula_Click(object sender, EventArgs e)
        {

            if (seleccionado != null)
            {
                AulaTab ventana = new AulaTab(seleccionado); //Crear tab insertar aula
                ventana.ShowDialog();
                Mostrar();
            }
            else
            {
                MessageBox.Show("Selecciona un aula para modificar", "Error", MessageBoxButtons.OK);
            }
        }

        private void bEliminarAula_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.borrarAula();
                seleccionado = null;
                Mostrar();
            }
            else
            {
                MessageBox.Show("Selecciona un aula para borrar", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int idAula = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                    seleccionado = new Aula(idAula);
                }
                toggleButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void toggleButton()
        {
            if (seleccionado != null)
            {
                bModificarAula.Enabled = true;
                bModificarAula.BackColor = SystemColors.Control;
                bEliminarAula.Enabled = true;
                bEliminarAula.BackColor = SystemColors.Control;
            }
            else
            {
                bModificarAula.Enabled = false;
                bModificarAula.BackColor = SystemColors.ControlDark;
                bEliminarAula.Enabled = false;
                bEliminarAula.BackColor = SystemColors.ControlDark;
            }
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
