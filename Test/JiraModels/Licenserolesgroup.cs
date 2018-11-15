using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Licenserolesgroup
    {
        public decimal Id { get; set; }
        public string LicenseRoleName { get; set; }
        public string GroupId { get; set; }
        public string PrimaryGroup { get; set; }
    }
}
