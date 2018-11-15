using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Issuelinktype
    {
        public decimal Id { get; set; }
        public string Linkname { get; set; }
        public string Inward { get; set; }
        public string Outward { get; set; }
        public string Pstyle { get; set; }
    }
}
