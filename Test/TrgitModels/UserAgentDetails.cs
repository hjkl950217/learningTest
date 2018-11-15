using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class UserAgentDetails
    {
        public int Id { get; set; }
        public string UserAgent { get; set; }
        public string IpAddress { get; set; }
        public int SubjectId { get; set; }
        public string SubjectType { get; set; }
        public bool Submitted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
