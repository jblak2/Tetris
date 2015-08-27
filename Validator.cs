using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Validator
    {
        public static bool IsInRange(Figure figure, int[,] field, int currX, int currY)
        {
            if (currX >= CONSTANTS.FIELD_HEIGHT - GetFigureInfo.getLastRowOfFigure(figure))
            {
                return false;
            }
            if (currY < -GetFigureInfo.getFirsColonOfFigure(figure))
            {
                return false;
            }
            if (currY + GetFigureInfo.getLastColonOfFigure(figure) + 1 > CONSTANTS.FIELD_WIDTH)
            {
                return false;
            }
   
            return true;
        }
    }
}
