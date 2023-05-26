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
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public int TimeLimit { get; set; }
    }
}
