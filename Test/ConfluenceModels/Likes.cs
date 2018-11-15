using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Likes
    {
        public decimal Id { get; set; }
        public decimal Contentid { get; set; }
        public string Username { get; set; }
        public DateTime Creationdate { get; set; }

        public Content Content { get; set; }
        public UserMapping UsernameNavigation { get; set; }
    }
}
