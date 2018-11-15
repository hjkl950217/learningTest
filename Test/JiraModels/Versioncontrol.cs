using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Versioncontrol
    {
        public decimal Id { get; set; }
        public string Vcsname { get; set; }
        public string Vcsdescription { get; set; }
        public string Vcstype { get; set; }
    }
}
