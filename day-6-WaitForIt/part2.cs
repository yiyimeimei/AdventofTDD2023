using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace day_6_WaitForIt
{
    public class BoatPart2
    {
        private BigInteger totalTime;
        private BigInteger recordDistance;
        public BoatPart2(BigInteger totalTime, BigInteger recordDistance)
        {
            this.totalTime = totalTime;
            this.recordDistance = recordDistance;
        }
        public BigInteger GetWinningWayNumber()
        {
            BigInteger wayNumber = 0;
            BigInteger holdingTime = totalTime / 2;
            BigInteger movingTime = totalTime - holdingTime;
            while (holdingTime * movingTime > recordDistance)
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
