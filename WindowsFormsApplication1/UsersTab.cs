using BDLibrary;
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UsersTab : Form
    {
        public UsersTab()
        {
            InitializeComponent();
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            dataGridView1.DataSource = Usuario.ListaUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
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
                            } catch (Exception ex) 
                            {
                                Console.WriteLine("The line alredy exist");
                                Console.WriteLine(ex.Message); Console.WriteLine(ex.StackTrace);
                            }
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            MostrarUsuarios();
        }
    }
}
