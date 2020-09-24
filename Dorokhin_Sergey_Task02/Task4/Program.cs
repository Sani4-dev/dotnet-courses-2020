using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;
using Task2;

namespace Task4
{
    class Tree : Pyramid
    {
        public Tree(string startingText)
            :base(startingText)
        {

        }
        void DisplayPyramid(int heightPyramid, int shifting = 0)
        {
            for (int i = 0; i < heightPyramid; i++)
            {
                DisplayLine(i + 1, heightPyramid, shifting);
            }
        }
        public override void DisplayFigure()
        {
            DisplayLine(1, 1, (quantityRows - 1) + 1);
            DisplayLine(1, 1 , (quantityRows - 1) + 1);
            DisplayLine(3, 1, quantityRows - 1);
            for (int i = 0; i < quantityRows - 1; i++)
            {
                DisplayPyramid(i + 3, (quantityRows - 1) - (i + 1));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree("Введите количество треугольников:");

            tree.GetQuantityRows();
            tree.DisplayFigure();

            Console.ReadKey();
        }
    }
}
