using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Clusters
    {
        public Clusters()
        {
            ClusterProjects = new HashSet<ClusterProjects>();
            ClustersApplicationsHelm = new HashSet<ClustersApplicationsHelm>();
            ClustersApplicationsIngress = new HashSet<ClustersApplicationsIngress>();
            ClustersApplicationsPrometheus = new HashSet<ClustersApplicationsPrometheus>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProviderType { get; set; }
        public int? PlatformType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Enabled { get; set; }
        public string Name { get; set; }
        public string EnvironmentScope { get; set; }

        public Users User { get; set; }
        public ClusterPlatformsKubernetes ClusterPlatformsKubernetes { get; set; }
        public ClusterProvidersGcp ClusterProvidersGcp { get; set; }
        public ClustersApplicationsRunners ClustersApplicationsRunners { get; set; }
        public ICollection<ClusterProjects> ClusterProjects { get; set; }
        public ICollection<ClustersApplicationsHelm> ClustersApplicationsHelm { get; set; }
        public ICollection<ClustersApplicationsIngress> ClustersApplicationsIngress { get; set; }
        public ICollection<ClustersApplicationsPrometheus> ClustersApplicationsPrometheus { get; set; }
    }
}
