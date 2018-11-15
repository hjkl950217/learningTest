using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoAefed0TeamMember
    {
        public AoAefed0TeamMember()
        {
            AoAefed0TeamToMember = new HashSet<AoAefed0TeamToMember>();
        }

        public int Id { get; set; }
        public string MemberKey { get; set; }
        public string MemberType { get; set; }
        public string RoleType { get; set; }

        public ICollection<AoAefed0TeamToMember> AoAefed0TeamToMember { get; set; }
    }
}
