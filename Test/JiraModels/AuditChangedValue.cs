using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AuditChangedValue
    {
        public decimal Id { get; set; }
        public decimal? LogId { get; set; }
        public string Name { get; set; }
        public string DeltaFrom { get; set; }
        public string DeltaTo { get; set; }
    }
}
