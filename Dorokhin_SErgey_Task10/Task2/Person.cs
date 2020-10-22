using Microsoft.Win32;
using System;

namespace Task2
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public delegate void MyEventHandlerArrive(Person person, TimeArriveEventArgs time);

        public delegate void MyEventHandlerQuit(Person person);
        
        public event MyEventHandlerArrive Arrive;

        public event MyEventHandlerQuit Quit;
        
        public string Name { get; }

        public virtual void OnArrive(TimeArriveEventArgs timeArrive)
        {
            Arrive?.Invoke(this, timeArrive);
        }

        public virtual void OnQuit()
        {
            Quit?.Invoke(this);
        }

        public void GreetingOfEmployee(Person person, TimeArriveEventArgs timeArrive)
        {
            if (timeArrive.Time.Hour < 12)
            {
                Console.WriteLine($"\"Доброе утро, {person.Name}!\" - сказал {Name}.");
            }
            else if (timeArrive.Time.Hour >= 12 && timeArrive.Time.Hour <= 17)
            {
                Console.WriteLine($"\"Добрый день, {person.Name}!\" - сказал {Name}.");
            }
            else
            {
                Console.WriteLine($"\"Добрый вечер, {person.Name}!\" - сказал {Name}.");
            }
        }

        public void GoodbyeWithEmployee(Person person)
        {
            Console.WriteLine($"\"До свидания, {person.Name}!\" - сказал {Name}.");
        }
    }
}
