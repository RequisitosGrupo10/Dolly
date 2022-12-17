using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Parser
{
    public class CSVParser
    {
        private String filePath;
        StreamReader reader;
        StreamWriter logger;
        private ParserStrategy strategy;

        public CSVParser(ParserStrategy strategy)
        {
            this.strategy = strategy;
            getFilepathDialog();
        }

        private void getFilepathDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = strategy.getTypeOfFile();
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK
                    && openFileDialog.FileName.Length > 0)
            {
                filePath = openFileDialog.FileName;
            }
            else
                throw new Exception("Archivo de texto no válido");
        }

        public void Parse()
        {
            int lineasProcesadas;
            
            reader = new StreamReader(filePath);
            logger = new StreamWriter(strategy.getLoggerFilename());
            lineasProcesadas = strategy.Parse(reader, logger);
            MessageBox.Show("Se procesaron" + (lineasProcesadas) + " líneas.",
                    "File Content at path: " + filePath, MessageBoxButtons.OK);
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