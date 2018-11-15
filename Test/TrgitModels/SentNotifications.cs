using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class SentNotifications
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? NoteableId { get; set; }
        public string NoteableType { get; set; }
        public int? RecipientId { get; set; }
        public string CommitId { get; set; }
        public string ReplyKey { get; set; }
        public string LineCode { get; set; }
        public string NoteType { get; set; }
        public string Position { get; set; }
        public string InReplyToDiscussionId { get; set; }
    }
}
