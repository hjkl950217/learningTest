using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Portalpage
    {
        public decimal Id { get; set; }
        public string Username { get; set; }
        public string Pagename { get; set; }
        public string Description { get; set; }
        public decimal? Sequence { get; set; }
        public decimal? FavCount { get; set; }
        public string Layout { get; set; }
        public decimal? Ppversion { get; set; }
    }
}
