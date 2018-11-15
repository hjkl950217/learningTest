using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Issuerankinglog
    {
        public long? CustomFieldId { get; set; }
        public long Id { get; set; }
        public long? IssueId { get; set; }
        public string LogType { get; set; }
        public long? NewNextId { get; set; }
        public long? NewPreviousId { get; set; }
        public long? OldNextId { get; set; }
        public long? OldPreviousId { get; set; }
        public string SanityChecked { get; set; }
    }
}
