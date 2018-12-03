using System.Collections.Generic;
using AdventOfCode.Utilities;

namespace AdventOfCode.Puzzles.Day02
{
    public class Solution
    {
        public static int Part1()
        {
            var inputList = InputReader.ReadInputToList("Day02");
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
            var inputList = InputReader.ReadInputToList("Day02");
            var currentLine = 0;
            var nextLine = 1;
            var commonLetters = "";

            while (currentLine < inputList.Count)
            {
                while (nextLine < inputList.Count)
                {
                    for (int i = 0; i < inputList[i].Length; i++)
                    {
                        if (inputList[currentLine][i] == inputList[nextLine][i])
                        {
                            commonLetters += inputList[currentLine][i];
                        }
                    }
                    
                    if (commonLetters.Length == (inputList[0].Length - 1))
                    {
                        return commonLetters;
                    }
                    commonLetters = "";
                    nextLine += 1;
                }

                currentLine += 1;
                nextLine = currentLine + 1;
            }

            return commonLetters;
        }
    }
}
