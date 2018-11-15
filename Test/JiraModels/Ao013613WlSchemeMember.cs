using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao013613WlSchemeMember
    {
        public int Id { get; set; }
        public string MemberKey { get; set; }
        public int? WorkloadSchemeId { get; set; }

        public Ao013613WlScheme WorkloadScheme { get; set; }
    }
}
