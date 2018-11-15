using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class AuditEvents
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Type { get; set; }
        public int EntityId { get; set; }
        public string EntityType { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
