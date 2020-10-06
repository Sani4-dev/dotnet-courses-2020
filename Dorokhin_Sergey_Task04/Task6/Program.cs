using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            string patternScience = @"-?\d+\,\d+e-?\d+";
            string patternUsual = @"-?\d+";
            Regex myRegex = new Regex(patternScience);

            Console.WriteLine("Введите число:");
            inputString = Console.ReadLine();

            MatchCollection matchesScience = myRegex.Matches(inputString);

            myRegex = new Regex(patternUsual);

            MatchCollection matchesUsual = myRegex.Matches(inputString);

            if (matchesScience.Count > 0)
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else if (matchesUsual.Count > 0)
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }

            Console.ReadKey();
        }
    }
}
