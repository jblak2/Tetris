using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Game
    {
        public static void StartGame(MyTimer GameTimer)
        {
            GameTimer.StartTimer();
            Field.prepareField();
        }
        public static void Play(bool gameOver)
        {
            while (!gameOver)
            {
                while (Console.KeyAvailable == true && !gameOver)
                {
                    Moves.MakeAMove(Program.myFigure, Field.field, Indexes.currX, Indexes.currY);
                }
            }
        }
    }
}
