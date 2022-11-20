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
            Object[] tupla = miDB.Select("Select idRol from Rol where nombre = 'Responsable de sede'")[0];
            int role = (int) tupla[0];
            Console.WriteLine("Responsable ID = " + role);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c\\";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt";
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
                                String ins = "Insert into Usuario (username, password, rol) values ('" + line + "', '" + "" + "', " + role + ");";
                                //Console.WriteLine(ins);
                                //miDB.Insert(ins);
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

        private void UsersTab_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grupo10DBDataSet7.Usuario' Puede moverla o quitarla según sea necesario.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
