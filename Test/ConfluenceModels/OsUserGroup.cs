using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class OsUserGroup
    {
        public decimal GroupId { get; set; }
        public decimal UserId { get; set; }

        public OsGroup Group { get; set; }
        public OsUser User { get; set; }
    }
}
