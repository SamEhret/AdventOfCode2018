using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Utilities;

namespace AdventOfCode.Puzzles.Day05
{
    public class Solution
    {
        public static int Part1()
        {
            var inputString = InputReader.ReadInputToString("day05");

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (Char.IsLower(inputString[i]))
                {
                    if (inputString[i].ToString().ToUpper() == inputString[i + 1].ToString())
                    {
                        inputString = inputString.Remove(i, 2);

                        i -= 2;
                    }
                }
                else if (Char.IsUpper(inputString[i]))
                {
                    if (inputString[i].ToString().ToLower() == inputString[i + 1].ToString())
                    {
                        inputString = inputString.Remove(i, 2);

                        i -= 2;
                    }
                }

                if (i < -1)
                {
                    i = -1;
                }
            }
            return inputString.Length;
        }

        public static int Part2()
        {
            var polymerDict = new Dictionary<int, int>();

            for (char x = 'A'; x <= 'Z'; x++)
            {
                var inputString = InputReader.ReadInputToString("day05");

                for (int j = 0; j < inputString.Length -1; j++)
                {
                    if (x == Char.ToUpper(inputString[j]))
                    {
                        inputString = inputString.Remove(j, 1);
                        j --;
                    }
                }

                for (int i = 0; i < inputString.Length - 1; i++)
                {
                    if (Char.IsLower(inputString[i]))
                    {
                        if (inputString[i].ToString().ToUpper() == inputString[i + 1].ToString())
                        {
                            inputString = inputString.Remove(i, 2);

                            i -= 2;
                        }
                    }
                    else if (Char.IsUpper(inputString[i]))
                    {
                        if (inputString[i].ToString().ToLower() == inputString[i + 1].ToString())
                        {
                            inputString = inputString.Remove(i, 2);

                            i -= 2;
                        }
                    }

                    if (i < -1)
                    {
                        i = -1;
                    }
                }

                polymerDict[x] = inputString.Length;
            }
            var shortest = polymerDict.OrderBy(x => x.Value).First().Value;

            return shortest;
        }
    }
}
