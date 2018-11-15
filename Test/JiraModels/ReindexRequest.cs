using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class ReindexRequest
    {
        public decimal Id { get; set; }
        public string Type { get; set; }
        public DateTime? RequestTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? CompletionTime { get; set; }
        public string Status { get; set; }
        public string ExecutionNodeId { get; set; }
        public string Query { get; set; }
    }
}
