using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Examen
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idExamen;
        private Asignatura asignatura;
        private FranjaHoraria franja;


       public static List<Examen> ListaExamenes()
        {
            List<Examen> res = new List<Examen>();
            foreach (var tupla in miBD.Select("SELECT idExamen FROM Examen"))
            {
                Examen examen = new Examen(Int32.Parse(tupla[0].ToString()));
                res.Add(examen);
            }
            return res;
        }

        public Examen(int idExamen)
        {
            try
            {
                object[] tupla = miBD.Select("SELECT idAsignatura, franja FROM Examen WHERE idExamen=" + idExamen + ";")[0];
                this.asignatura = new Asignatura((int)tupla[0]);
                this.franja = new FranjaHoraria((string)tupla[1]);
                this.idExamen = idExamen;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de carga" + ex.Message);
            }
        }

        public Examen(Asignatura asignatura, FranjaHoraria franja)
        {
            try
            {
                if (miBD.Select("SELECT idExamen FROM Examen WHERE franja = '" + franja.Franja + "' AND idAsignatura = " + asignatura.IdAsignatura + ";").Count == 0)
                {
                    miBD.Insert("INSERT INTO Examen(idAsignatura,franja) VALUES (" + asignatura.IdAsignatura + ",'" + franja.Franja + "');");
                    this.idExamen = Int32.Parse(miBD.SelectScalar("SELECT MAX(idExamen) FROM Examen").ToString());
                    this.franja = franja;
                    this.asignatura = asignatura;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de inserción" + ex.Message);
            }
        }

        public int IdExamen
        {
            get { return idExamen; }
        }

        public Asignatura Asignatura
        {
            get { return this.asignatura; }
        }

        public FranjaHoraria Franja
        {
            get { return this.franja; }
        }

        public override string ToString()
        {
            return this.idExamen+";"+this.asignatura+";"+this.franja;
        }

        public override bool Equals(object obj)
        {
            return obj is Examen examen;
        }

        public override int GetHashCode()
        {
            return asignatura.GetHashCode() + franja.GetHashCode();
        }

        internal void BorrarExamen()
        {
            miBD.Delete("DELETE FROM Examen WHERE idExamen =" + this.idExamen + ";");
            idExamen = -1;
            asignatura = null;
            franja= null;
        }
    }
}
