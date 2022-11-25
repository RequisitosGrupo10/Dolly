using BDLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApplication1
{
    public class Usuario
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idUsuario;
        private string username;
        private int rol;

        private Usuario()
        {
        }

        public Usuario(int idUsuario)
        {
            try { 
                object[] tupla = miBD.Select("SELECT username, rol FROM Usuario WHERE idUsuario = " + idUsuario + ";")[0];
                this.idUsuario = idUsuario;
                this.username = (string)tupla[0];
                this.rol = (int) tupla[1];
            } catch (Exception ex){
                Console.WriteLine("ERROR:" + ex.Message);
            }
        }
        public Usuario (string nombre)
        {
            try {
                var tupla = miBD.Select("Select idUsuario, username, rol from Usuario where username = '" + nombre + "';");
                if (tupla.Count == 1) {
                        var user = tupla[0];
                        this.idUsuario = (int)user[0];
                        this.username = (string)user[1];
                        this.rol = (int)user[2];
                } else
                {
                    throw new Exception("El usuario no está en la base de datos");
                }
               }catch (Exception ex){
                Console.WriteLine("ERROR:" + ex.Message);
            }
        }
        public Usuario(string username, int rol)
        {
            miBD.Insert("INSERT INTO Usuario (username, password, rol) VALUES ('" + username + "', '" + "" + "', " + rol + ");");
            this.idUsuario = (int) miBD.Select("SELECT MAX(idUsuario) from Usuario where username = '" + username + "' and rol = " + rol + ";")[0][0];
            this.username = username;
            this.rol = rol;
        }
        public int IdUsuario
        {
            get { return idUsuario; }
        }

        public String Username
        {
            get { return username; }
        }

        public bool checkPassword(string password)
        {
            return password.Equals((String)miBD.SelectScalar("SELECT password FROM Usuario WHERE idUsuario = " + IdUsuario + ";"));
        }

        public int Rol
        {
            get { return rol; }
        }

        public override string ToString()
        {
            return username;
        }

        public static List<Usuario> ListaResponsablesDisponibles()
        {
            List<Usuario> lista = new List<Usuario>();
            foreach (object[] tupla in miBD.Select("SELECT Usuario.idUsuario, Usuario.username, Usuario.rol FROM Usuario Join Rol On (Usuario.rol = Rol.idRol) WHERE Rol.nombre LIKE 'responsable' AND (Usuario.idUsuario Not in (Select responsable from Sede where responsable is not null));"))
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = (int)tupla[0];
                usuario.username = (string)tupla[1];
                usuario.rol = (int)tupla[2];
                lista.Add(usuario);
            }
            return lista;
        }
        public static List<Usuario> ListaUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            foreach (object[] tupla in miBD.Select("Select idUsuario, username, rol from Usuario"))
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = (int)tupla[0];
                usuario.username = (string)tupla[1];
                usuario.rol = (int)tupla[2];
                lista.Add(usuario);
            }
            return lista;
        }
    }
}
