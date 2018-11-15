using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class QrtzFiredTriggers
    {
        public decimal? Id { get; set; }
        public string EntryId { get; set; }
        public decimal? TriggerId { get; set; }
        public string TriggerListener { get; set; }
        public DateTime? FiredTime { get; set; }
        public string TriggerState { get; set; }
    }
}
