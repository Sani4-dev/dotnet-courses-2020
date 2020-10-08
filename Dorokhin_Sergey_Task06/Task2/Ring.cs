using System;

namespace Task2
{
    public class Ring 
    {
        protected double _radiusExternal;
        private Round innerRound;
        private Round outerRound;
        
        public Ring(double coordinateOfCenterX, double coordinateOfCenterY, double radius, double radiusExternal)
            //: base(coordinateOfCenterX, coordinateOfCenterY, radius)
        {
            if (radiusExternal <= radius)
            {
                throw new Exception("Значение \"radiusExternal\" должно быть больше значения \"radius\"!");
            }

            innerRound = new Round(coordinateOfCenterX, coordinateOfCenterY, radius);
            outerRound = new Round(coordinateOfCenterX, coordinateOfCenterY, radiusExternal);
        }
    
        public double Length => innerRound.Length + outerRound.Length;
        
        public double Area => outerRound.Area - innerRound.Area;
    }
}
