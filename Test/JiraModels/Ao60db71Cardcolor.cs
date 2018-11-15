using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Cardcolor
    {
        public string Color { get; set; }
        public long Id { get; set; }
        public int Pos { get; set; }
        public long RapidViewId { get; set; }
        public string Strategy { get; set; }
        public string Val { get; set; }

        public Ao60db71Rapidview RapidView { get; set; }
    }
}
