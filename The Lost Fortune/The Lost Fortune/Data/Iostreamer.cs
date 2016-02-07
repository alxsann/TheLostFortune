using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace The_Lost_Fortune
{
    class Iostreamer
    {
        public static void SaveToFile(List<object> data)
        {
            // Streamwriter oprettet for at kunne gemme "karateren"
            FileStream fs = new FileStream(Environment.SpecialFolder.MyDocuments.ToString(), FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                foreach(object attribute in data)
                sw.WriteLine(attribute);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                fs.Close();
                MessageBox.Show("Files have been saved");
            }

        }
            

        public static void LoadFile()
    {
                try
                {
                    // Har oprettet en StreamReader for at kunne læse fra fil.

                    using (StreamReader sr = new StreamReader(Environment.SpecialFolder.MyDocuments.ToString()))
                    {
                        string line;
                      
                        // Læser og viser samtlige ligner indtil den har gennemgået hele dokumentet.
                        while ((line = sr.ReadLine()) != null)
                        {
                        MessageBox.Show(line);
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception e)
                {
                    // En fejlmeddelse bliver udskrevet, hvis du har fucket noget op
                    Console.WriteLine("Something went horribly wrong! Did you select the wrong textfile scrublord");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
       