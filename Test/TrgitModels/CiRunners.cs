using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiRunners
    {
        public CiRunners()
        {
            ClustersApplicationsRunners = new HashSet<ClustersApplicationsRunners>();
        }

        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Description { get; set; }
        public DateTime? ContactedAt { get; set; }
        public bool? Active { get; set; }
        public bool? IsShared { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Revision { get; set; }
        public string Platform { get; set; }
        public string Architecture { get; set; }
        public bool? RunUntagged { get; set; }
        public bool Locked { get; set; }
        public int AccessLevel { get; set; }
        public string IpAddress { get; set; }

        public ICollection<ClustersApplicationsRunners> ClustersApplicationsRunners { get; set; }
    }
}
