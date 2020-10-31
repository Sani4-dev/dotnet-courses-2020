using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "yyyy.MM.dd HH-mm-ss";
            string pathToWatching = ConfigurationManager.AppSettings.Get("pathToWatching");
            string pathToBackuping = ConfigurationManager.AppSettings.Get("pathToBackuping");

            Console.WriteLine("Select mode (input \"w\" to select \"watcher mode\" or input \"b\" to select \"restore backup mode\")");

            string line = Console.ReadLine();
            
            if (line == "w")
            {
                Console.WriteLine("Current mode is watcher.");

                Directory.CreateDirectory(pathToBackuping);

                new Watcher(pathToWatching,
                            pathToBackuping,
                            new CopyDeleter(),
                            format)
                            .Run();
            }
            else if (line == "b")
            {
                Console.WriteLine("Current mode is restore backup mode");
                Console.WriteLine("Please, input the date and time to restore state of files (format following: yyyy.MM.dd HH-mm-ss):");

                string userString = Console.ReadLine();

                if (DateTime.TryParseExact(userString, format, CultureInfo.CurrentCulture, DateTimeStyles.AllowWhiteSpaces,
                    out DateTime userDateTime))
                {
                    new Backuper(pathToWatching, pathToBackuping, new CopyDeleter(), format)
                                .DoBackupTo(userDateTime);

                    Console.WriteLine("The operation backuping is succses");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("The input string do not according the format!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Unknow command");
                Console.ReadKey();
            }

        }
    }
}
