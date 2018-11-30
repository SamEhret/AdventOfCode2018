using System;
using AdventOfCode.Utilities;
using Microsoft.CSharp.RuntimeBinder;

namespace AdventOfCode
{
    public class PuzzlePrinter
    {

        public void PrintPuzzle(PuzzleRequest puzzleRequest)
        {
            switch (puzzleRequest.InputType)
            {
                case PuzzleType.solution:
                {
                    PrintSolution(puzzleRequest);
                    break;
                }
                case PuzzleType.problem:
                {
                    PrintProblem(puzzleRequest);
                    break;
                }
                case PuzzleType.input:
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
                var solution = Activator.CreateInstance(Type.GetType("AdventOfCode.Solutions." + puzzleRequest.ProblemId));
                var methodCall = solution.GetType().GetMethod(puzzleRequest.PartId).Invoke(this, null);
                Console.Write($"The solution to {puzzleRequest.InputId} is: {methodCall}");
            }
            catch (RuntimeBinderException)
            {
                Console.WriteLine("The requested solution does not exist");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("The requested solution does not exist");
            }

        }

        public void PrintProblem(PuzzleRequest puzzleRequest)
        {
            try
            {
                var solutionProblem = System.IO.File.ReadAllText($"../..\\Problems\\{puzzleRequest.ProblemId}{puzzleRequest.PartId}.txt");
                Console.Write($"The problem for {puzzleRequest.InputId} is: {solutionProblem}");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("The requested problem file does not exist");
                throw;
            }
        }

        public void PrintInput(PuzzleRequest puzzleRequest)
        {
            try
            {
                var solutionInput = System.IO.File.ReadAllText($"../..\\Inputs\\{puzzleRequest.ProblemId}{puzzleRequest.PartId}.txt");
                Console.Write($"The input for {puzzleRequest.InputId} is: {solutionInput}");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("The requested problem file does not exist");
                throw;
            }
        }
    }
}
