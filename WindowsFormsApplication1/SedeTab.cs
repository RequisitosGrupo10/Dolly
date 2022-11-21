using System;
using System.Drawing;
using System.IO;
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
            dataGridView.DataSource = Sede.ListaSede();
        }

        private void bImportarSedes_Click(object sender, EventArgs e)
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

        private void bModificarSede_Click(object sender, EventArgs e)
        {

            if (seleccionado != null)
            {
                AdminSedeTab ventana = new AdminSedeTab(seleccionado);
                ventana.ShowDialog();
            }
        }

        private void bEliminarSede_Click(object sender, EventArgs e)
        {

            if (seleccionado != null)
            {
                seleccionado.borrarSede();
                seleccionado = null;
                MostrarSedes();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int idSede = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                    seleccionado = new Sede(idSede);
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
                bModificarSede.Enabled = true;
                bModificarSede.BackColor = SystemColors.Control;
                bEliminarSede.Enabled = true;
                bEliminarSede.BackColor = SystemColors.Control;
            }
            else
            {
                bModificarSede.Enabled = false;
                bModificarSede.BackColor = SystemColors.ControlDark;
                bEliminarSede.Enabled = false;
                bEliminarSede.BackColor = SystemColors.ControlDark;
            }
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
