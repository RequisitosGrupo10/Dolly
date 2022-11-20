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

        public static List<Centro> ListaCentro()
        {
            List<Centro> lista = new List<Centro>();

            foreach (Object[] tupla in miBD.Select("SELECT idCentro FROM Centro;"))
            {
                Centro aux = new Centro((int)tupla[0]);
                lista.Add(aux);
            }
            return lista;
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
            MySqlBD miBD = new MySqlBD();
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
                MySqlBD miBD = new MySqlBD();
                miBD.Update("UPDATE Centro SET sede = " + sede.IdSede + " WHERE idCentro =" + this.idCentro + ";");

                sede = value;
            }
        }

        public void borrarCentro()
        {
            MySqlBD miBD = new MySqlBD();
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
    }
}
