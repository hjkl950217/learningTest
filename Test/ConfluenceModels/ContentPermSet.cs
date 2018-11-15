using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class ContentPermSet
    {
        public ContentPermSet()
        {
            ContentPerm = new HashSet<ContentPerm>();
        }

        public decimal Id { get; set; }
        public string ContPermType { get; set; }
        public decimal ContentId { get; set; }
        public DateTime? Creationdate { get; set; }
        public DateTime? Lastmoddate { get; set; }

        public Content Content { get; set; }
        public ICollection<ContentPerm> ContentPerm { get; set; }
    }
}
