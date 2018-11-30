using AdventOfCode.Utilities;

namespace AdventOfCode.Models
{
    public class PuzzleRequest
    {
        public string InputId { get; set; }
        public PuzzleType InputType { get; set; }
        public string ProblemId { get; set; }
        public string PartId { get; set; }
    }
}
