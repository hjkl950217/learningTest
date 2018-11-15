using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao575bf5ProviderIssue
    {
        public int Id { get; set; }
        public long IssueId { get; set; }
        public string ProviderSourceId { get; set; }
        public long? StaleAfter { get; set; }
    }
}
