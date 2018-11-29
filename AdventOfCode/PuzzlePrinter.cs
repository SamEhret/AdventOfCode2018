using System;

namespace AdventOfCode
{
    public class PuzzlePrinter
    {

        public void PrintPuzzle(string problemId, string partId, string inputType)
        {
            if (inputType == "solution")
            {
                var solution = Activator.CreateInstance(Type.GetType("AdventOfCode.Solutions." + problemId));
                var methodCall = solution.GetType().GetMethod(partId).Invoke(this, null);
                Console.Write($"The solution to {problemId}{partId} is: {methodCall}");
            }

            else if (inputType == "problem")
            {
                var solutionProblem = System.IO.File.ReadAllText($"../..\\Problems\\{problemId}{partId}.txt");
                Console.Write($"The problem for {problemId}{partId} is: {solutionProblem}");

            }

            else if (inputType == "input")
            {
                var solutionInput = System.IO.File.ReadAllText($"../..\\Inputs\\{problemId}{partId}.txt");
                Console.Write($"The input for {problemId}{partId} is: {solutionInput}");
            }

            else
            {
                Console.Write("Invalid input");
                Environment.Exit(0);
            }
        }
    }
}
