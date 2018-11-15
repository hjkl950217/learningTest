using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Issuetypescreenschemeentity
    {
        public decimal Id { get; set; }
        public string Issuetype { get; set; }
        public decimal? Scheme { get; set; }
        public decimal? Fieldscreenscheme { get; set; }
    }
}
