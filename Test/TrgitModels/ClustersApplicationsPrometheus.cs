using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ClustersApplicationsPrometheus
    {
        public int Id { get; set; }
        public int ClusterId { get; set; }
        public int Status { get; set; }
        public string Version { get; set; }
        public string StatusReason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Clusters Cluster { get; set; }
    }
}
