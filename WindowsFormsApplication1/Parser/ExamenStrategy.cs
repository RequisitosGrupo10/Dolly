using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Parser
{
    public class ExamenStrategy : ParserStrategy
    {
        public ExamenStrategy() {

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
            int n_line;
            string line;

            n_line = 0;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                try
                {
                    var split = line.Split(';');
                    if (split.Length != 2)
                        throw new Exception("No hay suficientes argumentos en la línea");
                    Asignatura asignatura = new Asignatura(split[0].ToString().Trim());
                    FranjaHoraria franja = new FranjaHoraria(split[1].ToString().Trim());
                    Examen examen = new Examen(asignatura, franja);
                }
                catch (Exception ex)
                {
                    logger.WriteLine("Error en la línea " + n_line + " - Descripción: " + ex.Message);
                }
                n_line++;
            }
            return (n_line++);
        }
    }
}
