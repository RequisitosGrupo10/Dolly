using BDLibrary;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class FranjaHoraria
    {
        private String franja;

        public FranjaHoraria(string franja)
        {
            this.franja = franja;
        }

        public static FranjaHoraria Insertar(string franja)
        {
            try
            {
                MySqlBD miBd = new MySqlBD();
                var query = miBd.Select("SELECT franja FROM FranjaHoraria WHERE franja = '" + franja +"';"); ;
                if (query.Count == 0)
                    miBd.Insert("Insert into FranjaHoraria values( '" + franja + "');");
                this.franja = franja;
            } catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            
        }

        public static List<FranjaHoraria> ListarFranjas()
        {
            List<FranjaHoraria> list = new List<FranjaHoraria>();
            MySqlBD db = new MySqlBD();
            List<object[]> fh = db.Select("Select * from FranjaHoraria");

            foreach (object[] franja in fh)
            {
                list.Add(new FranjaHoraria ((string) franja[0]));
            }
            return list;
        }

        public void EliminarFranja()
        {
            MySqlBD db = new MySqlBD();
            db.Delete("Delete from FranjaHoraria where franja = '" + this.franja + "';");
            this.franja = null;
        }

        public String Franja
        {
            get { return this.franja; }
        }

        public override string ToString()
        {
            return this.franja;
        }

        public override bool Equals(object obj)
        {
            if(obj is FranjaHoraria)
            {
                FranjaHoraria f = (FranjaHoraria)obj;
                return f.franja.Equals(this.franja);
            }
            return false;
        }
    }
}
