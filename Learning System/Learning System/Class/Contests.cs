using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_System
{
    internal class Contests
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool DescriptionShow { get; set; }
        public List<int> QuestionArray { get; set; } = new List<int>();
        public bool ShuffleAnswer { get; set; }
        public int DayStart { get; set; }
        public string? MonthStart { get; set; }
        public int YearStart { get; set; }
        public int HourStart { get; set; }
        public int MinuteStart { get; set; }
        public bool StartEnable { get; set; }
        public int DayEnd { get; set; }
        public string? MonthEnd { get; set; }
        public int YearEnd { get; set; }
        public int HourEnd { get; set; }
        public int MinuteEnd { get; set; }
        public bool EndEnable { get; set; }
        public int TimeLimit { get; set; }
        public bool TimeLimitEnable { get; set; }
        public double MaximumGrade { get; set; }
    }
}
