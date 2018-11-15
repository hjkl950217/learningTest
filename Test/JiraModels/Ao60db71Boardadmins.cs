using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Boardadmins
    {
        public long Id { get; set; }
        public string Key { get; set; }
        public long RapidViewId { get; set; }
        public string Type { get; set; }

        public Ao60db71Rapidview RapidView { get; set; }
    }
}
