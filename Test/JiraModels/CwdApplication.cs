using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class CwdApplication
    {
        public decimal Id { get; set; }
        public string ApplicationName { get; set; }
        public string LowerApplicationName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Active { get; set; }
        public string Description { get; set; }
        public string ApplicationType { get; set; }
        public string Credential { get; set; }
    }
}
