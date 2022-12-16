using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.CSVParser
{
    internal class CSVParser
    {
        private String filePath;
        StreamReader reader;
        StreamWriter logger;
        private ParserStrategy strategy;

        CSVParser(ParserStrategy strategy)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt) | *.txt | csv files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK
                    && openFileDialog.FileName.Length > 0)
            {
                filePath = openFileDialog.FileName;
            }
            else
            {
                throw new Exception("Archivo de texto no válido");
            }
            this.strategy = strategy;
        }

        public void openReaderAndWriter()
        {
            reader = new StreamReader(filePath);
            logger = new StreamWriter(strategy.getLoggerFilename());
        }


        ~CSVParser()
        {
            if (reader != null)
                reader.Close();
            if (logger != null)
                logger.Close();
        }
    }
}