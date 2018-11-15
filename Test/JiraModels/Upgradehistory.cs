using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Upgradehistory
    {
        public decimal? Id { get; set; }
        public string Upgradeclass { get; set; }
        public string Targetbuild { get; set; }
        public string Status { get; set; }
        public string Downgradetaskrequired { get; set; }
    }
}
