using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Label
    {
        public Label()
        {
            ContentLabel = new HashSet<ContentLabel>();
            Notifications = new HashSet<Notifications>();
        }

        public decimal Labelid { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Namespace { get; set; }
        public DateTime? Creationdate { get; set; }
        public DateTime? Lastmoddate { get; set; }

        public UserMapping OwnerNavigation { get; set; }
        public ICollection<ContentLabel> ContentLabel { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
    }
}
