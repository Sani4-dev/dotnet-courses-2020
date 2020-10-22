using System.Collections.Generic;

namespace Task1
{
    public class RemovingEachSecondItemDemo
    {
        public static int[] GetInitingArray(int maxValuePeoples)
        {
            int[] peoples = new int[maxValuePeoples];

            for (int i = 0; i < peoples.Length; i++)
            {
                peoples[i] = i + 1;
            }

            return peoples;
        }

        public static void RemoveEachSecondItem(ICollection<int> listToRemoving)
        {
            var listHelper = new List<int>();
            int counter = 0;

            do
            {
                listHelper.Clear();
                
                foreach (var item in listToRemoving)
                {
                    counter++;
                    if (counter % 2 == 0)
                    {
                        listHelper.Add(item);
                    }
                }

                foreach (var item in listHelper)
                {
                    listToRemoving.Remove(item);
                }

            }
            while (listToRemoving.Count > 1);
        }

    }
}
