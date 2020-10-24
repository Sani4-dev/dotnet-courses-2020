using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void TheHandlerOfEventSortingDone(object obj, EventArgs e)
        {
            if (obj.GetType() != typeof(string[]))
            {
                throw new Exception("Параметр \"obj\" должен быть типа \"string[]\"");
            }

            string[] arrayOfString = (string[])obj;
            
            Console.WriteLine("Значение массива строк после сортировки:");

            foreach (var item in arrayOfString)
            {
                Console.WriteLine(item);
            }

        }

        static void Main(string[] args)
        {
            string[] arrayOfString = new string[]{"different", "more", "linked", "apple", "pinapple", "sea", "automative", "sun",
                "foreground"};

            Console.WriteLine("Значиние массива строк до сортировки:");

            foreach (var item in arrayOfString)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            SortDemo.SortDone += TheHandlerOfEventSortingDone;
            
            SortDemo.SortInNewThread(arrayOfString);

            
            Console.ReadKey();
        }
    }
}
