using System;
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
                if (inputString[i].ToString() == inputString[i].ToString().ToLower())
                {
                    if (inputString[i].ToString().ToUpper() == inputString[i + 1].ToString())
                    {
                        inputString.Remove(inputString[i + 1]);
                        inputString.Remove(inputString[i]);

                        i--;
                    }
                }
                else if (inputString[i].ToString() == inputString[i].ToString().ToUpper())
                {
                    if (inputString[i].ToString().ToLower() == inputString[i + 1].ToString())
                    {
                        inputString.Remove(inputString[i + 1]);
                        inputString.Remove(inputString[i]);

                        i--;
                    }
                }
                Console.WriteLine(i);
            }

            var remaining = inputString.Length; 

            return remaining;
        }

        public static string Part2()
        {
            return null;
        }
    }
}
