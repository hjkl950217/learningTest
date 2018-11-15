using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Upgradetaskhistoryauditlog
    {
        public decimal Id { get; set; }
        public string UpgradeTaskFactoryKey { get; set; }
        public int? BuildNumber { get; set; }
        public string Status { get; set; }
        public string UpgradeType { get; set; }
        public DateTime? Timeperformed { get; set; }
        public string Action { get; set; }
    }
}
