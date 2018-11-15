using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class QrtzTriggers
    {
        public decimal Id { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public decimal? Job { get; set; }
        public DateTime? NextFire { get; set; }
        public string TriggerState { get; set; }
        public string TriggerType { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string CalendarName { get; set; }
        public int? MisfireInstr { get; set; }
    }
}
