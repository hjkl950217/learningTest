using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Snippets
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public int VisibilityLevel { get; set; }
        public string TitleHtml { get; set; }
        public string ContentHtml { get; set; }
        public int? CachedMarkdownVersion { get; set; }
        public string Description { get; set; }
        public string DescriptionHtml { get; set; }

        public Projects Project { get; set; }
    }
}
