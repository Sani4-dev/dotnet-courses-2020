using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task3
{
    public class Pyramid : Figure
    {
        public Pyramid(string startingText)
            :base(startingText)
        {

        }
        protected void DisplayLine(int lengthRow, int currentQuantityRows = 1, int shifting = 0)
        {
            for (int a = 0; a < shifting; a++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < currentQuantityRows + lengthRow - 1; i++)
            {
                if (i < currentQuantityRows - lengthRow)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
        public override void DisplayFigure()
        {
            for(int i = 0; i < quantityRows; i++)
            {
                DisplayLine(i+1, quantityRows);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid pyramid = new Pyramid("Введите высоту пирамиды:");

            pyramid.GetQuantityRows();
            pyramid.DisplayFigure();

            Console.ReadKey();
        }
    }
}
