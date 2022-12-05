using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AdventOfCode2022
{
    class DayTwo
    {
        private static DataTable DataTable = new DataTable();
        
        static Dictionary<string, int> MyMoves = new Dictionary<string, int>() { {"X", 1}, {"Y", 2}, {"Z", 3} };
        static Dictionary<string, int> OpponentsMoves = new Dictionary<string, int>() { {"A", 1}, {"B", 2}, {"C", 3} };
        static Dictionary<string, int> OutcomePoints = new Dictionary<string, int>() { {"X", 0}, {"Y", 3}, {"Z", 6} };

        public static void dayTwoSolution()
        {
            Console.WriteLine("--- Solutions for Day Two ---");

            var rawInput = System.IO.File.ReadAllLines(@"H:\Personal\Programming\Csharp\AdventOfCode2022\AdventOfCode2022\dayTwo\input.txt");

            Console.WriteLine($"Answer for part one: {partOne(rawInput)}");
            
            Console.WriteLine($"Answer for part two: {partTwo(rawInput)}");
        }

        private static int partOne(string[] rawInput)
        {
            int score = 0;
            
            foreach (var line in rawInput)
            {
                var currentRoundScore = 0;
                var opponentMove = line[0].ToString();
                var myMove = line[2].ToString();
                
                currentRoundScore += MyMoves[myMove.ToString()];

                if (OpponentsMoves[opponentMove] == MyMoves[myMove])
                    currentRoundScore += 3; //tie
                
                else if((opponentMove == "A" && myMove == "Y") || (opponentMove == "B" && myMove == "Z") || ( opponentMove == "C" && myMove == "X" ))
                    currentRoundScore += 6; //win

                score += currentRoundScore;
            }

            return score;
        }
        
        private static int partTwo(string[] rawInput)
        {
            int score = 0;
            
            foreach (var line in rawInput)
            {
                var currentRoundScore = 0;
                var opponentMove = line[0].ToString();
                var desiredOutcome = line[2].ToString();
                
                currentRoundScore += OutcomePoints[desiredOutcome];

                if (desiredOutcome == "Y") //tie
                    currentRoundScore += OpponentsMoves[opponentMove]; //tie, add opponents equivalent points.
                
                else if (desiredOutcome == "Z") //win
                    currentRoundScore += (OpponentsMoves[opponentMove] + 1) > 3 ? 1 : OpponentsMoves[opponentMove] + 1;
                
                else if (desiredOutcome == "X") //lose
                    currentRoundScore += (OpponentsMoves[opponentMove] - 1) <= 0 ? 3 : OpponentsMoves[opponentMove] - 1;


                Console.WriteLine($"Line: {line} | Opponent Move: {opponentMove} | Desired Outcome: {desiredOutcome} | Points gained: {currentRoundScore}");
                
                score += currentRoundScore;
            }

            return score;
        }
    }
}