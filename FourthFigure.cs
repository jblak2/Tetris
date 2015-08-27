using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class FourthFigure:Figure
    {
        public FourthFigure():base(3)
        {
            matrix[0, 2] = 4;
            matrix[1, 2] = 4;
            matrix[1, 1] = 4;
            matrix[1, 0] = 4;
        }
    }
}
