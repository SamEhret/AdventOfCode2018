using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.Utilities
{
    public class FileReader
    {
        public List<string> ReadFileToList(string filePath)
        {
            var fileRead = File.ReadAllLines(filePath);
            var fileList = new List<string>(fileRead);

            return fileList;
        }
    }
}
