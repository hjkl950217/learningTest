using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Oauthconsumertoken
    {
        public decimal Id { get; set; }
        public DateTime? Created { get; set; }
        public string TokenKey { get; set; }
        public string Token { get; set; }
        public string TokenSecret { get; set; }
        public string TokenType { get; set; }
        public string ConsumerKey { get; set; }
    }
}
