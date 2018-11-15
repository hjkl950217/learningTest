using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Confversion
    {
        public decimal Confversionid { get; set; }
        public int Buildnumber { get; set; }
        public DateTime? Installdate { get; set; }
        public string Versiontag { get; set; }
        public DateTime? Creationdate { get; set; }
        public DateTime? Lastmoddate { get; set; }
    }
}
