using System;
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
    public partial class ExamenTab : Form
    {
        public ExamenTab()
        {
            InitializeComponent();
            MostrarExamenes();
        }

        private void MostrarExamenes()
        {
            dataGridView1.DataSource = Examen.ListaExamenes();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bImportar_Click(object sender, EventArgs e)
        {
            // CSVParser csvParser = new CSVParser(new EstudianteStrategy);

            int n_line = 0;
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt) | *.txt | csv files (*.csv)|*.csv";
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
                                var split = line.Split(';');
                                if (split.Length != 2)
                                    throw new Exception("No hay suficientes argumentos en la línea");
                                Asignatura asignatura = new Asignatura(split[0].ToString().Trim());
                                FranjaHoraria franja = new FranjaHoraria(split[1].ToString().Trim());
                                Examen examen = new Examen(asignatura, franja);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error:" + ex.Message);
                            }
                            n_line++;
                        }
                    }
                    MessageBox.Show("Se procesaron" + (n_line) + " líneas.", "File Content at path: " + filePath, MessageBoxButtons.OK);
                }
                MostrarExamenes();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int len = dataGridView1.SelectedRows.Count;
                    for (int i = 0; i < len; i++)
                    { 
                    
                        Examen seleccionado =  new Examen (Int32.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString()));
                        seleccionado.BorrarExamen();
                    }
                    MostrarExamenes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
