using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class GetFigureInfo
    {
        public static int getFirstRowOfFigure(Figure figure)
        {
            for (int i = 0; i < figure.size; i++)
            {
                for (int j = 0; j < figure.size; j++)
                {
                    if (figure.matrix[i, j] != 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static int getLastRowOfFigure(Figure figure)
        {
            for (int i = figure.size - 1; i >= 0; i--)
            {
                for (int j = 0; j < figure.size; j++)
                {
                    if (figure.matrix[i, j] != 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static int getFirsColonOfFigure(Figure figure)
        {
            for (int i = 0; i < figure.size; i++)
            {
                for (int j = 0; j < figure.size; j++)
                {
                    if (figure.matrix[j, i] != 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static int getLastColonOfFigure(Figure figure)
        {
            for (int i = figure.size - 1; i >= 0; i--)
            {
                for (int j = 0; j < figure.size; j++)
                {
                    if (figure.matrix[j, i] != 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
       
    }
}
