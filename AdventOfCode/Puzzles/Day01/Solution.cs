using System.Collections.Generic;
using AdventOfCode.Utilities;
using static System.Int32;

namespace AdventOfCode.Puzzles.Day01
{
    public class Solution
    {
        public static int Part1()
        {
            var inputList = InputReader.ReadInputToList("Day01");
            var sum = 0;

            foreach (var line in inputList)
            {
                sum += Parse(line);
            }

            return sum;
        }

        public static int Part2()
        {
            var inputList = InputReader.ReadInputToList("Day01");
            var sumList = new List<int>();
            var currentSum = 0;
            var looping = true;

            while (looping)
            {
                foreach (var line in inputList)
                {
                    sumList.Add(currentSum);
                    currentSum += Parse(line);

                    if (sumList.Contains(currentSum))
                    {
                        looping = false;
                        break;
                    }
                }
            }
            
            return currentSum;
        }
    }
}
