using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Figure
    {
        protected int quantityRows;
        string startingText;

        public Figure(string startingText)
        {
            this.startingText = startingText;
        }
        public void GetQuantityRows()
        {
            bool isRepeating = false;
            do
            {
                Console.WriteLine(startingText);
                if (int.TryParse(Console.ReadLine(), out quantityRows) == false)
                {
                    Console.WriteLine("Вы ввели не число!");
                    isRepeating = true;
                }
                else
                {
                    if (quantityRows < 1)
                    {
                        Console.WriteLine("Число должно быть больше 0!");
                        isRepeating = true;
                    }
                    else
                    {
                        isRepeating = false;
                    }
                }
            } while (isRepeating);
        }
        public abstract void DisplayFigure();
    }
    public class Triangle : Figure
    {
        public Triangle(string startingText)
            : base(startingText)
        {

        }
        void DisplayLine(int lengthRow)
        {
            for (int i = 0; i < lengthRow; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        public override void DisplayFigure()
        {
            for (int i = 0; i < quantityRows; i++)
            {
                DisplayLine(i + 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle("Введите высоту треугольника:");

            triangle.GetQuantityRows();
            triangle.DisplayFigure();
            
            Console.ReadKey();
        }
    }
}
