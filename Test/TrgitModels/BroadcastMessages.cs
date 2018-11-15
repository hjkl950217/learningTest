using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class BroadcastMessages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Color { get; set; }
        public string Font { get; set; }
        public string MessageHtml { get; set; }
        public int? CachedMarkdownVersion { get; set; }
    }
}
