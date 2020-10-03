using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexOfElement = 0;
            char[] arrayOfChar = new char[100];
            string firstString;
            string secondString;
            string resultString;

            Console.WriteLine("Введите первую строку:");
            firstString = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            secondString = Console.ReadLine();
            foreach (var item in firstString)
            {
                arrayOfChar[indexOfElement] = item;
                indexOfElement++;
                if (secondString.Contains(item))
                {
                    arrayOfChar[indexOfElement] = item;
                    indexOfElement++;
                }
            }
            resultString = new string(arrayOfChar);
            Console.WriteLine(resultString);

            Console.ReadKey();
        }
    }
}
