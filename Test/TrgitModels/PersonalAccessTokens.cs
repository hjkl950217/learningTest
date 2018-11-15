using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class PersonalAccessTokens
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public bool? Revoked { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Scopes { get; set; }
        public bool Impersonation { get; set; }

        public Users User { get; set; }
    }
}
