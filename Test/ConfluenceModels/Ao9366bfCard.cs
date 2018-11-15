using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Ao9366bfCard
    {
        public Ao9366bfCard()
        {
            Ao9366bfAssignee = new HashSet<Ao9366bfAssignee>();
            Ao9366bfCardComment = new HashSet<Ao9366bfCardComment>();
        }

        public bool? Archived { get; set; }
        public long Created { get; set; }
        public string Description { get; set; }
        public long? Due { get; set; }
        public long? DueDate { get; set; }
        public int Id { get; set; }
        public int? ListId { get; set; }
        public int? Position { get; set; }
        public string Title { get; set; }
        public long Updated { get; set; }

        public Ao9366bfList List { get; set; }
        public ICollection<Ao9366bfAssignee> Ao9366bfAssignee { get; set; }
        public ICollection<Ao9366bfCardComment> Ao9366bfCardComment { get; set; }
    }
}
