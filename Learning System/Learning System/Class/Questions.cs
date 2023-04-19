using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_System
{
    internal class Questions
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int CategoryID { get; set; }
        public string? Content { get; set; }
        public double DefaultMark { get; set; }
        public List<QuestionChoice> Choice { get; set; } = new List<QuestionChoice>();
    }

    internal class QuestionChoice
    {
        public string? choice { get; set; }
        public double mark { get; set; }

    }
}
