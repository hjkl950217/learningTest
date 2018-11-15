using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Oauthconsumer
    {
        public decimal Id { get; set; }
        public DateTime? Created { get; set; }
        public string Consumername { get; set; }
        public string ConsumerKey { get; set; }
        public string Consumerservice { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public string Description { get; set; }
        public string Callback { get; set; }
        public string SignatureMethod { get; set; }
        public string SharedSecret { get; set; }
    }
}
