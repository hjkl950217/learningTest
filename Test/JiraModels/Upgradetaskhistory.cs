using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Upgradetaskhistory
    {
        public decimal Id { get; set; }
        public string UpgradeTaskFactoryKey { get; set; }
        public int? BuildNumber { get; set; }
        public string Status { get; set; }
        public string UpgradeType { get; set; }
    }
}
