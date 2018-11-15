using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Fieldconfigscheme
    {
        public decimal Id { get; set; }
        public string Configname { get; set; }
        public string Description { get; set; }
        public string Fieldid { get; set; }
        public decimal? Customfield { get; set; }
    }
}
