using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_System.ExternalClass
{
    internal class DataImport
    {
        static readonly public List<string> questionColumns = new() { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
        static readonly public List<Type> questionType = new() { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
        static readonly public List<string> questionKey = new() { "PRIMARY KEY", "", "", "", "", "" };
    }
}
