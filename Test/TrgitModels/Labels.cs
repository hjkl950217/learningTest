using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Labels
    {
        public Labels()
        {
            LabelPriorities = new HashSet<LabelPriorities>();
            Lists = new HashSet<Lists>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? Template { get; set; }
        public string Description { get; set; }
        public string DescriptionHtml { get; set; }
        public string Type { get; set; }
        public int? GroupId { get; set; }
        public int? CachedMarkdownVersion { get; set; }

        public Namespaces Group { get; set; }
        public Projects Project { get; set; }
        public ICollection<LabelPriorities> LabelPriorities { get; set; }
        public ICollection<Lists> Lists { get; set; }
    }
}
