using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class AuditAffectedObject
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal? Auditrecordid { get; set; }

        public Auditrecord Auditrecord { get; set; }
    }
}
