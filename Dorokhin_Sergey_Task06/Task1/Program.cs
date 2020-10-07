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
                var employee = new Employee("Чуманов", "Игорь", "Васильевич", 5, 7, 1985, "junior developer", 1);

                Console.WriteLine("Данные о сотруднике:");

                Console.WriteLine($"Фамилия: {employee.Surname}");

                Console.WriteLine($"Имя: {employee.Name}");

                Console.WriteLine($"Отчество: {employee.Patronymic}");

                Console.WriteLine($"Возраст: {employee.Age}");

                Console.WriteLine($"Должность: {employee.Position}");

                Console.WriteLine($"Стаж: {employee.WorkExperience}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadKey();
        }
    }
}
