using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao5fb9d7AohipChatLink
    {
        public Ao5fb9d7AohipChatLink()
        {
            Ao5fb9d7AohipChatUser = new HashSet<Ao5fb9d7AohipChatUser>();
        }

        public DateTime? AddonTokenExpiry { get; set; }
        public string ApiUrl { get; set; }
        public string ConnectDescriptor { get; set; }
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public int Id { get; set; }
        public string OauthId { get; set; }
        public string SecretKey { get; set; }
        public string SystemPassword { get; set; }
        public DateTime? SystemTokenExpiry { get; set; }
        public string SystemUser { get; set; }
        public string SystemUserToken { get; set; }
        public string Token { get; set; }

        public ICollection<Ao5fb9d7AohipChatUser> Ao5fb9d7AohipChatUser { get; set; }
    }
}
