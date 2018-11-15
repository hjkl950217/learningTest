using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class LfsObjectsProjects
    {
        public int Id { get; set; }
        public int LfsObjectId { get; set; }
        public int ProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
