using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
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
            Day = day;
            Month = month;
            Year = year;
            Age = age;
        }

        public string Surname { get; set; }
        
        public string Name { get; set; }
        
        public string Patronymic { get; set; }
        
        public string Year { get; set; }

        public string Month { get; set; }

        public string Day { get; set; }

        public string DateOfBirth => Day + "." + Month + "." + Year;
 
        public int Age { get; set; }
    }


    public class Employee : User
    {
        private int _workExperience;
        
        public Employee(string surname,
                        string name,
                        string patronymic,
                        string day,
                        string month,
                        string year,
                        string position,
                        int workExperience,
                        int age)
            : base(surname,
                   name,
                   patronymic,
                   day,
                   month,
                   year,
                   age)
        {
            Position = position;
            try
            {
                if (workExperience < 0)
                {
                    throw new Exception("Значение стажа не может " + 
                        "быть отрицательным!");
                }
                else
                {
                    _workExperience = workExperience;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string Position { get; set; }

        public int WorkExperience
        {
            get
            {
                return _workExperience;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("Значение стажа не может " + 
                            "быть отрицательным!");
                    }
                    else
                    {
                        _workExperience = value;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Чуманов", 
                                        "Игорь", 
                                        "Васильевич", 
                                        "05", 
                                        "05", 
                                        "2000", 
                                        "junior developer", 
                                        0, 
                                        20);

            Console.WriteLine("Данные о сотруднике:");
            Console.WriteLine($"Фамилия: {employee.Surname}");
            Console.WriteLine($"Имя: {employee.Name}");
            Console.WriteLine($"Отчество: {employee.Patronymic}");
            Console.WriteLine($"Дата рождения: {employee.DateOfBirth}");
            Console.WriteLine($"Возраст: {employee.Age}");
            Console.WriteLine($"Должность: {employee.Position}");
            Console.WriteLine($"Стаж: {employee.WorkExperience}");
            
            Console.ReadKey();
        }
    }
}
