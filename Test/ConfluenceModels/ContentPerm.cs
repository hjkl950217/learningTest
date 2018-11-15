using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class ContentPerm
    {
        public decimal Id { get; set; }
        public string CpType { get; set; }
        public string Username { get; set; }
        public string Groupname { get; set; }
        public decimal CpsId { get; set; }
        public string Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Lastmodifier { get; set; }
        public DateTime? Lastmoddate { get; set; }

        public ContentPermSet Cps { get; set; }
        public UserMapping CreatorNavigation { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
        public UserMapping UsernameNavigation { get; set; }
    }
}
