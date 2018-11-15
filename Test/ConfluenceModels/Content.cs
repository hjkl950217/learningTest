using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Content
    {
        public Content()
        {
            Bodycontent = new HashSet<Bodycontent>();
            ConfancestorsAncestor = new HashSet<Confancestors>();
            ConfancestorsDescendent = new HashSet<Confancestors>();
            ContentLabel = new HashSet<ContentLabel>();
            ContentPermSet = new HashSet<ContentPermSet>();
            ContentRelationSourcecontent = new HashSet<ContentRelation>();
            ContentRelationTargetcontent = new HashSet<ContentRelation>();
            Contentproperties = new HashSet<Contentproperties>();
            Extrnlnks = new HashSet<Extrnlnks>();
            InversePage = new HashSet<Content>();
            InverseParent = new HashSet<Content>();
            InverseParentcc = new HashSet<Content>();
            InverseParentcomment = new HashSet<Content>();
            InversePrevverNavigation = new HashSet<Content>();
            Likes = new HashSet<Likes>();
            Links = new HashSet<Links>();
            Notifications = new HashSet<Notifications>();
            SpacesHomepageNavigation = new HashSet<Spaces>();
            SpacesSpacedesc = new HashSet<Spaces>();
            Trackbacklinks = new HashSet<Trackbacklinks>();
            UsercontentRelation = new HashSet<UsercontentRelation>();
        }

        public decimal Contentid { get; set; }
        public string Contenttype { get; set; }
        public string Title { get; set; }
        public int? Version { get; set; }
        public string Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Lastmodifier { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public string Versioncomment { get; set; }
        public decimal? Prevver { get; set; }
        public string ContentStatus { get; set; }
        public decimal? Spaceid { get; set; }
        public int? ChildPosition { get; set; }
        public decimal? Parentid { get; set; }
        public string Messageid { get; set; }
        public string Pluginkey { get; set; }
        public string Pluginver { get; set; }
        public decimal? Parentccid { get; set; }
        public decimal? Pageid { get; set; }
        public string Draftpageid { get; set; }
        public string Draftspacekey { get; set; }
        public string Drafttype { get; set; }
        public int? Draftpageversion { get; set; }
        public decimal? Parentcommentid { get; set; }
        public string Username { get; set; }
        public int Hibernateversion { get; set; }
        public string Lowertitle { get; set; }

        public UserMapping CreatorNavigation { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
        public Content Page { get; set; }
        public Content Parent { get; set; }
        public Content Parentcc { get; set; }
        public Content Parentcomment { get; set; }
        public Content PrevverNavigation { get; set; }
        public Spaces Space { get; set; }
        public UserMapping UsernameNavigation { get; set; }
        public Attachmentdata Attachmentdata { get; set; }
        public Imagedetails Imagedetails { get; set; }
        public ICollection<Bodycontent> Bodycontent { get; set; }
        public ICollection<Confancestors> ConfancestorsAncestor { get; set; }
        public ICollection<Confancestors> ConfancestorsDescendent { get; set; }
        public ICollection<ContentLabel> ContentLabel { get; set; }
        public ICollection<ContentPermSet> ContentPermSet { get; set; }
        public ICollection<ContentRelation> ContentRelationSourcecontent { get; set; }
        public ICollection<ContentRelation> ContentRelationTargetcontent { get; set; }
        public ICollection<Contentproperties> Contentproperties { get; set; }
        public ICollection<Extrnlnks> Extrnlnks { get; set; }
        public ICollection<Content> InversePage { get; set; }
        public ICollection<Content> InverseParent { get; set; }
        public ICollection<Content> InverseParentcc { get; set; }
        public ICollection<Content> InverseParentcomment { get; set; }
        public ICollection<Content> InversePrevverNavigation { get; set; }
        public ICollection<Likes> Likes { get; set; }
        public ICollection<Links> Links { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
        public ICollection<Spaces> SpacesHomepageNavigation { get; set; }
        public ICollection<Spaces> SpacesSpacedesc { get; set; }
        public ICollection<Trackbacklinks> Trackbacklinks { get; set; }
        public ICollection<UsercontentRelation> UsercontentRelation { get; set; }
    }
}
