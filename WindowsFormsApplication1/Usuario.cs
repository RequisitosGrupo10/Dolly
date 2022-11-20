using BDLibrary;
using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class Usuario
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idUsuario;
        private string username;
        private int rol;

        public Usuario(int idUsuario)
        {
            Object[] tupla = miBD.Select("SELECT * FROM Usuario WHERE idUsuario = " + idUsuario + ";")[0];
            this.idUsuario = idUsuario;
            this.username = tupla[1].ToString();
            this.rol = (int) tupla[3];
        }

        public Usuario(string username, int rol)
        {
            miBD.Insert("INSERT INTO Usuario (username, password, rol) VALUES ('" + username + "', '" + "" + "', " + rol + ");");
            this.idUsuario = (int) miBD.Select("SELECT MAX(idUsuario) from Usuario where username = '" + username + "' and rol = " + rol + ";")[0][0];
            this.username = username;
            this.rol = rol;
        }

        public static List<Usuario> ListaUsuarios()
        {
            List <Usuario> lista = new List<Usuario>();
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

        public int Rol
        {
            get { return rol; }
        }

        public override string ToString()
        {
            return idUsuario + ";" + username + ";" + rol + ";";
        }

        internal static object ListaResponsablesDisponibles()
        {
            List<Usuario> res = new List<Usuario>();
            foreach (object[] tupla in miBD.Select("SELECT Usuario.idUsuario FROM Usuario Join Rol On (Usuario.rol = Rol.idRol) WHERE Rol.nombre LIKE 'responsable' AND (Usuario.idUsuario Not in (Select responsable from Sede where responsable is not null));"))
            {
                res.Add(new Usuario((int)tupla[0]));
            }
            return res;
        }

    }

}
