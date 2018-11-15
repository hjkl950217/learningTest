using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao4aeacdWebhookDao
    {
        public bool? Enabled { get; set; }
        public string EncodedEvents { get; set; }
        public string Filter { get; set; }
        public int Id { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedUser { get; set; }
        public string Name { get; set; }
        public string RegistrationMethod { get; set; }
        public string Url { get; set; }
        public bool? ExcludeIssueDetails { get; set; }
        public string Parameters { get; set; }
    }
}
