using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dynamicArray = new DynamicArray<MyNumberClass>(new MyNumberClass[] { new MyNumberClass(), new MyNumberClass(),
                new MyNumberClass(), new MyNumberClass(), new MyNumberClass() });

            foreach (var item in dynamicArray)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
