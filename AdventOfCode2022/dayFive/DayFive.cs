using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace AdventOfCode2022.dayFive;

public static class DayFive
{
    public static void dayFiveSolution()
        {
            Console.WriteLine("--- Solutions for Day Four ---");
            
            var rawInput = System.IO.File.ReadAllLines($"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}/dayFive/input.txt");

            // string[,] cargoStorage2 = new string[2,
            //     rawInput.FirstOrDefault(line => line.Replace(" ", string.Empty).IsDigitsOnly()).Length]; //row, column
            
            
             string[,] cargoStorage = 
            {
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "", "", "", "", "", ""},
                {"", "", "", "J", "", "", "", "B", "W"},
                {"", "", "", "T", "", "W", "F", "R", "Z"},
                {"", "", "Q", "M", "", "J", "R", "W", "H"},
                {"", "F", "L", "P", "", "R", "N", "Z", "G"},
                {"F", "M", "S", "Q", "", "M", "P", "S", "C"},
                {"L", "V", "R", "V", "W", "P", "C", "P", "J"},
                {"M", "Z", "V", "S", "S", "V", "Q", "H", "M"},
                {"W", "B", "H", "F", "L", "F", "J", "V", "B"},
            };

            foreach (var line in rawInput.Where(line => line.Contains("move")))
            {
                var amount = int.Parse(line.Split(" ")[1]);
                var fromColumn = int.Parse(line.Split(" ")[3]) - 1;
                var toColumn = int.Parse(line.Split(" ")[5]) - 1;

                for (int i = 0; i < amount; i++)
                {
                    var fromRow = 0;
                    var toRow = 0;
                    
                    string crate = "";

                    while (cargoStorage[fromRow, fromColumn] == "")
                        fromRow++;
                    
                    crate = cargoStorage[fromRow, fromColumn];
                    cargoStorage[fromRow, fromColumn] = "";

                    while (cargoStorage[toRow, toColumn] == "" && toRow < cargoStorage.GetLength(0) - 1)
                        toRow++;

                    if (cargoStorage[toRow, toColumn] == "") 
                        cargoStorage[toRow, toColumn] = crate;
                    else
                        cargoStorage[toRow - 1, toColumn] = crate;
                }
            }

            Console.WriteLine(cargoStorage.ToString());
            
            // Console.WriteLine($"Answer for part one: {partOne(rawInput)}");

            // Console.WriteLine($"Answer for part two: {partTwo(rawInput)}");
        }
        
        private static int PartOne(string[] rawInput)
        {

            var sum = 0;

            return sum;
        }
        
        private static int PartTwo(string[] rawInput)
        {

            var sum = 0;

            return sum;
        }
        
        static bool IsDigitsOnly(this string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
}