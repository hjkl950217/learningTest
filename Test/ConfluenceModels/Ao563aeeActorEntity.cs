using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao563aeeActorEntity
    {
        public Ao563aeeActorEntity()
        {
            Ao563aeeActivityEntity = new HashSet<Ao563aeeActivityEntity>();
        }

        public string FullName { get; set; }
        public int Id { get; set; }
        public string ProfilePageUri { get; set; }
        public string ProfilePictureUri { get; set; }
        public string Username { get; set; }

        public ICollection<Ao563aeeActivityEntity> Ao563aeeActivityEntity { get; set; }
    }
}
