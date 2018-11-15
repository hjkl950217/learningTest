using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoAefed0TeamToMember
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? TeamMemberId { get; set; }

        public AoAefed0Team Team { get; set; }
        public AoAefed0TeamMember TeamMember { get; set; }
    }
}
