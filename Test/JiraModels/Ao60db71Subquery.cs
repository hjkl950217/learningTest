using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Subquery
    {
        public long Id { get; set; }
        public string Query { get; set; }
        public long? RapidViewId { get; set; }
        public string Section { get; set; }
        public string LongQuery { get; set; }

        public Ao60db71Rapidview RapidView { get; set; }
    }
}
