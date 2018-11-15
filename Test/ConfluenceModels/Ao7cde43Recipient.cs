using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao7cde43Recipient
    {
        public int Id { get; set; }
        public bool? Individual { get; set; }
        public int? NotificationId { get; set; }
        public string ParamDisplay { get; set; }
        public string ParamValue { get; set; }
        public int? ServerId { get; set; }
        public string Type { get; set; }

        public Ao7cde43Notification Notification { get; set; }
    }
}
