using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Subscriptions
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? SubscribableId { get; set; }
        public string SubscribableType { get; set; }
        public bool? Subscribed { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? ProjectId { get; set; }

        public Projects Project { get; set; }
    }
}
