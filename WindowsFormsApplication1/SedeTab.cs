﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SedeTab : Form
    {
        Sede seleccionado;
        public SedeTab()
        {
            InitializeComponent();
            MostrarSedes();
            seleccionado = null;
        }

        private void MostrarSedes()
        {
            dataGridView1.DataSource = Sede.ListaSede();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bImport_Click(object sender, EventArgs e)
        {
            int n_line = 0;
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.tx)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK
                    && !openFileDialog.FileName.Equals(""))
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string line;

                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            try
                            {
                                Sede sede = new Sede(line);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error found");
                            }
                            n_line++;
                        }
                    }
                    MessageBox.Show("Se procesaron" + (n_line) + " líneas.", "File Content at path: " + filePath, MessageBoxButtons.OK);
                }
                MostrarSedes();
            }
        }

        private void bBorrarSede_Click(object sender, EventArgs e)
        {
            seleccionado.borrarSede();
            seleccionado = null;
            MostrarSedes();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int idSede = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    string nombre = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
                    string responsable = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
                    seleccionado = new Sede(idSede);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
