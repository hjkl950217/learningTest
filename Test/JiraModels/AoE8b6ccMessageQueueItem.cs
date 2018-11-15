using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoE8b6ccMessageQueueItem
    {
        public int Id { get; set; }
        public DateTime? LastFailed { get; set; }
        public int MessageId { get; set; }
        public string Queue { get; set; }
        public int RetriesCount { get; set; }
        public string State { get; set; }
        public string StateInfo { get; set; }
    }
}
