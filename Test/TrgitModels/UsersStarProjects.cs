using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class UsersStarProjects
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Projects Project { get; set; }
    }
}
