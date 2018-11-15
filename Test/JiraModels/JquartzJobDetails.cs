using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class JquartzJobDetails
    {
        public string SchedName { get; set; }
        public string JobName { get; set; }
        public string JobGroup { get; set; }
        public string Description { get; set; }
        public string JobClassName { get; set; }
        public string IsDurable { get; set; }
        public string IsVolatile { get; set; }
        public string IsStateful { get; set; }
        public string IsNonconcurrent { get; set; }
        public string IsUpdateData { get; set; }
        public string RequestsRecovery { get; set; }
        public byte[] JobData { get; set; }
    }
}
