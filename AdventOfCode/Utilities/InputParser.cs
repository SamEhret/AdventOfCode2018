using AdventOfCode.Models;

namespace AdventOfCode.Utilities
{
    public class InputParser
    {
        public PuzzleRequest ParseInput(PuzzleRequest puzzleRequest)
        {
            var problemIdSplit = puzzleRequest.InputId.Split('.');
            puzzleRequest.ProblemId = LeftPadProblemId(problemIdSplit[0]);
            puzzleRequest.PartId = problemIdSplit[1];

            return puzzleRequest;
        }

        public string LeftPadProblemId(string problemId)
        {
            if (problemId.Length == 1)
            {
                problemId = "0" + problemId;
            }

            return problemId;
        }
    }
}
