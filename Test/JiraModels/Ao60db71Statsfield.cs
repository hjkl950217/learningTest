using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Statsfield
    {
        public long Id { get; set; }
        public long RapidViewId { get; set; }
        public string TypeId { get; set; }

        public Ao60db71Rapidview RapidView { get; set; }
    }
}
