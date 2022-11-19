using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Asignatura
    {
        private static string BD_SERVER = "database-pevau.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "grupo10";

        private int idAsignatura;
        private string nombre;

        public static List<Asignatura> ListaAsignatura()
        {
            List<Asignatura> lista = new List<Asignatura>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (Object[] tupla in miBD.Select("SELECT idAsignatura FROM Asignatura;"))
            {
                lista.Add(new Asignatura((int)tupla[0]));
            }
            return lista;
        }

        public Asignatura(int idAsignatura)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Asignatura WHERE idAsignatura=" + this.idAsignatura + ";")[0];

            this.idAsignatura = (int)tupla[0];
            this.nombre = (String)tupla[1];
        }

        public Asignatura(int idAsignatura, String nombre)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            try {
                miBD.Insert("INSERT INTO Asignatura VALUES ('" + nombre + "');");
               this.idAsignatura = idAsignatura;
               this.nombre = nombre;
            } catch (Exception e) {
                // Ya estaba insertada, no hago nada
            }
        }

        public int IdAsignatura
        {
            get { return idAsignatura; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Grupo SET idAsignatura = " + value + " WHERE idAsignatura =" + this.idAsignatura + ";");

                idAsignatura = value;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Grupo SET nombre = '" + value + "' WHERE idAsignatura =" + this.idAsignatura + ";");

                nombre = value;
            }
        }

        public void borrarAsignatura()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
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
                && (((Asignatura)obj).idAsignatura == this.idAsignatura);
        }

        public override int GetHashCode()
        {
            return this.idAsignatura.GetHashCode();
        }
    }
    }
}
