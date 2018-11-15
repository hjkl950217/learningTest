using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class TrackbackPing
    {
        public decimal Id { get; set; }
        public decimal? Issue { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Blogname { get; set; }
        public string Excerpt { get; set; }
        public DateTime? Created { get; set; }
    }
}
