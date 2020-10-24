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
            int numberToFactorial = 6;
            double numberToPow = 5.0;
            double exponent = 4.0;

            Console.WriteLine($"Результат вычисления факториала для числа {numberToFactorial} равен: " +
                $"{ClassLibrary1.Class1.Factorial(numberToFactorial)}");

            Console.WriteLine($"Результат возведения числа {numberToPow} в степень {exponent} равен: " +
                $"{ClassLibrary1.Class1.Pow(numberToPow, exponent)}");

            
            Console.ReadKey();
        }
    }
}
