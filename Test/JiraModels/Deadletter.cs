using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Deadletter
    {
        public decimal Id { get; set; }
        public string MessageId { get; set; }
        public decimal? LastSeen { get; set; }
        public decimal? MailServerId { get; set; }
        public string FolderName { get; set; }
    }
}
