using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Todos
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int? TargetId { get; set; }
        public string TargetType { get; set; }
        public int AuthorId { get; set; }
        public int Action { get; set; }
        public string State { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? NoteId { get; set; }
        public string CommitId { get; set; }

        public Users Author { get; set; }
        public Notes Note { get; set; }
        public Projects Project { get; set; }
        public Users User { get; set; }
    }
}
