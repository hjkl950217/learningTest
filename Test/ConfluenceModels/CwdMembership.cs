using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdMembership
    {
        public decimal Id { get; set; }
        public decimal ParentId { get; set; }
        public decimal? ChildGroupId { get; set; }
        public decimal? ChildUserId { get; set; }

        public CwdGroup ChildGroup { get; set; }
        public CwdUser ChildUser { get; set; }
        public CwdGroup Parent { get; set; }
    }
}
