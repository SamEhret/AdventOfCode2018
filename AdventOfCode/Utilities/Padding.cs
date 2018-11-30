namespace AdventOfCode.Utilities
{
    public class Padding
    {
        public string LeftPadInputString(string inputString)
        {
            if (inputString.Length == 1)
            {
                inputString = "0" + inputString;
            }

            return inputString;
        }
    }
}
