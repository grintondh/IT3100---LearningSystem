using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_System
{
    public class Categories
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [JsonProperty("SubArray")]
        public List<int> SubArray { get; set; } = new List<int>();
        [JsonProperty("QuestionArray")]
        public List<int> QuestionArray { get; set; } = new List<int>();
        public string? Description { get; set; }
        public string? IdNumber { get; set; }
    }

}