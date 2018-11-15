using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Notifications
    {
        public decimal Notificationid { get; set; }
        public decimal? Contentid { get; set; }
        public decimal? Labelid { get; set; }
        public decimal? Spaceid { get; set; }
        public string Username { get; set; }
        public string Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Lastmodifier { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public byte? Digest { get; set; }
        public byte? Network { get; set; }
        public string Contenttype { get; set; }

        public Content Content { get; set; }
        public UserMapping CreatorNavigation { get; set; }
        public Label Label { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
        public Spaces Space { get; set; }
        public UserMapping UsernameNavigation { get; set; }
    }
}
