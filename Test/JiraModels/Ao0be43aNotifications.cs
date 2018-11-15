using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao0be43aNotifications
    {
        public Ao0be43aNotifications()
        {
            Ao0be43aNotificationBody = new HashSet<Ao0be43aNotificationBody>();
        }

        public string Content { get; set; }
        public string FromUser { get; set; }
        public string Icon { get; set; }
        public int Id { get; set; }
        public string Link { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Read { get; set; }
        public string SneakPeak { get; set; }
        public string Summary { get; set; }
        public string ToUser { get; set; }
        public string Type { get; set; }

        public ICollection<Ao0be43aNotificationBody> Ao0be43aNotificationBody { get; set; }
    }
}
