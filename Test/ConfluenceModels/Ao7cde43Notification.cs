using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao7cde43Notification
    {
        public Ao7cde43Notification()
        {
            Ao7cde43Event = new HashSet<Ao7cde43Event>();
            Ao7cde43FilterParam = new HashSet<Ao7cde43FilterParam>();
            Ao7cde43Recipient = new HashSet<Ao7cde43Recipient>();
        }

        public int Id { get; set; }
        public int? NotificationSchemeId { get; set; }

        public Ao7cde43NotificationScheme NotificationScheme { get; set; }
        public ICollection<Ao7cde43Event> Ao7cde43Event { get; set; }
        public ICollection<Ao7cde43FilterParam> Ao7cde43FilterParam { get; set; }
        public ICollection<Ao7cde43Recipient> Ao7cde43Recipient { get; set; }
    }
}
