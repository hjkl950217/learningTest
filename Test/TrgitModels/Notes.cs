using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Notes
    {
        public Notes()
        {
            Todos = new HashSet<Todos>();
        }

        public int Id { get; set; }
        public string Note { get; set; }
        public string NoteableType { get; set; }
        public int? AuthorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? ProjectId { get; set; }
        public string Attachment { get; set; }
        public string LineCode { get; set; }
        public string CommitId { get; set; }
        public int? NoteableId { get; set; }
        public bool System { get; set; }
        public string StDiff { get; set; }
        public int? UpdatedById { get; set; }
        public string Type { get; set; }
        public string Position { get; set; }
        public string OriginalPosition { get; set; }
        public DateTime? ResolvedAt { get; set; }
        public int? ResolvedById { get; set; }
        public string DiscussionId { get; set; }
        public string NoteHtml { get; set; }
        public int? CachedMarkdownVersion { get; set; }
        public string ChangePosition { get; set; }
        public bool? ResolvedByPush { get; set; }

        public Projects Project { get; set; }
        public SystemNoteMetadata SystemNoteMetadata { get; set; }
        public ICollection<Todos> Todos { get; set; }
    }
}
