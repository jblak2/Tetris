using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tetris
{
    class MyTimer
    {
        public Timer myTimer;
        public MyTimer()
        {
            myTimer = new Timer();
        }
        public void StartTimer(){
            myTimer.Elapsed += new ElapsedEventHandler(MoveToNextRow);
            myTimer.Interval = 1000;
            myTimer.Start();
        }
        public static void MoveToNextRow(object source, ElapsedEventArgs e)
        {
            if (!Moves.canBeMoved("down", Program.myFigure, Field.field, Indexes.currX, Indexes.currY))
            {
                if (Indexes.currX == 0)
                {
                    Console.WriteLine("GameOver");
                    Program.gameOver = true;
                    return;
                }
                else
                {
                    FieldSaver.saveField(Program.myFigure, Field.field, Indexes.currX, Indexes.currY);
                    LaneRemover.RemoveLane(Field.field, Indexes.currX, Indexes.currY);
                    Program.myFigure = GenerateFigure.Generate();
                    Indexes.currX = 0;
                    Indexes.currY = 0;
                    if (!Validator.IsInRange(Program.myFigure, Field.field, Indexes.currX, Indexes.currY)) 
                    {
                        Program.gameOver = true;
                        return;
                    }
                }
            }
            else
            {
                Indexes.currX++;
            }
            Printer.Print(Program.myFigure, Field.field, Indexes.currX, Indexes.currY);
        }
    }
}
