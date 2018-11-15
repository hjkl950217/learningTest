using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class OsPropertyentry
    {
        public string EntityName { get; set; }
        public decimal EntityId { get; set; }
        public string EntityKey { get; set; }
        public int? KeyType { get; set; }
        public byte? BooleanVal { get; set; }
        public double? DoubleVal { get; set; }
        public string StringVal { get; set; }
        public string TextVal { get; set; }
        public decimal? LongVal { get; set; }
        public int? IntVal { get; set; }
        public DateTime? DateVal { get; set; }
    }
}
