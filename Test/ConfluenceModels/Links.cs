using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Links
    {
        public decimal Linkid { get; set; }
        public string Destpagetitle { get; set; }
        public string Destspacekey { get; set; }
        public decimal Contentid { get; set; }
        public string Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Lastmodifier { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public string Lowerdestpagetitle { get; set; }
        public string Lowerdestspacekey { get; set; }

        public Content Content { get; set; }
        public UserMapping CreatorNavigation { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
    }
}
