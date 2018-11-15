using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Fieldlayout
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LayoutType { get; set; }
        public decimal? Layoutscheme { get; set; }
    }
}
