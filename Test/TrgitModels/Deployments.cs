using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Deployments
    {
        public int Id { get; set; }
        public int Iid { get; set; }
        public int ProjectId { get; set; }
        public int EnvironmentId { get; set; }
        public string Ref { get; set; }
        public bool Tag { get; set; }
        public string Sha { get; set; }
        public int? UserId { get; set; }
        public int? DeployableId { get; set; }
        public string DeployableType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string OnStop { get; set; }

        public Projects Project { get; set; }
    }
}
