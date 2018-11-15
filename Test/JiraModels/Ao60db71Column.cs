using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Column
    {
        public Ao60db71Column()
        {
            Ao60db71Columnstatus = new HashSet<Ao60db71Columnstatus>();
        }

        public long Id { get; set; }
        public double? Maxim { get; set; }
        public double? Minim { get; set; }
        public string Name { get; set; }
        public int Pos { get; set; }
        public long RapidViewId { get; set; }

        public Ao60db71Rapidview RapidView { get; set; }
        public ICollection<Ao60db71Columnstatus> Ao60db71Columnstatus { get; set; }
    }
}
