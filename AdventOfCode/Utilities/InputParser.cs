using AdventOfCode.Models;

namespace AdventOfCode.Utilities
{
    public class InputParser
    {
        public PuzzleRequest ParseInput(PuzzleRequest puzzleRequest)
        {
            var problemIdSplit = puzzleRequest.InputId.Split('.');
            var leftPadding = new LeftPadding();

            puzzleRequest.ProblemId = leftPadding.LeftPadInputString(problemIdSplit[0]);
            puzzleRequest.PartId = problemIdSplit[1];

            return puzzleRequest;
        }
    }
}
