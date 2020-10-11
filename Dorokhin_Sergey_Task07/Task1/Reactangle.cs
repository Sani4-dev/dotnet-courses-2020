using System;

namespace Task1
{
    public class Reactangle : Line
    {
        public Reactangle(int beginX, int beginY, int endX, int endY) : base(beginX, beginY, endX, endY)
        {
            _typeOfFigure = "прямоугольник";
        }

        public override string Draw()
        {
            return String.Format($"Тип фигуры: {_typeOfFigure}; X верхнего левого угла: {_coordinateX}; " +
                $"Y верхнего левого угла: {_coordinateY}; Высота прямоугольника: {_endY - _coordinateX}; " +
                $"Ширина прямоугольника: {_endX - _coordinateX}");
        }
    }
}
