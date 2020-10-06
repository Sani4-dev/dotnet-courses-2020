﻿using System;

namespace Task3
{
    public class Triangle
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            if (a > 0.0)
            {
                _a = a;
            }
            else
            {
                throw new Exception("Значение параметра \"a\" " + 
                    "должно быть больше 0");
            }
            if (b > 0.0)
            {
                _b = b;
            }
            else
            {
                throw new Exception("Значение параметра \"b\" " + 
                    "должно быть больше 0");
            }
            if (c > 0.0)
            {
                _c = c;
            }
            else
            {
                throw new Exception("Значение параметра \"c\" " + 
                    "должно быть больше 0");
            }
        }

        public double Perimeter()
        {
            return _a + _b + _c;
        }

        public double Area()
        {
            double halfPerimeter = (_a + _b + _c) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - _a) *
                (halfPerimeter - _b) * (halfPerimeter - _c));
        }
    }
}
