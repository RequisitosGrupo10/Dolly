using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EstudianteTab : Form
    {
        Alumno seleccionado;
        public EstudianteTab()
        {
            InitializeComponent();
            Mostrar();
            seleccionado = null;
        }

        private void Mostrar()
        {
            dataGridView.DataSource = Alumno.ListaAlumno();
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
                    // Obetener el Path
                    filePath = openFileDialog.FileName;
                    // Leer del fichero
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
                                    string nombre;
                                    string apellido1;
                                    string apellido2;
                                    string dni_nif;
                                    string[] materias;
                                    Centro centro;
                                    string s_centro;

                                    s_centro = attributes[0];
                                    centro = GetOrAddCentro(s_centro, centros);
                                    nombre = attributes[1];
                                    apellido1 = attributes[2];
                                    apellido2 = (attributes[3].Equals("0")) ? "" : attributes[3];
                                    dni_nif = attributes[4];
                                    materias = attributes[5].Split(',');
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
                    MessageBox.Show("Se procesaron " + (n_line) + " líneas.", "File Content at path: " + filePath, MessageBoxButtons.OK);
                    Mostrar();
                }
            }
        }

        private Centro GetOrAddCentro(string s_centro, List<Centro> centros)
        {
            Centro centro;
            int i;
                
            i = 0;
            while (i < centros.Count)
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
            {
                centro = centros[i];
            }
            return (centro);
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Borra todos los estudiantes de la base de datos*/
        private void bEliminarTodosLosEstudiantes_Click(object sender, EventArgs e)
        {
            foreach (var estudiante in Alumno.ListaAlumno())
                estudiante.borrarAlumno();
            Mostrar();
        }

        /* Borra el estudiante seleccionado */
        private void bEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.borrarAlumno();
                Mostrar();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            string idAlumno;

            if (dataGridView.SelectedRows.Count > 0)
            {
                idAlumno = (string)dataGridView.SelectedRows[0].Cells[3].Value;
                seleccionado = new Alumno(idAlumno);
            }
            toggleButton();
        }

        private void toggleButton()
        {
            if (seleccionado != null)
            {
                bEliminarEstudiante.Enabled = true;
                bEliminarEstudiante.BackColor = SystemColors.Control;
            }
            else
            {
                bEliminarEstudiante.Enabled = false;
                bEliminarEstudiante.BackColor = SystemColors.ControlDark;
            }
        }
    }
}
