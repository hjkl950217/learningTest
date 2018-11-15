using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class UserCallouts
    {
        public int Id { get; set; }
        public int FeatureName { get; set; }
        public int UserId { get; set; }

        public Users User { get; set; }
    }
}
