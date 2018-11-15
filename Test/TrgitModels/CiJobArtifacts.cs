using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class CiJobArtifacts
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int JobId { get; set; }
        public int FileType { get; set; }
        public long? Size { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? ExpireAt { get; set; }
        public string File { get; set; }
        public byte[] FileSha256 { get; set; }

        public CiBuilds Job { get; set; }
        public Projects Project { get; set; }
    }
}
