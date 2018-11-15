using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Searchrequest
    {
        public decimal Id { get; set; }
        public string Filtername { get; set; }
        public string Authorname { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string Groupname { get; set; }
        public decimal? Projectid { get; set; }
        public string Reqcontent { get; set; }
        public decimal? FavCount { get; set; }
        public string FilternameLower { get; set; }
    }
}
