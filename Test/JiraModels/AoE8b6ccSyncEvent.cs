using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AoE8b6ccSyncEvent
    {
        public string EventClass { get; set; }
        public DateTime EventDate { get; set; }
        public string EventJson { get; set; }
        public int Id { get; set; }
        public int RepoId { get; set; }
        public bool? ScheduledSync { get; set; }
    }
}
