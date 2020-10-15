namespace Task2
{
    public class GeometricProgression : ISeries
	{
		protected double start;
		protected double currentValueOfProgression;
		protected double step;

		public GeometricProgression(double start, double step)
		{
			this.start = start;
			this.step = step;
			currentValueOfProgression = start;
		}

		public double GetCurrent()
		{
			return currentValueOfProgression * step;
		}

		public bool MoveNext()
		{
			currentValueOfProgression = GetCurrent();
			return true;
		}

		public void Reset()
		{
			currentValueOfProgression = start;
		}
	}
}
