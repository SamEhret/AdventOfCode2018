using System;

namespace AdventOfCode
{
    class Program
    {
        private static void Main()
        {
            var input = "";

            Console.Write("What problem would you like to see? ");
            input = Console.ReadLine();
            var inputId = string.IsNullOrEmpty(input) ? "1.1" : input;

            Console.Write("Would you like to see the solution, problem, or input? ");
            input = Console.ReadLine();
            var inputType = string.IsNullOrEmpty(input) ? "solution" : input;

            var inputParser = new InputParser();
            inputParser.ParseInput(inputId, inputType);
        }
    }
}