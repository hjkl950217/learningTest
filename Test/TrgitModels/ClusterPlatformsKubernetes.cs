using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ClusterPlatformsKubernetes
    {
        public int Id { get; set; }
        public int ClusterId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ApiUrl { get; set; }
        public string CaCert { get; set; }
        public string Namespace { get; set; }
        public string Username { get; set; }
        public string EncryptedPassword { get; set; }
        public string EncryptedPasswordIv { get; set; }
        public string EncryptedToken { get; set; }
        public string EncryptedTokenIv { get; set; }

        public Clusters Cluster { get; set; }
    }
}
