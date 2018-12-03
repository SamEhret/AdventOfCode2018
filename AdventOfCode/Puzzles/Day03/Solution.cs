using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AdventOfCode.Utilities;

namespace AdventOfCode.Puzzles.Day03
{
    public class Solution
    {
        public static int Part1()
        {
            var squareDict = CreateDictionary();
            var squareSum = 0;

            foreach (var item in squareDict)
            {
                foreach (var subItem in item.Value)
                {
                    if (subItem.Value > 1)
                    {
                        squareSum += 1;
                    }
                }
            }

            return squareSum;
        }

        public static int Part2()
        {
            var squareDict = CreateDictionary();
            var inputList = InputReader.ReadInputToList("Day03");
            var regex = new Regex(@"(\d+)\s+@\s+(\d+),(\d+):\s+(\d+)x(\d+)");

            foreach (var line in inputList)
            {
                var hasOverlap = 0;
                var matches = regex.Match(line);
                var lineNum = Convert.ToInt32(matches.Groups[1].Value);
                var top = Convert.ToInt32(matches.Groups[2].Value);
                var left = Convert.ToInt32(matches.Groups[3].Value);
                var toBottom = Convert.ToInt32(matches.Groups[4].Value);
                var toRight = Convert.ToInt32(matches.Groups[5].Value);

                for (var row = top; row <= top + toBottom - 1; row++)
                {
                    for (var column = left; column <= left + toRight - 1; column++)
                    {
                        if (squareDict[row][column] > 1)
                        {
                            hasOverlap++;
                        }
                    }
                }

                if (hasOverlap == 0)
                {
                    return lineNum;
                }
            }

            return 0;
        }

        public static Dictionary<int, Dictionary<int, int>> CreateDictionary()
        {
            var inputList = InputReader.ReadInputToList("Day03");
            var regex = new Regex(@"(\d+)\s+@\s+(\d+),(\d+):\s+(\d+)x(\d+)");
            var squareDict = new Dictionary<int, Dictionary<int, int>>();

            foreach (var line in inputList)
            {
                var matches = regex.Match(line);
                var top = Convert.ToInt32(matches.Groups[2].Value);
                var left = Convert.ToInt32(matches.Groups[3].Value);
                var toBottom = Convert.ToInt32(matches.Groups[4].Value);
                var toRight = Convert.ToInt32(matches.Groups[5].Value);

                for (var row = top; row <= top + toBottom - 1; row++)
                {
                    for (var column = left; column <= left + toRight - 1; column++)
                    {
                        if (!squareDict.ContainsKey(row))
                        {
                            squareDict[row] = new Dictionary<int, int>() { { column, 1 } };
                        }
                        else if (!squareDict[row].ContainsKey(column))
                        {
                            squareDict[row].Add(column, 1);
                        }
                        else
                        {
                            squareDict[row][column]++;
                        }
                    }
                }
            }

            return squareDict;
        }
    }
}
