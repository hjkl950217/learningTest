using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Fileattachment
    {
        public decimal Id { get; set; }
        public decimal? Issueid { get; set; }
        public string Mimetype { get; set; }
        public string Filename { get; set; }
        public DateTime? Created { get; set; }
        public decimal? Filesize { get; set; }
        public string Author { get; set; }
        public int? Zip { get; set; }
        public int? Thumbnailable { get; set; }
    }
}
