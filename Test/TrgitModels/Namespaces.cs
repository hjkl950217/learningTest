using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Namespaces
    {
        public Namespaces()
        {
            Badges = new HashSet<Badges>();
            Boards = new HashSet<Boards>();
            CiGroupVariables = new HashSet<CiGroupVariables>();
            GroupCustomAttributes = new HashSet<GroupCustomAttributes>();
            Labels = new HashSet<Labels>();
            Milestones = new HashSet<Milestones>();
            ProtectedTagCreateAccessLevels = new HashSet<ProtectedTagCreateAccessLevels>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int? OwnerId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
        public bool? ShareWithGroupLock { get; set; }
        public int VisibilityLevel { get; set; }
        public bool RequestAccessEnabled { get; set; }
        public string DescriptionHtml { get; set; }
        public bool? LfsEnabled { get; set; }
        public int? ParentId { get; set; }
        public bool RequireTwoFactorAuthentication { get; set; }
        public int TwoFactorGracePeriod { get; set; }
        public int? CachedMarkdownVersion { get; set; }

        public ChatTeams ChatTeams { get; set; }
        public ICollection<Badges> Badges { get; set; }
        public ICollection<Boards> Boards { get; set; }
        public ICollection<CiGroupVariables> CiGroupVariables { get; set; }
        public ICollection<GroupCustomAttributes> GroupCustomAttributes { get; set; }
        public ICollection<Labels> Labels { get; set; }
        public ICollection<Milestones> Milestones { get; set; }
        public ICollection<ProtectedTagCreateAccessLevels> ProtectedTagCreateAccessLevels { get; set; }
    }
}
