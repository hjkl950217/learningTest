using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Favouriteassociations
    {
        public decimal Id { get; set; }
        public string Username { get; set; }
        public string Entitytype { get; set; }
        public decimal? Entityid { get; set; }
        public decimal? Sequence { get; set; }
    }
}
