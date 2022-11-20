﻿using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EstudianteTab : Form
    {
        public EstudianteTab()
        {
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            dataGridView.DataSource = Alumno.ListaEstudiantes();
        }

        private void bImportarEstudiantes_Click(object sender, EventArgs e)
        {
            int n_line = 0;
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
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

                        // Se lee la primera línea
                        if (!reader.EndOfStream)
                            line = reader.ReadLine();
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            string[] attributes = line.Split(';');
                            try
                            {
                                if (attributes.Length == 6)
                                {
                                    string centro = attributes[0];
                                    string nombre = attributes[1];
                                    string apellido1 = attributes[2];
                                    string apellido2 = (attributes[3].Equals("0")) ? "" : attributes[3];
                                    string dni_nif = attributes[4];
                                    string[] materias = attributes[5].Split(',');
                                    for (int i = 0; i < materias.Length; i++ )
                                    {
                                        materias[i] = materias[i].Trim(); 
                                    }
                                    Alumno newEstudiante = new Alumno(centro, nombre, apellido1, apellido2, dni_nif, materias);
                                }
                                else
                                    throw new Exception("Not enough arguments in the line " + n_line);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error found");
                            }
                            n_line++;
                        }
                    }
                    MessageBox.Show("Se procesaron" + (n_line - 1) + " líneas.", "File Content at path: " + filePath, MessageBoxButtons.OK);
                    Mostrar();
                }
            }
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EstudianteTab_Load(object sender, EventArgs e)
        {
            
        }
    }
}
