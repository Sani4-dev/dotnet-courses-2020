using System;

namespace Task1
{
    public class Circle : Figure
    {
        protected int _radius;

        public Circle(int centerX, int centerY, int radius)
        {
            _typeOfFigure = "окружность";
            _coordinateX = centerX;
            _coordinateY = centerY;
            _radius = radius;
        }

        public override string Draw()
        {
            return String.Format($"Тип фигуры: {_typeOfFigure}; X координата центра: {_coordinateX}; " +
                $"Y координата центра: {_coordinateY}; Значение радиуса: {_radius}");
        }
    }
}
