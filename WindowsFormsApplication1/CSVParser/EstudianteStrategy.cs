using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.CSVParser
{
    internal class EstudianteStrategy : ParserStrategy
    {
        public EstudianteStrategy() {

        }

        public string getLoggerFilename()
        {
            return ("Estudiantes.log");
        }
    }
}
