using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao587b34GlanceConfig
    {
        public long RoomId { get; set; }
        public string State { get; set; }
        public bool? SyncNeeded { get; set; }
        public string ApplicationUserKey { get; set; }
        public string Jql { get; set; }
        public string Name { get; set; }
    }
}
