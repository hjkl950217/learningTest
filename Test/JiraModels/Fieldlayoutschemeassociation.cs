using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Fieldlayoutschemeassociation
    {
        public decimal Id { get; set; }
        public string Issuetype { get; set; }
        public decimal? Project { get; set; }
        public decimal? Fieldlayoutscheme { get; set; }
    }
}
