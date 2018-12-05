using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.Utilities
{
    public class FileReader
    {
        public List<string> ReadInputToList(string inputPath)
        {
            var fileRead = File.ReadAllLines(inputPath);
            var fileList = new List<string>(fileRead);

            return fileList;
        }

        public string ReadInputToString(string inputPath)
        {
            var fileString = File.ReadAllText(inputPath);

            return fileString;
        }
    }
}
