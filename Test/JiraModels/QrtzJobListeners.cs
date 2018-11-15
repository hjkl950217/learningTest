using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class QrtzJobListeners
    {
        public decimal Id { get; set; }
        public decimal? Job { get; set; }
        public string JobListener { get; set; }
    }
}
