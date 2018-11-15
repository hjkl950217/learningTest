using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Logininfo
    {
        public decimal Id { get; set; }
        public int? Curfailed { get; set; }
        public int? Totalfailed { get; set; }
        public DateTime? Successdate { get; set; }
        public DateTime? Prevsuccessdate { get; set; }
        public DateTime? Faileddate { get; set; }
        public string Username { get; set; }

        public UserMapping UsernameNavigation { get; set; }
    }
}
