﻿using System;

namespace AdventOfCode
{
    public class PuzzlePrinter
    {

        public void PrintPuzzle(string problemId, string partId, string inputType)
        {
            if (inputType == "solution")
            {
                var solution = Activator.CreateInstance(Type.GetType("AdventOfCode.Solutions." + problemId));
                Console.Write(solution.GetType().GetMethod(partId).Invoke(this, null));
            }

            else if (inputType == "problem")
            {
                var solutionProblem = System.IO.File.ReadAllText($"../..\\Problems\\{problemId}{partId}.txt");
                Console.Write(solutionProblem);

            }

            else if (inputType == "input")
            {
                var solutionInput = System.IO.File.ReadAllText($"../..\\Inputs\\{problemId}{partId}.txt");
                Console.Write(solutionInput);
            }

            else
            {
                Console.Write("Invalid input");
                Environment.Exit(exitCode:0);
            }
        }
    }
}