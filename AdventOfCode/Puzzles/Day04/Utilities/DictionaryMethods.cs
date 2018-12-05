using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AdventOfCode.Utilities;

namespace AdventOfCode.Puzzles.Day04.Utilities
{
    public class DictionaryMethods
    {
        public List<Models.Action> CreateActionList()
        {
            var inputList = InputReader.ReadInputToList("Day04");
            var actionList = new List<Models.Action>();
            var inputRegex = new Regex(@"\[(\d+-\d+-\d+\s+\d+:\d+)\]\s+(.+)");

            foreach (var line in inputList)
            {
                var matches = inputRegex.Match(line);

                if (matches.Groups[2].Value.Contains("wakes"))
                {
                    actionList.Add(new Models.Action(Convert.ToDateTime(matches.Groups[1].Value), EventEnum.WakeUp,
                        matches.Groups[2].Value));
                }
                else if (matches.Groups[2].Value.Contains("asleep"))
                {
                    actionList.Add(new Models.Action(Convert.ToDateTime(matches.Groups[1].Value), EventEnum.FallAsleep,
                        matches.Groups[2].Value));
                }
                else
                {
                    actionList.Add(new Models.Action(Convert.ToDateTime(matches.Groups[1].Value), EventEnum.BeginShift,
                        matches.Groups[2].Value));
                }
            }
            actionList.Sort((x, y) => DateTime.Compare(x.Time, y.Time));

            return actionList;
        }

        public Dictionary<int, Dictionary<int, int>> CreateSleepDictionary(List<Models.Action> actionList)
        {
            var sleepDictionary = new Dictionary<int, Dictionary<int, int>>();
            var tempStartTime = new DateTime();
            var currentGuard = 0;
            var guardRegex = new Regex(@"#(\d+)");

            foreach (var item in actionList)
            {
                if (item.Event == EventEnum.WakeUp)
                {
                    while (tempStartTime < item.Time)
                    {
                        if (sleepDictionary[currentGuard].ContainsKey(tempStartTime.Minute))
                        {
                            sleepDictionary[currentGuard][tempStartTime.Minute]++;
                        }
                        else
                        {
                            sleepDictionary[currentGuard].Add(tempStartTime.Minute, 1);
                        }
                        tempStartTime = tempStartTime.AddMinutes(1);
                    }
                }
                else if (item.Event == EventEnum.FallAsleep)
                {
                    tempStartTime = item.Time;
                }
                else
                {
                    currentGuard = Convert.ToInt32(guardRegex.Match(item.FullEvent).Groups[1].Value);
                    if (!sleepDictionary.ContainsKey(currentGuard))
                    {
                        sleepDictionary.Add(currentGuard, new Dictionary<int, int>());
                    }
                }
            }

            return sleepDictionary;
        }
    }
}
