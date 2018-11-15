using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ClustersApplicationsIngress
    {
        public int Id { get; set; }
        public int ClusterId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Status { get; set; }
        public int IngressType { get; set; }
        public string Version { get; set; }
        public string ClusterIp { get; set; }
        public string StatusReason { get; set; }
        public string ExternalIp { get; set; }

        public Clusters Cluster { get; set; }
    }
}
