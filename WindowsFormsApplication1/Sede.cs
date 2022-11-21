using BDLibrary;
using System;
using System.Collections.Generic;


namespace WindowsFormsApplication1
{
    public class Sede
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idSede;
        private string nombre;
        private Usuario responsable;

        private Sede()
        {
        }

        public Sede(int idSede)
        {
            MySqlBD miBD = new MySqlBD();
            try
            {
                Object[] tupla = miBD.Select("SELECT idSede,nombre,IFNULL(responsable,-1) FROM Sede WHERE idSede=" + idSede + ";")[0];

                this.idSede = (int)tupla[0];
                this.nombre = (string)tupla[1];
                int responsableID = Int32.Parse(tupla[2].ToString());
                if (responsableID > 0)
                    this.responsable = new Usuario(responsableID);
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }

        }

        public Sede(String nombre)
        {
            
            try
            {
                if (miBD.Select("SELECT nombre FROM Sede WHERE nombre = '" + nombre + "';").Count == 0)
                {
                    miBD.Insert("INSERT INTO Sede(nombre) VALUES ('" + nombre + "');");
                    Console.WriteLine("Se insertó correctamente");
                    this.idSede = (int)miBD.SelectScalar("SELECT MAX(idSede) FROM Sede");
                    this.nombre = nombre;
                    this.responsable = null; 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public int IdSede
        {
            get { return idSede; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public Usuario Responsable
        {
            get {
                if (responsable == null)
                {
                    MySqlBD miBD = new MySqlBD();
                    var query = miBD.Select("SELECT idUsuario FROM Usuario Join Sede ON (Sede.responsable = Usuario.idUsuario) WHERE Sede.idSede = "+this.idSede+";");
                    if (query.Count > 0)
                        responsable = new Usuario((int)query[0][0]);
                    else
                        responsable = null;

                }
                return responsable;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        miBD.Update("UPDATE Sede SET responsable = null WHERE idSede =" + this.idSede + ";");
                    }
                    else
                    {
                        miBD.Update("UPDATE Sede SET responsable = " + value.IdUsuario + " WHERE idSede =" + this.idSede + ";");
                    }
                    responsable = value;
                } catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }

                
            }
        }

        public void borrarSede()
        {
            miBD.Delete("DELETE FROM Sede WHERE idSede =" + this.idSede + ";");
            idSede = -1;
            nombre = null;
            responsable = null;
        }

        public override String ToString()
        {
            return this.nombre;
        }

        public override bool Equals(object obj)
        {
            return obj is Sede
                && (((Sede)obj).idSede == this.idSede);
        }

        public override int GetHashCode()
        {
            return this.idSede.GetHashCode();
        }
        public static List<Sede> ListaSede()
        {
            List<Sede> lista = new List<Sede>();
            foreach (object[] tupla in miBD.Select("SELECT idSede, nombre, responsable FROM Sede;"))
            {
                Sede aux = new Sede();
                aux.idSede = (int)tupla[0];
                aux.nombre=(string)tupla[1];
                aux.responsable = null;
                lista.Add(aux);
            }
            return lista;
        }
    }
}
