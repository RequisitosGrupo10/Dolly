using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Asignatura
    {
        private int idAsignatura;
        private string nombre;

        public static List<Asignatura> ListaAsignatura()
        {
            List<Asignatura> lista = new List<Asignatura>();
            MySqlBD miBD = new MySqlBD();

            foreach (Object[] tupla in miBD.Select("SELECT idAsignatura FROM Asignatura;"))
            {
                lista.Add(new Asignatura((int)tupla[0]));
            }
            return lista;
        }

        public Asignatura(int idAsignatura)
        {
            MySqlBD miBD = new MySqlBD();
            Object[] tupla = miBD.Select("SELECT * FROM Asignatura WHERE idAsignatura=" + this.idAsignatura + ";")[0];

            this.idAsignatura = (int)tupla[0];
            this.nombre = (String)tupla[1];
        }

        public Asignatura(String nombre)
        {
            MySqlBD miBD = new MySqlBD();
            foreach (Object[] tupla in miBD.Select("SELECT nombre FROM Asignatura;"))
            {
                if ((String) tupla[0] != nombre)
                {
                    miBD.Insert("INSERT INTO Asignatura VALUES ('" + nombre + "');");
                    this.idAsignatura = (int) miBD.SelectScalar("SELECT MAX(idAsignatura) FROM Asignatura");
                    this.nombre = nombre;
                }
            }
        }

        public int IdAsignatura
        {
            get { return idAsignatura; }
            set
            {
                MySqlBD miBD = new MySqlBD();
                miBD.Update("UPDATE Grupo SET idAsignatura = " + value + " WHERE idAsignatura =" + this.idAsignatura + ";");

                idAsignatura = value;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                MySqlBD miBD = new MySqlBD();
                miBD.Update("UPDATE Grupo SET nombre = '" + value + "' WHERE idAsignatura =" + this.idAsignatura + ";");

                nombre = value;
            }
        }

        public void borrarAsignatura()
        {
            MySqlBD miBD = new MySqlBD();
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
    }
}
