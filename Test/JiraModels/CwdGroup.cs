using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class CwdGroup
    {
        public decimal Id { get; set; }
        public string GroupName { get; set; }
        public string LowerGroupName { get; set; }
        public int? Active { get; set; }
        public int? Local { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Description { get; set; }
        public string LowerDescription { get; set; }
        public string GroupType { get; set; }
        public decimal? DirectoryId { get; set; }
    }
}
