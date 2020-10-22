using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetString = "This is a string to testing the task 3 of solution 9. It content many different words. " +
                "The general target of this task is founding all the same words and point quantity of repeating. I hope that " +
                "my solve, for this task, will be work";
            string pattern = @" |\. |, |"",'',-,! , ? ";

            targetString = targetString.ToLower();

            string[] arrayString = Regex.Split(targetString, pattern);

            var query = arrayString.GroupBy(x => x)
                                   .Where(g => g.Count() > 0)
                                   .Select(y => new { Element = y.Key, Counter = y.Count() })
                                   .ToList();

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Element} = {item.Counter}");
            }

            Console.ReadKey();
        }
    }
}
