using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao2f1435HealthCheckStatus
    {
        public string ApplicationName { get; set; }
        public string CompleteKey { get; set; }
        public string Description { get; set; }
        public DateTime? FailedDate { get; set; }
        public string FailureReason { get; set; }
        public int Id { get; set; }
        public bool? IsHealthy { get; set; }
        public bool? IsResolved { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public string Severity { get; set; }
        public string StatusName { get; set; }
    }
}
