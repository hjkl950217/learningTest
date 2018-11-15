using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Extrnlnks
    {
        public decimal Linkid { get; set; }
        public string Contenttype { get; set; }
        public int Viewcount { get; set; }
        public string Url { get; set; }
        public decimal Contentid { get; set; }
        public string Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Lastmodifier { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public string Lowerurl { get; set; }

        public Content Content { get; set; }
        public UserMapping CreatorNavigation { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
    }
}
