using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            string myPattern = @"</*\w*( \w*=(""|')\w*( \w*)*(""|'))*>";//@"</*\w*\s*\w*=*""*\w*""*\w*>";
            string target = "_";
            string resultString;
            Regex myRegex = new Regex(myPattern);

            Console.WriteLine("Введите HTML текст:");
            //inputString = Console.ReadLine();
            inputString = "<div class=\"kjhgkjh hgkhgkyu uygu\" id=\"uygu\">Содержимое HTML тэга</div>Еще тэг<div id='letter'>" +
                "<b>Это</b> текст <i>c</i> <font color=\"red\">HTML</font>";
            Console.WriteLine(inputString);
            MatchCollection matches = myRegex.Matches(inputString);
            if (matches.Count > 0)
            {
                resultString = myRegex.Replace(inputString, target);
                Console.WriteLine($"Результат замены: {resultString}");
            }
            else
            {
                Console.WriteLine("В тексте не обнаружено ни одного HTML " +
                    "тэга");
            }

            Console.ReadKey();
        }
    }
}
