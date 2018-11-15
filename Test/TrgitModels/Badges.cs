using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Badges
    {
        public int Id { get; set; }
        public string LinkUrl { get; set; }
        public string ImageUrl { get; set; }
        public int? ProjectId { get; set; }
        public int? GroupId { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Namespaces Group { get; set; }
        public Projects Project { get; set; }
    }
}
