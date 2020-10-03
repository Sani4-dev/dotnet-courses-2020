using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int scaleCoef = 1000;

            int N = 100;
            double timeString;
            double timeStringBuilder;
            string str = "";
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            sw.Stop();
            timeString = sw.Elapsed.TotalMilliseconds * scaleCoef;
            Console.Write("Время, затраченное классом \"String\" ");
            Console.Write("на операцию сложения (в мкс): ");
            Console.WriteLine($"{timeString}");
            sw.Restart();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            sw.Stop();
            timeStringBuilder = sw.Elapsed.TotalMilliseconds * scaleCoef;
            Console.Write("Время, затраченное классом \"StringBuilder\" ");
            Console.Write("на операцию сложения (в мкс): ");
            Console.WriteLine($"{timeStringBuilder}");
            Console.Write($"Класс \"StringBuilder\" быстрее класса ");
            Console.Write($"\"String\" в {timeString / timeStringBuilder:F1}"); 
            Console.WriteLine(" раз");

            Console.ReadKey();
        }
    }
}
