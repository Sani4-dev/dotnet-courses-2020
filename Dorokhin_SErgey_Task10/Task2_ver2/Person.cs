using System;

namespace Task2_ver2
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public event OnCame OnCame;
        public event OnLeave OnLeave;

        public void GoToWork(DateTime timeArrive)
        {
            OnCame?.Invoke(this, timeArrive);
            Console.WriteLine();
        }

        public void GoHome()
        {
            OnLeave?.Invoke(this);
            Console.WriteLine();
        }

        public void SayHello(string otherPerson, DateTime time)
        {
            if (time.Hour < 12)
            {
                Console.WriteLine($"\"Доброе утро, {otherPerson}\"! - сказал {this.Name}");
            }
            else if (time.Hour >= 12 && time.Hour <= 17)
            {
                Console.WriteLine($"\"Добрый день, {otherPerson}\"! - сказал {this.Name}");
            }
            else
            {
                Console.WriteLine($"\"Добрый вечер, {otherPerson}\"! - сказал {this.Name}");
            }
        }

        public void SayGoodBye(string otherName)
        {
            Console.WriteLine($"\"До свидания, {otherName}\"! - сказал {this.Name}");
        }
    }
}
