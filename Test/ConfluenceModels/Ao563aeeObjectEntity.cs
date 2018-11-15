using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao563aeeObjectEntity
    {
        public Ao563aeeObjectEntity()
        {
            Ao563aeeActivityEntity = new HashSet<Ao563aeeActivityEntity>();
        }

        public string Content { get; set; }
        public string DisplayName { get; set; }
        public int Id { get; set; }
        public int? ImageId { get; set; }
        public string ObjectId { get; set; }
        public string ObjectType { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }

        public Ao563aeeMediaLinkEntity Image { get; set; }
        public ICollection<Ao563aeeActivityEntity> Ao563aeeActivityEntity { get; set; }
    }
}
