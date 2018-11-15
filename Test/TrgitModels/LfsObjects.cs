using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class LfsObjects
    {
        public int Id { get; set; }
        public string Oid { get; set; }
        public long Size { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string File { get; set; }
    }
}
