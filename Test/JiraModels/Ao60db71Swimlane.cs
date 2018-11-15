using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Swimlane
    {
        public bool DefaultLane { get; set; }
        public string Description { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Pos { get; set; }
        public string Query { get; set; }
        public long RapidViewId { get; set; }
        public string LongQuery { get; set; }

        public Ao60db71Rapidview RapidView { get; set; }
    }
}
