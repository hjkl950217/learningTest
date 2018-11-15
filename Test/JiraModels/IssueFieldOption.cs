using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class IssueFieldOption
    {
        public decimal Id { get; set; }
        public decimal? OptionId { get; set; }
        public string FieldKey { get; set; }
        public string OptionValue { get; set; }
        public string Properties { get; set; }
    }
}
