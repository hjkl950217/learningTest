using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Spaces
    {
        public Spaces()
        {
            Content = new HashSet<Content>();
            Notifications = new HashSet<Notifications>();
            Pagetemplates = new HashSet<Pagetemplates>();
            Spacepermissions = new HashSet<Spacepermissions>();
        }

        public decimal Spaceid { get; set; }
        public string Spacename { get; set; }
        public string Spacekey { get; set; }
        public decimal? Spacedescid { get; set; }
        public decimal? Homepage { get; set; }
        public string Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Lastmodifier { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public string Spacetype { get; set; }
        public string Spacestatus { get; set; }
        public string Lowerspacekey { get; set; }

        public UserMapping CreatorNavigation { get; set; }
        public Content HomepageNavigation { get; set; }
        public UserMapping LastmodifierNavigation { get; set; }
        public Content Spacedesc { get; set; }
        public ICollection<Content> Content { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
        public ICollection<Pagetemplates> Pagetemplates { get; set; }
        public ICollection<Spacepermissions> Spacepermissions { get; set; }
    }
}
