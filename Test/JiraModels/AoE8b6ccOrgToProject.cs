using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoE8b6ccOrgToProject
    {
        public int Id { get; set; }
        public int? OrganizationId { get; set; }
        public string ProjectKey { get; set; }

        public AoE8b6ccOrganizationMapping Organization { get; set; }
    }
}
