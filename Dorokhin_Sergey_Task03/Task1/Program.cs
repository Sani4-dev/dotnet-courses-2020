using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask03;

namespace Task1
{
    class Program
    {
        const int arrayLength = 10;
        static void Main(string[] args)
        {
            int[] myArray = new int[arrayLength];

            MyArrayMethods.InitOneDimension(myArray);
            Console.WriteLine("Исходный массив:");
            MyArrayMethods.DisplayOneDimension(myArray);
            Console.WriteLine($"Максимальное значение: {MyArrayMethods.GetMaxValue(myArray)}");
            Console.WriteLine($"Минимальное значение: {MyArrayMethods.GetMinValue(myArray)}");
            MyArrayMethods.SortArray(myArray);
            Console.WriteLine("Отсортированный массив:");
            MyArrayMethods.DisplayOneDimension(myArray);

            Console.ReadKey();
        }
    }
}
