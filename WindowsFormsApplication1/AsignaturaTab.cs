using BDLibrary;
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
    public partial class AsignaturaTab : Form
    {
        Asignatura seleccionado;
        public AsignaturaTab()
        {
            InitializeComponent();
            MostrarAsignaturas();
            seleccionado = null;
        }

        private void MostrarAsignaturas()
        {
            dataGridView1.DataSource = Asignatura.ListaAsignatura();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                                Asignatura asignatura = new Asignatura(line);
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
                MostrarAsignaturas();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int idAsignatura = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    string nombre = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
                    seleccionado = new Asignatura(idAsignatura);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bBorrarAsignatura_Click(object sender, EventArgs e)
        {
            seleccionado.borrarAsignatura();
            seleccionado = null;
            MostrarAsignaturas();
        }

        private void AsignaturaTab_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grupo10DBDataSet3.Asignatura' Puede moverla o quitarla según sea necesario.
            MostrarAsignaturas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
