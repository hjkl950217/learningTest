using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProjectCustomAttributes
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int ProjectId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public Projects Project { get; set; }
    }
}
