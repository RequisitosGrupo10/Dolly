using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class Log
    {
        public static void HacerLog(string text, string filename)
        {
            try
            {
                // Creating a new file, or overwrite
                // if the file already exists.
                using (FileStream fs = File.Create(filename))
                {
                    // Adding some info into the file
                    byte[] info = new UTF8Encoding(true).GetBytes(text);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception)
            {

            }
        }
        public static void EliminarLog(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
        }
    }
}
