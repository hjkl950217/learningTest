using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Attachmentdata
    {
        public decimal Attachmentdataid { get; set; }
        public int Attversion { get; set; }
        public byte[] Data { get; set; }
        public decimal Attachmentid { get; set; }
        public int Hibernateversion { get; set; }

        public Content Attachment { get; set; }
    }
}
