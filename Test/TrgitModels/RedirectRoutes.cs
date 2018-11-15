using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class RedirectRoutes
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public string SourceType { get; set; }
        public string Path { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Permanent { get; set; }
    }
}
