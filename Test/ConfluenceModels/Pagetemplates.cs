using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Pagetemplates
    {
        public Pagetemplates()
        {
            ContentLabel = new HashSet<ContentLabel>();
            InversePrevverNavigation = new HashSet<Pagetemplates>();
        }

        public decimal Templateid { get; set; }
        public string Templatename { get; set; }
        public string Templatedesc { get; set; }
        public string Pluginkey { get; set; }
        public string Modulekey { get; set; }
        public string Refpluginkey { get; set; }
        public string Refmodulekey { get; set; }
        public string Content { get; set; }
        public decimal? Spaceid { get; set; }
        public decimal? Prevver { get; set; }
        public int Version { get; set; }
        public string Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Lastmodifier { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public short? Bodytypeid { get; set; }
        public int Hibernateversion { get; set; }

        public UserMapping CreatorNavigation { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
        public Pagetemplates PrevverNavigation { get; set; }
        public Spaces Space { get; set; }
        public ICollection<ContentLabel> ContentLabel { get; set; }
        public ICollection<Pagetemplates> InversePrevverNavigation { get; set; }
    }
}
