using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MainApp
{

    class Program
    {
        public static bool amIPrinting = false;
        public static Figure test = GenerateFigure.Generate();
        public static bool gameOver = false;

        static void Main(string[] args)
        {
            MyTimer GameTimer = new MyTimer();
            GameTimer.StartTimer();
            Field.prepareField();
           
            while (!gameOver)
            {
                while (Console.KeyAvailable == true && !gameOver)
                {
                    Moves.MakeAMove(test, Field.field, Indexes.currX, Indexes.currY);
                }
            }
            
        }
    }
}
