using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Clusternodeheartbeat
    {
        public string NodeId { get; set; }
        public decimal? HeartbeatTime { get; set; }
        public decimal? DatabaseTime { get; set; }
    }
}
