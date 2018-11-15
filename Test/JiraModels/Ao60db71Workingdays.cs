using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Workingdays
    {
        public Ao60db71Workingdays()
        {
            Ao60db71Nonworkingday = new HashSet<Ao60db71Nonworkingday>();
        }

        public bool Friday { get; set; }
        public long Id { get; set; }
        public bool Monday { get; set; }
        public long RapidViewId { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public bool Thursday { get; set; }
        public string Timezone { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }

        public Ao60db71Rapidview RapidView { get; set; }
        public ICollection<Ao60db71Nonworkingday> Ao60db71Nonworkingday { get; set; }
    }
}
