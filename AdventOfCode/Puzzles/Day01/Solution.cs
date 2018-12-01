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
                sum += Parse(line);
            }

            return sum;
        }

        public static int Part2()
        {
            var inputList = GetInputPath();
            var sumList = new List<int>();
            var currentSum = 0;

            while (!sumList.Exists(x => x == currentSum))
            {
                foreach (var line in inputList)
                {
                    sumList.Add(currentSum);
                    currentSum += Parse(line);
                    
                    if (sumList.Exists(x => x == currentSum))
                    {
                        break;
                    }
                }
            }
            
            return currentSum;
        }

        public static List<string> GetInputPath()
        {
            var inputPath = ("../..\\Puzzles\\Day01\\Input.txt");
            var inputList = new FileReader().ReadInputToList(inputPath);

            return inputList;
        }
    }
}
