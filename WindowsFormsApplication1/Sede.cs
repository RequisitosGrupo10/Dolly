using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    internal class Sede
    {
        private MySqlBD miDB = new MySqlBD();
    
        public Sede()
        {
            miDB.Select("SELECT * FROM Sede;");
            miDB.Insert("INSERT INTO Rol(nombre) VALUES ('admin')");
        }
    
    }
}
