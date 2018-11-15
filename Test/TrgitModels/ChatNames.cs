using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ChatNames
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public string TeamId { get; set; }
        public string TeamDomain { get; set; }
        public string ChatId { get; set; }
        public string ChatName { get; set; }
        public DateTime? LastUsedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
