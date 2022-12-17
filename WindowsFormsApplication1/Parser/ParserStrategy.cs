using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Parser
{
    public interface ParserStrategy
    {
        string getLoggerFilename();
        string getTypeOfFile();
        int Parse(StreamReader reader, StreamWriter logger);
    }
}
