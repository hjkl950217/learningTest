using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao60db71Rapidview
    {
        public Ao60db71Rapidview()
        {
            Ao60db71Boardadmins = new HashSet<Ao60db71Boardadmins>();
            Ao60db71Cardcolor = new HashSet<Ao60db71Cardcolor>();
            Ao60db71Cardlayout = new HashSet<Ao60db71Cardlayout>();
            Ao60db71Column = new HashSet<Ao60db71Column>();
            Ao60db71Detailviewfield = new HashSet<Ao60db71Detailviewfield>();
            Ao60db71Estimatestatistic = new HashSet<Ao60db71Estimatestatistic>();
            Ao60db71Quickfilter = new HashSet<Ao60db71Quickfilter>();
            Ao60db71Statsfield = new HashSet<Ao60db71Statsfield>();
            Ao60db71Subquery = new HashSet<Ao60db71Subquery>();
            Ao60db71Swimlane = new HashSet<Ao60db71Swimlane>();
            Ao60db71Trackingstatistic = new HashSet<Ao60db71Trackingstatistic>();
            Ao60db71Workingdays = new HashSet<Ao60db71Workingdays>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string OwnerUserName { get; set; }
        public long SavedFilterId { get; set; }
        public bool? SprintsEnabled { get; set; }
        public string SwimlaneStrategy { get; set; }
        public string CardColorStrategy { get; set; }
        public bool? SprintMarkersMigrated { get; set; }
        public bool? ShowDaysInColumn { get; set; }
        public bool? ShowEpicAsPanel { get; set; }
        public string OldDoneIssuesCutoff { get; set; }
        public bool? KanPlanEnabled { get; set; }

        public ICollection<Ao60db71Boardadmins> Ao60db71Boardadmins { get; set; }
        public ICollection<Ao60db71Cardcolor> Ao60db71Cardcolor { get; set; }
        public ICollection<Ao60db71Cardlayout> Ao60db71Cardlayout { get; set; }
        public ICollection<Ao60db71Column> Ao60db71Column { get; set; }
        public ICollection<Ao60db71Detailviewfield> Ao60db71Detailviewfield { get; set; }
        public ICollection<Ao60db71Estimatestatistic> Ao60db71Estimatestatistic { get; set; }
        public ICollection<Ao60db71Quickfilter> Ao60db71Quickfilter { get; set; }
        public ICollection<Ao60db71Statsfield> Ao60db71Statsfield { get; set; }
        public ICollection<Ao60db71Subquery> Ao60db71Subquery { get; set; }
        public ICollection<Ao60db71Swimlane> Ao60db71Swimlane { get; set; }
        public ICollection<Ao60db71Trackingstatistic> Ao60db71Trackingstatistic { get; set; }
        public ICollection<Ao60db71Workingdays> Ao60db71Workingdays { get; set; }
    }
}
