using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Columnstatus
    {
        public long ColumnId { get; set; }
        public long Id { get; set; }
        public int Pos { get; set; }
        public string StatusId { get; set; }

        public Ao60db71Column Column { get; set; }
    }
}
