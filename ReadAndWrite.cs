using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleExcersise
{
    class ReadAndWrite
    {
        public void File()
        {
            string data;
            StreamReader Reader = null;
            StreamWriter writer = null;
            try
            {
                Reader = new StreamReader("C:\\Users\\Admin\\Desktop\\Read.txt");

                data = Reader.ReadLine();
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = Reader.ReadLine();
                }
                Reader.Close();
                writer = new StreamWriter("C:\\Users\\Admin\\Desktop\\Write.txt");
                writer.WriteLine("Once you've created the task, you can use these steps to view, edit, delete, or run:");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                writer.Close();
            }

        }

    }
}
