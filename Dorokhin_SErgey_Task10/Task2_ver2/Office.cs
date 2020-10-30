using System;
using System.Collections.Generic;

namespace Task2_ver2
{
    class Office
    {
        private SayHello greetAll;
        private SayBye byeAll;

        public Office(List<Person> persons)
        {
            foreach (var p in persons)
            {
                p.OnCame += OnCameHandler;
                p.OnLeave += OnLeaveHandler;
            }
        }

        private void OnCameHandler(Person p, DateTime time)
        {

            Console.WriteLine($"[На работу пришел {p.Name}]");

            greetAll?.Invoke(p.Name, time);

            greetAll += p.SayHello;
            byeAll += p.SayGoodBye;
        }

        private void OnLeaveHandler(Person p)
        {
            Console.WriteLine($"[{p.Name} ушел домой]");
                
            greetAll -= p.SayHello;
            byeAll -= p.SayGoodBye;

            byeAll?.Invoke(p.Name);
        }
    }
}
