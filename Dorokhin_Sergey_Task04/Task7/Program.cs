using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            string myPattern = "(([0-1][0-9])|(2[0-3])):[0-5][0-9]";
            string ending;
            Regex myRegex = new Regex(myPattern);

            Console.WriteLine("Введите текст:");
            inputString = Console.ReadLine();

            MatchCollection matches = myRegex.Matches(inputString);

            ending = (matches.Count > 1 && matches.Count < 5) ? "раза" : "раз";
            Console.Write($"Время в тексте присутствует {matches.Count} ");
            Console.WriteLine($"{ending}");

            Console.ReadKey();
        }
    }
}
