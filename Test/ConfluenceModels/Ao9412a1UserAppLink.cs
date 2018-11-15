using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao9412a1UserAppLink
    {
        public string ApplicationLinkId { get; set; }
        public bool? AuthVerified { get; set; }
        public DateTime? Created { get; set; }
        public long Id { get; set; }
        public DateTime? Updated { get; set; }
        public long? UserId { get; set; }

        public Ao9412a1Aouser User { get; set; }
    }
}
