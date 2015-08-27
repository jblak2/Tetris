using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class SecondFigure:Figure
    {
        public SecondFigure():base(3)
        {
            matrix[0, 1] = 2;
            matrix[1, 0] = 2;
            matrix[1, 1] = 2;
            matrix[1, 2] = 2;
        }
    }
}
