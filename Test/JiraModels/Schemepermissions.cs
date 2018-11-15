using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Schemepermissions
    {
        public decimal Id { get; set; }
        public decimal? Scheme { get; set; }
        public decimal? Permission { get; set; }
        public string PermType { get; set; }
        public string PermParameter { get; set; }
        public string PermissionKey { get; set; }
    }
}
