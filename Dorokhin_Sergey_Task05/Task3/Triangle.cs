using System;

namespace Task3
{
    public class Triangle
    {
        protected double _sideA;
        protected double _sideB;
        protected double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA > 0.0 && sideB > 0.0 && sideC > 0.0)
            {
                if (sideA + sideB > sideC && sideC + sideB > sideA && sideA + sideC > sideB)
                {
                    _sideA = sideA;
                    _sideB = sideB;
                    _sideC = sideC;
                }
                else
                {
                    throw new Exception("Сумма любых 2-х сторон треугольника должна быть больше 3-ей стороны!");
                }
            }
            else
            {
                throw new Exception("Значение параметров \"sideA\", \"sideB\" и \"sideC\" должно быть больше 0!");
            }
        }

        public virtual double Perimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        public virtual double Area()
        {
            double halfPerimeter = (_sideA + _sideB + _sideC) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
        }
    }
}
