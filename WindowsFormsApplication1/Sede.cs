using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    class Sede
    {
        private MySqlBD miDB = new MySqlBD();
        private int idSede;
        private string nombre;
        private Usuario responsable;

        public static List<Sede> ListaSede()
        {
            List<Sede> lista = new List<Sede>();
            MySqlBD miBD = new MySqlBD();

            foreach (Object[] tupla in miBD.Select("SELECT idSede FROM Sede;"))
            {
                Sede aux = new Sede((int)tupla[0]);
                lista.Add(aux);
            }
            return lista;
            
        }

        public Sede(int idSede)
        {
            MySqlBD miBD = new MySqlBD();
            try
            {
                Object[] tupla = miBD.Select("SELECT * FROM Sede WHERE idSede=" + idSede + ";")[0];

                this.idSede = (int)tupla[0];
                this.nombre = (string)tupla[1];
                int responsableID;
                //responsableID = Int32.Parse(tupla[2].ToString());
                responsableID = -1;
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
            MySqlBD miBD = new MySqlBD();
            try
            {
                if (miBD.Select("SELECT nombre FROM Sede WHERE nombre = '" + nombre + "';").Count == 0)
                {
                    miBD.Insert("INSERT INTO Sede(nombre) VALUES ('" + nombre + "');");
                    Console.WriteLine("Se insertó correctamente");
                    this.idSede = Int32.Parse(miBD.SelectScalar("SELECT MAX(idSede) FROM Sede").ToString());
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
            get { return responsable; }
            set
            {
                MySqlBD miBD = new MySqlBD();
                miBD.Update("UPDATE Sede SET responsable = " + responsable.IdUsuario + " WHERE idSede =" + this.idSede + ";");

                responsable = value;
            }
        }

        public void borrarSede()
        {
            MySqlBD miBD = new MySqlBD();
            miBD.Delete("DELETE FROM Sede WHERE idSede =" + this.idSede + ";");
            idSede = -1;
            nombre = null;
            responsable = null;
        }

        public override string ToString()
        {
            string res = this.idSede + ";" + this.nombre + ";";
            if (this.responsable != null) {
                res += responsable.ToString();
            }

            return res;
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
    }
    
}
