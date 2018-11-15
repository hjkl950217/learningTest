using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProtectedTags
    {
        public ProtectedTags()
        {
            ProtectedTagCreateAccessLevels = new HashSet<ProtectedTagCreateAccessLevels>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Projects Project { get; set; }
        public ICollection<ProtectedTagCreateAccessLevels> ProtectedTagCreateAccessLevels { get; set; }
    }
}
