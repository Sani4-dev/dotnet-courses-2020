using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Round
    {
        protected double _x;
        protected double _y;
        protected double _r;
        
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public virtual double Length => 2 * Math.PI * _r;

        public virtual double Area => Math.PI * Math.Pow(_r, 2.0);
    }


    public class Ring : Round
    {
        private double _rExternal;
        
        public Ring(double x, double y, double r, double rExternal)
            : base(x, y, r)
        {
            try
            {
                if (rExternal > 0)
                {
                    _rExternal = rExternal;
                }
                else
                {
                    throw new Exception("Значение внешнего радиуса кольца " +
                        "должно быть блольше 0!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override double Length => 2 * Math.PI * _r + 
            2 * Math.PI * _rExternal;
        
        public override double Area => Math.PI * (Math.Pow(_rExternal, 2.0) - 
            Math.Pow(_r, 2.0));
    }


    class Program
    {
        static void Main(string[] args)
        {
            var ring = new Ring(50.0, 65.0, 15.0, 19.0);

            Console.WriteLine($"Площадь кольца равна: {ring.Area:f1}");
            Console.WriteLine($"Суммарная длина внешней и внутренней границ " + 
                $"кольца равна: {ring.Length:f1}");
            
            Console.ReadKey();
        }
    }
}
