using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AsignaturaTab : Form
    {
        Asignatura seleccionado;
        public AsignaturaTab()
        {
            InitializeComponent();
            Mostrar();
            seleccionado = null;
        }

        private void Mostrar()
        {
            dataGridView.DataSource = Asignatura.ListaAsignatura();
        }

        private void bImportarAsignaturas_Click(object sender, EventArgs e)
        {
            // CSVParser csvParser = new CSVParser(new EstudianteStrategy);

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
                Mostrar();
            }
        }

        private void bEliminarAsignatura_Click(object sender, EventArgs e)
        {
            seleccionado.borrarAsignatura();
            seleccionado = null;
            Mostrar();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int idAsignatura = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                    string nombre = (string)dataGridView.SelectedRows[0].Cells[1].Value;
                    seleccionado = new Asignatura(idAsignatura);
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
                bEliminarAsignatura.Enabled = true;
                bEliminarAsignatura.BackColor = SystemColors.Control;
            }
            else
            {
                bEliminarAsignatura.Enabled = false;
                bEliminarAsignatura.BackColor = SystemColors.ControlDark;
            }
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
