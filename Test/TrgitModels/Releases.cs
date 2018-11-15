using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Releases
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string DescriptionHtml { get; set; }
        public int? CachedMarkdownVersion { get; set; }

        public Projects Project { get; set; }
    }
}
