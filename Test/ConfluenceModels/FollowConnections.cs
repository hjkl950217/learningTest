using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class FollowConnections
    {
        public decimal Connectionid { get; set; }
        public string Follower { get; set; }
        public string Followee { get; set; }

        public UserMapping FolloweeNavigation { get; set; }
        public UserMapping FollowerNavigation { get; set; }
    }
}
