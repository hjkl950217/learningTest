using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class MovedIssueKey
    {
        public decimal Id { get; set; }
        public string OldIssueKey { get; set; }
        public decimal? IssueId { get; set; }
    }
}
