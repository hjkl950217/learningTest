using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoAefed0Team
    {
        public AoAefed0Team()
        {
            AoAefed0TeamToMember = new HashSet<AoAefed0TeamToMember>();
        }

        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AoAefed0TeamToMember> AoAefed0TeamToMember { get; set; }
    }
}
