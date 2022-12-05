using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AdventOfCode2022
{
    class DayThree
    {

        public static void dayThreeSolution()
        {
            Console.WriteLine("--- Solutions for Day Three ---");
            
            Console.WriteLine($"Answer for part one: {partOne()}");
            
            Console.WriteLine($"Answer for part two: {partTwo()}");
        }

        private static int partOne()
        {
            var rawInput = System.IO.File.ReadAllLines(@"H:\Personal\Programming\Csharp\AdventOfCode2022\AdventOfCode2022\dayThree\input.txt");

            var sum = 0;
            
            foreach (var line in rawInput)
            {
                var compartmentOne = line.Substring(0, line.Length / 2);
                var compartmentTwo = line.Substring(line.Length / 2).ToArray();

                foreach (var item in compartmentOne.Where(item => compartmentTwo.Contains(item)))
                {
                    sum += item > 95 ? item - 96 : item - 38;
                    break;
                }
            }

            return sum;
        }
        
        private static int partTwo()
        {
            var rawInput = System.IO.File.ReadAllLines(@"H:\Personal\Programming\Csharp\AdventOfCode2022\AdventOfCode2022\dayThree\input.txt");

            var sum = 0;
            
            for (int i = 0; i < rawInput.Length; i += 3)
            {
                var lineOne = rawInput[i];
                var lineTwo = rawInput[i + 1];
                var lineThree = rawInput[i + 2];

                foreach (var item in lineOne.Where(item => lineTwo.Contains(item) && lineThree.Contains(item)))
                {
                    sum += item > 95 ? item - 96 : item - 38;
                    break;
                }
            }
            
            return sum;
        }
    }
}