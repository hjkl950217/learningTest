using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao7cde43Event
    {
        public string EventKey { get; set; }
        public int Id { get; set; }
        public int? NotificationId { get; set; }

        public Ao7cde43Notification Notification { get; set; }
    }
}
