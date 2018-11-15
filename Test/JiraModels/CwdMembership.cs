using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class CwdMembership
    {
        public decimal Id { get; set; }
        public decimal? ParentId { get; set; }
        public decimal? ChildId { get; set; }
        public string MembershipType { get; set; }
        public string GroupType { get; set; }
        public string ParentName { get; set; }
        public string LowerParentName { get; set; }
        public string ChildName { get; set; }
        public string LowerChildName { get; set; }
        public decimal? DirectoryId { get; set; }
    }
}
