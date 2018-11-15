using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class FeatureGates
    {
        public int Id { get; set; }
        public string FeatureKey { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
