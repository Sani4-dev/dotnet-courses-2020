using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int Factorial(int n)
        {
            int factResult = 1;

            for (int i = 2; i <= n; i++)
            {
                factResult *= i;
            }

            return factResult;
        }

        public static double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
