using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao2f1435ReadNotifications
    {
        public int Id { get; set; }
        public bool? IsSnoozed { get; set; }
        public int NotificationId { get; set; }
        public int? SnoozeCount { get; set; }
        public DateTime? SnoozeDate { get; set; }
        public string UserKey { get; set; }
    }
}
