using BDLibrary;
using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class Aula
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idAula;
        private string nombre;
        private int aforo;
        private Sede sede;

        public static List<Aula> ListaAula()
        {
            List<Aula> lista = new List<Aula>();
            
            foreach (Object[] tupla in miBD.Select("SELECT idAula FROM Aula;"))
            {
                Aula aux = new Aula((int)tupla[0]);
                lista.Add(aux);
            }
            return lista;
        }

        public static List<Aula> ListaAula(Sede sede)
        {
            List<Aula> lista = new List<Aula>();
            
            foreach (Object[] tupla in miBD.Select("SELECT idAula FROM Aula WHERE idSede = " + sede.IdSede + ";"))
            {
                Aula aux = new Aula((int)tupla[0]);
                lista.Add(aux);
            }
            return lista;
        }

        public Aula(int idAula)
        {
            try
            {
                Object[] tupla = miBD.Select("SELECT * FROM Aula WHERE idAula=" + idAula + ";")[0];

                this.idAula = (int)tupla[0];
                this.nombre = (string)tupla[1];
                this.aforo = (int)tupla[2];
                int sedeID;
                sedeID = -1;
                if (sedeID > 0)
                    this.sede = new Sede(sedeID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public Aula(String nombre)
        {
            try
            {
                if (miBD.Select("SELECT nombre FROM Aula WHERE nombre = '" + nombre + "';").Count == 0)
                {
                    miBD.Insert("INSERT INTO Aula(nombre) VALUES ('" + nombre + "');");
                    Console.WriteLine("Se insertó correctamente");
                    this.idAula = (int)miBD.SelectScalar("SELECT MAX(idAula) FROM Aula");
                    this.nombre = nombre;
                    this.sede = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public int IdAula
        {
            get { return idAula; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int Aforo
        {
            get { return aforo; }
        }

        public Sede Sede
        {
            get { return sede; }
            set
            {
                miBD.Update("UPDATE Aula SET sede = " + sede.IdSede + " WHERE idAula =" + this.idAula + ";");

                sede = value;
            }
        }

        public void borrarAula()
        {
            miBD.Delete("DELETE FROM Aula WHERE idAula =" + this.idAula + ";");
            idAula = -1;
            nombre = null;
            sede = null;
        }

        public override string ToString()
        {
            string res = this.idAula + ";" + this.nombre + ";";
            if (this.sede != null)
            {
                res += sede.ToString();
            }

            return res;
        }

        public override bool Equals(object obj)
        {
            return obj is Aula
                && (((Aula)obj).Nombre.Equals(this.Nombre));
        }

        public override int GetHashCode()
        {
            return this.Nombre.GetHashCode();
        }
    }
}