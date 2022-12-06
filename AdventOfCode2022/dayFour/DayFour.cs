using System;
using System.Collections;

namespace AdventOfCode2022.dayFour
{
    public class DayFour
    {
        public static void dayFourSolution()
        {
            Console.WriteLine("--- Solutions for Day Four ---");
            
            var rawInput = System.IO.File.ReadAllLines(@"H:\Personal\Programming\Csharp\AdventOfCode2022\AdventOfCode2022\dayFour\input.txt");

            Console.WriteLine($"Answer for part one: {partOne(rawInput)}");

            Console.WriteLine($"Answer for part two: {partTwo(rawInput)}");
        }
        
        private static int partOne(string[] rawInput)
        {

            var sum = 0;
            
            foreach (var line in rawInput)
            {
                var currentScore = 0;
                
                var firstSection = line.Split(",")[0];
                var secondSection = line.Split(",")[1];

                currentScore += (Int32.Parse(firstSection.Split("-")[0]) <= Int32.Parse(secondSection.Split("-")[0])) && (Int32.Parse(firstSection.Split("-")[1]) >= Int32.Parse(secondSection.Split("-")[1])) ? 1 : 0;
                
                if (currentScore != 1)
                    currentScore += (Int32.Parse(secondSection.Split("-")[0]) <= Int32.Parse(firstSection.Split("-")[0])) && (Int32.Parse(secondSection.Split("-")[1]) >= Int32.Parse(firstSection.Split("-")[1])) ? 1 : 0;

                sum += currentScore;
            }

            return sum;
        }
        
        private static int partTwo(string[] rawInput)
        {

            var sum = 0;
            
            foreach (var line in rawInput)
            {
                var currentScore = 0;
                
                var firstSection = line.Split(",")[0];
                var secondSection = line.Split(",")[1];

                var firstSectionValues = new ArrayList();

                for (int i = int.Parse(firstSection.Split("-")[0]); i < int.Parse(firstSection.Split("-")[1]) + 1; i++)
                {
                    firstSectionValues.Add(i);
                }

                var overlaps = (firstSectionValues.Contains(int.Parse(secondSection.Split("-")[0])) ||
                               firstSectionValues.Contains(int.Parse(secondSection.Split("-")[1]))) || (int.Parse(firstSection.Split("-")[0]) > int.Parse(secondSection.Split("-")[0]) && int.Parse(firstSection.Split("-")[1]) < int.Parse(secondSection.Split("-")[1]));

                sum += overlaps ? 1 : 0;
            }
            
            return sum;
        }
    }
}