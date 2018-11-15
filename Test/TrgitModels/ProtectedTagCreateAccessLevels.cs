using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProtectedTagCreateAccessLevels
    {
        public int Id { get; set; }
        public int ProtectedTagId { get; set; }
        public int? AccessLevel { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Namespaces Group { get; set; }
        public ProtectedTags ProtectedTag { get; set; }
        public Users User { get; set; }
    }
}
