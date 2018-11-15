using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Rundetails
    {
        public decimal Id { get; set; }
        public string JobId { get; set; }
        public DateTime? StartTime { get; set; }
        public decimal? RunDuration { get; set; }
        public string RunOutcome { get; set; }
        public string InfoMessage { get; set; }
    }
}
