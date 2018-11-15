using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Identities
    {
        public int Id { get; set; }
        public string ExternUid { get; set; }
        public string Provider { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
