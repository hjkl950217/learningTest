using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class OauthAccessTokens
    {
        public int Id { get; set; }
        public int? ResourceOwnerId { get; set; }
        public int? ApplicationId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public int? ExpiresIn { get; set; }
        public DateTime? RevokedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Scopes { get; set; }
    }
}
