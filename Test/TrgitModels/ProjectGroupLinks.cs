using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProjectGroupLinks
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int GroupId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int GroupAccess { get; set; }
        public DateTime? ExpiresAt { get; set; }

        public Projects Project { get; set; }
    }
}
