using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiTriggerRequests
    {
        public int Id { get; set; }
        public int TriggerId { get; set; }
        public string Variables { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CommitId { get; set; }

        public CiTriggers Trigger { get; set; }
    }
}
