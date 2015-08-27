using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class SeventhFigure:Figure
    {
        public SeventhFigure():base(3)
        {
            matrix[0, 0] = 7;
            matrix[0, 1] = 7;
            matrix[1, 1] = 7;
            matrix[1, 2] = 7;
        }
    }
}
