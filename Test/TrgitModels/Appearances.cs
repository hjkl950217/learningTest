using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Appearances
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string HeaderLogo { get; set; }
        public string Logo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string DescriptionHtml { get; set; }
        public int? CachedMarkdownVersion { get; set; }
        public string NewProjectGuidelines { get; set; }
        public string NewProjectGuidelinesHtml { get; set; }
    }
}
