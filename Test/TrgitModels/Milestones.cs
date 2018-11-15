using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Milestones
    {
        public Milestones()
        {
            Issues = new HashSet<Issues>();
            MergeRequests = new HashSet<MergeRequests>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? ProjectId { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string State { get; set; }
        public int? Iid { get; set; }
        public string TitleHtml { get; set; }
        public string DescriptionHtml { get; set; }
        public DateTime? StartDate { get; set; }
        public int? CachedMarkdownVersion { get; set; }
        public int? GroupId { get; set; }

        public Namespaces Group { get; set; }
        public Projects Project { get; set; }
        public ICollection<Issues> Issues { get; set; }
        public ICollection<MergeRequests> MergeRequests { get; set; }
    }
}
