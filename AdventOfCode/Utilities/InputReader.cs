using System.Collections.Generic;

namespace AdventOfCode.Utilities
{
    class InputReader
    {
        public static List<string> ReadInputToList(string day)
        {
            var inputPath = ($"../../..\\AdventOfCode\\Puzzles\\{day}\\Input.txt");
            var inputList = new FileReader().ReadInputToList(inputPath);

            return inputList;
        }

        public static string ReadInputToString(string day)
        {
            var inputPath = ($"../../..\\AdventOfCode\\Puzzles\\{day}\\Input.txt");
            var inputString = new FileReader().ReadInputToString(inputPath);

            return inputString;
        }
    }
}
