using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Configurationcontext
    {
        public decimal Id { get; set; }
        public decimal? Projectcategory { get; set; }
        public decimal? Project { get; set; }
        public string Customfield { get; set; }
        public decimal? Fieldconfigscheme { get; set; }
    }
}
