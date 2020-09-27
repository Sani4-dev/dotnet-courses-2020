using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask03
{
    public static class MyArrayMethods
    {
        const int minValueRandom = -100;
        const int maxValueRandom = 100;
        public static void InitOneDimension(int[] arrayToInit)
        {
            Random random = new Random();

            for (int i = 0; i < arrayToInit.Length; i++)
            {

                arrayToInit[i] = random.Next(minValueRandom, maxValueRandom);
            }
        }
        public static int GetMaxValue(int[] arrayToFound)
        {
            int maxValue = arrayToFound[0];
            for (int i = 1; i < arrayToFound.Length; i++)
            {
                if (arrayToFound[i] > maxValue)
                {
                    maxValue = arrayToFound[i];
                }
            }
            return maxValue;
        }
        public static int GetMinValue(int[] arrayToFound)
        {
            int minValue = arrayToFound[0];
            for (int i = 1; i < arrayToFound.Length; i++)
            {
                if (arrayToFound[i] < minValue)
                {
                    minValue = arrayToFound[i];
                }
            }
            return minValue;
        }
        public static void SortArray(int[] arrayToSort)
        {
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = i; j < arrayToSort.Length; j++)
                {
                    if (arrayToSort[j] < arrayToSort[i])
                    {
                        int temp = arrayToSort[i];

                        arrayToSort[i] = arrayToSort[j];
                        arrayToSort[j] = temp;
                    }
                }
            }
        }
        public static void DisplayOneDimension(int[] arrayToDisplay)
        {
            foreach (var item in arrayToDisplay)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static void FormattingDisplay(int valueToFormat)
        {
            if (valueToFormat >= 0)
            {
                Console.Write(" ");
            }
            if (Math.Abs(valueToFormat) < 10)
            {
                Console.Write("  ");
            }
            else if ((Math.Abs(valueToFormat) > 9) && (Math.Abs(valueToFormat) < 100))
            {
                Console.Write(" ");
            }
        }

    }
}
