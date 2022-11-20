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
        private DateTime franja;

        public FranjaHoraria(string franja)
        {
            this.franja = DateTime.ParseExact(franja, "dd-MM-yyyy:HH:mm", CultureInfo.InvariantCulture);
            try
            {
                
                MySqlBD db = new MySqlBD();
                string s = toSQLFormat(this.franja);
                db.Insert("Insert into FranjaHoraria values( '" + s + "');");
            } catch (Exception)
            {
                // Its already in DB;
            }
        }

        public FranjaHoraria(DateTime franja)
        {

            this.franja = franja;
            MySqlBD db = new MySqlBD();
            try
            {
                string s = toSQLFormat(this.franja);
                db.Insert("Insert into FranjaHoraria values( '" + s + "');");
            }
            catch (Exception)
            {
                // Its already in DB;
            }
        }

        public static List<DateTime> ListarFranjas()
        {
            List<DateTime> list = new List<DateTime>();
            MySqlBD db = new MySqlBD();
            List<Object[]> fh = db.Select("Select * from FranjaHoraria");

            foreach (Object[] franja in fh)
            {
                list.Add((DateTime) franja[0]);
            }

            return list;
        }

        public void EliminarFranja()
        {
            MySqlBD db = new MySqlBD();
            string s = toSQLFormat(franja);
            db.Delete("Delete from FranjaHoraria where franja = '" + s + "';");
        }

        public static string toSQLFormat(DateTime franja)
        {
            return franja.Year.ToString() + "-" + franja.Month.ToString() + "-" + franja.Day.ToString() + " " + franja.Hour.ToString() + ":" + franja.Minute.ToString() + ";" + franja.Second.ToString();
        }
        public DateTime Franja
        {
            get { return this.franja; }
        }

        public override string ToString()
        {
            return franja.ToString();
        }
    }
}
