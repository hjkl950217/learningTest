using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Nodeindexcounter
    {
        public decimal Id { get; set; }
        public string NodeId { get; set; }
        public string SendingNodeId { get; set; }
        public decimal? IndexOperationId { get; set; }
    }
}
