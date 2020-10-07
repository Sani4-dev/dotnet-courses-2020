using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var triangle = new Triangle(25.0, 25.0, 15.0);

                Console.WriteLine($"Периметр треугольника: {triangle.Perimeter():f1}");

                Console.WriteLine($"Площадь треугольника: {triangle.Area():f1}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            Console.ReadKey();
        }
    }
}
