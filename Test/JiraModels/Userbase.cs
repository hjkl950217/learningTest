using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Userbase
    {
        public decimal Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
