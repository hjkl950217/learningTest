using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class OauthAccessGrants
    {
        public OauthAccessGrants()
        {
            OauthOpenidRequests = new HashSet<OauthOpenidRequests>();
        }

        public int Id { get; set; }
        public int ResourceOwnerId { get; set; }
        public int ApplicationId { get; set; }
        public string Token { get; set; }
        public int ExpiresIn { get; set; }
        public string RedirectUri { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? RevokedAt { get; set; }
        public string Scopes { get; set; }

        public ICollection<OauthOpenidRequests> OauthOpenidRequests { get; set; }
    }
}
