using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class JquartzFiredTriggers
    {
        public string SchedName { get; set; }
        public string EntryId { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public string IsVolatile { get; set; }
        public string InstanceName { get; set; }
        public long? FiredTime { get; set; }
        public long? SchedTime { get; set; }
        public int? Priority { get; set; }
        public string State { get; set; }
        public string JobName { get; set; }
        public string JobGroup { get; set; }
        public string IsStateful { get; set; }
        public string IsNonconcurrent { get; set; }
        public string IsUpdateData { get; set; }
        public string RequestsRecovery { get; set; }
    }
}
