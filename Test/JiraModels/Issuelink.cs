using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Issuelink
    {
        public decimal Id { get; set; }
        public decimal? Linktype { get; set; }
        public decimal? Source { get; set; }
        public decimal? Destination { get; set; }
        public decimal? Sequence { get; set; }
    }
}
