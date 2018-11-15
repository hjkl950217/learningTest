using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class QrtzJobDetails
    {
        public decimal Id { get; set; }
        public string JobName { get; set; }
        public string JobGroup { get; set; }
        public string ClassName { get; set; }
        public string IsDurable { get; set; }
        public string IsStateful { get; set; }
        public string RequestsRecovery { get; set; }
        public string JobData { get; set; }
    }
}
