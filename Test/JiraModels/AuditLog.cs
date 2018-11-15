using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AuditLog
    {
        public decimal Id { get; set; }
        public string RemoteAddress { get; set; }
        public DateTime? Created { get; set; }
        public string AuthorKey { get; set; }
        public string Summary { get; set; }
        public string Category { get; set; }
        public string ObjectType { get; set; }
        public string ObjectId { get; set; }
        public string ObjectName { get; set; }
        public string ObjectParentId { get; set; }
        public string ObjectParentName { get; set; }
        public int? AuthorType { get; set; }
        public string EventSourceName { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string SearchField { get; set; }
    }
}
