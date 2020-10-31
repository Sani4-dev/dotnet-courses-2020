using System;
using System.Threading;

namespace Task3
{
    public class SortDemo
    {
        protected delegate bool ComparatorTwoString(string srt1, string str2);

        public event EventHandler<SortEventArgs> SortDone;

        public SortDemo(string[] args)
        {
            StringsArray = args;
        }

        public string[] StringsArray { get; }

        public void Sort()
        {
            if (StringsArray == null)
            {
                throw new ArgumentNullException();
            }

            ComparatorTwoString comparatorTwoString = Comparator.StringOneGreaterThenStringTwo;

            for (int i = 0; i < StringsArray.Length; i++)
            {
                Console.WriteLine($"Прогресс сортировки {i} из {StringsArray.Length}");
                Thread.Sleep(1000);
                for (int j = i; j < StringsArray.Length; j++)
                {
                    if (comparatorTwoString.Invoke(StringsArray[i], StringsArray[j]))
                    {
                        string temp = StringsArray[j];
                        StringsArray[j] = StringsArray[i];
                        StringsArray[i] = temp;
                    }
                }
            }

            SortDone?.Invoke(this, new SortEventArgs(StringsArray));
        }

        public void SortInNewThread()
        {
            var threadToSorting = new Thread(new ThreadStart(Sort));

            threadToSorting.Start();
        }
    }
}
