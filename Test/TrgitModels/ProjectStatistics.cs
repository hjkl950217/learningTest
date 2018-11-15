using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class ProjectStatistics
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int NamespaceId { get; set; }
        public long CommitCount { get; set; }
        public long StorageSize { get; set; }
        public long RepositorySize { get; set; }
        public long LfsObjectsSize { get; set; }
        public long BuildArtifactsSize { get; set; }

        public Projects Project { get; set; }
    }
}
