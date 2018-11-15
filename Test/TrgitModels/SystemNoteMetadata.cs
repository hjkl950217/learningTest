using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class SystemNoteMetadata
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public int? CommitCount { get; set; }
        public string Action { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Notes Note { get; set; }
    }
}
