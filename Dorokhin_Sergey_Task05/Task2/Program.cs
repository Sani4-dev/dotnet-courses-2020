using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Round
    {
        private double _x;
        private double _y;
        private double _r;

        public Round(double x, double y, double r)
        {
            try
            {
                if (x > 0.0)
                {
                    _x = x;
                }
                else
                {
                    throw new Exception("Значение \"x\" должно быть больше 0");
                }
                if (y > 0.0)
                {
                    _y = y;
                }
                else
                {
                    throw new Exception("Значение \"y\" должно быть больше 0");
                }
                if (r > 0.0)
                {
                    _r = r;
                }
                else
                {
                    throw new Exception("Значение \"r\" должно быть больше 0");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public double Length => 2 * Math.PI * _r;

        public double Area => Math.PI * Math.Pow(_r, 2.0);
    }


    class Program
    {
        static void Main(string[] args)
        {
            Round round;
            try
            {
                round = new Round(55.0, 50.0, 14.0);
            }
            catch { }
            var str = round.ToString();
            Console.WriteLine($"Длина описанной окружности: {round.Length:f1}");
            Console.WriteLine($"Площадь круга: {round.Area:f1}");
            
            Console.ReadKey();
        }
    }
}
