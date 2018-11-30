namespace AdventOfCode.Utilities
{
    public class LeftPadding
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
