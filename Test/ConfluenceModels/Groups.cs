using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Groups
    {
        public Groups()
        {
            ExternalMembers = new HashSet<ExternalMembers>();
            LocalMembers = new HashSet<LocalMembers>();
        }

        public decimal Id { get; set; }
        public string Groupname { get; set; }

        public ICollection<ExternalMembers> ExternalMembers { get; set; }
        public ICollection<LocalMembers> LocalMembers { get; set; }
    }
}
