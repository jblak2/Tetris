using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class SixthFigure:Figure
    {
        public SixthFigure():base(3)
        {
            matrix[0, 1] = 6;
            matrix[0, 2] = 6;
            matrix[1, 1] = 6;
            matrix[1, 0] = 6;
        }
    }
}
