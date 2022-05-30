using System;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Day_01 day_01 = new Day_01(); 
            Console.WriteLine("Day 01 Part 1: " + day_01.Part1());
            Console.WriteLine("Day 01 Part 2: " + day_01.Part2());

            Day_02 day_02 = new Day_02();
            Console.WriteLine("Day 02 Part 1: " + day_02.Part1());
            Console.WriteLine("Day 02 Part 2: " + day_02.Part2());

            Day_03 day_03 = new Day_03();
            Console.WriteLine("Day 03 Part 1: " + day_03.Part1());
            Console.WriteLine("Day 03 Part 2: " + day_03.Part2());

            Day_04 day_04 = new Day_04();
            Console.WriteLine("Day 04 Part 1: " + day_04.Part1());
            Console.WriteLine("Day 04 Part 2: " + day_04.Part2());

            Console.ReadLine();
        }
    }
}
