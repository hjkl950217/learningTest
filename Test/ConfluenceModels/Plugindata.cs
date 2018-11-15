using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Plugindata
    {
        public decimal Plugindataid { get; set; }
        public string Pluginkey { get; set; }
        public string Filename { get; set; }
        public DateTime? Lastmoddate { get; set; }
        public byte[] Data { get; set; }
    }
}
