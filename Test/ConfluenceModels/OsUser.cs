using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class OsUser
    {
        public OsUser()
        {
            OsUserGroup = new HashSet<OsUserGroup>();
        }

        public decimal Id { get; set; }
        public string Username { get; set; }
        public string Passwd { get; set; }

        public ICollection<OsUserGroup> OsUserGroup { get; set; }
    }
}
