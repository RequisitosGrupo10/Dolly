using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EstudianteTab : Form
    {
        Alumno seleccionado;
        public EstudianteTab()
        {
            InitializeComponent();
            MostrarAlumnos();
            seleccionado = null;
        }

        private void MostrarAlumnos()
        {
            dataGridView.DataSource = Alumno.ListaAlumno();
        }

        private void bImportarEstudiantes_Click(object sender, EventArgs e)
        {
            int n_line = 0;
            int n_error = 0;
            var fileContent = string.Empty;
            var filePath = string.Empty;

 //           Dictionary<string, int> asignaturas = Asignatura.AsignaturasDiccionario();
            Dictionary<string, int> centros = Centro.CentrosDiccionario();

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
                    using (StreamWriter errorLogger = new StreamWriter("Estudiante.log"))
                    {
                        string line;

                        errorLogger.WriteLine("##################################");
                        errorLogger.WriteLine(" Log de Errores - " + DateTime.Now);
                        // Se lee la primera línea
                        if (!reader.EndOfStream)
                            line = reader.ReadLine();
                        // Comprobar para insertar nuevos Centros
                        //var centros = Centro.ListaCentro();
                        int cnt = 0;
                        StringBuilder query = new StringBuilder();
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
                                    string s_centro;

                                    s_centro = attributes[0];
                                    int idCentro;
                                    try
                                    {
                                        idCentro = centros[s_centro];
                                    }
                                    catch (Exception)
                                    {
                                        // Centro no encontrado
                                        if (s_centro.Contains("'"))
                                        {
                                            int idx = s_centro.IndexOf("'");
                                            string s_centro_new;
                                            s_centro_new = s_centro.Substring(0, idx) + "\\'" + s_centro.Substring(idx+ 1);
                                            idCentro = Centro.InsertarCentro(s_centro_new);
                                        }
                                        else
                                        {
                                            idCentro = Centro.InsertarCentro(s_centro);
                                        }
                                        centros[s_centro] = idCentro;
                                    }
                                    //centro = GetOrAddCentro(s_centro, centros);
                                    nombre = attributes[1];
                                    apellido1 = attributes[2];
                                    apellido2 = (attributes[3].Equals("0")) ? "" : attributes[3];
                                    dni_nif = attributes[4];
                                    materias = attributes[5].Split(',');
 //                                   Dictionary<string, int> examenes = new Dictionary<string, int>();
                                    for (int m = 0; m < materias.Length; m++)
                                    {
                                        materias[m] = materias[m].Trim();
//                                        int id = asignaturas[materias[m]]; // Lanza una excepción en caso si la materia no está en la base de datos.
//                                        examenes[materias[m]] = id;
                                    }
                                    query.Append(BuildQuery(idCentro, nombre, apellido1, apellido2, dni_nif, materias));
                                    cnt++;
                                    if (cnt >= 500)
                                    {
                                        Alumno.Isertar(query.ToString());
                                        query.Clear();
                                        cnt = 0;
                                    }
                                    //Alumno newEstudiante = new Alumno(centro.IdCentro, nombre, apellido1, apellido2, dni_nif, materias);
                                }
                                else
                                {
                                    throw new Exception("Not enough arguments in the line " + n_line);
                                }
                                    
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error encontrado");
                                errorLogger.WriteLine("·Error encontrado en la línea " + (n_line + 1));
                                n_error++;
                            }
                            n_line++;
                        }
                        Alumno.Isertar(query.ToString());
                        errorLogger.WriteLine("##################################");
                    }
                    MessageBox.Show("Se procesaron " + (n_line) + " líneas, con " + (n_error) + " errores", "File Content at path: " + filePath, MessageBoxButtons.OK);
                    MostrarAlumnos();
                }
            }
        }

        private string BuildQuery(int idCentro, string nombre, string apellido1, string apellido2, string dni_nif, string[] materias)
        {
            string ins = "Insert IGNORE into Alumno(idCentro, DNI, nombre, apellido1, apellido2) VALUES ('" + idCentro + "', '" + dni_nif + "',' " + nombre + "', '" + apellido1 + "', '" + apellido2 + "');\n";
            ins += "insert IGNORE into AlumnoAsignatura (DNI, idAsignatura) values";
            string[] subq = new string[materias.Length];
            for (int i = 0; i < materias.Length; i++)
            {
                subq[i] = "('" + dni_nif + "', (select idAsignatura from Asignatura where nombre = '" + materias[i] + "')) ";
            }
            ins += String.Join(",", subq) + ";\n";
            return ins;
        }

        // TODO: Remove if not used;
        /*
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
        */
        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Borra todos los estudiantes de la base de datos*/
        private void bEliminarTodosLosEstudiantes_Click(object sender, EventArgs e)
        {
            foreach (var estudiante in Alumno.ListaAlumno())
                estudiante.borrarAlumno();
            MostrarAlumnos();
        }

        /* Borra el estudiante seleccionado */
        private void bEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.borrarAlumno();
                MostrarAlumnos();
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
