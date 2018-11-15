using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Userhistoryitem
    {
        public decimal Id { get; set; }
        public string Entitytype { get; set; }
        public string Entityid { get; set; }
        public string Username { get; set; }
        public decimal? Lastviewed { get; set; }
        public string Data { get; set; }
    }
}
