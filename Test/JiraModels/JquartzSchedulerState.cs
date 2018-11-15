using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class JquartzSchedulerState
    {
        public string SchedName { get; set; }
        public string InstanceName { get; set; }
        public long? LastCheckinTime { get; set; }
        public long? CheckinInterval { get; set; }
    }
}
