using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask03;

namespace Task2
{
    class Program
    {
        const int sizeOneDimensionArray = 5;
        const int sizeTwoDimensionArray = 5;
        const int sizeThreeDimensionArray = 5;
        const int minValueRandom = -100;
        const int maxValueRandom = 100;

        static void Main(string[] args)
        {
            int[,,] myThreeDimensionArrray = new int[sizeOneDimensionArray, sizeTwoDimensionArray, sizeThreeDimensionArray];
            Random random = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < myThreeDimensionArrray.GetLength(0); i++)
            {
                for (int j = 0; j < myThreeDimensionArrray.GetLength(1); j++)
                {
                    Console.Write("[");
                    for (int k = 0; k < myThreeDimensionArrray.GetLength(2); k++)
                    {
                        myThreeDimensionArrray[i, j, k] = random.Next(minValueRandom, maxValueRandom);
                        MyArrayMethods.FormattingDisplay(myThreeDimensionArrray[i, j, k]);
                        if (k == (myThreeDimensionArrray.GetLength(2) - 1))
                        {
                            Console.Write($"{myThreeDimensionArrray[i, j, k]}");
                        }
                        else
                        {
                            Console.Write($"{myThreeDimensionArrray[i, j, k]}, ");
                        }
                        if (myThreeDimensionArrray[i, j, k] > 0)
                        {
                            myThreeDimensionArrray[i, j, k] = 0;
                        }
                    }
                    Console.Write("] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Обработанный массив:");
            for (int i = 0; i < myThreeDimensionArrray.GetLength(0); i++)
            {
                for (int j = 0; j < myThreeDimensionArrray.GetLength(1); j++)
                {
                    Console.Write("[");
                    for (int k = 0; k < myThreeDimensionArrray.GetLength(2); k++)
                    {
                        MyArrayMethods.FormattingDisplay(myThreeDimensionArrray[i, j, k]);
                        if (k == (myThreeDimensionArrray.GetLength(2) - 1))
                        {
                            Console.Write($"{myThreeDimensionArrray[i, j, k]}");
                        }
                        else
                        {
                            Console.Write($"{myThreeDimensionArrray[i, j, k]}, ");
                        }
                    }
                    Console.Write("] ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
