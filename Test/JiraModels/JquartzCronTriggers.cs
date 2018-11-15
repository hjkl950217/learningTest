using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class JquartzCronTriggers
    {
        public string SchedName { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public string CronExpression { get; set; }
        public string TimeZoneId { get; set; }
    }
}
