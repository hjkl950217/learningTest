using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao0db21aCalendar
    {
        public Ao0db21aCalendar()
        {
            Ao0db21aShare = new HashSet<Ao0db21aShare>();
        }

        public string AuthorKey { get; set; }
        public string Color { get; set; }
        public string DisplayedFields { get; set; }
        public string EventEnd { get; set; }
        public string EventStart { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }

        public ICollection<Ao0db21aShare> Ao0db21aShare { get; set; }
    }
}
