using System;
using AdventOfCode.Puzzles.Day04.Utilities;

namespace AdventOfCode.Puzzles.Day04.Models
{
    public class Action
    {
        public DateTime Time { get; set; }
        public EventEnum Event { get; set; }
        public string FullEvent { get; set; }

        public Action(DateTime newDate, EventEnum newAction, string newFullEvent)
        {
            Time = newDate;
            Event = newAction;
            FullEvent = newFullEvent;
        }
    }
}
