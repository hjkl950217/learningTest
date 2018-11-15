using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Userassociation
    {
        public string SourceName { get; set; }
        public decimal SinkNodeId { get; set; }
        public string SinkNodeEntity { get; set; }
        public string AssociationType { get; set; }
        public int? Sequence { get; set; }
        public DateTime? Created { get; set; }
    }
}
