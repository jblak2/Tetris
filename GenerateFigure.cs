using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class GenerateFigure
    {
        private static Random rand = new Random();

        public static Figure Generate()
        {
            int index = rand.Next() % 7;
            Indexes.currIndex = index;
            return getFigure(index);
        }

        static public Figure getFigure(int i)
        {
            switch (i)
            {
                case 0:
                    return new FirstFigure();
                case 1:
                    return new SecondFigure();
                case 2:
                    return new ThirdFigure();
                case 3:
                    return new FourthFigure();
                case 4:
                    return new FifthFigure();
                case 5:
                    return new SixthFigure();
                case 6:
                    return new SeventhFigure();
                default:
                    break;
            }
            throw new ArgumentException("Generated number must be between 0 and 6");
        }

    }
}
