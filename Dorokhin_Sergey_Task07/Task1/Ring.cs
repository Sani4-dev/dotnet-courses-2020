using System;

namespace Task1
{
    public class Ring : Circle
    {
        protected int _radiusExternal;

        public Ring(int centerX, int centerY, int radius, int radiusExternal) : base(centerX, centerY, radius)
        {
            _typeOfFigure = "кольцо";
            _radiusExternal = radiusExternal;
        }

        public override string Draw()
        {
            return String.Format($"Тип фигуры: {_typeOfFigure}; X координата центра: {_coordinateX}; " +
                $"Y координата центра: {_coordinateY}; Радиус внутренний: {_radius}; Радиус внешний: {_radiusExternal}");
        }
    }
}
