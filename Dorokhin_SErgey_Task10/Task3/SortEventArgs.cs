using System;

namespace Task3
{
    public class SortEventArgs : EventArgs
    {
        public SortEventArgs(string[] args)
        {
            StringsArray = args;
        }

        public string[] StringsArray { get; }
    }
}
