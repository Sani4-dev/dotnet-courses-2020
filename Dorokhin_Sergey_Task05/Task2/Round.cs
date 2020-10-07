using System;

namespace Task2
{
    public class Round
    {
        protected double _coordinateOfCenterX;
        protected double _coordinateOfCenterY;
        protected double _radius;

        public Round(double coordinateOfCenterX, double coordinateOfCenterY, double radius)
        {
            if (coordinateOfCenterX > 0.0)
            {
                _coordinateOfCenterX = coordinateOfCenterX;
            }
            else
            {
                throw new Exception("Значение \"coordinaeOfCenterX\" должно быть больше 0");
            }

            if (coordinateOfCenterY > 0.0)
            {
                _coordinateOfCenterY = coordinateOfCenterY;
            }
            else
            {
                throw new Exception("Значение \"coordinateOfCenterY\" должно быть больше 0");
            }

            if (radius > 0.0 && radius < _coordinateOfCenterX && radius < _coordinateOfCenterY)
            {
                _radius = radius;
            }
            else
            {
                throw new Exception("Значение \"radius\" должно быть больше 0, " +
                    "но меньше \"coordinateOfCenterX\" и \"coordinateOfCenterY\"");
            }
        }

        public virtual double Length => 2 * Math.PI * _radius;

        public virtual double Area => Math.PI * Math.Pow(_radius, 2.0);
    }
}
