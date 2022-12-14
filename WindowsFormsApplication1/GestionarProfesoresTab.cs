using BDLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GestionarProfesoresTab : Form
    {
        Usuario responsableDeSede;

        public GestionarProfesoresTab(Usuario usuario)
        {
            this.responsableDeSede = usuario;
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            lNombreSede.Text = responsableDeSede.TrabajaEn.Nombre;
            MySqlBD miDB = new MySqlBD();
            dataGridView.Rows.Clear();
            List<Object[]> list = miDB.Select("Select idUsuario, username, nombre from Usuario join Rol on (Usuario.rol = Rol.idRol) where Lower(Rol.nombre) like 'profesor';");
            foreach (Object[] u in list)
            {
                dataGridView.Rows.Add(new object[] { u[0], u[1], u[2] });
            }
        }

        private void bImportarProfesores_Click(object sender, EventArgs e)
        {
            int added = 0;
            int errors = 0;
            StringBuilder sb = new StringBuilder();
            string filePath = null;
            MySqlBD miDB = new MySqlBD();
            List<Object[]> tupla = miDB.Select("Select idRol from Rol where Lower(nombre) like 'profesor'");
            if (tupla.Count == 0)
            {
                miDB.Insert("Insert into Rol (nombre) values ('profesor');");
                tupla = miDB.Select("Select idRol from Rol where Lower(nombre) like 'profesor'");
            }

            int role = (int)tupla[0][0];
            Console.WriteLine("Profesor ID = " + role);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
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
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            try
                            {
                                new Usuario(line, role, responsableDeSede.TrabajaEn.IdSede);
                                added++;
                            }
                            catch (Exception)
                            {
                                errors++;
                                int idx = added + errors;
                                sb.Append(idx + ". Usuario " + line + " probablemente ya existe en la base de datos\n");
                            }
                        }
                    }
                }
            }
            Mostrar();

            string filename = @".\Errores en importar profesores.txt";

            string msg = errors == 0 ? "Se ha añadido " + added + " usuarios nuevos." : "Se ha añadido " + added + " usuarios nuevos.\nNo he podido importar " + errors + " usuarios.\nConsulte el fichero:\n" + filename;
            MessageBox.Show(msg);

            if (errors > 0)
            {
                Log.HacerLog(sb.ToString(), filename);
            }
            else
            {
                Log.EliminarLog(filename);
            }
        }

        private void bEliminarProfesores_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                {
                    int idUsuario = (int)dataGridView.SelectedRows[i].Cells[0].Value;
                    Usuario usuario = new Usuario(idUsuario);
                    usuario.borrarUsuario();
                }
                dataGridView.ClearSelection();
                Mostrar();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para borrar", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
               toggleButton();
        }

        private void toggleButton()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                bEliminarProfesores.Enabled = true;
                bEliminarProfesores.BackColor = SystemColors.Control;
            }
            else
            {
                bEliminarProfesores.Enabled = false;
                bEliminarProfesores.BackColor = SystemColors.ControlDark;
            }
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
