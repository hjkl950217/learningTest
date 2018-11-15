using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class OsWfentry
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public int? Initialized { get; set; }
        public int? State { get; set; }
    }
}
