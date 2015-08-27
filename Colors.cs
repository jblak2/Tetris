using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Colors
    {
        public static void ChangeColor(int index)
        {
            switch (index)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }
    }
}
