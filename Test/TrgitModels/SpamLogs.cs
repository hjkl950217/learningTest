using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class SpamLogs
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string SourceIp { get; set; }
        public string UserAgent { get; set; }
        public bool? ViaApi { get; set; }
        public string NoteableType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool SubmittedAsHam { get; set; }
        public bool RecaptchaVerified { get; set; }
    }
}
