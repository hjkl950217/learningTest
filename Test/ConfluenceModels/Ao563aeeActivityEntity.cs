using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao563aeeActivityEntity
    {
        public long ActivityId { get; set; }
        public int? ActorId { get; set; }
        public string Content { get; set; }
        public string GeneratorDisplayName { get; set; }
        public string GeneratorId { get; set; }
        public int? IconId { get; set; }
        public string Id { get; set; }
        public string IssueKey { get; set; }
        public int? ObjectId { get; set; }
        public string Poster { get; set; }
        public string ProjectKey { get; set; }
        public DateTime? Published { get; set; }
        public int? TargetId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string Verb { get; set; }

        public Ao563aeeActorEntity Actor { get; set; }
        public Ao563aeeMediaLinkEntity Icon { get; set; }
        public Ao563aeeObjectEntity Object { get; set; }
        public Ao563aeeTargetEntity Target { get; set; }
    }
}
