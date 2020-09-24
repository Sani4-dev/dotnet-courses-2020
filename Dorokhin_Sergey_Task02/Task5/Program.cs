using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class CalculatorPro
    {
        public int Calculate()
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if((i%3 == 0) || (i%5 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorPro calculatorPro = new CalculatorPro();

            Console.WriteLine($"Сумма всех чисел меньше 1000, кратных 3, или 5 равна: {calculatorPro.Calculate()}");

            Console.ReadKey();
        }
    }
}
