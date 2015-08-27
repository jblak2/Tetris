using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class FieldSaver
    {
        public static void saveField(Figure figure, int[,] field, int currX, int currY)
        {
            for (int i = 0; i < CONSTANTS.FIELD_HEIGHT; i++)
            {
                for (int j = 0; j < CONSTANTS.FIELD_WIDTH; j++)
                {

                    if (i < Indexes.currX + figure.size && i >= Indexes.currX && j < Indexes.currY + figure.size && j >= Indexes.currY)
                    {
                        if (figure.matrix[i - Indexes.currX, j - Indexes.currY] == 0 || field[i, j] == 0)
                        {
                            field[i, j] = figure.matrix[i - Indexes.currX, j - Indexes.currY] | field[i, j];
                        }
                        else
                        {
                            ImportantGameVariables.gameOver = true;
                        }
                    }

                }
            }
        }
    }
}
