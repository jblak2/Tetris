using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Moves
    {
        public static bool canBeMoved(string where, Figure figure, int[,] field, int currX, int currY)
        {
            if (Validator.IsInRange(figure, field, currX, currY))
            {
                for (int i = 0; i < figure.size; i++)
                {
                    for (int j = 0; j < figure.size; j++)
                    {
                        if (figure.matrix[i, j] != 0)
                        {
                            switch (where)
                            {
                                case "right":
                                    if ((j + currY + 1 >= CONSTANTS.FIELD_WIDTH) || (field[i + currX, j + currY + 1] != 0))
                                    {
                                        return false;
                                    }
                                    break;
                                case "left":
                                    if ((j + currY - 1 < 0) || (field[i + currX, j + currY - 1] != 0))
                                    {
                                        return false;
                                    }
                                    break;
                                case "down":
                                    if ((i + currX + 1 >= CONSTANTS.FIELD_HEIGHT) || (field[i + currX + 1, j + currY] != 0))
                                    {
                                        return false;
                                    }
                                    break;
                            }
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CanBeRotated(Figure figure, int[,] field, int currX, int currY)
        {
            var CheckingFigure = GenerateFigure.getFigure(Indexes.currIndex);
            for (int i = 0; i < CheckingFigure.size; i++)
            {
                for (int j = 0; j < CheckingFigure.size; j++)
                {
                    CheckingFigure.matrix[i, j] = figure.matrix[i, j];
                }
            }
            CheckingFigure.rotate();
            if (Validator.IsInRange(CheckingFigure, field, Indexes.currX, Indexes.currY))
            {
                for (int i = 0; i < CheckingFigure.size; i++)
                {
                    for (int j = 0; j < CheckingFigure.size; j++)
                    {
                        if (CheckingFigure.matrix[i, j] != 0 && field[i + Indexes.currX, j + Indexes.currY] != 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void MakeAMove(Figure figure, int[,] field, int currX, int currY)
        {
            if (ImportantGameVariables.gameOver)
            {
                return;
            }
            else
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (Moves.canBeMoved("right", figure, field, currX, currY))
                        {
                            Indexes.currY++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Moves.canBeMoved("left", figure, field, currX, currY))
                        {
                            currY--;
                            Indexes.currY--;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (CanBeRotated(figure, field, currX, currY))
                        {
                            figure.rotate();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Moves.canBeMoved("down", figure, field, currX, currY))
                        {
                            currX++;
                            Indexes.currX++;
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        while (Moves.canBeMoved("down", figure, field, currX, currY))
                        {
                            currX++;
                            Indexes.currX++;
                        }
                        break;
                }
                Printer.Print(figure, field, currX, currY);
            }
        }
    }
}
