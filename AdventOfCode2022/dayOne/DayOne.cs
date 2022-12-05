using System;
using System.Data;
using System.Linq;

namespace AdventOfCode2022
{
    class DayOne
    {
        private static DataTable DataTable = new DataTable();
        
        public static void dayOneSolution()
        {
            Console.WriteLine("--- Solutions for Day One ---");
            
            string rawInput = System.IO.File.ReadAllText(@"H:\Personal\Programming\Csharp\AdventOfCode2022\AdventOfCode2022\dayOne\input.txt");

            var groupedValues = rawInput.Split("\r\n\r\n");
            
            int[] groupValueTotals = new int[groupedValues.Length];

            for (int i = 0; i < groupedValues.Length; i++)
            {
                groupedValues[i] = groupedValues[i].Replace("\r\n", "+");

                groupValueTotals[i] = (Int32.Parse(DataTable.Compute(groupedValues[i], null).ToString()));
            }

            Console.WriteLine($"Answer for part one: {partOne(groupValueTotals)}");
            
            Console.WriteLine($"Answer for part two: {partTwo(groupValueTotals)}");
        }

        private static int partOne(int[] groupValueTotals)
        {
            return groupValueTotals.Max();
        }
        
        private static int partTwo(int[] groupValueTotals)
        {
            Array.Sort(groupValueTotals);
            
            return groupValueTotals[^1] + groupValueTotals[^2] +groupValueTotals[^3];
        }
    }
}