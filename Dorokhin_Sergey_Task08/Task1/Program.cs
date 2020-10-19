using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyObject
    {
        public MyObject()
        {
        }

        public int Number { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка конструктора без параметров:");

            var dynamicArray = new DynamicArray<object>();

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка конструктора с параметром, задающим размер массива:");
            Console.WriteLine("Создается пустой массив размером 5:");

            dynamicArray = new DynamicArray<object>(5);

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка конструктора с параметром, задающим массив содержащий 3 элемента \"Object\":");

            dynamicArray = new DynamicArray<object>(new object[] { new object(), new object(), new object() });

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка метода \"Add\". Добавление элемента к массиву с \"Length\" = 3 и \"Capacity\" = 3:");

            dynamicArray.Add(new object());
            
            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка метода \"Add\". Добавление элемента к массиву с \"Length\" = 4 и \"Capacity\" = 6:");

            dynamicArray.Add(new object());

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка метода \"AddRange\". Добавление массива с 2-мя элементами" +
                " к массиву с \"Length\" = 0 и \"Capacity\" = 3:");

            dynamicArray = new DynamicArray<object>(3);

            dynamicArray.AddRange(new object[] { new object(), new object() });

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка метода \"AddRange\". Добавление массива с 3-мя элементами" +
                " к массиву с \"Length\" = 2 и \"Capacity\" = 3:");

            dynamicArray.AddRange(new object[] { new object(), new object(), new object() });

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка метода \"Remove\". Удаление элемента если массив пуст." +
                " Исходный массив с \"Length\" = 0 и \"Capacity\" = 3:");

            dynamicArray = new DynamicArray<object>(3);

            Console.WriteLine($"Результат выполнения метода: {dynamicArray.Remove(0)}");

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка метода \"Remove\". Удаление элемента с индексом 3." +
                " Исходный массив с \"Length\" = 3 и \"Capacity\" = 6:");

            dynamicArray = new DynamicArray<object>(6);

            dynamicArray.Add(new object());
            dynamicArray.Add(new object());
            dynamicArray.Add(new object());

            Console.WriteLine($"Результат выполнения метода: {dynamicArray.Remove(3)}");

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка метода \"Remove\". Удаление элемента с индексом 2." +
                " Исходный массив с \"Length\" = 3 и \"Capacity\" = 6:");

            Console.WriteLine($"Результат выполнения метода: {dynamicArray.Remove(2)}");

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка метода \"Remove\". Удаление элемента с индексом 1." +
                " Исходный массив с \"Length\" = 3 и \"Capacity\" = 6:");

            dynamicArray = new DynamicArray<object>(6);

            dynamicArray.Add(new object());
            dynamicArray.Add(new object());
            dynamicArray.Add(new object());

            Console.WriteLine($"Результат выполнения метода: {dynamicArray.Remove(1)}");

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            /*Console.WriteLine("Проверка метода \"Insert\". Вставка элемента по индексу 5." +
                " Исходный массив с \"Length\" = 5 и \"Capacity\" = 5:");

            dynamicArray = new DynamicArray<object>(new object[] { new object(), new object(), new object(), new object(), new object() });

            dynamicArray.Insert(5, new object());

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }*/

            Console.WriteLine("Проверка метода \"Insert\". Вставка элемента по индексу 4." +
                " Исходный массив с \"Length\" = 5 и \"Capacity\" = 5:");

            dynamicArray = new DynamicArray<object>(new object[] { new object(), new object(), new object(), new object(), new object() });

            dynamicArray.Insert(4, new object());

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            Console.WriteLine("Проверка метода \"Insert\". Вставка элемента по индексу 0." +
                " Исходный массив с \"Length\" = 6 и \"Capacity\" = 6:");

            dynamicArray.Insert(0, new object());

            Console.WriteLine($"Length: {dynamicArray.Length}");
            Console.WriteLine($"Capacity: {dynamicArray.Capacity}");
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray[i] ?? "NULL");
            }

            
            Console.ReadKey();
        }
    }
}
