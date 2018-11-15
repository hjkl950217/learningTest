using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class DeployKeysProjects
    {
        public int Id { get; set; }
        public int DeployKeyId { get; set; }
        public int ProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool CanPush { get; set; }

        public Projects Project { get; set; }
    }
}
