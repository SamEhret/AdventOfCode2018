namespace AdventOfCode
{
    class InputParser
    {
        public void ParseInput(string inputId, string inputType)
        {
            var problemIdSplit = inputId.Split('.');
            var problemId = $"Problem{problemIdSplit[0]}";
            var partId = $"Part{problemIdSplit[1]}";

            var puzzlePrinter = new PuzzlePrinter();
            puzzlePrinter.PrintPuzzle(problemId, partId, inputType);
        }
    }
}
