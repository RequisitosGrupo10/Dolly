using BDLibrary;
using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class Centro
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idCentro;
        private string nombre;
        private Sede sede;
        private Centro()
        {
        }
        public Centro(int idCentro)
        {
            try
            {
                Object[] tupla = miBD.Select("SELECT idCentro,nombre,IFNULL(idSede,-1) FROM Centro WHERE idCentro=" + idCentro + ";")[0];

                this.idCentro = (int)tupla[0];
                this.nombre = (string)tupla[1];
                int sedeID = Int32.Parse(tupla[2].ToString());
                if (sedeID > 0)
                    this.sede = new Sede(sedeID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Centro(String nombre)
        {
           
            try
            {
                if (miBD.Select("SELECT nombre FROM Centro WHERE nombre = '" + nombre + "';").Count == 0)
                {
                    miBD.Insert("INSERT INTO Centro(nombre) VALUES ('" + nombre + "');");
                    Console.WriteLine("Se insertó correctamente");
                    this.idCentro = (int)miBD.SelectScalar("SELECT MAX(idCentro) FROM Centro");
                    this.nombre = nombre;
                    this.sede = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public int IdCentro
        {
            get { return idCentro; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public Sede Sede
        {
            get { return sede; }
            set
            {
                if (value == null)
                {
                    miBD.Update("UPDATE Centro SET idSede = null WHERE idCentro =" + this.idCentro + ";");
                }
                else
                {
                    miBD.Update("UPDATE Centro SET idSede = " + value.IdSede + " WHERE idCentro =" + this.idCentro + ";");
                }
                sede = value;
            }
        }

        public void borrarCentro()
        {
            miBD.Delete("DELETE FROM Centro WHERE idCentro =" + this.idCentro + ";");
            idCentro = -1;
            nombre = null;
            sede = null;
        }

        public override string ToString()
        {
            string res = this.idCentro + ";" + this.nombre + ";";
            if (this.sede != null)
            {
                res += sede.ToString();
            }

            return res;
        }

        public override bool Equals(object obj)
        {
            return obj is Centro
                && (((Centro)obj).Nombre.Equals(this.Nombre));
        }

        public override int GetHashCode()
        {
            return this.Nombre.GetHashCode();
        }
        public static List<Centro> ListaCentro()
        {
            List<Centro> lista = new List<Centro>();

            foreach (object[] tupla in miBD.Select("SELECT idCentro, nombre FROM Centro;"))
            {
                Centro centro = new Centro();
                centro.idCentro = (int)tupla[0];
                centro.nombre= (string)tupla[1];
                lista.Add(centro);
            }
            return lista;
        }

        public static List<Centro> ListaCentro(Sede sede)
        {
            List<Centro> lista = new List<Centro>();

            foreach (object[] tupla in miBD.Select("SELECT idCentro, nombre FROM Centro WHERE idSede = " + sede.IdSede + ";"))
            {
                Centro centro = new Centro();
                centro.idCentro = (int)tupla[0];
                centro.nombre = (string)tupla[1];
                centro.sede = sede;
                lista.Add(centro);
            }
            return lista;
        }

        public static List<Centro> ListaCentrosDisponibles()
        {
            List<Centro> lista = new List<Centro>();
            foreach (object[] tupla in miBD.Select("SELECT idCentro FROM Centro WHERE idSede is null;"))
            {
                Centro centro = new Centro((int)tupla[0]);
                lista.Add(centro);
            }
            return lista;
        }
    }
}
