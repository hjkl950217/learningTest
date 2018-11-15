using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Sharepermissions
    {
        public decimal Id { get; set; }
        public decimal? Entityid { get; set; }
        public string Entitytype { get; set; }
        public string Sharetype { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
    }
}
