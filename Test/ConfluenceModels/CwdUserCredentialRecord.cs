using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdUserCredentialRecord
    {
        public decimal Id { get; set; }
        public decimal? UserId { get; set; }
        public string PasswordHash { get; set; }
        public int? ListIndex { get; set; }

        public CwdUser User { get; set; }
    }
}
