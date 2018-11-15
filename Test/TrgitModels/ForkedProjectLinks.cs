using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ForkedProjectLinks
    {
        public int Id { get; set; }
        public int ForkedToProjectId { get; set; }
        public int ForkedFromProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Projects ForkedToProject { get; set; }
    }
}
