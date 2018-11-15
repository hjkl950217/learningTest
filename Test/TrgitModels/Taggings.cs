using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Taggings
    {
        public int Id { get; set; }
        public int? TagId { get; set; }
        public int? TaggableId { get; set; }
        public string TaggableType { get; set; }
        public int? TaggerId { get; set; }
        public string TaggerType { get; set; }
        public string Context { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
