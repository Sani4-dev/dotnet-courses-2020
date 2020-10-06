using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class St
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(25.0, 25.0, 15.0);

            Console.WriteLine("Периметр треугольника: " + 
                $"{triangle.Perimeter():f1}");

            Console.WriteLine("Площадь треугольника: " + 
                $"{triangle.Area():f1}");
            
            Console.ReadKey();
        }
    }
}
