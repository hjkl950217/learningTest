using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class JquartzSimpropTriggers
    {
        public string SchedName { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public string StrProp1 { get; set; }
        public string StrProp2 { get; set; }
        public string StrProp3 { get; set; }
        public int? IntProp1 { get; set; }
        public int? IntProp2 { get; set; }
        public long? LongProp1 { get; set; }
        public long? LongProp2 { get; set; }
        public decimal? DecProp1 { get; set; }
        public decimal? DecProp2 { get; set; }
        public string BoolProp1 { get; set; }
        public string BoolProp2 { get; set; }
    }
}
