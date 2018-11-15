using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class QrtzCronTriggers
    {
        public decimal Id { get; set; }
        public decimal? TriggerId { get; set; }
        public string CronExperssion { get; set; }
    }
}
