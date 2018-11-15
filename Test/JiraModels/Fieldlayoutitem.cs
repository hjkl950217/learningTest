using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Fieldlayoutitem
    {
        public decimal Id { get; set; }
        public decimal? Fieldlayout { get; set; }
        public string Fieldidentifier { get; set; }
        public string Description { get; set; }
        public decimal? Verticalposition { get; set; }
        public string Ishidden { get; set; }
        public string Isrequired { get; set; }
        public string Renderertype { get; set; }
    }
}
