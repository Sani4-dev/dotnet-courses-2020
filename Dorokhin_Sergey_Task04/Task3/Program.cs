using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CultureRu = "ru";
            const string CultureEn = "en";
            const string CultureInvariant = "";

            void DisplayCultureInfo(CultureInfo cultureObject)
            {
                string cultureName = cultureObject.Name == "" ? "invariant" : cultureObject.Name;
                
                Console.WriteLine($"    Параметры культуры \"{cultureName}\":");
                Console.WriteLine($"        Формат отображения даты длинный: {cultureObject.DateTimeFormat.LongDatePattern};");
                Console.WriteLine($"        Формат отображения даты короткий: {cultureObject.DateTimeFormat.ShortDatePattern};");
                Console.WriteLine($"        Формат отображения времени длинный: {cultureObject.DateTimeFormat.LongTimePattern};");
                Console.WriteLine($"        Формат отображения времени короткий: {cultureObject.DateTimeFormat.ShortTimePattern}.");
                Console.WriteLine($"        Десятичный разделитель в числовых значениях: " +
                    $"{cultureObject.NumberFormat.NumberDecimalSeparator}");
                Console.WriteLine($"        Разделитель разрядов в целой части десятичной дроби в числовых значениях: " +
                    $"{cultureObject.NumberFormat.NumberGroupSeparator}");
                Console.WriteLine($"        Число десятичных разрядов, используемое в числовых значениях: " +
                    $"{cultureObject.NumberFormat.NumberDecimalDigits}");
            }

            void DisplayDifferent(string cultureOne, string cultureSecond)
            {
                var cultureOneObject = new CultureInfo(cultureOne);
                var cultureSecondObject = new CultureInfo(cultureSecond);
                string cultureNameOne = cultureOneObject.Name == "" ? "invariant" : cultureOneObject.Name;
                string cultureNameSecond = cultureSecondObject.Name == "" ? "invariant" : cultureSecondObject.Name;
                

                Console.WriteLine($"Сравнение культур \"{cultureNameOne}\" и \"{cultureNameSecond}\":");

                DisplayCultureInfo(cultureOneObject);
                DisplayCultureInfo(cultureSecondObject);

                Console.WriteLine();
                Console.WriteLine();
            }

            
            DisplayDifferent(CultureRu, CultureEn);

            DisplayDifferent(CultureEn, CultureInvariant);

            DisplayDifferent(CultureRu, CultureInvariant);

            Console.ReadKey();
        }
    }
}
