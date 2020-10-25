using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            string path = ConfigurationManager.AppSettings.Get("ThePathToUsingFile");

            try
            {
                using (var sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (int.TryParse(line, out int number))
                        {
                            list.Add(number * number);
                        }
                        else
                        {
                            Console.WriteLine("Это не число!");
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            try
            {
                using (var sw = new StreamWriter(path, false))
                {
                    foreach (var item in list)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be write:");
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
