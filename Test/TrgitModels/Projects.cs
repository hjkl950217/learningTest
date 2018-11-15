using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Projects
    {
        public Projects()
        {
            Badges = new HashSet<Badges>();
            Boards = new HashSet<Boards>();
            CiBuildTraceSectionNames = new HashSet<CiBuildTraceSectionNames>();
            CiBuildTraceSections = new HashSet<CiBuildTraceSections>();
            CiBuilds = new HashSet<CiBuilds>();
            CiJobArtifacts = new HashSet<CiJobArtifacts>();
            CiPipelineSchedules = new HashSet<CiPipelineSchedules>();
            CiPipelines = new HashSet<CiPipelines>();
            CiRunnerProjects = new HashSet<CiRunnerProjects>();
            CiStages = new HashSet<CiStages>();
            CiTriggers = new HashSet<CiTriggers>();
            CiVariables = new HashSet<CiVariables>();
            ClusterProjects = new HashSet<ClusterProjects>();
            ContainerRepositories = new HashSet<ContainerRepositories>();
            DeployKeysProjects = new HashSet<DeployKeysProjects>();
            Deployments = new HashSet<Deployments>();
            Environments = new HashSet<Environments>();
            Events = new HashSet<Events>();
            ForkNetworkMembersForkedFromProject = new HashSet<ForkNetworkMembers>();
            GpgSignatures = new HashSet<GpgSignatures>();
            Issues = new HashSet<Issues>();
            LabelPriorities = new HashSet<LabelPriorities>();
            Labels = new HashSet<Labels>();
            LfsFileLocks = new HashSet<LfsFileLocks>();
            MergeRequestsSourceProject = new HashSet<MergeRequests>();
            MergeRequestsTargetProject = new HashSet<MergeRequests>();
            Milestones = new HashSet<Milestones>();
            Notes = new HashSet<Notes>();
            PagesDomains = new HashSet<PagesDomains>();
            ProjectCustomAttributes = new HashSet<ProjectCustomAttributes>();
            ProjectFeatures = new HashSet<ProjectFeatures>();
            ProjectGroupLinks = new HashSet<ProjectGroupLinks>();
            ProjectImportData = new HashSet<ProjectImportData>();
            ProtectedBranches = new HashSet<ProtectedBranches>();
            ProtectedTags = new HashSet<ProtectedTags>();
            Releases = new HashSet<Releases>();
            Services = new HashSet<Services>();
            Snippets = new HashSet<Snippets>();
            Subscriptions = new HashSet<Subscriptions>();
            Todos = new HashSet<Todos>();
            UsersStarProjects = new HashSet<UsersStarProjects>();
            WebHooks = new HashSet<WebHooks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CreatorId { get; set; }
        public int NamespaceId { get; set; }
        public DateTime? LastActivityAt { get; set; }
        public string ImportUrl { get; set; }
        public int VisibilityLevel { get; set; }
        public bool Archived { get; set; }
        public string ImportStatus { get; set; }
        public int StarCount { get; set; }
        public string Avatar { get; set; }
        public string ImportType { get; set; }
        public string ImportSource { get; set; }
        public string ImportError { get; set; }
        public int? CiId { get; set; }
        public bool? SharedRunnersEnabled { get; set; }
        public string RunnersToken { get; set; }
        public string BuildCoverageRegex { get; set; }
        public bool? BuildAllowGitFetch { get; set; }
        public int BuildTimeout { get; set; }
        public bool? PendingDelete { get; set; }
        public bool? PublicBuilds { get; set; }
        public bool? LastRepositoryCheckFailed { get; set; }
        public DateTime? LastRepositoryCheckAt { get; set; }
        public bool? ContainerRegistryEnabled { get; set; }
        public bool OnlyAllowMergeIfPipelineSucceeds { get; set; }
        public bool? HasExternalIssueTracker { get; set; }
        public string RepositoryStorage { get; set; }
        public bool RequestAccessEnabled { get; set; }
        public bool? HasExternalWiki { get; set; }
        public bool? LfsEnabled { get; set; }
        public string DescriptionHtml { get; set; }
        public bool? OnlyAllowMergeIfAllDiscussionsAreResolved { get; set; }
        public bool? PrintingMergeRequestLinkEnabled { get; set; }
        public int AutoCancelPendingPipelines { get; set; }
        public string ImportJid { get; set; }
        public int? CachedMarkdownVersion { get; set; }
        public DateTime? LastRepositoryUpdatedAt { get; set; }
        public bool MergeRequestsRebaseEnabled { get; set; }
        public bool MergeRequestsFfOnlyEnabled { get; set; }
        public bool? RepositoryReadOnly { get; set; }
        public string CiConfigPath { get; set; }
        public string DeleteError { get; set; }
        public short? StorageVersion { get; set; }
        public bool? ResolveOutdatedDiffDiscussions { get; set; }
        public int? JobsCacheIndex { get; set; }

        public ForkNetworkMembers ForkNetworkMembersProject { get; set; }
        public ForkNetworks ForkNetworks { get; set; }
        public ForkedProjectLinks ForkedProjectLinks { get; set; }
        public GcpClusters GcpClusters { get; set; }
        public ProjectAutoDevops ProjectAutoDevops { get; set; }
        public ProjectStatistics ProjectStatistics { get; set; }
        public TrendingProjects TrendingProjects { get; set; }
        public ICollection<Badges> Badges { get; set; }
        public ICollection<Boards> Boards { get; set; }
        public ICollection<CiBuildTraceSectionNames> CiBuildTraceSectionNames { get; set; }
        public ICollection<CiBuildTraceSections> CiBuildTraceSections { get; set; }
        public ICollection<CiBuilds> CiBuilds { get; set; }
        public ICollection<CiJobArtifacts> CiJobArtifacts { get; set; }
        public ICollection<CiPipelineSchedules> CiPipelineSchedules { get; set; }
        public ICollection<CiPipelines> CiPipelines { get; set; }
        public ICollection<CiRunnerProjects> CiRunnerProjects { get; set; }
        public ICollection<CiStages> CiStages { get; set; }
        public ICollection<CiTriggers> CiTriggers { get; set; }
        public ICollection<CiVariables> CiVariables { get; set; }
        public ICollection<ClusterProjects> ClusterProjects { get; set; }
        public ICollection<ContainerRepositories> ContainerRepositories { get; set; }
        public ICollection<DeployKeysProjects> DeployKeysProjects { get; set; }
        public ICollection<Deployments> Deployments { get; set; }
        public ICollection<Environments> Environments { get; set; }
        public ICollection<Events> Events { get; set; }
        public ICollection<ForkNetworkMembers> ForkNetworkMembersForkedFromProject { get; set; }
        public ICollection<GpgSignatures> GpgSignatures { get; set; }
        public ICollection<Issues> Issues { get; set; }
        public ICollection<LabelPriorities> LabelPriorities { get; set; }
        public ICollection<Labels> Labels { get; set; }
        public ICollection<LfsFileLocks> LfsFileLocks { get; set; }
        public ICollection<MergeRequests> MergeRequestsSourceProject { get; set; }
        public ICollection<MergeRequests> MergeRequestsTargetProject { get; set; }
        public ICollection<Milestones> Milestones { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<PagesDomains> PagesDomains { get; set; }
        public ICollection<ProjectCustomAttributes> ProjectCustomAttributes { get; set; }
        public ICollection<ProjectFeatures> ProjectFeatures { get; set; }
        public ICollection<ProjectGroupLinks> ProjectGroupLinks { get; set; }
        public ICollection<ProjectImportData> ProjectImportData { get; set; }
        public ICollection<ProtectedBranches> ProtectedBranches { get; set; }
        public ICollection<ProtectedTags> ProtectedTags { get; set; }
        public ICollection<Releases> Releases { get; set; }
        public ICollection<Services> Services { get; set; }
        public ICollection<Snippets> Snippets { get; set; }
        public ICollection<Subscriptions> Subscriptions { get; set; }
        public ICollection<Todos> Todos { get; set; }
        public ICollection<UsersStarProjects> UsersStarProjects { get; set; }
        public ICollection<WebHooks> WebHooks { get; set; }
    }
}
