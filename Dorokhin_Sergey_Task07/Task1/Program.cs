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
            List < Figure > arrayOfFigures= new List<Figure>();

            arrayOfFigures.Add(new Line(0, 0, 10, 15));
            arrayOfFigures.Add(new Reactangle(10, 5, 17, 25));
            arrayOfFigures.Add(new Circle(15, 15, 7));
            arrayOfFigures.Add(new Round(34, 25, 12));
            arrayOfFigures.Add(new Ring(100, 145, 35, 70));

            foreach (var item in arrayOfFigures)
            {
                Console.WriteLine(item.Draw());
            }

            Console.ReadKey();
        }
    }
}
