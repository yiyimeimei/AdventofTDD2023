namespace day_6_WaitForIt.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ZeroWays()
        {
            BoatPart1 boat1 = new BoatPart1(10, 2000);
            Assert.Equal(0, boat1.GetWinningWayNumber());
        }
        [Fact]
        public void MultiWays()
        {
            BoatPart1 boat2 = new BoatPart1(100, 2000);
            Assert.Equal(45, boat2.GetWinningWayNumber());
        }
        [Fact]
        public void OneWay()
        {
            BoatPart1 boat3 = new BoatPart1(6, 8);
            Assert.Equal(1, boat3.GetWinningWayNumber());
        }
        [Fact]
        public void RecordDistanceEqualsZero()
        {
            BoatPart1 boat4 = new BoatPart1(6, 0);
            Assert.Equal(5, boat4.GetWinningWayNumber());
        }
        [Fact]
        public void TimeEqualsZero()
        {
            BoatPart1 boat5 = new BoatPart1(0, 200);
            Assert.Equal(0, boat5.GetWinningWayNumber());
        }
    }
}