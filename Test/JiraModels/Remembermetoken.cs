using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Remembermetoken
    {
        public decimal Id { get; set; }
        public DateTime? Created { get; set; }
        public string Token { get; set; }
        public string Username { get; set; }
    }
}
