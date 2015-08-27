using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class ScoreCounter
    {
        private static int score = 0;
        public static void increaseScore()
        {
            score++;
        }
        public static int GetScore()
        {
            return score * 100;
        }
    }
}
