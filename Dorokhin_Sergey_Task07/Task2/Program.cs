using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
        static void Main(string[] args)
        {
            var geometricProgression = new GeometricProgression(5, 2);

            PrintSeries(geometricProgression);

            Console.ReadKey();
        }
    }
}
