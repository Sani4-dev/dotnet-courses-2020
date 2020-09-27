using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask03;

namespace Task4
{
    class Program
    {
        const int sizeOneDimensionArray = 5;
        const int sizeTwoDimensionArray = 5;
        const int minValueRandom = -100;
        const int maxValueRandom = 100;
        
        static void Main(string[] args)
        {
            int[,] myTwoDimensionArray = new int[sizeOneDimensionArray, sizeTwoDimensionArray];
            int sumEvenPositionElementsArray = 0;
            Random random = new Random();

            for (int i = 0; i < myTwoDimensionArray.GetLength(0); i++)
            {
                for (int j = 0; j < myTwoDimensionArray.GetLength(1); j++)
                {
                    myTwoDimensionArray[i, j] = random.Next(minValueRandom, maxValueRandom);
                    if ((i + j) % 2 == 0)
                    {
                        sumEvenPositionElementsArray += myTwoDimensionArray[i, j];
                    }
                    MyArrayMethods.FormattingDisplay(myTwoDimensionArray[i, j]);
                    Console.Write($"{myTwoDimensionArray[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма элементов массива, стоящих на четных позициях: {sumEvenPositionElementsArray}");

            Console.ReadKey();
        }
    }
}
