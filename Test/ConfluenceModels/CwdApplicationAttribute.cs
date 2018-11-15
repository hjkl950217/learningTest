using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class CwdApplicationAttribute
    {
        public decimal ApplicationId { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeName { get; set; }

        public CwdApplication Application { get; set; }
    }
}
