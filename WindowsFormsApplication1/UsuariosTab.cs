using BDLibrary;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication1
{
    public partial class UsuariosTab : Form
    {
        public UsuariosTab()
        {
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            MySqlBD miDB = new MySqlBD();
            List<Object[]> list = miDB.Select("Select idUsuario, username, nombre from Usuario join Rol on (Usuario.rol = Rol.idRol) where Lower(Rol.nombre) like 'responsable';");
            foreach (Object[] u in list)
            {
                dataGridView.Rows.Add(new object[] { u[0], u[1], u[2] });
            }
        }

        private void bImportarUsuarios_Click(object sender, EventArgs e)
        {
            int added = 0;
            int errors = 0;
            StringBuilder sb = new StringBuilder();
            string filePath = null;
            MySqlBD miDB = new MySqlBD();
            List<Object[]> tupla = miDB.Select("Select idRol from Rol where Lower(nombre) like 'responsable'");
            if (tupla.Count == 0)
            {
                miDB.Insert("Insert into Rol (nombre) values ('responsable');");
                tupla = miDB.Select("Select idRol from Rol where Lower(nombre) like 'responsable'");
            }

            int role = (int)tupla[0][0];
            Console.WriteLine("Responsable ID = " + role);
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
                                new Usuario(line, role);
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

            string filename = @".\Errores en importar usuarios.txt";

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

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
