using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Field
    {
        public static int[,] field = new int[CONSTANTS.FIELD_HEIGHT, CONSTANTS.FIELD_HEIGHT];

        public static void prepareField(){
            for (int i = 0; i < CONSTANTS.FIELD_HEIGHT; i++)
            {
                for (int j = 0; j < CONSTANTS.FIELD_WIDTH; j++)
                {
                    field[i, j] = 0;
                }
                return;
            }
        }
    }
}
