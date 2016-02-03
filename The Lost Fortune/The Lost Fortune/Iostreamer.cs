using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The_Lost_Fortune
{
    class Iostreamer
    {
        public static void LoadFile()
        {
            // Streamwriter oprettet for at kunne gemme "karateren"
            FileStream fs = new FileStream("c:\\Users\\Casper\\Documents\\text.bat.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                sw.WriteLine("Kevin er bøgse");
            } finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                fs.Close();
            }
            
        }
        // StreamReader til at hente og læse "Karakterern"
    }
}
 // Load + save file