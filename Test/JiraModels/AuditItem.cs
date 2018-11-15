using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AuditItem
    {
        public decimal Id { get; set; }
        public decimal? LogId { get; set; }
        public string ObjectType { get; set; }
        public string ObjectId { get; set; }
        public string ObjectName { get; set; }
        public string ObjectParentId { get; set; }
        public string ObjectParentName { get; set; }
    }
}
