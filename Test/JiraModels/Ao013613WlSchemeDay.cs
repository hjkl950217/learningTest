using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao013613WlSchemeDay
    {
        public int? Day { get; set; }
        public int Id { get; set; }
        public long? RequiredSeconds { get; set; }
        public int? WorkloadSchemeId { get; set; }

        public Ao013613WlScheme WorkloadScheme { get; set; }
    }
}
