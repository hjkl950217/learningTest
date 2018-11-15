using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoE8b6ccOrganizationMapping
    {
        public AoE8b6ccOrganizationMapping()
        {
            AoE8b6ccOrgToProject = new HashSet<AoE8b6ccOrgToProject>();
        }

        public string AccessToken { get; set; }
        public string AdminPassword { get; set; }
        public string AdminUsername { get; set; }
        public bool? AutolinkNewRepos { get; set; }
        public string DefaultGroupsSlugs { get; set; }
        public string DvcsType { get; set; }
        public string HostUrl { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string OauthKey { get; set; }
        public string OauthSecret { get; set; }
        public string PrincipalId { get; set; }
        public bool? SmartcommitsForNewRepos { get; set; }
        public string ApprovalState { get; set; }
        public long? LastPolled { get; set; }

        public ICollection<AoE8b6ccOrgToProject> AoE8b6ccOrgToProject { get; set; }
    }
}
