namespace Task1
{
    public class Round : Circle
    {
        public Round(int centerX, int centerY, int radius) : base(centerX, centerY, radius)
        {
            _typeOfFigure = "круг";
        }
    }
}
