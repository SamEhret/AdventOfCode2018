using System;
using AdventOfCode.Utilities;

namespace AdventOfCode
{
    class Program
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
            var input = "";
            Console.Write("What problem would you like to see? ");
            input = Console.ReadLine();
            puzzleRequest.InputId = string.IsNullOrEmpty(input) ? "1.1" : input;

            return puzzleRequest;
        }

        public static PuzzleRequest GetPuzzleType(PuzzleRequest puzzleRequest)
        {
            var inputInt = 1;

            Console.Write("Would you like to see the solution, problem, or input? ");
            inputInt = Convert.ToInt32(Console.ReadLine());
            if (Enum.IsDefined(typeof(PuzzleType), inputInt))
            {
                puzzleRequest.InputType = (PuzzleType)inputInt;
            }
            else
            {
                puzzleRequest.InputType = PuzzleType.Solution;
            }

            return puzzleRequest;
        }
    }
}