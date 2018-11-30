namespace AdventOfCode
{
    public class InputParser
    {
        public PuzzleRequest ParseInput(PuzzleRequest puzzleRequest)
        {
            var problemIdSplit = puzzleRequest.InputId.Split('.');
            puzzleRequest.ProblemId = problemIdSplit[0];
            puzzleRequest.PartId = problemIdSplit[1];

            return puzzleRequest;
        }
    }
}
