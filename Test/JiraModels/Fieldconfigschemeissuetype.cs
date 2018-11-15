using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Fieldconfigschemeissuetype
    {
        public decimal Id { get; set; }
        public string Issuetype { get; set; }
        public decimal? Fieldconfigscheme { get; set; }
        public decimal? Fieldconfiguration { get; set; }
    }
}
