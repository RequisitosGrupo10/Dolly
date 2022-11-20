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

        public Aula(String nombre, int aforo, int idSede)
        {
            Console.WriteLine("Nombre = " + nombre + ", aforo = "+aforo + ", idSede = " + idSede);
            try
            {
                miBD.Insert("INSERT INTO Aula (nombre,aforo, idSede) VALUES ('" + nombre + "', "+aforo+", "+ idSede + ");");
                Console.WriteLine("Se insertó correctamente");
                this.idAula = (int)miBD.SelectScalar("SELECT MAX(idAula) FROM Aula");
                this.nombre = nombre;
                this.aforo = 0;
                this.sede = new Sede(idSede);
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
            set
            {
                miBD.Update("UPDATE Aula SET nombre = '" + value + "' WHERE idAula =" + this.idAula + ";");
                nombre = value;
            }
        }

        public int Aforo
        {
            get { return aforo; }
            set 
            {
                miBD.Update("UPDATE Aula SET aforo = " + value + " WHERE idAula =" + this.idAula + ";");
                aforo = value; 
            }
        }

        public Sede Sede
        {
            get { return sede; }
            set
            {
                miBD.Update("UPDATE Aula SET sede = " + value.IdSede + " WHERE idAula =" + this.idAula + ";");

                sede = value;
            }
        }

        public static List<DateTime> DisponibilidadHorarias(Aula aula)
        {
            List<Object[]> datesAssignedAux = miBD.Select("SELECT franja FROM DisponibilidadAulas WHERE idAula = " + aula.IdAula + ";");
            List<DateTime> datesAssigned = new List<DateTime>();
            foreach (Object[] date in datesAssignedAux) { datesAssigned.Add((DateTime)date[0]); }
            return datesAssigned;
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

        internal static object ListaSede(object sede)
        {
            throw new NotImplementedException();
        }
    }
}