using System.Collections.Generic;
using AdventOfCode.Utilities;

namespace AdventOfCode.Puzzles.Day02
{
    public class Solution
    {
        public static int Part1()
        {
            var inputList = GetInputPath();
            var twoCount = 0;
            var threeCount = 0;
            var checkSum = 0;

            foreach (var line in inputList)
            {
                var lineDict = new Dictionary<char, int>();

                foreach (var letter in line)
                {
                    if (!lineDict.ContainsKey(letter))
                    {
                        lineDict.Add(letter, 1);
                    }
                    else
                    {
                        lineDict[letter] += 1;
                    }
                }

                if (lineDict.ContainsValue(3))
                {
                    threeCount += 1;
                }

                if (lineDict.ContainsValue(2))
                {
                    twoCount += 1;
                }
            }

            checkSum = threeCount * twoCount;

            return checkSum;
        }

        public static string Part2()
        {
            return null;
        }

        public static List<string> GetInputPath()
        {
            var inputPath = ("../..\\Puzzles\\Day02\\Input.txt");
            var inputList = new FileReader().ReadInputToList(inputPath);

            return inputList;
        }
    }
}
