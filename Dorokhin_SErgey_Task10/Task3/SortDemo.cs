using System;
using System.Threading;

namespace Task3
{
    public class SortDemo
    {
        protected delegate bool ComparatorTwoString(string srt1, string str2);

        public static event EventHandler SortDone;

        public static void Sort(object args)
        {
            if (args == null)
            {
                throw new ArgumentNullException();
            }

            if (args.GetType() != typeof(string[]))
            {
                throw new Exception("Параметр \"obj\" должен быть типа \"string[]\"");
            }
            
            ComparatorTwoString comparatorTwoString = Comparator.StringOneGreaterThenStringTwo;

            string[] arrayOfStrings = (string[])args;

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                for (int j = i; j < arrayOfStrings.Length; j++)
                {
                    if (comparatorTwoString.Invoke(arrayOfStrings[i], arrayOfStrings[j]))
                    {
                        string temp = arrayOfStrings[j];
                        arrayOfStrings[j] = arrayOfStrings[i];
                        arrayOfStrings[i] = temp;
                    }
                }
            }

            SortDone?.Invoke(arrayOfStrings, EventArgs.Empty);
        }

        public static void SortInNewThread(string[] args)
        {
            var threadToSorting = new Thread(new ParameterizedThreadStart(Sort));

            threadToSorting.Start(args);
        }
    }
}
