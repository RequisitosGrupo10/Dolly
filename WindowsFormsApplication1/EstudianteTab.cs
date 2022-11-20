using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EstudianteTab : Form
    {
        public EstudianteTab()
        {
            InitializeComponent();
            MostrarEstudiantes();
        }

        private void MostrarEstudiantes()
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
                        // Comprobar para insertar nuevos Centros
                        var centros = Centro.ListaCentro();
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            string[] attributes = line.Split(';');
                            try
                            {
                                if (attributes.Length == 6)
                                {
                                    string s_centro = attributes[0];
                                    Centro centro;
                                    /* A continuación se comprueba si el nombre está en la lista de centros para insertarlo o no*/
                                        var i = 0;
                                        while(i < centros.Count)
                                        {
                                            if (s_centro.Equals(centros[i].Nombre))
                                                break;
                                            i++;
                                        }
                                        if (i == centros.Count)
                                        {
                                            centro = new Centro(s_centro);
                                            centros.Add(centro);
                                        }
                                        else
                                            centro = centros[i];
                                    /**/
                                    string nombre = attributes[1];
                                    string apellido1 = attributes[2];
                                    string apellido2 = (attributes[3].Equals("0")) ? "" : attributes[3];
                                    string dni_nif = attributes[4];
                                    string[] materias = attributes[5].Split(',');
                                    for (int m = 0; m < materias.Length; m++)
                                    {
                                        materias[m] = materias[m].Trim();
                                    }
                                    Alumno newEstudiante = new Alumno(centro.IdCentro, nombre, apellido1, apellido2, dni_nif, materias);
                                    
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
                    MessageBox.Show("Se procesaron " + (n_line - 1) + " líneas.", "File Content at path: " + filePath, MessageBoxButtons.OK);
                    MostrarEstudiantes();
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

        private void bBorrar_Click(object sender, EventArgs e)
        {
            foreach (var estudiante in Alumno.ListaEstudiantes())
                estudiante.borrarAlumno();
            MostrarEstudiantes();
        }
    }
}
