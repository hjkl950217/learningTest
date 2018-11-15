using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao7cde43ServerParam
    {
        public int Id { get; set; }
        public string ParamKey { get; set; }
        public string ParamValue { get; set; }
        public int? ServerConfigId { get; set; }

        public Ao7cde43ServerConfig ServerConfig { get; set; }
    }
}
