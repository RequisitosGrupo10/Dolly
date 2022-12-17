using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Parser
{
    public class EstudianteStrategy : ParserStrategy
    {
        public EstudianteStrategy() {

        }

        public string getLoggerFilename()
        {
            return ("Estudiantes.log");
        }

        public string getTypeOfFile()
        {
            return ("txt files (*.txt) | *.txt | csv files (*.csv)|*.csv");
        }

        public int Parse(StreamReader reader, StreamWriter logger)
        {
            throw new NotImplementedException();
        }
    }
}
