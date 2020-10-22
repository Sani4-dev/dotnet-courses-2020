using System;

namespace Task2
{
    public class TimeArriveEventArgs : EventArgs
    {
        public TimeArriveEventArgs(DateTime time)
        {
            Time = time;
        }

        public DateTime Time { get; }
    }
}
