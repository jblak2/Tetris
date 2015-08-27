﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Printer
    {
        public static void Print(Figure test, int[,] field, int currX, int currY)
        {
            while (true)
            {
                if (!Program.amIPrinting)
                {
                    Program.amIPrinting = true;
                    Console.Clear();
                    Console.WriteLine("Score:{0}", ScoreCounter.GetScore());
                    printField(test, field, currX, currY);
                    Program.amIPrinting = false;
                    break;
                }
            }
        }
        public static void printField(Figure test, int[,] field, int currX, int currY)
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
                    if (i < currX + test.size && i >= currX && j < currY + test.size && j >= currY)
                    {
                        if (test.matrix[i - currX, j - currY] == 0 || field[i, j] == 0)
                        {
                            Colors.ChangeColor(test.matrix[i - currX, j - currY] | field[i, j]);
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