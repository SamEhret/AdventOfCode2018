using System;
using AdventOfCode.Models;
using AdventOfCode.Utilities;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main()
        {
            var puzzleRequest = new PuzzleRequest();
            var inputParser = new InputParser();
            var puzzlePrinter = new PuzzlePrinter();

            try
            {
                puzzleRequest = GetPuzzleId(puzzleRequest);
                puzzleRequest = GetPuzzleType(puzzleRequest);
                puzzlePrinter.PrintPuzzle(inputParser.ParseInput(puzzleRequest));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e}");
                throw;
            }
        }

        public static PuzzleRequest GetPuzzleId(PuzzleRequest puzzleRequest)
        {
            Console.Write("What problem would you like to see? ");
            var input = Console.ReadLine();
            puzzleRequest.InputId = string.IsNullOrEmpty(input) ? "1.1" : input;

            return puzzleRequest;
        }

        public static PuzzleRequest GetPuzzleType(PuzzleRequest puzzleRequest)
        {
            Console.Write("Would you like to see the solution, problem, or input? ");
            var input = Console.ReadLine().ToLower();
            if (Enum.IsDefined(typeof(PuzzleType), input))
            {
                puzzleRequest.InputType = (PuzzleType)Enum.Parse(typeof(PuzzleType), input);
            }
            else
            {
                puzzleRequest.InputType = PuzzleType.Solution;
            }

            return puzzleRequest;
        }
    }
}