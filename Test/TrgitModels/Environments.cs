using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Environments
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string ExternalUrl { get; set; }
        public string EnvironmentType { get; set; }
        public string State { get; set; }
        public string Slug { get; set; }

        public Projects Project { get; set; }
    }
}
