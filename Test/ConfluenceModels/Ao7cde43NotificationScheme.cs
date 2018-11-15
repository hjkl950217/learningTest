using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao7cde43NotificationScheme
    {
        public Ao7cde43NotificationScheme()
        {
            Ao7cde43Notification = new HashSet<Ao7cde43Notification>();
        }

        public string Description { get; set; }
        public int Id { get; set; }
        public string SchemeName { get; set; }

        public ICollection<Ao7cde43Notification> Ao7cde43Notification { get; set; }
    }
}
