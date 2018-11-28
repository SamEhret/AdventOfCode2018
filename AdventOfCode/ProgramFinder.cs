﻿using System;

namespace AdventOfCode
{
    public class ProgramFinder
    {
        public void GetProblem()
        {
            Console.Write("What problem would you like to see? ");
            var inputId = Console.ReadLine();

            Console.Write("Would you like to see the solution, problem, or input? ");
            var inputType = Console.ReadLine();

            printProblem(inputId, inputType);
        }

        public void printProblem(string inputId, string inputType = "solution")
        {
            var problemIdSplit = inputId.Split('.');
            var problemId = $"Problem{problemIdSplit[0]}";
            var partId = $"Part{problemIdSplit[1]}";

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
