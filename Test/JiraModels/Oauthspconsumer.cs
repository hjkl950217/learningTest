using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Oauthspconsumer
    {
        public decimal Id { get; set; }
        public DateTime? Created { get; set; }
        public string ConsumerKey { get; set; }
        public string Consumername { get; set; }
        public string PublicKey { get; set; }
        public string Description { get; set; }
        public string Callback { get; set; }
        public string TwoLOAllowed { get; set; }
        public string TwoLOImpersonationAllowed { get; set; }
        public string ThreeLOAllowed { get; set; }
        public string ExecutingTwoLOUser { get; set; }
    }
}
