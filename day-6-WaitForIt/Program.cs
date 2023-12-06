using System;
using System.Numerics;
using System.Text.RegularExpressions;
using day_6_WaitForIt;
class BoatRace
{
    public BoatRace() { }
    static void Main(string[] args)
    {
        string path = "../../../input.txt";
        string[] input = File.ReadAllLines(path);
        string[] timeStr = new Regex("[\\s]+").Replace(input[0], " ").Split(' ');
        string[] distanceStr = new Regex("[\\s]+").Replace(input[1], " ").Split(' ');
        int res = 1;
        for (int i = 1; i < timeStr.Length; i++)
        {
            BoatPart1 boat = new BoatPart1(int.Parse(timeStr[i]), int.Parse(distanceStr[i]));
            res *= boat.GetWinningWayNumber();
        }
        Console.WriteLine(res);
    }
    //static void Main(string[] args)
    //{
    //    string path = "../../../input.txt";
    //    string[] input = File.ReadAllLines(path);
    //    BoatPart2 boat = new BoatPart2(BigInteger.Parse(Regex.Replace(input[0], @"[^0-9]+", "")), BigInteger.Parse(Regex.Replace(input[1], @"[^0-9]+", "")));
    //    Console.WriteLine(boat.GetWinningWayNumber());
    //}

}