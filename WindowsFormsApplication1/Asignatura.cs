using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Asignatura
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
            try
            {
                Object[] tupla = miBD.Select("SELECT * FROM Asignatura WHERE idAsignatura=" + idAsignatura + ";")[0];

                this.idAsignatura = (int)tupla[0];
                this.nombre = (string)tupla[1];
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public Asignatura(String nombre)
        {
            MySqlBD miBD = new MySqlBD();
            try
            {
                if (miBD.Select("SELECT nombre FROM Asignatura WHERE nombre = '" + nombre + "';").Count == 0)
                {
                    miBD.Insert("INSERT INTO Asignatura(nombre) VALUES ('" + nombre + "');");
                    Console.WriteLine("Se insertó correctamente");
                    this.idAsignatura = (int)miBD.SelectScalar("SELECT MAX(idAsignatura) FROM Asignatura");
                    this.nombre = nombre;
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
