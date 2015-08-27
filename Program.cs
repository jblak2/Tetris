using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tetris
{

    class Program
    {
        public static bool amIPrinting = false;
        public static Figure myFigure = GenerateFigure.Generate();
        public static bool gameOver = false;

        static void Main(string[] args)
        {
            MyTimer GameTimer = new MyTimer();
            Game.StartGame(GameTimer);
            Game.Play(gameOver);
            
        }
    }
}
