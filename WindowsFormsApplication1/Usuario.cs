using BDLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApplication1
{
    public class Usuario
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idUsuario;
        private string username;
        private int rol;
        private Sede trabajaEn;

        private Usuario()
        {
        }

        public Usuario(int idUsuario)
        {
            try { 
                object[] tupla = miBD.Select("SELECT username, rol, IFNULL(trabajaEn,-1) FROM Usuario WHERE idUsuario = " + idUsuario + ";")[0];
                this.idUsuario = idUsuario;
                this.username = (string)tupla[0];
                this.rol = (int) tupla[1];
                int trabajaEnID = Int32.Parse(tupla[2].ToString());
                if (trabajaEnID > 0)
                    this.trabajaEn = new Sede(trabajaEnID);
            } catch (Exception ex){
                Console.WriteLine("ERROR:" + ex.Message);
            }
        }
        public Usuario (string nombre)
        {
            try {
                var tupla = miBD.Select("Select idUsuario, username, rol, trabajaEn from Usuario where username = '" + nombre + "';");
                if (tupla.Count == 1) {
                    var user = tupla[0];
                    this.idUsuario = (int)user[0];
                    this.username = (string)user[1];
                    this.rol = (int)user[2];
                    this.trabajaEn = null;
                } else
                {
                    throw new Exception("El usuario no está en la base de datos");
                }
               }catch (Exception ex){
                Console.WriteLine("ERROR:" + ex.Message);
            }
        }
        public Usuario(string username, int rol, int trabajaEn)
        {
            if(trabajaEn == -1)
                miBD.Insert("INSERT INTO Usuario (username, password, rol) VALUES ('" + username + "', '" + "" + "', " + rol + ");");
            else
                miBD.Insert("INSERT INTO Usuario (username, password, rol, trabajaEn) VALUES ('" + username + "', '" + "" + "', " + rol + ", " + trabajaEn + ");");
            this.idUsuario = (int) miBD.Select("SELECT MAX(idUsuario) from Usuario where username = '" + username + "' and rol = " + rol + ";")[0][0];
            this.username = username;
            this.rol = rol;
            this.trabajaEn = trabajaEn == -1 ? null: new Sede(trabajaEn);
        }
        public int IdUsuario
        {
            get { return idUsuario; }
        }

        public string Username
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

        public Sede TrabajaEn
        {
            get
            {
                if (trabajaEn == null)
                {
                    MySqlBD miBD = new MySqlBD();
                    var query = miBD.Select("SELECT idSede FROM Usuario Join Sede ON (Usuario.trabajaEn = Sede.idSede) WHERE Usuario.idUsuario = " + this.idUsuario + ";");
                    if (query.Count > 0)
                        trabajaEn = new Sede(Int32.Parse(query[0][0].ToString()));
                    else
                        trabajaEn = null;

                }
                return trabajaEn;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        miBD.Update("UPDATE Usuario SET trabajaEn = null WHERE idUsuario =" + this.idUsuario + ";");
                    }
                    else
                    {
                        miBD.Update("UPDATE Sede SET trabajaEn = " + value.IdSede + " WHERE idUsuario =" + this.idUsuario + ";");
                    }
                    trabajaEn = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }


            }
        }

        public override string ToString()
        {
            return username;
        }

        public override bool Equals(object obj)
        {
            if(obj != null && obj is Usuario)
            {
                Usuario u = (Usuario)obj;
                return this.idUsuario == u.idUsuario && u.username.Equals(this.username);
            }
            return false;
        }

        public void borrarUsuario()
        {
            miBD.Insert("DELETE FROM Usuario WHERE idUsuario =" + this.idUsuario + ";");
            this.idUsuario = -1;
            this.username = null;
            this.rol = -1;
        }

        public static List<Usuario> ListaResponsablesDisponibles()
        {
            List<Usuario> lista = new List<Usuario>();
            foreach (object[] tupla in miBD.Select("SELECT Usuario.idUsuario, Usuario.username, Usuario.rol FROM Usuario Join Rol On (Usuario.rol = Rol.idRol) WHERE Rol.nombre LIKE 'responsable' AND Usuario.trabajaEn is null;"))
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

        public static List<Usuario> ListaProfesoresLibres(Sede sede, FranjaHoraria franja)
        {
            List<Usuario> lista = new List<Usuario>();
            foreach (object[] tupla in miBD.Select("Select idUsuario from (Select idUsuario from Usuario where rol = 3  AND (trabajaEn = "+sede.IdSede+")  AND idUsuario NOT IN (Select responsable from DisponibilidadAulas Where franja = '" + franja.Franja+"' and responsable is not null))U where U.idUsuario not in (Select idVigilante from vigilante inner join DisponibilidadAulas where franja = '"+franja.Franja+"' and idVigilante is not null);"))
            {
                Usuario usuario = new Usuario((int)tupla[0]);
                lista.Add(usuario);
            }
            return lista;
        }
        public static List<Usuario> ListaVigilantes(FranjaHoraria franja, Aula aula)
        {
            List<Usuario> lista = new List<Usuario>();
            string sel = "select V.idVigilante " +
                        "from DisponibilidadAulas D join vigilante V on ( D.idDisponibilidad = V.disponibilidad) " +
                        "where D.franja = '" + franja.ToString() + "' and D.idAula = " + aula.IdAula + ";";
            foreach (Object[] o in miBD.Select(sel))
            {
                Usuario usuario = new Usuario((int)o[0]);
                lista.Add(usuario);
            }
            return lista;
        }
    }
}
