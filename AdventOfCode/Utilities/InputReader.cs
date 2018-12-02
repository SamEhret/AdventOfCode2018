using System.Collections.Generic;

namespace AdventOfCode.Utilities
{
    class InputReader
    {
        public static List<string> ReadInputToList(string day)
        {
            var inputPath = ($"../..\\Puzzles\\{day}\\Input.txt");
            var inputList = new FileReader().ReadInputToList(inputPath);

            return inputList;
        }
    }
}
