using BDLibrary;
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

        private void tNombre_Click(object sender, EventArgs e)
        {
            tNombre.SelectAll();
        }

        private void tContrasena_Click(object sender, EventArgs e)
        {
            tContrasena.SelectAll();
        }

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = new Usuario(tNombre.Text);
                if (usuario != null && tNombre.Text.Equals(usuario.Username))
                {                           
                    if (usuario.checkPassword(tContrasena.Text))
                        loginCorrecto();
                    else
                        MessageBox.Show("Nombre o contraseña incorrecta");
                }
                else
                {
                    MessageBox.Show("Nombre o contraseña incorrecta");
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
                this.Close();
                
            }
            else if (this.usuario.Rol == 2)
            {
                Sede sede = checkSede();
                if (sede != null)
                {
                    MenuResponsable menuResponsable = new MenuResponsable(sede);
                    this.Hide();
                    menuResponsable.ShowDialog();
                    this.Close();
                }
            }
        }

        private Sede checkSede()
        {
            List<Sede> sedes = Sede.ListaSede();
            foreach(Sede sede in sedes)
            {
                if (sede.Responsable!= null)
                {
                    if (sede.Responsable.IdUsuario == this.usuario.IdUsuario)
                    {
                        return sede;
                    }
                }
                
            }
            return null;
        }
        private void cbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (tContrasena.PasswordChar == '*') tContrasena.PasswordChar = '\0';
            else tContrasena.PasswordChar = '*';
        }

        /* Enter en la contraseña = Presionar iniciar sesión */
        private void tContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                bIniciarSesion_Click(this, e);
        }
    }
}
