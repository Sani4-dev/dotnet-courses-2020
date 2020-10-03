using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        private string _year;
        private string _month;
        private string _day;

        public User(string surname,
                    string name,
                    string patronymic,
                    string day,
                    string month,
                    string year,
                    int age)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            _day = day;
            _month = month;
            _year = year;
            Age = age;
        }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Year 
        { 
            set
            {
                _year = value;
            }
        }
        public string Month
        {
            set
            {
                _month = value;
            }
        }
        public string Day
        {
            set
            {
                _day = value;
            }
        }
        public string DateOfBirth 
        {
            get
            {
                return _day + "." + _month + "." + _year;
            }
        }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Риченко",
                                "Василий",
                                "Петрович",
                                "07",
                                "07",
                                "2007",
                                13);

            Console.WriteLine("Данные о человеке:");
            Console.WriteLine($"Фамилия: {user.Surname}");
            Console.WriteLine($"Имя: {user.Name}");
            Console.WriteLine($"Отчество: {user.Patronymic}");
            Console.WriteLine($"Дата рождения: {user.DateOfBirth}");
            Console.WriteLine($"Возраст: {user.Age}");
            
            Console.ReadKey();
        }
    }
}
