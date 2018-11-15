using System;
using System.Collections.Generic;

namespace Test.JiraModels
{
    public partial class Ao3d5e3bGlobalConfigEntity
    {
        public string Apikey { get; set; }
        public bool? Authenticate { get; set; }
        public bool? AuthenticateProxy { get; set; }
        public bool? BlackoutTime { get; set; }
        public bool? BlackoutTime2 { get; set; }
        public string ClientId { get; set; }
        public string CommentField { get; set; }
        public bool? CreatingIssuesAlert { get; set; }
        public bool? CustomizeJiraTextLimit { get; set; }
        public string EmailAlert { get; set; }
        public bool? EnableDelta { get; set; }
        public bool? EnableProxySettings { get; set; }
        public string EndHour { get; set; }
        public string EndHour2 { get; set; }
        public string EndMnt { get; set; }
        public string EndMnt2 { get; set; }
        public bool? GlobalConfigSaved { get; set; }
        public int Id { get; set; }
        public bool? IgnoreCert { get; set; }
        public bool? ImportClosed { get; set; }
        public long? IntervalBtwTicket { get; set; }
        public long? JiraTextLimit { get; set; }
        public string LastSuccessSync { get; set; }
        public bool? LastUpdate { get; set; }
        public long? LogBufferSize { get; set; }
        public string LogLevel { get; set; }
        public bool? LookupVulnerabilityInfo { get; set; }
        public int? NumWorkerThreads { get; set; }
        public int? PagesPerRequest { get; set; }
        public string ProxyHost { get; set; }
        public string ProxyPassword { get; set; }
        public int? ProxyPort { get; set; }
        public string ProxyUsername { get; set; }
        public bool? ReopenJiraIssues { get; set; }
        public bool? ResolveJiraIssues { get; set; }
        public bool? SchedulerState { get; set; }
        public bool? SentinelApiAlert { get; set; }
        public string SentinelServerLocation { get; set; }
        public string SentinelServerUrl { get; set; }
        public bool? ShouldCommentIssue { get; set; }
        public bool? ShowOnlyCustomDescSol { get; set; }
        public string StartHour { get; set; }
        public string StartHour2 { get; set; }
        public string StartMnt { get; set; }
        public string StartMnt2 { get; set; }
        public long? SyncInterval { get; set; }
        public string WhiteHatKey { get; set; }
        public string SourceServerUrl { get; set; }
    }
}
