using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class LaneRemover
    {
        public static int WhichLaneMustBeRemoved(int[,] field, int currX, int currY)
        {
            bool isLaneReady;
            for (int i = CONSTANTS.FIELD_HEIGHT-1; i >= 0; i--)
            {
                isLaneReady = true;
                for (int j = 0; j < CONSTANTS.FIELD_WIDTH; j++)
                {
                    if (field[i, j] == 0)
                    {
                        isLaneReady = false;
                        break;
                    }
                }
                if (isLaneReady)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void RemoveLane(int[,] field, int currX, int currY)
        {
            var laneForRemoving = -1;
            while (WhichLaneMustBeRemoved(field, currX, currY) != -1)
            {
                laneForRemoving = WhichLaneMustBeRemoved(field, currX, currY);
                for (int i = laneForRemoving; i > 0; i--)
                {
                    for (int j = 0; j < CONSTANTS.FIELD_WIDTH; j++)
                    {
                        field[i, j] = field[i - 1, j];
                    }
                }
                for (int i = 0; i < CONSTANTS.FIELD_WIDTH; i++)
                {
                    field[0, i] = 0;
                }
                ScoreCounter.increaseScore();
            }
        }
    }
}
