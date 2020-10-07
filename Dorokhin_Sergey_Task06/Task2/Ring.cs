using System;

namespace Task2
{
    public class Ring : Round
    {
        protected double _radiusExternal;
        
        public Ring(double coordinateOfCenterX, double coordinateOfCenterY, double radius, double radiusExternal)
            : base(coordinateOfCenterX, coordinateOfCenterY, radius)
        {
            if (radiusExternal > _radius && radiusExternal < _coordinateOfCenterX && radiusExternal < _coordinateOfCenterY)
            {
                _radiusExternal = radiusExternal;
            }
            else
            {
                throw new Exception("Значение \"radiusExternal\" должно быть больше значения \"radius\" и меньше, " +
                    "чем \"coordinateOfCenterX\" или \"coordinateOfCenterY\"!");
            }
        }
    
        public override double Length => 2 * Math.PI * _radius + 2 * Math.PI * _radiusExternal;
        
        public override double Area => Math.PI * (Math.Pow(_radiusExternal, 2.0) - Math.Pow(_radius, 2.0));
    }
}
