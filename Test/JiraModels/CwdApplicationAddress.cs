using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class CwdApplicationAddress
    {
        public decimal ApplicationId { get; set; }
        public string RemoteAddress { get; set; }
        public string EncodedAddressBinary { get; set; }
        public int? RemoteAddressMask { get; set; }
    }
}
