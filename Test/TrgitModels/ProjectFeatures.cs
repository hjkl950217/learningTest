using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProjectFeatures
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? MergeRequestsAccessLevel { get; set; }
        public int? IssuesAccessLevel { get; set; }
        public int? WikiAccessLevel { get; set; }
        public int? SnippetsAccessLevel { get; set; }
        public int? BuildsAccessLevel { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int RepositoryAccessLevel { get; set; }

        public Projects Project { get; set; }
    }
}
