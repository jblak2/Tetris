using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class FifthFigure:Figure
    {
        public FifthFigure():base(4)
        {
            matrix[0, 1] = 5;
            matrix[1, 1] = 5;
            matrix[2, 1] = 5;
            matrix[3, 1] = 5;
        }
    }
}
