using System.Linq;
using AdventOfCode.Puzzles.Day04.Utilities;

namespace AdventOfCode.Puzzles.Day04
{
    public class Solution
    {
        public static int Part1()
        {
            var sleepDictionary = new DictionaryMethods().CreateSleepDictionary(new DictionaryMethods().CreateActionList());            

            var sortedDict = from entry in sleepDictionary orderby entry.Value.Sum(x => x.Value) descending select entry;
            var sortedMinuteInFirst = from entry in sortedDict.First().Value orderby entry.Value descending select entry;

            var guardTimesMinute = sortedDict.First().Key * sortedMinuteInFirst.First().Key;

            return guardTimesMinute;
        }

        public static int Part2()
        {
            var sleepDictionary = new DictionaryMethods().CreateSleepDictionary(new DictionaryMethods().CreateActionList());

            var sortedDict = sleepDictionary
                .Where(x => x.Value.Values.Any())
                .OrderByDescending (x => x.Value.Max(z => z.Value))
                .ToDictionary(x => x.Key, x => x.Value
                    .OrderByDescending(y => y.Value)
                    .ToDictionary(y => y.Key, y => y.Value));

            var mostSleptGuard = sortedDict.First();
            var guardTimesMinute = mostSleptGuard.Key * mostSleptGuard.Value.First().Key;

            return guardTimesMinute;
        }
    }
}
