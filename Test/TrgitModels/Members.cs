using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Members
    {
        public int Id { get; set; }
        public int AccessLevel { get; set; }
        public int SourceId { get; set; }
        public string SourceType { get; set; }
        public int? UserId { get; set; }
        public int NotificationLevel { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CreatedById { get; set; }
        public string InviteEmail { get; set; }
        public string InviteToken { get; set; }
        public DateTime? InviteAcceptedAt { get; set; }
        public DateTime? RequestedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }

        public Users User { get; set; }
    }
}
