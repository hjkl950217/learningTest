using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao5fb9d7AohipChatUser
    {
        public int? HipChatLinkId { get; set; }
        public string HipChatUserId { get; set; }
        public string HipChatUserName { get; set; }
        public int Id { get; set; }
        public string RefreshCode { get; set; }
        public string UserKey { get; set; }
        public string UserScopes { get; set; }
        public string UserToken { get; set; }
        public DateTime? UserTokenExpiry { get; set; }

        public Ao5fb9d7AohipChatLink HipChatLink { get; set; }
    }
}
