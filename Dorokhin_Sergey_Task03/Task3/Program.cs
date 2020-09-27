using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask03;

namespace Task3
{
    class Program
    {
        const int arrayLength = 10;
        static void Main(string[] args)
        {
            int[] myArray = new int[arrayLength];
            int sumNumbersGreatThenZero = 0;
            
            MyArrayMethods.InitOneDimension(myArray);
            MyArrayMethods.DisplayOneDimension(myArray);
            foreach (var item in myArray)
            {
                if (item > 0)
                {
                    sumNumbersGreatThenZero += item;
                }
            }
            Console.WriteLine($"Сумма неотрицательных элементов: {sumNumbersGreatThenZero}");

            Console.ReadKey();
        }
    }
}
