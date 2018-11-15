using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao9412a1Aouser
    {
        public Ao9412a1Aouser()
        {
            Ao9412a1UserAppLink = new HashSet<Ao9412a1UserAppLink>();
        }

        public DateTime? Created { get; set; }
        public long Id { get; set; }
        public long? LastReadNotificationId { get; set; }
        public string TaskOrdering { get; set; }
        public DateTime? Updated { get; set; }
        public string Username { get; set; }

        public ICollection<Ao9412a1UserAppLink> Ao9412a1UserAppLink { get; set; }
    }
}
