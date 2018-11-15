using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class JquartzBlobTriggers
    {
        public string SchedName { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public byte[] BlobData { get; set; }
    }
}
