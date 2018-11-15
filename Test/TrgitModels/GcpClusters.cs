using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class GcpClusters
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int? UserId { get; set; }
        public int? ServiceId { get; set; }
        public int? Status { get; set; }
        public int GcpClusterSize { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Enabled { get; set; }
        public string StatusReason { get; set; }
        public string ProjectNamespace { get; set; }
        public string Endpoint { get; set; }
        public string CaCert { get; set; }
        public string EncryptedKubernetesToken { get; set; }
        public string EncryptedKubernetesTokenIv { get; set; }
        public string Username { get; set; }
        public string EncryptedPassword { get; set; }
        public string EncryptedPasswordIv { get; set; }
        public string GcpProjectId { get; set; }
        public string GcpClusterZone { get; set; }
        public string GcpClusterName { get; set; }
        public string GcpMachineType { get; set; }
        public string GcpOperationId { get; set; }
        public string EncryptedGcpToken { get; set; }
        public string EncryptedGcpTokenIv { get; set; }

        public Projects Project { get; set; }
        public Services Service { get; set; }
        public Users User { get; set; }
    }
}
