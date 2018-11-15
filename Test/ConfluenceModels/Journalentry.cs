using System;
using System.Collections.Generic;

namespace Test.ConfluenceModels
{
    public partial class Journalentry
    {
        public decimal EntryId { get; set; }
        public string JournalName { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
    }
}
