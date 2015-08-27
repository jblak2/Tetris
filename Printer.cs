using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Printer
    {
        public static void Print(Figure myFigure, int[,] field, int currX, int currY)
        {
            while (true)
            {
                if (!ImportantGameVariables.amIPrinting)
                {
                    ImportantGameVariables.amIPrinting = true;
                    Console.Clear();
                    Console.WriteLine("Score:{0}", ScoreCounter.GetScore());
                    printField(myFigure, field, currX, currY);
                    ImportantGameVariables.amIPrinting = false;
                    break;
                }
            }
        }
        public static void printField(Figure myFigure, int[,] field, int currX, int currY)
        {


            Console.BackgroundColor = ConsoleColor.White;
            for (int k = 0; k < CONSTANTS.FIELD_WIDTH + 2; k++)
            {

                Console.Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            for (int i = 0; i < CONSTANTS.FIELD_HEIGHT; i++)
            {
                for (int j = 0; j < CONSTANTS.FIELD_WIDTH; j++)
                {
                    if (j == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                    }
                    if (i < currX + myFigure.size && i >= currX && j < currY + myFigure.size && j >= currY)
                    {
                        if (myFigure.matrix[i - currX, j - currY] == 0 || field[i, j] == 0)
                        {
                            Colors.ChangeColor(myFigure.matrix[i - currX, j - currY] | field[i, j]);
                            Console.Write("  ");
                        }
                        else
                        {
                            Colors.ChangeColor(field[i, j]);
                            Console.Write("  ");
                        }
                    }
                    else
                    {
                        Colors.ChangeColor(field[i, j]);
                        Console.Write("  ");
                    }
                    if (j == CONSTANTS.FIELD_WIDTH - 1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
            for (int k = 0; k < CONSTANTS.FIELD_WIDTH + 2; k++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }
    }
}
