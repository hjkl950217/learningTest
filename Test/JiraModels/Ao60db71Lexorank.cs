using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Lexorank
    {
        public long FieldId { get; set; }
        public long Id { get; set; }
        public long IssueId { get; set; }
        public string LockHash { get; set; }
        public long? LockTime { get; set; }
        public string Rank { get; set; }
        public int Type { get; set; }
        public int? Bucket { get; set; }
    }
}
