using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiTriggers
    {
        public CiTriggers()
        {
            CiTriggerRequests = new HashSet<CiTriggerRequests>();
        }

        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? ProjectId { get; set; }
        public int? OwnerId { get; set; }
        public string Description { get; set; }
        public string Ref { get; set; }

        public Users Owner { get; set; }
        public Projects Project { get; set; }
        public ICollection<CiTriggerRequests> CiTriggerRequests { get; set; }
    }
}
