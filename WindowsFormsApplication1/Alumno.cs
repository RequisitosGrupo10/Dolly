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
        private Alumno()
        {
        }
        public Alumno(string dni_nif)
        {
            try {
                object[] tupla = miBD.Select("SELECT DNI, nombre, apellido1, apellido2, idCentro FROM Alumno WHERE DNI = '" + dni_nif + "';")[0];
                this.dni_nif = (string)tupla[0];
                this.nombre = (string)tupla[1];
                this.apellido1 = (string)tupla[2];
                this.apellido2 = (string)tupla[3];
                this.centro = null;
                this.materias = null;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public Alumno(int idCentro, string nombre, string apellido1, string apellido2, string dni_nif, string[] materias)
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
        }

        public string Nombre
        {
            get { return nombre; }
        }


        public string Apellido1
        {
            get { return apellido1; }
        }

        public string Apellido2
        {
            get { return apellido2; }
        }

        public string DNI
        {
            get { return this.dni_nif; }
            set
            {
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
                Asignatura asignatura = Asignatura.getAsignaturaByName(s_asignatura);
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

        public static List<Alumno> ListaAlumno()
        {
            List<Alumno> lista = new List<Alumno>();

            foreach (object[] tupla in miBD.Select("SELECT DNI, nombre, apellido2, apellido2 FROM Alumno;"))
            {
                Alumno aux = new Alumno();
                aux.dni_nif = (string)tupla[0];
                aux.nombre = (string)tupla[1];
                aux.apellido1 = (string)tupla[2];
                aux.apellido2 = (string)tupla[3];
                aux.centro = null;
                aux.materias = null;
                lista.Add(aux);
            }
            return lista;

        }
    }
}
