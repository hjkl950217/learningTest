using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class AuditChangedValue
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Oldvalue { get; set; }
        public string Newvalue { get; set; }
        public decimal? Auditrecordid { get; set; }

        public Auditrecord Auditrecord { get; set; }
    }
}
