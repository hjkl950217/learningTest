using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Clustermessage
    {
        public decimal Id { get; set; }
        public string SourceNode { get; set; }
        public string DestinationNode { get; set; }
        public string ClaimedByNode { get; set; }
        public string Message { get; set; }
        public DateTime? MessageTime { get; set; }
    }
}
