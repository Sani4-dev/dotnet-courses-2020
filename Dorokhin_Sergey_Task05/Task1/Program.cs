using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User("Риченко", "Василий", "Петрович", 7, 10, 1993);

                Console.WriteLine("Данные о человеке:");

                Console.WriteLine($"Фамилия: {user.Surname}");

                Console.WriteLine($"Имя: {user.Name}");

                Console.WriteLine($"Отчество: {user.Patronymic}");

                Console.WriteLine($"Дата рождения: {user.Day}.{user.Month}.{user.Year}");

                Console.WriteLine($"Возраст: {user.Age}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
