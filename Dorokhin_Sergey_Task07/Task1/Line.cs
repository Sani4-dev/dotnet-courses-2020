using System;

namespace Task1
{
    public class Line : Figure
    {
        protected int _endX;
        protected int _endY;
                
        public Line(int beginX, int beginY, int endX, int endY)
        {
            _typeOfFigure = "линия";
            _coordinateX = beginX;
            _coordinateY = beginY;
            _endX = endX;
            _endY = endY;
        }

        public override string Draw()
        {
            return String.Format($"Тип фигуры: {_typeOfFigure}; X начала линии: {_coordinateX}; Y начала линии: {_coordinateY}; " +
                $"X конца линии: {_endX}; Y конца линии: {_endY}");
        }
    }
}
