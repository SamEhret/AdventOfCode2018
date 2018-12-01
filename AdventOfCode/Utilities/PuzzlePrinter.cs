using System;
using AdventOfCode.Models;

namespace AdventOfCode.Utilities
{
    public class PuzzlePrinter
    {
        public void PrintPuzzle(PuzzleRequest puzzleRequest)
        {
            switch (puzzleRequest.InputType)
            {
                case PuzzleType.Solution:
                {
                    PrintSolution(puzzleRequest);
                    break;
                }
                case PuzzleType.Problem:
                {
                    PrintProblem(puzzleRequest);
                    break;
                }
                case PuzzleType.Input:
                {
                    PrintInput(puzzleRequest);
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid print type");
                    break;
                }
            }
        }
        
        public void PrintSolution(PuzzleRequest puzzleRequest)
        {
            try
            {
                var solution = Activator.CreateInstance(Type.GetType("AdventOfCode.Puzzles.Day" + puzzleRequest.ProblemId + ".Solution"));
                var methodCall = solution.GetType().GetMethod("Part" + puzzleRequest.PartId).Invoke(this, null);
                Console.Write($"The solution to {puzzleRequest.InputId} is: {methodCall}");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The requested solution file does not exist");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("The requested solution part does not exist");
            }
        }

        public void PrintProblem(PuzzleRequest puzzleRequest)
        {
            try
            {
                var solutionProblem = System.IO.File.ReadAllText($"../..\\Puzzles\\Day{puzzleRequest.ProblemId}\\ProblemPart{puzzleRequest.PartId}.txt");
                Console.Write($"The problem for {puzzleRequest.InputId} is: {solutionProblem}");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The requested problem file does not exist");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("The requested problem part does not exist");
            }
        }

        public void PrintInput(PuzzleRequest puzzleRequest)
        {
            try
            {
                var solutionInput = System.IO.File.ReadAllText($"../..\\Puzzles\\Day{puzzleRequest.ProblemId}\\Input.txt");
                Console.Write($"The input for {puzzleRequest.InputId} is: {solutionInput}");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The requested input file does not exist");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("The requested input part does not exist");
            }
        }
    }
}
