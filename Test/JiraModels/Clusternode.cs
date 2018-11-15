using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Clusternode
    {
        public string NodeId { get; set; }
        public string NodeState { get; set; }
        public decimal? Timestamp { get; set; }
        public string Ip { get; set; }
        public decimal? CacheListenerPort { get; set; }
        public decimal? NodeBuildNumber { get; set; }
        public string NodeVersion { get; set; }
    }
}
