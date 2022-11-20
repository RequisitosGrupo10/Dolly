using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LogIn : Form
    {
        private Usuario usuario;
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("He llegado al handler");
            try
            {
                List<Usuario> users = Usuario.ListaUsuarios();
                foreach (Usuario user in users)
                {
                    Console.WriteLine(user.ToString());
                    if (user.Username.Equals(nombre.Text) && user.Password.Equals(password.Text))
                    {
                        usuario = new Usuario(user.IdUsuario);
                        loginCorrecto();
                        Console.WriteLine("Login correcto");
                        break;
                        // Comenzar a usar la aplicación
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loginCorrecto()
        {
            if (this.usuario.Rol == 1)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                
            }else if (this.usuario.Rol == 2)
            {
                ResponsableSedeTab responsableSedeTab = new ResponsableSedeTab();
                this.Hide();
                responsableSedeTab.ShowDialog();
                
            }
        }

        private void ver_CheckedChanged(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*') password.PasswordChar = '\0';
            else password.PasswordChar = '*';
        }
    }
}
