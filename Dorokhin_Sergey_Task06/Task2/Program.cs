using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var ring = new Ring(15.0, 11.0, 5.0, 8.0);

                Console.WriteLine($"Площадь кольца равна: {ring.Area:f1}");

                Console.WriteLine($"Суммарная длина внешней и внутренней границ кольца равна: {ring.Length:f1}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            Console.ReadKey();
        }
    }
}
