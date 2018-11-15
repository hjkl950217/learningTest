using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdApplicationAddress
    {
        public decimal ApplicationId { get; set; }
        public string RemoteAddress { get; set; }

        public CwdApplication Application { get; set; }
    }
}
