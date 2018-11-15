using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class LfsFileLocks
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Path { get; set; }

        public Projects Project { get; set; }
        public Users User { get; set; }
    }
}
