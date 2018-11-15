using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Oauthsptoken
    {
        public decimal Id { get; set; }
        public DateTime? Created { get; set; }
        public string Token { get; set; }
        public string TokenSecret { get; set; }
        public string TokenType { get; set; }
        public string ConsumerKey { get; set; }
        public string Username { get; set; }
        public decimal? Ttl { get; set; }
        public string Spauth { get; set; }
        public string Callback { get; set; }
        public string Spverifier { get; set; }
        public string Spversion { get; set; }
        public string SessionHandle { get; set; }
        public DateTime? SessionCreationTime { get; set; }
        public DateTime? SessionLastRenewalTime { get; set; }
        public DateTime? SessionTimeToLive { get; set; }
    }
}
