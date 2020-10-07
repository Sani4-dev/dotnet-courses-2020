using System;
using System.CodeDom;
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
                var round = new Round(5.0, 7.0, 4.0);

                Console.WriteLine($"Длина описанной окружности: {round.Length:f1}");

                Console.WriteLine($"Площадь круга: {round.Area:f1}");
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
                        
            
            Console.ReadKey();
        }
    }
}
