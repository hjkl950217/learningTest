using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Uploads
    {
        public int Id { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public string Checksum { get; set; }
        public int? ModelId { get; set; }
        public string ModelType { get; set; }
        public string Uploader { get; set; }
        public DateTime CreatedAt { get; set; }
        public string MountPoint { get; set; }
        public string Secret { get; set; }
    }
}
