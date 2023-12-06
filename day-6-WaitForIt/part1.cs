using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_WaitForIt
{
    public class BoatPart1
    {
        private int totalTime;
        private int recordDistance;
        public BoatPart1(int totalTime, int recordDistance)
        {
            this.totalTime = totalTime;
            this.recordDistance = recordDistance;
        }
        public int GetWinningWayNumber()
        {
            int wayNumber = 0;
            int holdingTime = totalTime / 2;
            int movingTime = totalTime - holdingTime;
            while(holdingTime * movingTime > recordDistance)
            {
                ++wayNumber;
                --holdingTime;
                ++movingTime;
            }
            wayNumber *= 2;
            if (wayNumber > 0 && totalTime % 2 == 0)
            {
                --wayNumber;
            }
            return wayNumber;
        }
    }
}
