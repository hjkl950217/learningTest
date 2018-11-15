using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class OsGroup
    {
        public OsGroup()
        {
            OsUserGroup = new HashSet<OsUserGroup>();
        }

        public decimal Id { get; set; }
        public string Groupname { get; set; }

        public ICollection<OsUserGroup> OsUserGroup { get; set; }
    }
}
