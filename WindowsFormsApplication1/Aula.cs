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

        private Aula()
        {
        }

        public Aula(int idAula)
        {
            try {
                object[] tupla = miBD.Select("SELECT * FROM Aula WHERE idAula=" + idAula + ";")[0];

                this.idAula = (int)tupla[0];
                this.nombre = (string)tupla[1];
                this.aforo = (int)tupla[2];
                this.sede = null;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }

        public Aula(String nombre, int aforo, int idSede)
        {
            try {
                miBD.Insert("INSERT INTO Aula (nombre,aforo, idSede) VALUES ('" + nombre + "', "+aforo+", "+ idSede + ");");
                Console.WriteLine("Se insertó correctamente");
                this.idAula = (int)miBD.SelectScalar("SELECT MAX(idAula) FROM Aula");
                this.nombre = nombre;
                this.aforo = 0;
                this.sede = new Sede(idSede);
            } catch (Exception e) {
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
                try {
                    miBD.Update("UPDATE Aula SET nombre = '" + value + "' WHERE idAula =" + this.idAula + ";");
                    nombre = value;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
}
        }

        public int Aforo
        {
            get { return aforo; }
            set 
            {
                try {
                    miBD.Update("UPDATE Aula SET aforo = " + value + " WHERE idAula =" + this.idAula + ";");
                    aforo = value;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public Sede Sede
        {
            get { return sede; }
            set
            {
                try {
                    miBD.Update("UPDATE Aula SET sede = " + value.IdSede + " WHERE idAula =" + this.idAula + ";");
                    sede = value;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
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
            string res;
            
            res = this.idAula + ";" + this.nombre + ";";
            if (this.sede != null)
                res += sede.ToString();
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

        public static List<Aula> ListaAula()
        {
            List<Aula> lista = new List<Aula>();

            foreach (object[] tupla in miBD.Select("SELECT idAula, nombre, aforo FROM Aula;"))
            {
                Aula aula = new Aula();
                aula.idAula = (int)tupla[0];
                aula.nombre = (string)tupla[1];
                aula.aforo = (int)tupla[2];
                lista.Add(aula);
            }
            return lista;
        }

        public static List<Aula> ListaAula(Sede sede)
        {
            List<Aula> lista = new List<Aula>();

            foreach (object[] tupla in miBD.Select("SELECT idAula, nombre, aforo FROM Aula WHERE idSede = " + sede.IdSede + ";"))
            {
                Aula aula = new Aula();
                aula.idAula = (int)tupla[0];
                aula.nombre = (string)tupla[1];
                aula.aforo = (int)tupla[2];
                aula.sede = sede;
                lista.Add(aula);
            }
            return lista;
        }

        public static List<string> DisponibilidadHorarias(Aula aula)
        {
            List<object[]> datesAssignedAux = miBD.Select("SELECT franja FROM DisponibilidadAulas WHERE idAula = " + aula.IdAula + ";");
            List<string> datesAssigned = new List<string>();
            foreach (object[] date in datesAssignedAux) { datesAssigned.Add((string)date[0]); }
            return datesAssigned;
        }
    }
}