using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Schemeissuesecurities
    {
        public decimal Id { get; set; }
        public decimal? Scheme { get; set; }
        public decimal? Security { get; set; }
        public string SecType { get; set; }
        public string SecParameter { get; set; }
    }
}
