using System.Collections.Generic;
using AdventOfCode.Utilities;
using static System.Int32;

namespace AdventOfCode.Puzzles.Day01
{
    public class Solution
    {
        public static int Part1()
        {
            var inputList = GetInputPath();
            var sum = 0;

            foreach (var line in inputList)
            {
                if (line[0] == '+')
                {
                    sum += Parse(line.Substring(1));
                }
                else
                {
                    sum += Parse(line);
                }
            }

            return sum;
        }

        public static string Part2()
        {
            return null;
        }

        public static List<string> GetInputPath()
        {
            var inputPath = ($"../..\\Puzzles\\Day01\\Input.txt");
            var inputList = new FileReader().ReadInputToList(inputPath);

            return inputList;
        }
    }
}
