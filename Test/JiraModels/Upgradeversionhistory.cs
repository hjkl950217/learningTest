using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Upgradeversionhistory
    {
        public decimal? Id { get; set; }
        public DateTime? Timeperformed { get; set; }
        public string Targetbuild { get; set; }
        public string Targetversion { get; set; }
    }
}
