using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //using operator "+"
            var myStringFirst = new MyString("Это первая строка и она большая, больше, чем все остальные");
            var myStringSecond = new MyString("Это вторая строка");
            
            Console.WriteLine($"Содержимое первого обьекта класса \"myString\": {myStringFirst}");

            Console.WriteLine($"Содержимое второго обьекта класса \"myString\": {myStringSecond}");

            Console.WriteLine($"Результат сложения двух обьектов типа \"MyString\": {myStringFirst + myStringSecond}");


            //using operator "-"
            myStringFirst.SetString("Это строка из которой необходимо удалить подстроку");
            myStringSecond.SetString("удалить");
            
            Console.WriteLine($"Содержимое первого обьекта класса \"MyString\": {myStringFirst}");

            Console.WriteLine($"Содержимое второго обьекта класса \"MyString\": {myStringSecond}");

            Console.WriteLine($"Результат удаления подстроки: {myStringFirst - myStringSecond}");

            
            //using operator "=="
            var myStringToCompare1 = new MyString("Это строка близнец");
            var myStringToCompare2 = new MyString("Это строка близнец");

            if(myStringToCompare2==null) myStringToCompare2 = new MyString("Это строка близнец");
            Console.WriteLine($"Содержимое первого обьекта класса \"MyString\": {myStringToCompare1}");

            Console.WriteLine($"Содержимое второго обьекта класса \"MyString\": {myStringToCompare2}");

            Console.WriteLine($"Результат сравнения двух обьектов типа \"MyString\": {myStringToCompare1 == myStringToCompare2}");


            //reusing operator "=="
            myStringToCompare2.SetString("Эта строка не является близнецом");

            Console.WriteLine($"Значение первого обьекта класса \"MyString\": {myStringToCompare1}");

            Console.WriteLine($"Значение второго обьекта класса \"MyString\": {myStringToCompare2}");

            Console.WriteLine($"Результат сравнения двух обьектов типа \"MyString\": {myStringToCompare1 == myStringToCompare2}");


            //using method "ToString()"
            myStringFirst.SetString("Метод \"ToString\" должен вывести данную строку.");

            Console.WriteLine($"Результат вызова метода \"ToString\" для обьекта класса \"myString\": " + 
                $"{myStringFirst}");


            //using array mode
            myStringFirst.SetString("Эта строка используется для проверки возможности обращения к полям данного обьекта по индексу");

            Console.WriteLine($"Содержимое обьекта класса \"MyString\": {myStringFirst}");

            Console.WriteLine($"Значение 10-го символа строки: {myStringFirst[9]}");
            

            Console.ReadKey();
        }
    }
}
