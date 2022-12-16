using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.CSVParser
{
    internal interface ParserStrategy
    {
        string getLoggerFilename();
    }
}
