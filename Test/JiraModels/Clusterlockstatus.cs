using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Clusterlockstatus
    {
        public decimal Id { get; set; }
        public string LockName { get; set; }
        public string LockedByNode { get; set; }
        public decimal? UpdateTime { get; set; }
    }
}
