namespace AdventOfCode
{
    class InputParser
    {
        public PuzzleRequest ParseInput(PuzzleRequest puzzleRequest)
        {
            var problemIdSplit = puzzleRequest.InputId.Split('.');
            puzzleRequest.ProblemId = $"Problem{problemIdSplit[0]}";
            puzzleRequest.PartId = $"Part{problemIdSplit[1]}";

            return puzzleRequest;
        }
    }
}
