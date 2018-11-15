using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class CwdDirectory
    {
        public decimal Id { get; set; }
        public string DirectoryName { get; set; }
        public string LowerDirectoryName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Active { get; set; }
        public string Description { get; set; }
        public string ImplClass { get; set; }
        public string LowerImplClass { get; set; }
        public string DirectoryType { get; set; }
        public decimal? DirectoryPosition { get; set; }
    }
}
