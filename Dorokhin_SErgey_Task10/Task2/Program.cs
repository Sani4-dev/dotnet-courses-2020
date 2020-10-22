using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ostin = new Person("Ostin");
            var Jack = new Person("Jack");
            var Mihael = new Person("Mihael");

            Console.WriteLine($"[На работу пришел {Ostin.Name}]");
            Ostin.OnArrive(new TimeArriveEventArgs(new DateTime(2020, 10, 21, 8, 0, 0)));
            Console.WriteLine();

            Jack.Arrive += Ostin.GreetingOfEmployee;
            Mihael.Arrive += Ostin.GreetingOfEmployee;

            Console.WriteLine($"[На работу пришел {Jack.Name}]");
            Jack.OnArrive(new TimeArriveEventArgs(new DateTime(2020, 10, 21, 11, 30, 51)));
            Console.WriteLine();

            Mihael.Arrive += Jack.GreetingOfEmployee;

            Console.WriteLine($"[На работу пришел {Mihael.Name}]");
            Mihael.OnArrive(new TimeArriveEventArgs(new DateTime(2020, 10, 21, 18, 0, 5)));
            Console.WriteLine();

            Ostin.Quit += Jack.GoodbyeWithEmployee;
            Ostin.Quit += Mihael.GoodbyeWithEmployee;
            Jack.Quit += Ostin.GoodbyeWithEmployee;
            Jack.Quit += Mihael.GoodbyeWithEmployee;
            Mihael.Quit += Ostin.GoodbyeWithEmployee;
            Mihael.Quit += Jack.GoodbyeWithEmployee;

            Console.WriteLine($"[{Ostin.Name} ушел домой]");
            Ostin.OnQuit();
            Console.WriteLine();

            Jack.Quit -= Ostin.GoodbyeWithEmployee;
            Mihael.Quit -= Ostin.GoodbyeWithEmployee;

            Console.WriteLine($"[{Jack.Name} ушел домой]");
            Jack.OnQuit();
            Console.WriteLine();

            Mihael.Quit -= Jack.GoodbyeWithEmployee;

            Console.WriteLine($"[{Mihael.Name} ушел домой]");
            Mihael.OnQuit();
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
