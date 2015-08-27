using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tetris
{

    class MainClass
    {
        static void Main(string[] args)
        {
            MyTimer GameTimer = new MyTimer();
            Game.StartGame(GameTimer);
            Game.Play();   
        }
    }
}
