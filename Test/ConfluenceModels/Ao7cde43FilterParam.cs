using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao7cde43FilterParam
    {
        public int Id { get; set; }
        public int? NotificationId { get; set; }
        public string ParamKey { get; set; }
        public string ParamValue { get; set; }

        public Ao7cde43Notification Notification { get; set; }
    }
}
