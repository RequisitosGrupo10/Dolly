using BDLibrary;
using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class Alumno
    {
        private static MySqlBD miBD = new MySqlBD();
        private Centro centro;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string dni_nif;
        private List<Asignatura> materias;

        public static List<Alumno> ListaEstudiantes()
        {
            List<Alumno> lista = new List<Alumno>();

            foreach (Object[] tupla in miBD.Select("SELECT DNI FROM Alumno;"))
            {
                Alumno aux = new Alumno((string)tupla[0]);
                lista.Add(aux);
            }
            return lista;

        }

        public Alumno(string dni_nif)
        {
            // TODO: Complete member initialization
            Object[] tupla = miBD.Select("SELECT DNI, nombre, apellido1, apellido2, idCentro FROM Alumno WHERE DNI = '" + dni_nif + "';")[0];
            this.dni_nif = (string)tupla[0];
            this.nombre = (string)tupla[1];
            this.apellido1 = (string)tupla[2];
            this.apellido2 = (string)tupla[3];
            this.centro = null;
            this.materias = null;
        }

        public Alumno(int idCentro, string nombre, string apellido1, string apellido2, string dni_nif, string[] materias)
        {
            // TODO: Complete member initialization
            try
            {
                miBD.Insert("Insert Into Alumno(idCentro, DNI, nombre, apellido1, apellido2) VALUES ('"+ idCentro +"', '" + dni_nif + "',' " + nombre + "', '" + apellido1 + "', '"+ apellido2+"');");
                this.centro = new Centro(idCentro);
                this.nombre = nombre;
                this.apellido1 = apellido1;
                this.apellido2 = apellido2;
                this.dni_nif = dni_nif;
                this.materias = null;
                foreach (var materia in materias)
                    this.addAsignatura(materia);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string Nombre
        {
            get { return nombre; }
        }


        public string Apellido
        {
            get { return apellido1 + " " + apellido2; }
        }


        public string DNI
        {
            get { return this.dni_nif; }
            set
            {
                // No actualizar
            }
        }

        public List<Asignatura> Materias
        {
            get {
                if (materias == null)
                    materias = Asignatura.ListaAsignaturaAlumno(this);
                return materias;
            }
        }

        public void addAsignatura(string s_asignatura)
        {
            if (Asignatura.ListaAsignaturaNombre().Contains(s_asignatura))
            {
                var asignatura = Asignatura.getAsignaturaByName(s_asignatura);
                miBD.Insert("Insert into AlumnoAsignatura(idAsignatura, DNI) values ("+asignatura.IdAsignatura+ ", '"+ this.dni_nif +"');");
                Materias.Add(asignatura);
            }
            else
            {
                throw new Exception("Una materia desconocida se intentó insertar en un estudiante: " + s_asignatura);
            }
        }

        public void borrarAlumno()
        {
            miBD.Delete("Delete from AlumnoAsignatura where DNI='" + this.DNI + "';");
            miBD.Delete("DELETE FROM Alumno WHERE DNI ='" + this.DNI + "';");
            dni_nif = null;
            nombre = null;
            apellido1 = null;
            apellido2 = null;
        }

        public override string ToString()
        {
            string res = this.nombre + ";" + this.apellido1 + ";";
            return res;
        }
    }
}
