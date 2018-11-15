using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Trustedapp
    {
        public decimal Id { get; set; }
        public string ApplicationId { get; set; }
        public string Name { get; set; }
        public string PublicKey { get; set; }
        public string IpMatch { get; set; }
        public string UrlMatch { get; set; }
        public decimal? Timeout { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
