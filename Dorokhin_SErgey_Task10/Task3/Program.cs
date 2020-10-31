using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void MainHandler(object sender, SortEventArgs e)
        {
            if (e.StringsArray == null)
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine("Значение массива строк после сортировки:");

            foreach (var str in e.StringsArray)
            {
                Console.WriteLine(str);
            }

        }

        public static string PrintAllStrings(string[] strings)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            
            foreach (var str in strings)
            {
                sb.Append(str);
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public static void BeginSort(string[] args)
        {
            var sd = new SortDemo(args);

            sd.SortDone += MainHandler;
            sd.SortInNewThread();
        }

        static void Main(string[] args)
        {
            string[] fruits = new string[]{"apple", "avocado", "banana", "date", "pinapple", "fiq", "pomegranate"};
            string[] vegetables = new string[] { "eggplant", "cabbage", "cauliflower", "potato", "pea", "dill", "asparagus" };

            Console.WriteLine($"Значиние массива фруктов до сортировки:{PrintAllStrings(fruits)}");
            Console.WriteLine($"Значиние массива овощей до сортировки:{PrintAllStrings(vegetables)}");

            Console.WriteLine("Запуск сортировки фруктов:");
            BeginSort(fruits);

            Console.WriteLine("Запуск сортировки овощей:");
            BeginSort(vegetables);

          
            Console.ReadKey();
        }
    }
}
