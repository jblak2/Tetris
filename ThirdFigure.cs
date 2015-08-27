using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class ThirdFigure:Figure
    {
        public ThirdFigure():base(3)
        {
            matrix[0, 0] = 3;
            matrix[1, 0] = 3;
            matrix[1, 1] = 3;
            matrix[1, 2] = 3;
        }
    }
}
