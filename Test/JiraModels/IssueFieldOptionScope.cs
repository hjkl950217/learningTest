using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class IssueFieldOptionScope
    {
        public decimal Id { get; set; }
        public decimal? OptionId { get; set; }
        public string EntityId { get; set; }
        public string ScopeType { get; set; }
    }
}
