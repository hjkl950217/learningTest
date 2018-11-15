using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao7cde43ServerConfig
    {
        public Ao7cde43ServerConfig()
        {
            Ao7cde43ServerParam = new HashSet<Ao7cde43ServerParam>();
        }

        public string CustomTemplatePath { get; set; }
        public string DefaultUserIdTemplate { get; set; }
        public bool? EnabledForAllUsers { get; set; }
        public string GroupsWithAccess { get; set; }
        public int Id { get; set; }
        public string NotificationMediumKey { get; set; }
        public string ServerName { get; set; }

        public ICollection<Ao7cde43ServerParam> Ao7cde43ServerParam { get; set; }
    }
}
