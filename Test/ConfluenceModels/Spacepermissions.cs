using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Spacepermissions
    {
        public decimal Permid { get; set; }
        public decimal? Spaceid { get; set; }
        public string Permtype { get; set; }
        public string Permgroupname { get; set; }
        public string Permusername { get; set; }
        public string Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Lastmodifier { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public string Permalluserssubject { get; set; }

        public UserMapping CreatorNavigation { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
        public UserMapping PermusernameNavigation { get; set; }
        public Spaces Space { get; set; }
    }
}
