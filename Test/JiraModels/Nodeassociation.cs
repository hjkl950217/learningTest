using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Nodeassociation
    {
        public decimal SourceNodeId { get; set; }
        public string SourceNodeEntity { get; set; }
        public decimal SinkNodeId { get; set; }
        public string SinkNodeEntity { get; set; }
        public string AssociationType { get; set; }
        public int? Sequence { get; set; }
    }
}
