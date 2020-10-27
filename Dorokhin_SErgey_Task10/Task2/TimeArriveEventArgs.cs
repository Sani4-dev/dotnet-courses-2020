using System;

namespace Task2
{
    public class ArriveEventArgs : EventArgs
    {
        public ArriveEventArgs(DateTime time, Person[] persons)
        {
            Time = time;
            ListOfPersons = persons;
        }

        public DateTime Time { get; }

        public Person[] ListOfPersons { get; }
    }
}
