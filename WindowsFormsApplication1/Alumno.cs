using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Alumno
    {
        private Centro centro;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string dni_nif;
        private List<Asignatura> materias;

        public static List<Alumno> ListaEstudiantes()
        {
            List<Alumno> lista = new List<Alumno>();
            MySqlBD miBD = new MySqlBD();

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
            MySqlBD miBD = new MySqlBD();
            Object[] tupla = miBD.Select("SELECT DNI, nombre, apellido1, apellido2, idCentro FROM Alumno WHERE DNI = '" + dni_nif + "';")[0];
            this.dni_nif = (string)tupla[0];
            this.nombre = (string)tupla[1];
            this.apellido1 = (string)tupla[2];
            this.apellido2 = (string)tupla[3];
            this.centro = null;
            this.materias = null;
        }

        public Alumno(string centro, string nombre, string apellido1, string apellido2, string dni_nif, string[] materias)
        {
            // TODO: Complete member initialization
            MySqlBD miBD = new MySqlBD();
            try
            {
                Centro centrado = new Centro(centro);
                miBD.Insert("Insert Into Alumno(idCentro, DNI, nombre, apellido1, apellido2) VALUES ('"+ centrado.IdCentro +"', '" + dni_nif + "',' " + nombre + "', '" + apellido1 + "', '"+ apellido2+"');");
                this.centro = null;
                this.nombre = nombre;
                this.apellido1 = apellido1;
                this.apellido2 = apellido2;
                this.dni_nif = dni_nif;
                this.materias = null;
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

        public void borrarAlumno()
        {
            MySqlBD miBD = new MySqlBD();
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
