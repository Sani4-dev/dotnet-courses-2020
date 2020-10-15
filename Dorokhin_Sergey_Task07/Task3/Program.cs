using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static string GetDemoResult(IIndexable objectIIndexable)
        {
            if (objectIIndexable != null)
            {
                return String.Format($"Демонстрация работы индексаторов для обьекта класса {objectIIndexable.GetType()}:\n" +
                    $"Значение по индексу 3: {objectIIndexable[3]}\n" +
                    $"Значение по индексу 7: {objectIIndexable[7]}\n" +
                    $"Значение по индексу 10: {objectIIndexable[10]}");
            }
            else 
            {
                return String.Format("Значение аргумента метода равно \"NULL\"");
            }
        }
        
        static void Main(string[] args)
        {
            var progression = new ArithmeticalProgression(5, 3);
            var list = new List(new double[] { 7.0, 3.0, 2.0, 13.0, 5.0, 2.0, 35.0, 11.0, 3.0, 9.0, 47.0 });

            Console.WriteLine(GetDemoResult(progression));
            Console.WriteLine(GetDemoResult(list));

            Console.ReadKey();
        }
    }
}
