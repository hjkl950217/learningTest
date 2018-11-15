using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class UsercontentRelation
    {
        public decimal Relationid { get; set; }
        public decimal Targetcontentid { get; set; }
        public string Sourceuser { get; set; }
        public string Targettype { get; set; }
        public string Relationname { get; set; }
        public DateTime Creationdate { get; set; }
        public DateTime Lastmoddate { get; set; }
        public string Creator { get; set; }
        public string Lastmodifier { get; set; }

        public UserMapping CreatorNavigation { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
        public UserMapping SourceuserNavigation { get; set; }
        public Content Targetcontent { get; set; }
    }
}
