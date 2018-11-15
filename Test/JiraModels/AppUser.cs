using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class AppUser
    {
        public decimal Id { get; set; }
        public string UserKey { get; set; }
        public string LowerUserName { get; set; }
    }
}
