using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Clusterupgradestate
    {
        public decimal Id { get; set; }
        public decimal? DatabaseTime { get; set; }
        public decimal? ClusterBuildNumber { get; set; }
        public string ClusterVersion { get; set; }
        public string State { get; set; }
        public decimal? OrderNumber { get; set; }
    }
}
