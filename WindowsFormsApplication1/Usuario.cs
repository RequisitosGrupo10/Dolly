using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Usuario
    {
        private int idUsuario;
        private string username;
        private string password;
        private int rol;

        public Usuario(int idUsuario)
        {
            MySqlBD miBD = new MySqlBD();
            Object[] tupla = miBD.Select("SELECT * FROM Usuario WHERE idUsuario = " + idUsuario + ";")[0];
            this.idUsuario = idUsuario;
            this.username = tupla[1].ToString();
            this.password = tupla[2].ToString();
            this.rol = (int) tupla[3];
        }

        public Usuario(string username, int rol)
        {
            MySqlBD miBD = new MySqlBD();
            miBD.Insert("INSERT INTO Usuario (username, password, rol) VALUES ('" + username + "', '" + "" + "', " + rol + ");");
            this.idUsuario = (int) miBD.Select("SELECT MAX(idUsuario) from Usuario where username = '" + username + " and rol = " + rol + ";")[0][0];
            this.username = username;
            this.password = "";
            this.rol = rol;
        }

        public static List<Usuario> ListaUsuarios()
        {
            List <Usuario> lista = new List<Usuario>();
            MySqlBD miBD = new MySqlBD();
            List<Object[]> users = miBD.Select("Select idUsuario from Usuario");
            foreach (Object[] user in users)
            {
                lista.Add(new Usuario((int) user[0]));
            }
            return lista;
        }

        public int IdUsuario
        {
            get { return idUsuario; }
        }

        public String Username
        {
            get { return username; }
        }

        internal static object ListaResponsablesDisponibles()
        {
            MySqlBD miBD = new MySqlBD();
            List<Usuario> res = new List<Usuario>();
            foreach (object[] tupla in miBD.Select("SELECT Usuario.idUsuario FROM Usuario Join Rol On (Usuario.rol = Rol.idRol) WHERE Rol.nombre LIKE 'responsable' AND (Usuario.idUsuario Not in (Select responsable from Sede where responsable is not null));"))
            {
                res.Add(new Usuario((int)tupla[0]));
            }
            return res;
        }

        public override string ToString() {
            return (this.username);
          }  

    }

}
