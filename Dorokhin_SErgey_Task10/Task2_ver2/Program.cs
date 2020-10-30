using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ver2
{
    public delegate void OnCame(Person p, DateTime time);
    public delegate void OnLeave(Person p);
    public delegate void SayHello(string otherPerson, DateTime time);
    public delegate void SayBye(string otherName);
    
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPersons = new List<Person>(new Person[] { new Person("Джон"),
                                                                new Person("Билл"),
                                                                new Person("Хьюго")});

            var office = new Office(listOfPersons,);

            int hourArrive = 8;
            int deltaArrive = 5;
            
            foreach (var item in listOfPersons)
            {
                item.GoToWork(new DateTime(2020, 10, 29, hourArrive, 30, 0));
                hourArrive += deltaArrive;
                Console.WriteLine();
            }

            foreach (var item in listOfPersons)
            {
                item.GoHome();
            }


            Console.ReadKey();
        }
    }
}
