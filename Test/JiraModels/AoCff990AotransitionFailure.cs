using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoCff990AotransitionFailure
    {
        public string ErrorMessages { get; set; }
        public DateTime? FailureTime { get; set; }
        public int Id { get; set; }
        public long? IssueId { get; set; }
        public string LogReferralHash { get; set; }
        public long? TransitionId { get; set; }
        public long? TriggerId { get; set; }
        public string UserKey { get; set; }
        public string WorkflowId { get; set; }
    }
}
