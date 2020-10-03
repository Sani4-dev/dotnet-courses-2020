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
        public double CircumFerence
        {
            get
            {
                return 2 * 3.14 * _r;
            }
        }
        public double AreaOfCircle
        {
            get
            {
                return 3.14 * _r * _r;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var round = new Round(55.0, 50.0, 14.0);

            Console.WriteLine($"Длина описанной окружности: {round.CircumFerence}");
            Console.WriteLine($"Площадь круга: {round.AreaOfCircle}");
            
            Console.ReadKey();
        }
    }
}
