using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Imagedetails
    {
        public decimal Attachmentid { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string Mimetype { get; set; }

        public Content Attachment { get; set; }
    }
}
