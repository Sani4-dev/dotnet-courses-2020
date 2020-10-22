using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(RemovingEachSecondItemDemo.GetInitingArray(9));

            var linkedList = new LinkedList<int>(RemovingEachSecondItemDemo.GetInitingArray(9));

            Console.WriteLine("Тестирование метода \"RemoveEachSecondItem\" для \"List\":");
            RemovingEachSecondItemDemo.RemoveEachSecondItem(list);

            Console.WriteLine("Output array to \"list\":");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Тестирование метода \"RemoveEachSecondItem\" для \"LinkedList\":");
            RemovingEachSecondItemDemo.RemoveEachSecondItem(linkedList);

            Console.WriteLine("Output array to \"linkedList\":");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            
            
            Console.ReadKey();
        }
    }
}
