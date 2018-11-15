using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class OauthOpenidRequests
    {
        public int Id { get; set; }
        public int AccessGrantId { get; set; }
        public string Nonce { get; set; }

        public OauthAccessGrants AccessGrant { get; set; }
    }
}
