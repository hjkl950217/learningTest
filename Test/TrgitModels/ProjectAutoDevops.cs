using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProjectAutoDevops
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Enabled { get; set; }
        public string Domain { get; set; }

        public Projects Project { get; set; }
    }
}
