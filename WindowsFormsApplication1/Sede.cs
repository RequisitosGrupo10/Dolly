using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WindowsFormsApplication1
{
    public class Sede
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idSede;
        private string nombre;

        private Sede()
        {
        }

        public Sede(int idSede)
        {
            MySqlBD miBD = new MySqlBD();
            try
            {
                Object[] tupla = miBD.Select("SELECT idSede,nombre FROM Sede WHERE idSede=" + idSede + ";")[0];

                this.idSede = (int)tupla[0];
                this.nombre = (string)tupla[1];
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }

        }

        public Sede(String nombre)
        {
            
            try
            {
                if (miBD.Select("SELECT nombre FROM Sede WHERE nombre = '" + nombre + "';").Count == 0)
                {
                    miBD.Insert("INSERT INTO Sede(nombre) VALUES ('" + nombre + "');");
                    Console.WriteLine("Se insertó correctamente");
                    this.idSede = (int)miBD.SelectScalar("SELECT MAX(idSede) FROM Sede");
                    this.nombre = nombre;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public int IdSede
        {
            get { return idSede; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public void borrarSede()
        {
            miBD.Delete("DELETE FROM Sede WHERE idSede =" + this.idSede + ";");
            idSede = -1;
            nombre = null;
        }

        public override String ToString()
        {
            return this.nombre;
        }

        public override bool Equals(object obj)
        {
            return obj is Sede
                && (((Sede)obj).idSede == this.idSede);
        }

        public override int GetHashCode()
        {
            return this.idSede.GetHashCode();
        }
        public static List<Sede> ListaSede()
        {
            List<Sede> lista = new List<Sede>();
            foreach (object[] tupla in miBD.Select("SELECT idSede, nombre FROM Sede;"))
            {
                Sede aux = new Sede();
                aux.idSede = (int)tupla[0];
                aux.nombre=(string)tupla[1];
                lista.Add(aux);
            }
            return lista;
        }

        public Usuario ResponsableSede()
        {
            var o = miBD.Select("SELECT Usuario.idUsuario FROM Usuario JOIN Sede ON(Usuario.trabajaEn = Sede.idSede) JOIN Rol ON(Usuario.rol = Rol.idRol) WHERE Lower(Rol.nombre) like 'responsable';");
            if (o.Count() > 0) {
                object[] tupla = o[0];
                Usuario usuario = new Usuario((int)tupla[0]);
                return usuario;
            }

            return null;
        }
    }
}
