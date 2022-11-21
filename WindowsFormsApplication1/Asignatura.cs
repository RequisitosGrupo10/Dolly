using BDLibrary;
using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class Asignatura
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idAsignatura;
        private string nombre;

        public static List<Asignatura> ListaAsignatura()
        {
            List<Asignatura> lista = new List<Asignatura>();

            foreach (object[] tupla in miBD.Select("SELECT idAsignatura, nombre FROM Asignatura;"))
            {
                Asignatura aux = new Asignatura();
                aux.idAsignatura = (int)tupla[0];
                aux.nombre = (string)tupla[1];
                lista.Add(aux);
            }
            return lista;
        }

        public static List<string> ListaAsignaturaNombre()
        {
            List<string> lista = new List<string>();

            foreach (Object[] tupla in miBD.Select("select nombre from Asignatura;"))
            {
                lista.Add((string)tupla[0]);
            }
            return lista;
        }

        public static List<Asignatura> ListaAsignaturaAlumno(Alumno alumno)
        {
            List<Asignatura> lista = new List<Asignatura>();

            foreach (object[] tupla in miBD.Select("Select Asignatura.idAsignatura, Asignatura.nombre from Asignatura join AlumnoAsignatura on (Asignatura.idAsignatura = AlumnoAsignatura.idAsignatura) Where AlumnoAsignatura.DNI = '" + alumno.DNI +"';"))
            {
                Asignatura aux = new Asignatura();
                aux.idAsignatura = (int)tupla[0];
                aux.nombre = (string)tupla[1];
                lista.Add(aux);
            }
            return lista;
        }

        private Asignatura()
        {
            // Por motivos de eficiencia, se podrá crear una asignatura vacía
        }

        public Asignatura(int idAsignatura)
        {
            try
            {
                object[] tupla = miBD.Select("SELECT idAsignatura, nombre FROM Asignatura WHERE idAsignatura=" + idAsignatura + ";")[0];
                this.idAsignatura = (int)tupla[0];
                this.nombre = (string)tupla[1];
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public Asignatura(string nombre)
        {
            try
            {
                if (miBD.Select("SELECT nombre FROM Asignatura WHERE nombre = '" + nombre + "';").Count == 0)
                {
                    miBD.Insert("INSERT INTO Asignatura(nombre) VALUES ('" + nombre + "');");
                    Console.WriteLine("Se insertó correctamente");
                    this.idAsignatura = (int)miBD.SelectScalar("SELECT MAX(idAsignatura) FROM Asignatura");
                    this.nombre = nombre;
                }
            } catch (Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }

        public int IdAsignatura
        {
            get { return idAsignatura; }
            set
            {
                try {
                    miBD.Update("UPDATE Grupo SET idAsignatura = " + value + " WHERE idAsignatura =" + this.idAsignatura + ";");
                    idAsignatura = value;
                } catch (Exception e) {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                try {
                    miBD.Update("UPDATE Grupo SET nombre = '" + value + "' WHERE idAsignatura =" + this.idAsignatura + ";");
                    nombre = value;
                } catch (Exception e) {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }

        public void borrarAsignatura()
        {
            miBD.Delete("DELETE FROM Asignatura WHERE idAsignatura =" + this.idAsignatura + ";");
            idAsignatura = -1;
            nombre = null;
        }

        public override string ToString()
        {
            string res = this.idAsignatura + ";" + this.nombre + ";";

            return res;
        }

        public override bool Equals(object obj)
        {
            return obj is Asignatura
                && (((Asignatura)obj).nombre == this.nombre);
        }

        public override int GetHashCode()
        {
            return this.idAsignatura.GetHashCode();
        }
        public static Asignatura getAsignaturaByName(string nombre)
        {
            Asignatura res = new Asignatura();
            res.idAsignatura = -1;
            res.nombre = "";
            try
            {
                var query = miBD.Select("SELECT idAsignatura FROM Asignatura WHERE nombre = '" + nombre + "';");
                if (query.Count > 0)
                {
                    res.idAsignatura = (int) query[0][0];
                    res.nombre = nombre;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }
    }

}
