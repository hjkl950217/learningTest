using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class QrtzTriggerListeners
    {
        public decimal Id { get; set; }
        public decimal? TriggerId { get; set; }
        public string TriggerListener { get; set; }
    }
}
