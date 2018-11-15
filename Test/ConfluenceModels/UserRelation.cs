using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class UserRelation
    {
        public decimal Relationid { get; set; }
        public string Sourceuser { get; set; }
        public string Targetuser { get; set; }
        public string Relationname { get; set; }
        public DateTime Creationdate { get; set; }
        public DateTime Lastmoddate { get; set; }
        public string Creator { get; set; }
        public string Lastmodifier { get; set; }

        public UserMapping CreatorNavigation { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
        public UserMapping SourceuserNavigation { get; set; }
        public UserMapping TargetuserNavigation { get; set; }
    }
}
