using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Auditrecord
    {
        public Auditrecord()
        {
            AuditAffectedObject = new HashSet<AuditAffectedObject>();
            AuditChangedValue = new HashSet<AuditChangedValue>();
        }

        public decimal Auditrecordid { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Address { get; set; }
        public byte Sysamdin { get; set; }
        public string Authorname { get; set; }
        public string Authorfullname { get; set; }
        public string Authorkey { get; set; }
        public string Objectname { get; set; }
        public string Objecttype { get; set; }
        public string Searchstring { get; set; }
        public decimal Creationdate { get; set; }

        public ICollection<AuditAffectedObject> AuditAffectedObject { get; set; }
        public ICollection<AuditChangedValue> AuditChangedValue { get; set; }
    }
}
