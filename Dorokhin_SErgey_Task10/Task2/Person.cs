using Microsoft.Win32;
using System;

namespace Task2
{
    public class Person
    {
        private MyEventHandlerArrive _arrive;
        private MyEventHandlerQuit _quit;

        public Person(string name)
        {
            Name = name;
        }

        public delegate void MyEventHandlerArrive(Person person, ArriveEventArgs time);

        public delegate void MyEventHandlerQuit(Person person);

        public event MyEventHandlerArrive Arrive
        {
            add
            {
                if (value != this.GreetingOfEmployee)
                {
                    _arrive += value;
                }
            }
            remove
            {
                _arrive -= value;
            }
        }
        
        public event MyEventHandlerQuit Quit
        {
            add
            {
                if (value != this.GoodbyeWithEmployee)
                {
                    _quit += value;
                }
            }
            remove
            {
                _quit -= value;
            }
        }
                
        public string Name { get; }

        public virtual void OnArrive(ArriveEventArgs e)
        {
            _arrive?.Invoke(this, e);
            foreach (var item in e.ListOfPersons)
            {
                item.Arrive += this.GreetingOfEmployee;
                item.Quit += this.GoodbyeWithEmployee;
            }
        }

        public virtual void OnQuit()
        {
            _quit?.Invoke(this);
        }

        public void GreetingOfEmployee(Person person, ArriveEventArgs e)
        {
            if (e.Time.Hour < 12)
            {
                Console.WriteLine($"\"Доброе утро, {person.Name}!\" - сказал {Name}.");
            }
            else if (e.Time.Hour >= 12 && e.Time.Hour <= 17)
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

            this.Quit -= person.GoodbyeWithEmployee;
        }
    }
}
