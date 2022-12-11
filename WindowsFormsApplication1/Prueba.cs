using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Prueba
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idAula;
        private int idExamen;
        private int idAlumno;

        public static List<Object[]> listaAlumnosAsignaturas()
        {
            //Devuelve una lista de alumnos y exámenes
            List<Object[]> lista = new List<Object[]>();
            string query = "SELECT idAlumnos, idExamen FROM Prueba;";
            
            foreach (object[] tupla in miBD.Select(query))
            {
                lista.Add(tupla);
            }
            return lista;
        }

        public static List<Object[]> listaAulasExamenes()
        {
            List<Object[]> lista = new List<Object[]>();
            string query = "SELECT DISTINCT idAula, idExamen FROM Prueba;";

            foreach (object[] tupla in miBD.Select(query))
            {
                lista.Add(tupla);
            }
            return lista;
        }


        public Prueba(int idAula, int idExamen, int idAlumno)
        {
            try
            {
                if (miBD.Select("SELECT idExamen FROM Prueba WHERE idAula = " + idAula + " AND idExamen = " + idExamen + " AND idAlumno = "+ idAlumno + ";").Count == 0)
                {
                    miBD.Insert("INSERT INTO Prueba(idAula,idExamen,idAlumno) VALUES (" + idAula + "," + idExamen + ", "+idAlumno+");");
                    Console.WriteLine("Se insertó correctamente");
                    this.idAula = idAula;
                    this.idExamen = idExamen;
                    this.idAlumno = idAlumno;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
        public override string ToString()
        {
            return this.idAula + ";"+this.idExamen + ";"+this.idAlumno;
        }

        public override bool Equals(object obj)
        {
            return obj is Examen examen;
        }

        public override int GetHashCode()
        {
            return idAula.GetHashCode() + idExamen.GetHashCode()+ this.idAlumno;
        }
    }
}
