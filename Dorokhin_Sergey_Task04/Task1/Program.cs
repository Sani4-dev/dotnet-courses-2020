using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");

            char[] mySeparator = new char[] { ' ', '.', ',', ':', ';', '?', '!', '-', '(', ')', '\"' };
            string[] stringDevided= Console.ReadLine().Split(mySeparator, StringSplitOptions.RemoveEmptyEntries);
            double totalQuantityOfChar = 0.0;
            double mediumLengthOfWord;

            foreach (var item in stringDevided)
            {
                totalQuantityOfChar += item.Length;
            }
            mediumLengthOfWord = totalQuantityOfChar / stringDevided.Length;
            Console.WriteLine("Средняя длина слова во введенной строке: {0:f1}", mediumLengthOfWord);

            Console.ReadKey();
        }
    }
}
