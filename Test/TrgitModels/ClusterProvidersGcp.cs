using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ClusterProvidersGcp
    {
        public int Id { get; set; }
        public int ClusterId { get; set; }
        public int? Status { get; set; }
        public int NumNodes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string StatusReason { get; set; }
        public string GcpProjectId { get; set; }
        public string Zone { get; set; }
        public string MachineType { get; set; }
        public string OperationId { get; set; }
        public string Endpoint { get; set; }
        public string EncryptedAccessToken { get; set; }
        public string EncryptedAccessTokenIv { get; set; }

        public Clusters Cluster { get; set; }
    }
}
