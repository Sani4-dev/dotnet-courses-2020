using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle
    {
        int a;
        int b;

        public void GetLengthSides()
        {
            bool isRepeating = false;
            
            do
            {
                Console.WriteLine("Введите 2 стороны прямоугольника, разделенные пробелом:");

                int number;
                string textReciving = Console.ReadLine();
                string[] textParse = textReciving.Split(' ');


                for (int i = 0; i < 2; i++)
                {
                    if (int.TryParse(textParse[i], out number) == false)
                    {
                        Console.WriteLine("Вы ввели не число!");
                        isRepeating = true;
                        break;
                    }
                    else 
                    {
                        if(number < 1)
                        {
                            Console.WriteLine("Число должно быть больше 0!");
                            isRepeating = true;
                            break;
                        }
                        else
                        {
                            if(i == 0)
                                a = number;
                            else
                                b = number;
                            isRepeating = false;
                        }
                    }
                }
            } while (isRepeating);
        }
        public int DisplayArea()
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.GetLengthSides();
            Console.WriteLine($"Площадь прямоугольника с указанными длинами сторон равно: {rectangle.DisplayArea()}");

            Console.ReadKey();
        }
    }
}
