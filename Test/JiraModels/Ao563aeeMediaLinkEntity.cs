using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao563aeeMediaLinkEntity
    {
        public Ao563aeeMediaLinkEntity()
        {
            Ao563aeeActivityEntity = new HashSet<Ao563aeeActivityEntity>();
            Ao563aeeObjectEntity = new HashSet<Ao563aeeObjectEntity>();
            Ao563aeeTargetEntity = new HashSet<Ao563aeeTargetEntity>();
        }

        public int? Duration { get; set; }
        public int? Height { get; set; }
        public int Id { get; set; }
        public string Url { get; set; }
        public int? Width { get; set; }

        public ICollection<Ao563aeeActivityEntity> Ao563aeeActivityEntity { get; set; }
        public ICollection<Ao563aeeObjectEntity> Ao563aeeObjectEntity { get; set; }
        public ICollection<Ao563aeeTargetEntity> Ao563aeeTargetEntity { get; set; }
    }
}
