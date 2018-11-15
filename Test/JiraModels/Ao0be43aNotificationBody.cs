using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao0be43aNotificationBody
    {
        public string Body { get; set; }
        public int Id { get; set; }
        public int? NotificationId { get; set; }

        public Ao0be43aNotifications Notification { get; set; }
    }
}
