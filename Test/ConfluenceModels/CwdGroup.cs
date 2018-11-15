using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdGroup
    {
        public CwdGroup()
        {
            CwdGroupAttribute = new HashSet<CwdGroupAttribute>();
            CwdMembershipChildGroup = new HashSet<CwdMembership>();
            CwdMembershipParent = new HashSet<CwdMembership>();
        }

        public decimal Id { get; set; }
        public string GroupName { get; set; }
        public string LowerGroupName { get; set; }
        public string Active { get; set; }
        public string Local { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Description { get; set; }
        public string GroupType { get; set; }
        public decimal DirectoryId { get; set; }

        public CwdDirectory Directory { get; set; }
        public ICollection<CwdGroupAttribute> CwdGroupAttribute { get; set; }
        public ICollection<CwdMembership> CwdMembershipChildGroup { get; set; }
        public ICollection<CwdMembership> CwdMembershipParent { get; set; }
    }
}
