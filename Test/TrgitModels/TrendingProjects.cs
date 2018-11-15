using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class TrendingProjects
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }

        public Projects Project { get; set; }
    }
}
