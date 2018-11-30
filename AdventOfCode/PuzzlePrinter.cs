using System;
using Microsoft.CSharp.RuntimeBinder;

namespace AdventOfCode
{
    public class PuzzlePrinter
    {

        public void PrintPuzzle(PuzzleRequest puzzleRequest)
        {
            switch (puzzleRequest.InputType.problem)
            {
                case puzzleRequest.InputType.problem
                {

                }
            }
        }

        public void TEST(PuzzleRequest puzzleRequest)
        {
            if (puzzleRequest.InputType == "solution")
            {
                try
                {
                    var solution = Activator.CreateInstance(Type.GetType("AdventOfCode.Solutions." + puzzleRequest.ProblemId));
                    var methodCall = solution.GetType().GetMethod(puzzleRequest.PartId).Invoke(this, null);
                    Console.Write($"The solution to {puzzleRequest.InputId} is: {methodCall}");
                }
                catch (RuntimeBinderException)
                {
                    Console.WriteLine("The requested problem does not exist");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("The requested problem does not exist");
                }
            }

            else if (puzzleRequest.InputType == "problem")
            {
                try
                {
                    var solutionProblem = System.IO.File.ReadAllText($"../..\\Problems\\{puzzleRequest.ProblemId}{puzzleRequest.PartId}.txt");
                    Console.Write($"The problem for {puzzleRequest.InputId} is: {solutionProblem}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            else if (puzzleRequest.InputType == "input")
            {
                var solutionInput = System.IO.File.ReadAllText($"../..\\Inputs\\{puzzleRequest.ProblemId}{puzzleRequest.PartId}.txt");
                Console.Write($"The input for {puzzleRequest.InputId} is: {solutionInput}");
            }

            else
            {
                Console.Write("Invalid input");
                Environment.Exit(0);
            }
        }
    }
}
