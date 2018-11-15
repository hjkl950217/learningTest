using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class UserMapping
    {
        public UserMapping()
        {
            ContentCreatorNavigation = new HashSet<Content>();
            ContentLabel = new HashSet<ContentLabel>();
            ContentLastmodifierNavigation = new HashSet<Content>();
            ContentPermCreatorNavigation = new HashSet<ContentPerm>();
            ContentPermLastmodifierNavigation = new HashSet<ContentPerm>();
            ContentPermUsernameNavigation = new HashSet<ContentPerm>();
            ContentRelationCreatorNavigation = new HashSet<ContentRelation>();
            ContentRelationLastmodifierNavigation = new HashSet<ContentRelation>();
            ContentUsernameNavigation = new HashSet<Content>();
            ExtrnlnksCreatorNavigation = new HashSet<Extrnlnks>();
            ExtrnlnksLastmodifierNavigation = new HashSet<Extrnlnks>();
            FollowConnectionsFolloweeNavigation = new HashSet<FollowConnections>();
            FollowConnectionsFollowerNavigation = new HashSet<FollowConnections>();
            Label = new HashSet<Label>();
            Likes = new HashSet<Likes>();
            LinksCreatorNavigation = new HashSet<Links>();
            LinksLastmodifierNavigation = new HashSet<Links>();
            NotificationsCreatorNavigation = new HashSet<Notifications>();
            NotificationsLastmodifierNavigation = new HashSet<Notifications>();
            NotificationsUsernameNavigation = new HashSet<Notifications>();
            PagetemplatesCreatorNavigation = new HashSet<Pagetemplates>();
            PagetemplatesLastmodifierNavigation = new HashSet<Pagetemplates>();
            SpacepermissionsCreatorNavigation = new HashSet<Spacepermissions>();
            SpacepermissionsLastmodifierNavigation = new HashSet<Spacepermissions>();
            SpacepermissionsPermusernameNavigation = new HashSet<Spacepermissions>();
            SpacesCreatorNavigation = new HashSet<Spaces>();
            SpacesLastmodifierNavigation = new HashSet<Spaces>();
            TrackbacklinksCreatorNavigation = new HashSet<Trackbacklinks>();
            TrackbacklinksLastmodifierNavigation = new HashSet<Trackbacklinks>();
            UserRelationCreatorNavigation = new HashSet<UserRelation>();
            UserRelationLastmodifierNavigation = new HashSet<UserRelation>();
            UserRelationSourceuserNavigation = new HashSet<UserRelation>();
            UserRelationTargetuserNavigation = new HashSet<UserRelation>();
            UsercontentRelationCreatorNavigation = new HashSet<UsercontentRelation>();
            UsercontentRelationLastmodifierNavigation = new HashSet<UsercontentRelation>();
            UsercontentRelationSourceuserNavigation = new HashSet<UsercontentRelation>();
        }

        public string UserKey { get; set; }
        public string Username { get; set; }
        public string LowerUsername { get; set; }

        public Logininfo Logininfo { get; set; }
        public ICollection<Content> ContentCreatorNavigation { get; set; }
        public ICollection<ContentLabel> ContentLabel { get; set; }
        public ICollection<Content> ContentLastmodifierNavigation { get; set; }
        public ICollection<ContentPerm> ContentPermCreatorNavigation { get; set; }
        public ICollection<ContentPerm> ContentPermLastmodifierNavigation { get; set; }
        public ICollection<ContentPerm> ContentPermUsernameNavigation { get; set; }
        public ICollection<ContentRelation> ContentRelationCreatorNavigation { get; set; }
        public ICollection<ContentRelation> ContentRelationLastmodifierNavigation { get; set; }
        public ICollection<Content> ContentUsernameNavigation { get; set; }
        public ICollection<Extrnlnks> ExtrnlnksCreatorNavigation { get; set; }
        public ICollection<Extrnlnks> ExtrnlnksLastmodifierNavigation { get; set; }
        public ICollection<FollowConnections> FollowConnectionsFolloweeNavigation { get; set; }
        public ICollection<FollowConnections> FollowConnectionsFollowerNavigation { get; set; }
        public ICollection<Label> Label { get; set; }
        public ICollection<Likes> Likes { get; set; }
        public ICollection<Links> LinksCreatorNavigation { get; set; }
        public ICollection<Links> LinksLastmodifierNavigation { get; set; }
        public ICollection<Notifications> NotificationsCreatorNavigation { get; set; }
        public ICollection<Notifications> NotificationsLastmodifierNavigation { get; set; }
        public ICollection<Notifications> NotificationsUsernameNavigation { get; set; }
        public ICollection<Pagetemplates> PagetemplatesCreatorNavigation { get; set; }
        public ICollection<Pagetemplates> PagetemplatesLastmodifierNavigation { get; set; }
        public ICollection<Spacepermissions> SpacepermissionsCreatorNavigation { get; set; }
        public ICollection<Spacepermissions> SpacepermissionsLastmodifierNavigation { get; set; }
        public ICollection<Spacepermissions> SpacepermissionsPermusernameNavigation { get; set; }
        public ICollection<Spaces> SpacesCreatorNavigation { get; set; }
        public ICollection<Spaces> SpacesLastmodifierNavigation { get; set; }
        public ICollection<Trackbacklinks> TrackbacklinksCreatorNavigation { get; set; }
        public ICollection<Trackbacklinks> TrackbacklinksLastmodifierNavigation { get; set; }
        public ICollection<UserRelation> UserRelationCreatorNavigation { get; set; }
        public ICollection<UserRelation> UserRelationLastmodifierNavigation { get; set; }
        public ICollection<UserRelation> UserRelationSourceuserNavigation { get; set; }
        public ICollection<UserRelation> UserRelationTargetuserNavigation { get; set; }
        public ICollection<UsercontentRelation> UsercontentRelationCreatorNavigation { get; set; }
        public ICollection<UsercontentRelation> UsercontentRelationLastmodifierNavigation { get; set; }
        public ICollection<UsercontentRelation> UsercontentRelationSourceuserNavigation { get; set; }
    }
}
