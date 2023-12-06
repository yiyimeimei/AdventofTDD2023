using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_WaitForIt.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void ZeroWays()
        {
            BoatPart2 boat1 = new BoatPart2(1000000, 9999999999999999);
            Assert.Equal(0, boat1.GetWinningWayNumber());
        }
        [Fact]
        public void MultiWays()
        {
            BoatPart2 boat2 = new BoatPart2(99999999, 2147483649);
            Assert.Equal(99999956, boat2.GetWinningWayNumber());
        }
        [Fact]
        public void OneWay()
        {
            BoatPart2 boat3 = new BoatPart2(6, 8);
            Assert.Equal(1, boat3.GetWinningWayNumber());
        }
        [Fact]
        public void RecordDistanceEqualsZero()
        {
            BoatPart2 boat4 = new BoatPart2(2147483650, 0);
            Assert.Equal(2147483649, boat4.GetWinningWayNumber());
        }
        [Fact]
        public void TimeEqualsZero()
        {
            BoatPart2 boat5 = new BoatPart2(0, 2147483649);
            Assert.Equal(0, boat5.GetWinningWayNumber());
        }
    }
}
