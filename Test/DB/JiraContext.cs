using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Test.JiraModels;

namespace Test.DB
{
    public partial class JiraContext : DbContext
    {
        public JiraContext()
        {
        }

        public JiraContext(DbContextOptions<JiraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ao013613HdScheme> Ao013613HdScheme { get; set; }
        public virtual DbSet<Ao013613HdSchemeDay> Ao013613HdSchemeDay { get; set; }
        public virtual DbSet<Ao013613HdSchemeMember> Ao013613HdSchemeMember { get; set; }
        public virtual DbSet<Ao013613PermissionGroup> Ao013613PermissionGroup { get; set; }
        public virtual DbSet<Ao013613WlScheme> Ao013613WlScheme { get; set; }
        public virtual DbSet<Ao013613WlSchemeDay> Ao013613WlSchemeDay { get; set; }
        public virtual DbSet<Ao013613WlSchemeMember> Ao013613WlSchemeMember { get; set; }
        public virtual DbSet<Ao0be43aNotificationBody> Ao0be43aNotificationBody { get; set; }
        public virtual DbSet<Ao0be43aNotifications> Ao0be43aNotifications { get; set; }
        public virtual DbSet<Ao0db21aCalendar> Ao0db21aCalendar { get; set; }
        public virtual DbSet<Ao0db21aShare> Ao0db21aShare { get; set; }
        public virtual DbSet<Ao0db21aUserData> Ao0db21aUserData { get; set; }
        public virtual DbSet<Ao1fba15Template> Ao1fba15Template { get; set; }
        public virtual DbSet<Ao1fba15TemplateField> Ao1fba15TemplateField { get; set; }
        public virtual DbSet<Ao21d670WhitelistRules> Ao21d670WhitelistRules { get; set; }
        public virtual DbSet<Ao21f425MessageAo> Ao21f425MessageAo { get; set; }
        public virtual DbSet<Ao21f425MessageMappingAo> Ao21f425MessageMappingAo { get; set; }
        public virtual DbSet<Ao21f425UserPropertyAo> Ao21f425UserPropertyAo { get; set; }
        public virtual DbSet<Ao2c326bDocDetails> Ao2c326bDocDetails { get; set; }
        public virtual DbSet<Ao2f1435HealthCheckStatus> Ao2f1435HealthCheckStatus { get; set; }
        public virtual DbSet<Ao2f1435Properties> Ao2f1435Properties { get; set; }
        public virtual DbSet<Ao2f1435ReadNotifications> Ao2f1435ReadNotifications { get; set; }
        public virtual DbSet<Ao38321bCustomContentLink> Ao38321bCustomContentLink { get; set; }
        public virtual DbSet<Ao3b1893LoopDetection> Ao3b1893LoopDetection { get; set; }
        public virtual DbSet<Ao3d5e3bAssigneeMapEnt> Ao3d5e3bAssigneeMapEnt { get; set; }
        public virtual DbSet<Ao3d5e3bBasicConfEnt> Ao3d5e3bBasicConfEnt { get; set; }
        public virtual DbSet<Ao3d5e3bCustomFieldsEnt> Ao3d5e3bCustomFieldsEnt { get; set; }
        public virtual DbSet<Ao3d5e3bFieldAssignmentEnt> Ao3d5e3bFieldAssignmentEnt { get; set; }
        public virtual DbSet<Ao3d5e3bGlobalConfigEntity> Ao3d5e3bGlobalConfigEntity { get; set; }
        public virtual DbSet<Ao3d5e3bGlobalTempEntity> Ao3d5e3bGlobalTempEntity { get; set; }
        public virtual DbSet<Ao3d5e3bJiraPriorMapEnt> Ao3d5e3bJiraPriorMapEnt { get; set; }
        public virtual DbSet<Ao3d5e3bSentinelLogger> Ao3d5e3bSentinelLogger { get; set; }
        public virtual DbSet<Ao3d5e3bStatusEntity> Ao3d5e3bStatusEntity { get; set; }
        public virtual DbSet<Ao3d5e3bStatusMappingEnt> Ao3d5e3bStatusMappingEnt { get; set; }
        public virtual DbSet<Ao3d5e3bTransitionActEnt> Ao3d5e3bTransitionActEnt { get; set; }
        public virtual DbSet<Ao3d5e3bTransitionEntity> Ao3d5e3bTransitionEntity { get; set; }
        public virtual DbSet<Ao3d5e3bWorkflowEntity> Ao3d5e3bWorkflowEntity { get; set; }
        public virtual DbSet<Ao3d5e3bWorkflowXml> Ao3d5e3bWorkflowXml { get; set; }
        public virtual DbSet<Ao4aeacdWebhookDao> Ao4aeacdWebhookDao { get; set; }
        public virtual DbSet<Ao550953Shortcut> Ao550953Shortcut { get; set; }
        public virtual DbSet<Ao563aeeActivityEntity> Ao563aeeActivityEntity { get; set; }
        public virtual DbSet<Ao563aeeActorEntity> Ao563aeeActorEntity { get; set; }
        public virtual DbSet<Ao563aeeMediaLinkEntity> Ao563aeeMediaLinkEntity { get; set; }
        public virtual DbSet<Ao563aeeObjectEntity> Ao563aeeObjectEntity { get; set; }
        public virtual DbSet<Ao563aeeTargetEntity> Ao563aeeTargetEntity { get; set; }
        public virtual DbSet<Ao575bf5DevSummary> Ao575bf5DevSummary { get; set; }
        public virtual DbSet<Ao575bf5ProcessedCommits> Ao575bf5ProcessedCommits { get; set; }
        public virtual DbSet<Ao575bf5ProviderIssue> Ao575bf5ProviderIssue { get; set; }
        public virtual DbSet<Ao575bf5ProviderSeqNo> Ao575bf5ProviderSeqNo { get; set; }
        public virtual DbSet<Ao587b34GlanceConfig> Ao587b34GlanceConfig { get; set; }
        public virtual DbSet<Ao587b34ProjectConfig> Ao587b34ProjectConfig { get; set; }
        public virtual DbSet<Ao5fb9d7AohipChatLink> Ao5fb9d7AohipChatLink { get; set; }
        public virtual DbSet<Ao5fb9d7AohipChatUser> Ao5fb9d7AohipChatUser { get; set; }
        public virtual DbSet<Ao60db71Auditentry> Ao60db71Auditentry { get; set; }
        public virtual DbSet<Ao60db71Boardadmins> Ao60db71Boardadmins { get; set; }
        public virtual DbSet<Ao60db71Cardcolor> Ao60db71Cardcolor { get; set; }
        public virtual DbSet<Ao60db71Cardlayout> Ao60db71Cardlayout { get; set; }
        public virtual DbSet<Ao60db71Column> Ao60db71Column { get; set; }
        public virtual DbSet<Ao60db71Columnstatus> Ao60db71Columnstatus { get; set; }
        public virtual DbSet<Ao60db71Detailviewfield> Ao60db71Detailviewfield { get; set; }
        public virtual DbSet<Ao60db71Estimatestatistic> Ao60db71Estimatestatistic { get; set; }
        public virtual DbSet<Ao60db71Issueranking> Ao60db71Issueranking { get; set; }
        public virtual DbSet<Ao60db71Issuerankinglog> Ao60db71Issuerankinglog { get; set; }
        public virtual DbSet<Ao60db71Lexorank> Ao60db71Lexorank { get; set; }
        public virtual DbSet<Ao60db71Lexorankbalancer> Ao60db71Lexorankbalancer { get; set; }
        public virtual DbSet<Ao60db71Nonworkingday> Ao60db71Nonworkingday { get; set; }
        public virtual DbSet<Ao60db71Quickfilter> Ao60db71Quickfilter { get; set; }
        public virtual DbSet<Ao60db71Rankableobject> Ao60db71Rankableobject { get; set; }
        public virtual DbSet<Ao60db71RankIssueLink> Ao60db71RankIssueLink { get; set; }
        public virtual DbSet<Ao60db71Rapidview> Ao60db71Rapidview { get; set; }
        public virtual DbSet<Ao60db71Sprint> Ao60db71Sprint { get; set; }
        public virtual DbSet<Ao60db71Sprintmarker> Ao60db71Sprintmarker { get; set; }
        public virtual DbSet<Ao60db71Statsfield> Ao60db71Statsfield { get; set; }
        public virtual DbSet<Ao60db71Subquery> Ao60db71Subquery { get; set; }
        public virtual DbSet<Ao60db71Swimlane> Ao60db71Swimlane { get; set; }
        public virtual DbSet<Ao60db71Trackingstatistic> Ao60db71Trackingstatistic { get; set; }
        public virtual DbSet<Ao60db71Version> Ao60db71Version { get; set; }
        public virtual DbSet<Ao60db71Workingdays> Ao60db71Workingdays { get; set; }
        public virtual DbSet<Ao86ed1bGracePeriod> Ao86ed1bGracePeriod { get; set; }
        public virtual DbSet<Ao86ed1bProjectConfig> Ao86ed1bProjectConfig { get; set; }
        public virtual DbSet<Ao86ed1bStreamsEntry> Ao86ed1bStreamsEntry { get; set; }
        public virtual DbSet<Ao86ed1bTimeplan> Ao86ed1bTimeplan { get; set; }
        public virtual DbSet<Ao86ed1bTimesheetStatus> Ao86ed1bTimesheetStatus { get; set; }
        public virtual DbSet<Ao935429Jsuconfig> Ao935429Jsuconfig { get; set; }
        public virtual DbSet<Ao935429Jsusession> Ao935429Jsusession { get; set; }
        public virtual DbSet<Ao97edabUserinvitation> Ao97edabUserinvitation { get; set; }
        public virtual DbSet<AoA0b856WebHookListenerAo> AoA0b856WebHookListenerAo { get; set; }
        public virtual DbSet<AoA44657HealthCheckEntity> AoA44657HealthCheckEntity { get; set; }
        public virtual DbSet<AoAefed0Team> AoAefed0Team { get; set; }
        public virtual DbSet<AoAefed0TeamMember> AoAefed0TeamMember { get; set; }
        public virtual DbSet<AoAefed0TeamToMember> AoAefed0TeamToMember { get; set; }
        public virtual DbSet<AoB9a0f0AppliedTemplate> AoB9a0f0AppliedTemplate { get; set; }
        public virtual DbSet<AoBf4748AttachFromMail> AoBf4748AttachFromMail { get; set; }
        public virtual DbSet<AoBf4748AttachUpload> AoBf4748AttachUpload { get; set; }
        public virtual DbSet<AoBf4748DynamicForm> AoBf4748DynamicForm { get; set; }
        public virtual DbSet<AoBf4748DynamicFormValue> AoBf4748DynamicFormValue { get; set; }
        public virtual DbSet<AoBf4748MentionRequest> AoBf4748MentionRequest { get; set; }
        public virtual DbSet<AoBf4748SdPrep> AoBf4748SdPrep { get; set; }
        public virtual DbSet<AoCbc281DefLibForGroup> AoCbc281DefLibForGroup { get; set; }
        public virtual DbSet<AoCbc281Diagram> AoCbc281Diagram { get; set; }
        public virtual DbSet<AoCbc281DrawioConfiguration> AoCbc281DrawioConfiguration { get; set; }
        public virtual DbSet<AoCbc281DrawioDraft> AoCbc281DrawioDraft { get; set; }
        public virtual DbSet<AoCbc281DrawioLibrary> AoCbc281DrawioLibrary { get; set; }
        public virtual DbSet<AoCff990AotransitionFailure> AoCff990AotransitionFailure { get; set; }
        public virtual DbSet<AoE8b6ccBranch> AoE8b6ccBranch { get; set; }
        public virtual DbSet<AoE8b6ccBranchHeadMapping> AoE8b6ccBranchHeadMapping { get; set; }
        public virtual DbSet<AoE8b6ccChangesetMapping> AoE8b6ccChangesetMapping { get; set; }
        public virtual DbSet<AoE8b6ccCommit> AoE8b6ccCommit { get; set; }
        public virtual DbSet<AoE8b6ccGitHubEvent> AoE8b6ccGitHubEvent { get; set; }
        public virtual DbSet<AoE8b6ccIssueMapping> AoE8b6ccIssueMapping { get; set; }
        public virtual DbSet<AoE8b6ccIssueMappingV2> AoE8b6ccIssueMappingV2 { get; set; }
        public virtual DbSet<AoE8b6ccIssueToBranch> AoE8b6ccIssueToBranch { get; set; }
        public virtual DbSet<AoE8b6ccIssueToChangeset> AoE8b6ccIssueToChangeset { get; set; }
        public virtual DbSet<AoE8b6ccMessage> AoE8b6ccMessage { get; set; }
        public virtual DbSet<AoE8b6ccMessageQueueItem> AoE8b6ccMessageQueueItem { get; set; }
        public virtual DbSet<AoE8b6ccMessageTag> AoE8b6ccMessageTag { get; set; }
        public virtual DbSet<AoE8b6ccOrganizationMapping> AoE8b6ccOrganizationMapping { get; set; }
        public virtual DbSet<AoE8b6ccOrgToProject> AoE8b6ccOrgToProject { get; set; }
        public virtual DbSet<AoE8b6ccPrIssueKey> AoE8b6ccPrIssueKey { get; set; }
        public virtual DbSet<AoE8b6ccProjectMapping> AoE8b6ccProjectMapping { get; set; }
        public virtual DbSet<AoE8b6ccProjectMappingV2> AoE8b6ccProjectMappingV2 { get; set; }
        public virtual DbSet<AoE8b6ccPrParticipant> AoE8b6ccPrParticipant { get; set; }
        public virtual DbSet<AoE8b6ccPrToCommit> AoE8b6ccPrToCommit { get; set; }
        public virtual DbSet<AoE8b6ccPullRequest> AoE8b6ccPullRequest { get; set; }
        public virtual DbSet<AoE8b6ccRepositoryMapping> AoE8b6ccRepositoryMapping { get; set; }
        public virtual DbSet<AoE8b6ccRepoToChangeset> AoE8b6ccRepoToChangeset { get; set; }
        public virtual DbSet<AoE8b6ccRepoToProject> AoE8b6ccRepoToProject { get; set; }
        public virtual DbSet<AoE8b6ccSyncAuditLog> AoE8b6ccSyncAuditLog { get; set; }
        public virtual DbSet<AoE8b6ccSyncEvent> AoE8b6ccSyncEvent { get; set; }
        public virtual DbSet<AoEd669cSeenAssertions> AoEd669cSeenAssertions { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<AuditChangedValue> AuditChangedValue { get; set; }
        public virtual DbSet<AuditItem> AuditItem { get; set; }
        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<Avatar> Avatar { get; set; }
        public virtual DbSet<Board> Board { get; set; }
        public virtual DbSet<Boardproject> Boardproject { get; set; }
        public virtual DbSet<Changegroup> Changegroup { get; set; }
        public virtual DbSet<Changeitem> Changeitem { get; set; }
        public virtual DbSet<Clusteredjob> Clusteredjob { get; set; }
        public virtual DbSet<Clusterlockstatus> Clusterlockstatus { get; set; }
        public virtual DbSet<Clustermessage> Clustermessage { get; set; }
        public virtual DbSet<Clusternode> Clusternode { get; set; }
        public virtual DbSet<Clusternodeheartbeat> Clusternodeheartbeat { get; set; }
        public virtual DbSet<Clusterupgradestate> Clusterupgradestate { get; set; }
        public virtual DbSet<Columnlayout> Columnlayout { get; set; }
        public virtual DbSet<Columnlayoutitem> Columnlayoutitem { get; set; }
        public virtual DbSet<Component> Component { get; set; }
        public virtual DbSet<Configurationcontext> Configurationcontext { get; set; }
        public virtual DbSet<Customfield> Customfield { get; set; }
        public virtual DbSet<Customfieldoption> Customfieldoption { get; set; }
        public virtual DbSet<Customfieldvalue> Customfieldvalue { get; set; }
        public virtual DbSet<CwdApplication> CwdApplication { get; set; }
        public virtual DbSet<CwdApplicationAddress> CwdApplicationAddress { get; set; }
        public virtual DbSet<CwdDirectory> CwdDirectory { get; set; }
        public virtual DbSet<CwdDirectoryAttribute> CwdDirectoryAttribute { get; set; }
        public virtual DbSet<CwdDirectoryOperation> CwdDirectoryOperation { get; set; }
        public virtual DbSet<CwdGroup> CwdGroup { get; set; }
        public virtual DbSet<CwdGroupAttributes> CwdGroupAttributes { get; set; }
        public virtual DbSet<CwdMembership> CwdMembership { get; set; }
        public virtual DbSet<CwdUser> CwdUser { get; set; }
        public virtual DbSet<CwdUserAttributes> CwdUserAttributes { get; set; }
        public virtual DbSet<Deadletter> Deadletter { get; set; }
        public virtual DbSet<Draftworkflowscheme> Draftworkflowscheme { get; set; }
        public virtual DbSet<Draftworkflowschemeentity> Draftworkflowschemeentity { get; set; }
        public virtual DbSet<EntityProperty> EntityProperty { get; set; }
        public virtual DbSet<EntityPropertyIndexDocument> EntityPropertyIndexDocument { get; set; }
        public virtual DbSet<EntityTranslation> EntityTranslation { get; set; }
        public virtual DbSet<ExternalEntities> ExternalEntities { get; set; }
        public virtual DbSet<Externalgadget> Externalgadget { get; set; }
        public virtual DbSet<Favouriteassociations> Favouriteassociations { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<Fieldconfigscheme> Fieldconfigscheme { get; set; }
        public virtual DbSet<Fieldconfigschemeissuetype> Fieldconfigschemeissuetype { get; set; }
        public virtual DbSet<Fieldconfiguration> Fieldconfiguration { get; set; }
        public virtual DbSet<Fieldlayout> Fieldlayout { get; set; }
        public virtual DbSet<Fieldlayoutitem> Fieldlayoutitem { get; set; }
        public virtual DbSet<Fieldlayoutscheme> Fieldlayoutscheme { get; set; }
        public virtual DbSet<Fieldlayoutschemeassociation> Fieldlayoutschemeassociation { get; set; }
        public virtual DbSet<Fieldlayoutschemeentity> Fieldlayoutschemeentity { get; set; }
        public virtual DbSet<Fieldscreen> Fieldscreen { get; set; }
        public virtual DbSet<Fieldscreenlayoutitem> Fieldscreenlayoutitem { get; set; }
        public virtual DbSet<Fieldscreenscheme> Fieldscreenscheme { get; set; }
        public virtual DbSet<Fieldscreenschemeitem> Fieldscreenschemeitem { get; set; }
        public virtual DbSet<Fieldscreentab> Fieldscreentab { get; set; }
        public virtual DbSet<Fileattachment> Fileattachment { get; set; }
        public virtual DbSet<Filtersubscription> Filtersubscription { get; set; }
        public virtual DbSet<Gadgetuserpreference> Gadgetuserpreference { get; set; }
        public virtual DbSet<Genericconfiguration> Genericconfiguration { get; set; }
        public virtual DbSet<Globalpermissionentry> Globalpermissionentry { get; set; }
        public virtual DbSet<Groupbase> Groupbase { get; set; }
        public virtual DbSet<IssueFieldOption> IssueFieldOption { get; set; }
        public virtual DbSet<IssueFieldOptionScope> IssueFieldOptionScope { get; set; }
        public virtual DbSet<Issuelink> Issuelink { get; set; }
        public virtual DbSet<Issuelinktype> Issuelinktype { get; set; }
        public virtual DbSet<Issuesecurityscheme> Issuesecurityscheme { get; set; }
        public virtual DbSet<Issuestatus> Issuestatus { get; set; }
        public virtual DbSet<Issuetype> Issuetype { get; set; }
        public virtual DbSet<Issuetypescreenscheme> Issuetypescreenscheme { get; set; }
        public virtual DbSet<Issuetypescreenschemeentity> Issuetypescreenschemeentity { get; set; }
        public virtual DbSet<Jiraaction> Jiraaction { get; set; }
        public virtual DbSet<Jiradraftworkflows> Jiradraftworkflows { get; set; }
        public virtual DbSet<Jiraeventtype> Jiraeventtype { get; set; }
        public virtual DbSet<Jiraissue> Jiraissue { get; set; }
        public virtual DbSet<Jiraperms> Jiraperms { get; set; }
        public virtual DbSet<Jiraworkflows> Jiraworkflows { get; set; }
        public virtual DbSet<Jiraworkflowstatuses> Jiraworkflowstatuses { get; set; }
        public virtual DbSet<JquartzBlobTriggers> JquartzBlobTriggers { get; set; }
        public virtual DbSet<JquartzCalendars> JquartzCalendars { get; set; }
        public virtual DbSet<JquartzCronTriggers> JquartzCronTriggers { get; set; }
        public virtual DbSet<JquartzFiredTriggers> JquartzFiredTriggers { get; set; }
        public virtual DbSet<JquartzJobDetails> JquartzJobDetails { get; set; }
        public virtual DbSet<JquartzJobListeners> JquartzJobListeners { get; set; }
        public virtual DbSet<JquartzLocks> JquartzLocks { get; set; }
        public virtual DbSet<JquartzPausedTriggerGrps> JquartzPausedTriggerGrps { get; set; }
        public virtual DbSet<JquartzSchedulerState> JquartzSchedulerState { get; set; }
        public virtual DbSet<JquartzSimpleTriggers> JquartzSimpleTriggers { get; set; }
        public virtual DbSet<JquartzSimpropTriggers> JquartzSimpropTriggers { get; set; }
        public virtual DbSet<JquartzTriggerListeners> JquartzTriggerListeners { get; set; }
        public virtual DbSet<JquartzTriggers> JquartzTriggers { get; set; }
        public virtual DbSet<Label> Label { get; set; }
        public virtual DbSet<Licenserolesdefault> Licenserolesdefault { get; set; }
        public virtual DbSet<Licenserolesgroup> Licenserolesgroup { get; set; }
        public virtual DbSet<Listenerconfig> Listenerconfig { get; set; }
        public virtual DbSet<Mailserver> Mailserver { get; set; }
        public virtual DbSet<Managedconfigurationitem> Managedconfigurationitem { get; set; }
        public virtual DbSet<Membershipbase> Membershipbase { get; set; }
        public virtual DbSet<MovedIssueKey> MovedIssueKey { get; set; }
        public virtual DbSet<NeweggProjectMaster> NeweggProjectMaster { get; set; }
        public virtual DbSet<NeweggProjectTransaction> NeweggProjectTransaction { get; set; }
        public virtual DbSet<Nodeassociation> Nodeassociation { get; set; }
        public virtual DbSet<Nodeindexcounter> Nodeindexcounter { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Notificationinstance> Notificationinstance { get; set; }
        public virtual DbSet<Notificationscheme> Notificationscheme { get; set; }
        public virtual DbSet<Oauthconsumer> Oauthconsumer { get; set; }
        public virtual DbSet<Oauthconsumertoken> Oauthconsumertoken { get; set; }
        public virtual DbSet<Oauthspconsumer> Oauthspconsumer { get; set; }
        public virtual DbSet<Oauthsptoken> Oauthsptoken { get; set; }
        public virtual DbSet<Optionconfiguration> Optionconfiguration { get; set; }
        public virtual DbSet<OsCurrentstep> OsCurrentstep { get; set; }
        public virtual DbSet<OsCurrentstepPrev> OsCurrentstepPrev { get; set; }
        public virtual DbSet<OsHistorystep> OsHistorystep { get; set; }
        public virtual DbSet<OsHistorystepPrev> OsHistorystepPrev { get; set; }
        public virtual DbSet<OsWfentry> OsWfentry { get; set; }
        public virtual DbSet<Permissionscheme> Permissionscheme { get; set; }
        public virtual DbSet<Permissionschemeattribute> Permissionschemeattribute { get; set; }
        public virtual DbSet<Pluginstate> Pluginstate { get; set; }
        public virtual DbSet<Pluginversion> Pluginversion { get; set; }
        public virtual DbSet<Portalpage> Portalpage { get; set; }
        public virtual DbSet<Portletconfiguration> Portletconfiguration { get; set; }
        public virtual DbSet<Priority> Priority { get; set; }
        public virtual DbSet<Productlicense> Productlicense { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Projectcategory> Projectcategory { get; set; }
        public virtual DbSet<Projectchangedtime> Projectchangedtime { get; set; }
        public virtual DbSet<ProjectKey> ProjectKey { get; set; }
        public virtual DbSet<Projectrole> Projectrole { get; set; }
        public virtual DbSet<Projectroleactor> Projectroleactor { get; set; }
        public virtual DbSet<Projectversion> Projectversion { get; set; }
        public virtual DbSet<Propertydata> Propertydata { get; set; }
        public virtual DbSet<Propertydate> Propertydate { get; set; }
        public virtual DbSet<Propertydecimal> Propertydecimal { get; set; }
        public virtual DbSet<Propertyentry> Propertyentry { get; set; }
        public virtual DbSet<Propertynumber> Propertynumber { get; set; }
        public virtual DbSet<Propertystring> Propertystring { get; set; }
        public virtual DbSet<Propertytext> Propertytext { get; set; }
        public virtual DbSet<QrtzCalendars> QrtzCalendars { get; set; }
        public virtual DbSet<QrtzCronTriggers> QrtzCronTriggers { get; set; }
        public virtual DbSet<QrtzFiredTriggers> QrtzFiredTriggers { get; set; }
        public virtual DbSet<QrtzJobDetails> QrtzJobDetails { get; set; }
        public virtual DbSet<QrtzJobListeners> QrtzJobListeners { get; set; }
        public virtual DbSet<QrtzSimpleTriggers> QrtzSimpleTriggers { get; set; }
        public virtual DbSet<QrtzTriggerListeners> QrtzTriggerListeners { get; set; }
        public virtual DbSet<QrtzTriggers> QrtzTriggers { get; set; }
        public virtual DbSet<ReindexComponent> ReindexComponent { get; set; }
        public virtual DbSet<ReindexRequest> ReindexRequest { get; set; }
        public virtual DbSet<Remembermetoken> Remembermetoken { get; set; }
        public virtual DbSet<Remotelink> Remotelink { get; set; }
        public virtual DbSet<Replicatedindexoperation> Replicatedindexoperation { get; set; }
        public virtual DbSet<Resolution> Resolution { get; set; }
        public virtual DbSet<Rundetails> Rundetails { get; set; }
        public virtual DbSet<Schemeissuesecurities> Schemeissuesecurities { get; set; }
        public virtual DbSet<Schemeissuesecuritylevels> Schemeissuesecuritylevels { get; set; }
        public virtual DbSet<Schemepermissions> Schemepermissions { get; set; }
        public virtual DbSet<Searchrequest> Searchrequest { get; set; }
        public virtual DbSet<SequenceValueItem> SequenceValueItem { get; set; }
        public virtual DbSet<Serviceconfig> Serviceconfig { get; set; }
        public virtual DbSet<Sharepermissions> Sharepermissions { get; set; }
        public virtual DbSet<Tempattachmentsmonitor> Tempattachmentsmonitor { get; set; }
        public virtual DbSet<TrackbackPing> TrackbackPing { get; set; }
        public virtual DbSet<Trustedapp> Trustedapp { get; set; }
        public virtual DbSet<Upgradehistory> Upgradehistory { get; set; }
        public virtual DbSet<Upgradetaskhistory> Upgradetaskhistory { get; set; }
        public virtual DbSet<Upgradetaskhistoryauditlog> Upgradetaskhistoryauditlog { get; set; }
        public virtual DbSet<Upgradeversionhistory> Upgradeversionhistory { get; set; }
        public virtual DbSet<Userassociation> Userassociation { get; set; }
        public virtual DbSet<Userbase> Userbase { get; set; }
        public virtual DbSet<Userhistoryitem> Userhistoryitem { get; set; }
        public virtual DbSet<Userpickerfilter> Userpickerfilter { get; set; }
        public virtual DbSet<Userpickerfiltergroup> Userpickerfiltergroup { get; set; }
        public virtual DbSet<Userpickerfilterrole> Userpickerfilterrole { get; set; }
        public virtual DbSet<Versioncontrol> Versioncontrol { get; set; }
        public virtual DbSet<Votehistory> Votehistory { get; set; }
        public virtual DbSet<Workflowscheme> Workflowscheme { get; set; }
        public virtual DbSet<Workflowschemeentity> Workflowschemeentity { get; set; }
        public virtual DbSet<Worklog> Worklog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.16.89.40;database=jira_hackathon;User id=hackathonDbo;password=hackathonDbo;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ao013613HdScheme>(entity =>
            {
                entity.ToTable("AO_013613_HD_SCHEME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DefaultScheme).HasColumnName("DEFAULT_SCHEME");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao013613HdSchemeDay>(entity =>
            {
                entity.ToTable("AO_013613_HD_SCHEME_DAY");

                entity.HasIndex(e => e.HolidaySchemeId)
                    .HasName("index_ao_013613_hd_353373503");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DurationSeconds).HasColumnName("DURATION_SECONDS");

                entity.Property(e => e.HolidaySchemeId).HasColumnName("HOLIDAY_SCHEME_ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.HolidayScheme)
                    .WithMany(p => p.Ao013613HdSchemeDay)
                    .HasForeignKey(d => d.HolidaySchemeId)
                    .HasConstraintName("fk_ao_013613_hd_scheme_day_holiday_scheme_id");
            });

            modelBuilder.Entity<Ao013613HdSchemeMember>(entity =>
            {
                entity.ToTable("AO_013613_HD_SCHEME_MEMBER");

                entity.HasIndex(e => e.HolidaySchemeId)
                    .HasName("index_ao_013613_hd_764606571");

                entity.HasIndex(e => e.UserKey)
                    .HasName("U_AO_013613_HD_SCHE903392985")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HolidaySchemeId).HasColumnName("HOLIDAY_SCHEME_ID");

                entity.Property(e => e.UserKey)
                    .IsRequired()
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.HolidayScheme)
                    .WithMany(p => p.Ao013613HdSchemeMember)
                    .HasForeignKey(d => d.HolidaySchemeId)
                    .HasConstraintName("fk_ao_013613_hd_scheme_member_holiday_scheme_id");
            });

            modelBuilder.Entity<Ao013613PermissionGroup>(entity =>
            {
                entity.ToTable("AO_013613_PERMISSION_GROUP");

                entity.HasIndex(e => e.PermissionKey)
                    .HasName("index_ao_013613_per594040534");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupKey)
                    .IsRequired()
                    .HasColumnName("GROUP_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasColumnName("PERMISSION_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao013613WlScheme>(entity =>
            {
                entity.ToTable("AO_013613_WL_SCHEME");

                entity.HasIndex(e => e.Name)
                    .HasName("U_AO_013613_WL_SCHEME_NAME")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DefaultScheme).HasColumnName("DEFAULT_SCHEME");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao013613WlSchemeDay>(entity =>
            {
                entity.ToTable("AO_013613_WL_SCHEME_DAY");

                entity.HasIndex(e => e.WorkloadSchemeId)
                    .HasName("index_ao_013613_wl_1287258379");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Day).HasColumnName("DAY");

                entity.Property(e => e.RequiredSeconds).HasColumnName("REQUIRED_SECONDS");

                entity.Property(e => e.WorkloadSchemeId).HasColumnName("WORKLOAD_SCHEME_ID");

                entity.HasOne(d => d.WorkloadScheme)
                    .WithMany(p => p.Ao013613WlSchemeDay)
                    .HasForeignKey(d => d.WorkloadSchemeId)
                    .HasConstraintName("fk_ao_013613_wl_scheme_day_workload_scheme_id");
            });

            modelBuilder.Entity<Ao013613WlSchemeMember>(entity =>
            {
                entity.ToTable("AO_013613_WL_SCHEME_MEMBER");

                entity.HasIndex(e => e.MemberKey)
                    .HasName("U_AO_013613_WL_SCHE1322162621")
                    .IsUnique();

                entity.HasIndex(e => e.WorkloadSchemeId)
                    .HasName("index_ao_013613_wl_283136883");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberKey)
                    .IsRequired()
                    .HasColumnName("MEMBER_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkloadSchemeId).HasColumnName("WORKLOAD_SCHEME_ID");

                entity.HasOne(d => d.WorkloadScheme)
                    .WithMany(p => p.Ao013613WlSchemeMember)
                    .HasForeignKey(d => d.WorkloadSchemeId)
                    .HasConstraintName("fk_ao_013613_wl_scheme_member_workload_scheme_id");
            });

            modelBuilder.Entity<Ao0be43aNotificationBody>(entity =>
            {
                entity.ToTable("AO_0BE43A_NOTIFICATION_BODY");

                entity.HasIndex(e => e.NotificationId)
                    .HasName("index_ao_0be43a_not1274326106");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Body)
                    .HasColumnName("BODY")
                    .HasColumnType("ntext");

                entity.Property(e => e.NotificationId).HasColumnName("NOTIFICATION_ID");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.Ao0be43aNotificationBody)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("fk_ao_0be43a_notification_body_notification_id");
            });

            modelBuilder.Entity<Ao0be43aNotifications>(entity =>
            {
                entity.ToTable("AO_0BE43A_NOTIFICATIONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.FromUser)
                    .HasColumnName("FROM_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasColumnName("ICON")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasColumnName("LINK")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Read).HasColumnName("READ");

                entity.Property(e => e.SneakPeak)
                    .HasColumnName("SNEAK_PEAK")
                    .HasColumnType("ntext");

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasColumnType("ntext");

                entity.Property(e => e.ToUser)
                    .HasColumnName("TO_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(767)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao0db21aCalendar>(entity =>
            {
                entity.ToTable("AO_0DB21A_CALENDAR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorKey)
                    .HasColumnName("AUTHOR_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Color)
                    .HasColumnName("COLOR")
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayedFields)
                    .HasColumnName("DISPLAYED_FIELDS")
                    .HasMaxLength(255);

                entity.Property(e => e.EventEnd)
                    .HasColumnName("EVENT_END")
                    .HasMaxLength(255);

                entity.Property(e => e.EventStart)
                    .HasColumnName("EVENT_START")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao0db21aShare>(entity =>
            {
                entity.ToTable("AO_0DB21A_SHARE");

                entity.HasIndex(e => e.CalendarId)
                    .HasName("index_ao_0db21a_sha759172747");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CalendarId).HasColumnName("CALENDAR_ID");

                entity.Property(e => e.Group)
                    .HasColumnName("GROUP")
                    .HasMaxLength(255);

                entity.Property(e => e.Project).HasColumnName("PROJECT");

                entity.Property(e => e.Role).HasColumnName("ROLE");

                entity.HasOne(d => d.Calendar)
                    .WithMany(p => p.Ao0db21aShare)
                    .HasForeignKey(d => d.CalendarId)
                    .HasConstraintName("fk_ao_0db21a_share_calendar_id");
            });

            modelBuilder.Entity<Ao0db21aUserData>(entity =>
            {
                entity.ToTable("AO_0DB21A_USER_DATA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DefaultView)
                    .HasColumnName("DEFAULT_VIEW")
                    .HasMaxLength(255);

                entity.Property(e => e.HideWeekends).HasColumnName("HIDE_WEEKENDS");

                entity.Property(e => e.ShowTime).HasColumnName("SHOW_TIME");

                entity.Property(e => e.ShowedCalendars)
                    .HasColumnName("SHOWED_CALENDARS")
                    .HasMaxLength(255);

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao1fba15Template>(entity =>
            {
                entity.ToTable("AO_1FBA15_TEMPLATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao1fba15TemplateField>(entity =>
            {
                entity.ToTable("AO_1FBA15_TEMPLATE_FIELD");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("index_ao_1fba15_tem754519975");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnName("TEMPLATE_ID");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.Ao1fba15TemplateField)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("fk_ao_1fba15_template_field_template_id");
            });

            modelBuilder.Entity<Ao21d670WhitelistRules>(entity =>
            {
                entity.ToTable("AO_21D670_WHITELIST_RULES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allowinbound).HasColumnName("ALLOWINBOUND");

                entity.Property(e => e.Expression)
                    .IsRequired()
                    .HasColumnName("EXPRESSION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao21f425MessageAo>(entity =>
            {
                entity.ToTable("AO_21F425_MESSAGE_AO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("CONTENT");
            });

            modelBuilder.Entity<Ao21f425MessageMappingAo>(entity =>
            {
                entity.ToTable("AO_21F425_MESSAGE_MAPPING_AO");

                entity.HasIndex(e => e.MessageId)
                    .HasName("index_ao_21f425_mes1965715920");

                entity.HasIndex(e => e.UserHash)
                    .HasName("index_ao_21f425_mes223897723");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MessageId)
                    .IsRequired()
                    .HasColumnName("MESSAGE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.UserHash)
                    .IsRequired()
                    .HasColumnName("USER_HASH")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao21f425UserPropertyAo>(entity =>
            {
                entity.ToTable("AO_21F425_USER_PROPERTY_AO");

                entity.HasIndex(e => e.User)
                    .HasName("index_ao_21f425_use1458667739");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnName("USER")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao2c326bDocDetails>(entity =>
            {
                entity.ToTable("AO_2C326B_DOC_DETAILS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocComments)
                    .HasColumnName("DOC_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Docpath)
                    .HasColumnName("DOCPATH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao2f1435HealthCheckStatus>(entity =>
            {
                entity.ToTable("AO_2F1435_HEALTH_CHECK_STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationName)
                    .HasColumnName("APPLICATION_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CompleteKey)
                    .HasColumnName("COMPLETE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.FailedDate)
                    .HasColumnName("FAILED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FailureReason)
                    .HasColumnName("FAILURE_REASON")
                    .HasMaxLength(450);

                entity.Property(e => e.IsHealthy).HasColumnName("IS_HEALTHY");

                entity.Property(e => e.IsResolved).HasColumnName("IS_RESOLVED");

                entity.Property(e => e.ResolvedDate)
                    .HasColumnName("RESOLVED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Severity)
                    .HasColumnName("SEVERITY")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnName("STATUS_NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao2f1435Properties>(entity =>
            {
                entity.ToTable("AO_2F1435_PROPERTIES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasColumnName("PROPERTY_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PropertyValue)
                    .IsRequired()
                    .HasColumnName("PROPERTY_VALUE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao2f1435ReadNotifications>(entity =>
            {
                entity.ToTable("AO_2F1435_READ_NOTIFICATIONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsSnoozed).HasColumnName("IS_SNOOZED");

                entity.Property(e => e.NotificationId).HasColumnName("NOTIFICATION_ID");

                entity.Property(e => e.SnoozeCount).HasColumnName("SNOOZE_COUNT");

                entity.Property(e => e.SnoozeDate)
                    .HasColumnName("SNOOZE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserKey)
                    .IsRequired()
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao38321bCustomContentLink>(entity =>
            {
                entity.ToTable("AO_38321B_CUSTOM_CONTENT_LINK");

                entity.HasIndex(e => e.ContentKey)
                    .HasName("index_ao_38321b_cus1828044926");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentKey)
                    .HasColumnName("CONTENT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.LinkLabel)
                    .HasColumnName("LINK_LABEL")
                    .HasMaxLength(255);

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LINK_URL")
                    .HasMaxLength(255);

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            });

            modelBuilder.Entity<Ao3b1893LoopDetection>(entity =>
            {
                entity.ToTable("AO_3B1893_LOOP_DETECTION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.ExpiresAt).HasColumnName("EXPIRES_AT");

                entity.Property(e => e.SenderEmail)
                    .IsRequired()
                    .HasColumnName("SENDER_EMAIL")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Ao3d5e3bAssigneeMapEnt>(entity =>
            {
                entity.ToTable("AO_3D5E3B_ASSIGNEE_MAP_ENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Assignee)
                    .HasColumnName("ASSIGNEE")
                    .HasMaxLength(255);

                entity.Property(e => e.AssigneeType)
                    .HasColumnName("ASSIGNEE_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.JiraProjectKey)
                    .HasColumnName("JIRA_PROJECT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.RowId)
                    .HasColumnName("ROW_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelKey)
                    .HasColumnName("SENTINEL_KEY")
                    .HasColumnType("ntext");

                entity.Property(e => e.SentinelType)
                    .HasColumnName("SENTINEL_TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bBasicConfEnt>(entity =>
            {
                entity.ToTable("AO_3D5E3B_BASIC_CONF_ENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConditionLevel)
                    .HasColumnName("CONDITION_LEVEL")
                    .HasMaxLength(255);

                entity.Property(e => e.CriticalityLevelFilter)
                    .HasColumnName("CRITICALITY_LEVEL_FILTER")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomIssueDescriptionn)
                    .HasColumnName("CUSTOM_ISSUE_DESCRIPTIONN")
                    .HasColumnType("ntext");

                entity.Property(e => e.CustomIssueSummaryy)
                    .HasColumnName("CUSTOM_ISSUE_SUMMARYY")
                    .HasColumnType("ntext");

                entity.Property(e => e.CustomRiskIssueSummaryy)
                    .HasColumnName("CUSTOM_RISK_ISSUE_SUMMARYY")
                    .HasColumnType("ntext");

                entity.Property(e => e.CustomSeverityIssueSummaryy)
                    .HasColumnName("CUSTOM_SEVERITY_ISSUE_SUMMARYY")
                    .HasColumnType("ntext");

                entity.Property(e => e.DastConfigSaved).HasColumnName("DAST_CONFIG_SAVED");

                entity.Property(e => e.DastuserGroups)
                    .HasColumnName("DASTUSER_GROUPS")
                    .HasMaxLength(255);

                entity.Property(e => e.EnableSync).HasColumnName("ENABLE_SYNC");

                entity.Property(e => e.ImportClosed).HasColumnName("IMPORT_CLOSED");

                entity.Property(e => e.JiraAssigneeMap)
                    .HasColumnName("JIRA_ASSIGNEE_MAP")
                    .HasMaxLength(255);

                entity.Property(e => e.LikelihoodLevelFilter)
                    .HasColumnName("LIKELIHOOD_LEVEL_FILTER")
                    .HasMaxLength(255);

                entity.Property(e => e.QuestionsVisibility).HasColumnName("QUESTIONS_VISIBILITY");

                entity.Property(e => e.RatingTypeFilter)
                    .HasColumnName("RATING_TYPE_FILTER")
                    .HasMaxLength(255);

                entity.Property(e => e.RatingValueFilter)
                    .HasColumnName("RATING_VALUE_FILTER")
                    .HasMaxLength(255);

                entity.Property(e => e.Reporter)
                    .HasColumnName("REPORTER")
                    .HasMaxLength(255);

                entity.Property(e => e.RetestVisibility).HasColumnName("RETEST_VISIBILITY");

                entity.Property(e => e.SastConfigSaved).HasColumnName("SAST_CONFIG_SAVED");

                entity.Property(e => e.SastquestionsVisibility).HasColumnName("SASTQUESTIONS_VISIBILITY");

                entity.Property(e => e.SastuserGroups)
                    .HasColumnName("SASTUSER_GROUPS")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelRatingMapSelected)
                    .HasColumnName("SENTINEL_RATING_MAP_SELECTED")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelRatingType)
                    .HasColumnName("SENTINEL_RATING_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelType)
                    .HasColumnName("SENTINEL_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.TagnoteVisibility).HasColumnName("TAGNOTE_VISIBILITY");

                entity.Property(e => e.Tags)
                    .HasColumnName("TAGS")
                    .HasMaxLength(255);

                entity.Property(e => e.UserGroups)
                    .HasColumnName("USER_GROUPS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bCustomFieldsEnt>(entity =>
            {
                entity.ToTable("AO_3D5E3B_CUSTOM_FIELDS_ENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.TransitionActionId).HasColumnName("TRANSITION_ACTION_ID");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bFieldAssignmentEnt>(entity =>
            {
                entity.ToTable("AO_3D5E3B_FIELD_ASSIGNMENT_ENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.FieldType)
                    .HasColumnName("FIELD_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.FieldValue)
                    .HasColumnName("FIELD_VALUE")
                    .HasMaxLength(255);

                entity.Property(e => e.ScreenType)
                    .HasColumnName("SCREEN_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelType)
                    .HasColumnName("SENTINEL_TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bGlobalConfigEntity>(entity =>
            {
                entity.ToTable("AO_3D5E3B_GLOBAL_CONFIG_ENTITY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apikey)
                    .HasColumnName("APIKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Authenticate).HasColumnName("AUTHENTICATE");

                entity.Property(e => e.AuthenticateProxy).HasColumnName("AUTHENTICATE_PROXY");

                entity.Property(e => e.BlackoutTime).HasColumnName("BLACKOUT_TIME");

                entity.Property(e => e.BlackoutTime2).HasColumnName("BLACKOUT_TIME2");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CommentField)
                    .HasColumnName("COMMENT_FIELD")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatingIssuesAlert).HasColumnName("CREATING_ISSUES_ALERT");

                entity.Property(e => e.CustomizeJiraTextLimit).HasColumnName("CUSTOMIZE_JIRA_TEXT_LIMIT");

                entity.Property(e => e.EmailAlert)
                    .HasColumnName("EMAIL_ALERT")
                    .HasMaxLength(255);

                entity.Property(e => e.EnableDelta).HasColumnName("ENABLE_DELTA");

                entity.Property(e => e.EnableProxySettings).HasColumnName("ENABLE_PROXY_SETTINGS");

                entity.Property(e => e.EndHour)
                    .HasColumnName("END_HOUR")
                    .HasMaxLength(255);

                entity.Property(e => e.EndHour2)
                    .HasColumnName("END_HOUR2")
                    .HasMaxLength(255);

                entity.Property(e => e.EndMnt)
                    .HasColumnName("END_MNT")
                    .HasMaxLength(255);

                entity.Property(e => e.EndMnt2)
                    .HasColumnName("END_MNT2")
                    .HasMaxLength(255);

                entity.Property(e => e.GlobalConfigSaved).HasColumnName("GLOBAL_CONFIG_SAVED");

                entity.Property(e => e.IgnoreCert).HasColumnName("IGNORE_CERT");

                entity.Property(e => e.ImportClosed).HasColumnName("IMPORT_CLOSED");

                entity.Property(e => e.IntervalBtwTicket).HasColumnName("INTERVAL_BTW_TICKET");

                entity.Property(e => e.JiraTextLimit).HasColumnName("JIRA_TEXT_LIMIT");

                entity.Property(e => e.LastSuccessSync)
                    .HasColumnName("LAST_SUCCESS_SYNC")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdate).HasColumnName("LAST_UPDATE");

                entity.Property(e => e.LogBufferSize).HasColumnName("LOG_BUFFER_SIZE");

                entity.Property(e => e.LogLevel)
                    .HasColumnName("LOG_LEVEL")
                    .HasMaxLength(255);

                entity.Property(e => e.LookupVulnerabilityInfo).HasColumnName("LOOKUP_VULNERABILITY_INFO");

                entity.Property(e => e.NumWorkerThreads).HasColumnName("NUM_WORKER_THREADS");

                entity.Property(e => e.PagesPerRequest).HasColumnName("PAGES_PER_REQUEST");

                entity.Property(e => e.ProxyHost)
                    .HasColumnName("PROXY_HOST")
                    .HasMaxLength(255);

                entity.Property(e => e.ProxyPassword)
                    .HasColumnName("PROXY_PASSWORD")
                    .HasMaxLength(255);

                entity.Property(e => e.ProxyPort).HasColumnName("PROXY_PORT");

                entity.Property(e => e.ProxyUsername)
                    .HasColumnName("PROXY_USERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ReopenJiraIssues).HasColumnName("REOPEN_JIRA_ISSUES");

                entity.Property(e => e.ResolveJiraIssues).HasColumnName("RESOLVE_JIRA_ISSUES");

                entity.Property(e => e.SchedulerState).HasColumnName("SCHEDULER_STATE");

                entity.Property(e => e.SentinelApiAlert).HasColumnName("SENTINEL_API_ALERT");

                entity.Property(e => e.SentinelServerLocation)
                    .HasColumnName("SENTINEL_SERVER_LOCATION")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelServerUrl)
                    .HasColumnName("SENTINEL_SERVER_URL")
                    .HasMaxLength(255);

                entity.Property(e => e.ShouldCommentIssue).HasColumnName("SHOULD_COMMENT_ISSUE");

                entity.Property(e => e.ShowOnlyCustomDescSol).HasColumnName("SHOW_ONLY_CUSTOM_DESC_SOL");

                entity.Property(e => e.SourceServerUrl)
                    .HasColumnName("SOURCE_SERVER_URL")
                    .HasMaxLength(255);

                entity.Property(e => e.StartHour)
                    .HasColumnName("START_HOUR")
                    .HasMaxLength(255);

                entity.Property(e => e.StartHour2)
                    .HasColumnName("START_HOUR2")
                    .HasMaxLength(255);

                entity.Property(e => e.StartMnt)
                    .HasColumnName("START_MNT")
                    .HasMaxLength(255);

                entity.Property(e => e.StartMnt2)
                    .HasColumnName("START_MNT2")
                    .HasMaxLength(255);

                entity.Property(e => e.SyncInterval).HasColumnName("SYNC_INTERVAL");

                entity.Property(e => e.WhiteHatKey)
                    .HasColumnName("WHITE_HAT_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bGlobalTempEntity>(entity =>
            {
                entity.ToTable("AO_3D5E3B_GLOBAL_TEMP_ENTITY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apikey)
                    .HasColumnName("APIKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Authenticate).HasColumnName("AUTHENTICATE");

                entity.Property(e => e.AuthenticateProxy).HasColumnName("AUTHENTICATE_PROXY");

                entity.Property(e => e.BlackoutTime).HasColumnName("BLACKOUT_TIME");

                entity.Property(e => e.BlackoutTime2).HasColumnName("BLACKOUT_TIME2");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CommentField)
                    .HasColumnName("COMMENT_FIELD")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatingIssuesAlert).HasColumnName("CREATING_ISSUES_ALERT");

                entity.Property(e => e.CustomizeJiraTextLimit).HasColumnName("CUSTOMIZE_JIRA_TEXT_LIMIT");

                entity.Property(e => e.EmailAlert)
                    .HasColumnName("EMAIL_ALERT")
                    .HasMaxLength(255);

                entity.Property(e => e.EnableDelta).HasColumnName("ENABLE_DELTA");

                entity.Property(e => e.EnableProxySettings).HasColumnName("ENABLE_PROXY_SETTINGS");

                entity.Property(e => e.EndHour)
                    .HasColumnName("END_HOUR")
                    .HasMaxLength(255);

                entity.Property(e => e.EndHour2)
                    .HasColumnName("END_HOUR2")
                    .HasMaxLength(255);

                entity.Property(e => e.EndMnt)
                    .HasColumnName("END_MNT")
                    .HasMaxLength(255);

                entity.Property(e => e.EndMnt2)
                    .HasColumnName("END_MNT2")
                    .HasMaxLength(255);

                entity.Property(e => e.IgnoreCert).HasColumnName("IGNORE_CERT");

                entity.Property(e => e.ImportClosed).HasColumnName("IMPORT_CLOSED");

                entity.Property(e => e.IntervalBtwTicket).HasColumnName("INTERVAL_BTW_TICKET");

                entity.Property(e => e.JiraTextLimit).HasColumnName("JIRA_TEXT_LIMIT");

                entity.Property(e => e.LastSuccessSync)
                    .HasColumnName("LAST_SUCCESS_SYNC")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdate).HasColumnName("LAST_UPDATE");

                entity.Property(e => e.LogBufferSize).HasColumnName("LOG_BUFFER_SIZE");

                entity.Property(e => e.LogLevel)
                    .HasColumnName("LOG_LEVEL")
                    .HasMaxLength(255);

                entity.Property(e => e.LookupVulnerabilityInfo).HasColumnName("LOOKUP_VULNERABILITY_INFO");

                entity.Property(e => e.NumWorkerThreads).HasColumnName("NUM_WORKER_THREADS");

                entity.Property(e => e.PagesPerRequest).HasColumnName("PAGES_PER_REQUEST");

                entity.Property(e => e.ProxyHost)
                    .HasColumnName("PROXY_HOST")
                    .HasMaxLength(255);

                entity.Property(e => e.ProxyPassword)
                    .HasColumnName("PROXY_PASSWORD")
                    .HasMaxLength(255);

                entity.Property(e => e.ProxyPort).HasColumnName("PROXY_PORT");

                entity.Property(e => e.ProxyUsername)
                    .HasColumnName("PROXY_USERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ReopenJiraIssues).HasColumnName("REOPEN_JIRA_ISSUES");

                entity.Property(e => e.ResolveJiraIssues).HasColumnName("RESOLVE_JIRA_ISSUES");

                entity.Property(e => e.SchedulerState).HasColumnName("SCHEDULER_STATE");

                entity.Property(e => e.SentinelApiAlert).HasColumnName("SENTINEL_API_ALERT");

                entity.Property(e => e.SentinelServerLocation)
                    .HasColumnName("SENTINEL_SERVER_LOCATION")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelServerUrl)
                    .HasColumnName("SENTINEL_SERVER_URL")
                    .HasMaxLength(255);

                entity.Property(e => e.ShouldCommentIssue).HasColumnName("SHOULD_COMMENT_ISSUE");

                entity.Property(e => e.ShowOnlyCustomDescSol).HasColumnName("SHOW_ONLY_CUSTOM_DESC_SOL");

                entity.Property(e => e.StartHour)
                    .HasColumnName("START_HOUR")
                    .HasMaxLength(255);

                entity.Property(e => e.StartHour2)
                    .HasColumnName("START_HOUR2")
                    .HasMaxLength(255);

                entity.Property(e => e.StartMnt)
                    .HasColumnName("START_MNT")
                    .HasMaxLength(255);

                entity.Property(e => e.StartMnt2)
                    .HasColumnName("START_MNT2")
                    .HasMaxLength(255);

                entity.Property(e => e.SyncInterval).HasColumnName("SYNC_INTERVAL");

                entity.Property(e => e.WhiteHatKey)
                    .HasColumnName("WHITE_HAT_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bJiraPriorMapEnt>(entity =>
            {
                entity.ToTable("AO_3D5E3B_JIRA_PRIOR_MAP_ENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JiraPriority)
                    .HasColumnName("JIRA_PRIORITY")
                    .HasMaxLength(255);

                entity.Property(e => e.RowId)
                    .HasColumnName("ROW_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelRating)
                    .HasColumnName("SENTINEL_RATING")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelRatingMapSelected)
                    .HasColumnName("SENTINEL_RATING_MAP_SELECTED")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelRatingType)
                    .HasColumnName("SENTINEL_RATING_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.SentinelType)
                    .HasColumnName("SENTINEL_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bSentinelLogger>(entity =>
            {
                entity.ToTable("AO_3D5E3B_SENTINEL_LOGGER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Log)
                    .HasColumnName("LOG")
                    .HasColumnType("ntext");

                entity.Property(e => e.NewRowId).HasColumnName("NEW_ROW_ID");

                entity.Property(e => e.RowId)
                    .HasColumnName("ROW_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bStatusEntity>(entity =>
            {
                entity.ToTable("AO_3D5E3B_STATUS_ENTITY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("WORKFLOW_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bStatusMappingEnt>(entity =>
            {
                entity.ToTable("AO_3D5E3B_STATUS_MAPPING_ENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("WORKFLOW_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bTransitionActEnt>(entity =>
            {
                entity.ToTable("AO_3D5E3B_TRANSITION_ACT_ENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ACTION_ID");

                entity.Property(e => e.TransitionId).HasColumnName("TRANSITION_ID");
            });

            modelBuilder.Entity<Ao3d5e3bTransitionEntity>(entity =>
            {
                entity.ToTable("AO_3D5E3B_TRANSITION_ENTITY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");
            });

            modelBuilder.Entity<Ao3d5e3bWorkflowEntity>(entity =>
            {
                entity.ToTable("AO_3D5E3B_WORKFLOW_ENTITY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectKeys)
                    .HasColumnName("PROJECT_KEYS")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao3d5e3bWorkflowXml>(entity =>
            {
                entity.ToTable("AO_3D5E3B_WORKFLOW_XML");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WorkflowName)
                    .HasColumnName("WORKFLOW_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.XmlConfiguration)
                    .HasColumnName("XML_CONFIGURATION")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Ao4aeacdWebhookDao>(entity =>
            {
                entity.ToTable("AO_4AEACD_WEBHOOK_DAO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Enabled).HasColumnName("ENABLED");

                entity.Property(e => e.EncodedEvents)
                    .HasColumnName("ENCODED_EVENTS")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExcludeIssueDetails).HasColumnName("EXCLUDE_ISSUE_DETAILS");

                entity.Property(e => e.Filter)
                    .HasColumnName("FILTER")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedUser)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("ntext");

                entity.Property(e => e.Parameters)
                    .HasColumnName("PARAMETERS")
                    .HasColumnType("ntext");

                entity.Property(e => e.RegistrationMethod)
                    .IsRequired()
                    .HasColumnName("REGISTRATION_METHOD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Ao550953Shortcut>(entity =>
            {
                entity.ToTable("AO_550953_SHORTCUT");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_ao_550953_sho1778115994");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Icon)
                    .HasColumnName("ICON")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");

                entity.Property(e => e.ShortcutUrl)
                    .HasColumnName("SHORTCUT_URL")
                    .HasColumnType("ntext");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao563aeeActivityEntity>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.ToTable("AO_563AEE_ACTIVITY_ENTITY");

                entity.HasIndex(e => e.ActorId)
                    .HasName("index_ao_563aee_act995325379");

                entity.HasIndex(e => e.IconId)
                    .HasName("index_ao_563aee_act972488439");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("index_ao_563aee_act1642652291");

                entity.HasIndex(e => e.TargetId)
                    .HasName("index_ao_563aee_act1978295567");

                entity.Property(e => e.ActivityId).HasColumnName("ACTIVITY_ID");

                entity.Property(e => e.ActorId).HasColumnName("ACTOR_ID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.GeneratorDisplayName)
                    .HasColumnName("GENERATOR_DISPLAY_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratorId)
                    .HasColumnName("GENERATOR_ID")
                    .HasMaxLength(450);

                entity.Property(e => e.IconId).HasColumnName("ICON_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(450);

                entity.Property(e => e.IssueKey)
                    .HasColumnName("ISSUE_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectId).HasColumnName("OBJECT_ID");

                entity.Property(e => e.Poster)
                    .HasColumnName("POSTER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectKey)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Published)
                    .HasColumnName("PUBLISHED")
                    .HasColumnType("datetime");

                entity.Property(e => e.TargetId).HasColumnName("TARGET_ID");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(450);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Verb)
                    .HasColumnName("VERB")
                    .HasMaxLength(450);

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.Ao563aeeActivityEntity)
                    .HasForeignKey(d => d.ActorId)
                    .HasConstraintName("fk_ao_563aee_activity_entity_actor_id");

                entity.HasOne(d => d.Icon)
                    .WithMany(p => p.Ao563aeeActivityEntity)
                    .HasForeignKey(d => d.IconId)
                    .HasConstraintName("fk_ao_563aee_activity_entity_icon_id");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.Ao563aeeActivityEntity)
                    .HasForeignKey(d => d.ObjectId)
                    .HasConstraintName("fk_ao_563aee_activity_entity_object_id");

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.Ao563aeeActivityEntity)
                    .HasForeignKey(d => d.TargetId)
                    .HasConstraintName("fk_ao_563aee_activity_entity_target_id");
            });

            modelBuilder.Entity<Ao563aeeActorEntity>(entity =>
            {
                entity.ToTable("AO_563AEE_ACTOR_ENTITY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePageUri)
                    .HasColumnName("PROFILE_PAGE_URI")
                    .HasMaxLength(450);

                entity.Property(e => e.ProfilePictureUri)
                    .HasColumnName("PROFILE_PICTURE_URI")
                    .HasMaxLength(450);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao563aeeMediaLinkEntity>(entity =>
            {
                entity.ToTable("AO_563AEE_MEDIA_LINK_ENTITY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Height).HasColumnName("HEIGHT");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(450);

                entity.Property(e => e.Width).HasColumnName("WIDTH");
            });

            modelBuilder.Entity<Ao563aeeObjectEntity>(entity =>
            {
                entity.ToTable("AO_563AEE_OBJECT_ENTITY");

                entity.HasIndex(e => e.ImageId)
                    .HasName("index_ao_563aee_obj696886343");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("DISPLAY_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId).HasColumnName("IMAGE_ID");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasMaxLength(450);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(450);

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(450);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Ao563aeeObjectEntity)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("fk_ao_563aee_object_entity_image_id");
            });

            modelBuilder.Entity<Ao563aeeTargetEntity>(entity =>
            {
                entity.ToTable("AO_563AEE_TARGET_ENTITY");

                entity.HasIndex(e => e.ImageId)
                    .HasName("index_ao_563aee_tar521440921");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("DISPLAY_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId).HasColumnName("IMAGE_ID");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasMaxLength(450);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(450);

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(450);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Ao563aeeTargetEntity)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("fk_ao_563aee_target_entity_image_id");
            });

            modelBuilder.Entity<Ao575bf5DevSummary>(entity =>
            {
                entity.ToTable("AO_575BF5_DEV_SUMMARY");

                entity.HasIndex(e => e.IssueId)
                    .HasName("index_ao_575bf5_dev567785983");

                entity.HasIndex(e => e.ProviderSourceId)
                    .HasName("index_ao_575bf5_dev996442447");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.IssueId).HasColumnName("ISSUE_ID");

                entity.Property(e => e.Json).HasColumnName("JSON");

                entity.Property(e => e.ProviderSourceId)
                    .IsRequired()
                    .HasColumnName("PROVIDER_SOURCE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Ao575bf5ProcessedCommits>(entity =>
            {
                entity.ToTable("AO_575BF5_PROCESSED_COMMITS");

                entity.HasIndex(e => e.CommitHash)
                    .HasName("index_ao_575bf5_pro1681808571");

                entity.HasIndex(e => e.MetadataHash)
                    .HasName("index_ao_575bf5_pro78019725");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommitHash)
                    .IsRequired()
                    .HasColumnName("COMMIT_HASH")
                    .HasMaxLength(255);

                entity.Property(e => e.MetadataHash)
                    .HasColumnName("METADATA_HASH")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao575bf5ProviderIssue>(entity =>
            {
                entity.ToTable("AO_575BF5_PROVIDER_ISSUE");

                entity.HasIndex(e => e.IssueId)
                    .HasName("index_ao_575bf5_pro741170824");

                entity.HasIndex(e => e.ProviderSourceId)
                    .HasName("index_ao_575bf5_pro1348521624");

                entity.HasIndex(e => e.StaleAfter)
                    .HasName("index_ao_575bf5_pro1117502689");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IssueId).HasColumnName("ISSUE_ID");

                entity.Property(e => e.ProviderSourceId)
                    .IsRequired()
                    .HasColumnName("PROVIDER_SOURCE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.StaleAfter).HasColumnName("STALE_AFTER");
            });

            modelBuilder.Entity<Ao575bf5ProviderSeqNo>(entity =>
            {
                entity.ToTable("AO_575BF5_PROVIDER_SEQ_NO");

                entity.HasIndex(e => e.ProviderSourceId)
                    .HasName("index_ao_575bf5_pro996609822");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProviderSourceId)
                    .IsRequired()
                    .HasColumnName("PROVIDER_SOURCE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao587b34GlanceConfig>(entity =>
            {
                entity.HasKey(e => e.RoomId);

                entity.ToTable("AO_587B34_GLANCE_CONFIG");

                entity.Property(e => e.RoomId)
                    .HasColumnName("ROOM_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationUserKey)
                    .HasColumnName("APPLICATION_USER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Jql)
                    .HasColumnName("JQL")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(255);

                entity.Property(e => e.SyncNeeded).HasColumnName("SYNC_NEEDED");
            });

            modelBuilder.Entity<Ao587b34ProjectConfig>(entity =>
            {
                entity.ToTable("AO_587B34_PROJECT_CONFIG");

                entity.HasIndex(e => e.ConfigurationGroupId)
                    .HasName("index_ao_587b34_pro193829489");

                entity.HasIndex(e => e.Name)
                    .HasName("index_ao_587b34_pro2115480362");

                entity.HasIndex(e => e.NameUniqueConstraint)
                    .HasName("U_AO_587B34_PROJECT2070954277")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_ao_587b34_pro2093917684");

                entity.HasIndex(e => e.RoomId)
                    .HasName("index_ao_587b34_pro1732672724");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConfigurationGroupId)
                    .IsRequired()
                    .HasColumnName("CONFIGURATION_GROUP_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.NameUniqueConstraint)
                    .IsRequired()
                    .HasColumnName("NAME_UNIQUE_CONSTRAINT")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");

                entity.Property(e => e.RoomId).HasColumnName("ROOM_ID");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao5fb9d7AohipChatLink>(entity =>
            {
                entity.ToTable("AO_5FB9D7_AOHIP_CHAT_LINK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddonTokenExpiry)
                    .HasColumnName("ADDON_TOKEN_EXPIRY")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApiUrl)
                    .HasColumnName("API_URL")
                    .HasMaxLength(255);

                entity.Property(e => e.ConnectDescriptor)
                    .HasColumnName("CONNECT_DESCRIPTOR")
                    .HasColumnType("ntext");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.OauthId)
                    .HasColumnName("OAUTH_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SecretKey)
                    .HasColumnName("SECRET_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.SystemPassword)
                    .HasColumnName("SYSTEM_PASSWORD")
                    .HasMaxLength(255);

                entity.Property(e => e.SystemTokenExpiry)
                    .HasColumnName("SYSTEM_TOKEN_EXPIRY")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemUser)
                    .HasColumnName("SYSTEM_USER")
                    .HasMaxLength(255);

                entity.Property(e => e.SystemUserToken)
                    .HasColumnName("SYSTEM_USER_TOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.Token)
                    .HasColumnName("TOKEN")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao5fb9d7AohipChatUser>(entity =>
            {
                entity.ToTable("AO_5FB9D7_AOHIP_CHAT_USER");

                entity.HasIndex(e => e.HipChatLinkId)
                    .HasName("index_ao_5fb9d7_aoh49772492");

                entity.HasIndex(e => e.UserKey)
                    .HasName("index_ao_5fb9d7_aoh1981563178");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HipChatLinkId).HasColumnName("HIP_CHAT_LINK_ID");

                entity.Property(e => e.HipChatUserId)
                    .HasColumnName("HIP_CHAT_USER_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.HipChatUserName)
                    .HasColumnName("HIP_CHAT_USER_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.RefreshCode)
                    .HasColumnName("REFRESH_CODE")
                    .HasMaxLength(255);

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.UserScopes)
                    .HasColumnName("USER_SCOPES")
                    .HasMaxLength(255);

                entity.Property(e => e.UserToken)
                    .HasColumnName("USER_TOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.UserTokenExpiry)
                    .HasColumnName("USER_TOKEN_EXPIRY")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.HipChatLink)
                    .WithMany(p => p.Ao5fb9d7AohipChatUser)
                    .HasForeignKey(d => d.HipChatLinkId)
                    .HasConstraintName("fk_ao_5fb9d7_aohip_chat_user_hip_chat_link_id");
            });

            modelBuilder.Entity<Ao60db71Auditentry>(entity =>
            {
                entity.ToTable("AO_60DB71_AUDITENTRY");

                entity.HasIndex(e => e.Category)
                    .HasName("index_ao_60db71_aud1756477597");

                entity.HasIndex(e => e.EntityClass)
                    .HasName("index_ao_60db71_aud137736645");

                entity.HasIndex(e => e.EntityId)
                    .HasName("index_ao_60db71_aud604788536");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("DATA")
                    .HasColumnType("ntext");

                entity.Property(e => e.EntityClass)
                    .IsRequired()
                    .HasColumnName("ENTITY_CLASS")
                    .HasMaxLength(255);

                entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

                entity.Property(e => e.Time).HasColumnName("TIME");

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao60db71Boardadmins>(entity =>
            {
                entity.ToTable("AO_60DB71_BOARDADMINS");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_boa2110227660");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Boardadmins)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_boardadmins_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Cardcolor>(entity =>
            {
                entity.ToTable("AO_60DB71_CARDCOLOR");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_car2031978979");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Color)
                    .HasColumnName("COLOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.Property(e => e.Strategy)
                    .HasColumnName("STRATEGY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Val)
                    .HasColumnName("VAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Cardcolor)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_cardcolor_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Cardlayout>(entity =>
            {
                entity.ToTable("AO_60DB71_CARDLAYOUT");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_car149237770");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldId)
                    .IsRequired()
                    .HasColumnName("FIELD_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ModeName)
                    .IsRequired()
                    .HasColumnName("MODE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Cardlayout)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_cardlayout_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Column>(entity =>
            {
                entity.ToTable("AO_60DB71_COLUMN");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_col2098611346");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Maxim).HasColumnName("MAXIM");

                entity.Property(e => e.Minim).HasColumnName("MINIM");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Column)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_column_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Columnstatus>(entity =>
            {
                entity.ToTable("AO_60DB71_COLUMNSTATUS");

                entity.HasIndex(e => e.ColumnId)
                    .HasName("index_ao_60db71_col1856623434");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnId).HasColumnName("COLUMN_ID");

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.StatusId)
                    .HasColumnName("STATUS_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Column)
                    .WithMany(p => p.Ao60db71Columnstatus)
                    .HasForeignKey(d => d.ColumnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_columnstatus_column_id");
            });

            modelBuilder.Entity<Ao60db71Detailviewfield>(entity =>
            {
                entity.ToTable("AO_60DB71_DETAILVIEWFIELD");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_det878495474");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldId)
                    .IsRequired()
                    .HasColumnName("FIELD_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Detailviewfield)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_detailviewfield_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Estimatestatistic>(entity =>
            {
                entity.ToTable("AO_60DB71_ESTIMATESTATISTIC");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_est1680565966");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FIELD_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.Property(e => e.TypeId)
                    .IsRequired()
                    .HasColumnName("TYPE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Estimatestatistic)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_estimatestatistic_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Issueranking>(entity =>
            {
                entity.ToTable("AO_60DB71_ISSUERANKING");

                entity.HasIndex(e => e.CustomFieldId)
                    .HasName("index_ao_60db71_iss1786461035");

                entity.HasIndex(e => e.IssueId)
                    .HasName("index_ao_60db71_iss1616896230");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomFieldId).HasColumnName("CUSTOM_FIELD_ID");

                entity.Property(e => e.IssueId).HasColumnName("ISSUE_ID");

                entity.Property(e => e.NextId).HasColumnName("NEXT_ID");
            });

            modelBuilder.Entity<Ao60db71Issuerankinglog>(entity =>
            {
                entity.ToTable("AO_60DB71_ISSUERANKINGLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomFieldId).HasColumnName("CUSTOM_FIELD_ID");

                entity.Property(e => e.IssueId).HasColumnName("ISSUE_ID");

                entity.Property(e => e.LogType)
                    .HasColumnName("LOG_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewNextId).HasColumnName("NEW_NEXT_ID");

                entity.Property(e => e.NewPreviousId).HasColumnName("NEW_PREVIOUS_ID");

                entity.Property(e => e.OldNextId).HasColumnName("OLD_NEXT_ID");

                entity.Property(e => e.OldPreviousId).HasColumnName("OLD_PREVIOUS_ID");

                entity.Property(e => e.SanityChecked)
                    .HasColumnName("SANITY_CHECKED")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao60db71Lexorank>(entity =>
            {
                entity.ToTable("AO_60DB71_LEXORANK");

                entity.HasIndex(e => e.IssueId)
                    .HasName("index_ao_60db71_lex604083109");

                entity.HasIndex(e => e.LockHash)
                    .HasName("index_ao_60db71_lex1632828616");

                entity.HasIndex(e => new { e.FieldId, e.Rank })
                    .HasName("index_ao_60db71_lex1569533973");

                entity.HasIndex(e => new { e.FieldId, e.Bucket, e.Rank })
                    .HasName("index_ao_60db71_lex1694305086");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bucket).HasColumnName("BUCKET");

                entity.Property(e => e.FieldId).HasColumnName("FIELD_ID");

                entity.Property(e => e.IssueId).HasColumnName("ISSUE_ID");

                entity.Property(e => e.LockHash)
                    .HasColumnName("LOCK_HASH")
                    .HasMaxLength(255);

                entity.Property(e => e.LockTime).HasColumnName("LOCK_TIME");

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasColumnName("RANK")
                    .HasMaxLength(255);

                entity.Property(e => e.Type).HasColumnName("TYPE");
            });

            modelBuilder.Entity<Ao60db71Lexorankbalancer>(entity =>
            {
                entity.ToTable("AO_60DB71_LEXORANKBALANCER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisableRankOperations).HasColumnName("DISABLE_RANK_OPERATIONS");

                entity.Property(e => e.FieldId).HasColumnName("FIELD_ID");

                entity.Property(e => e.RebalanceTime).HasColumnName("REBALANCE_TIME");
            });

            modelBuilder.Entity<Ao60db71Nonworkingday>(entity =>
            {
                entity.ToTable("AO_60DB71_NONWORKINGDAY");

                entity.HasIndex(e => e.WorkingDaysId)
                    .HasName("index_ao_60db71_non1145824037");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iso8601Date)
                    .IsRequired()
                    .HasColumnName("ISO8601_DATE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingDaysId).HasColumnName("WORKING_DAYS_ID");

                entity.HasOne(d => d.WorkingDays)
                    .WithMany(p => p.Ao60db71Nonworkingday)
                    .HasForeignKey(d => d.WorkingDaysId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_nonworkingday_working_days_id");
            });

            modelBuilder.Entity<Ao60db71Quickfilter>(entity =>
            {
                entity.ToTable("AO_60DB71_QUICKFILTER");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_qui432573905");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongQuery)
                    .HasColumnName("LONG_QUERY")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.Query)
                    .HasColumnName("QUERY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Quickfilter)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_quickfilter_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Rankableobject>(entity =>
            {
                entity.ToTable("AO_60DB71_RANKABLEOBJECT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao60db71RankIssueLink>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("AO_60DB71_RANK_ISSUE_LINK");

                entity.Property(e => e.IssueId)
                    .HasColumnName("ISSUE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NextId).HasColumnName("NEXT_ID");
            });

            modelBuilder.Entity<Ao60db71Rapidview>(entity =>
            {
                entity.ToTable("AO_60DB71_RAPIDVIEW");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardColorStrategy)
                    .HasColumnName("CARD_COLOR_STRATEGY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KanPlanEnabled).HasColumnName("KAN_PLAN_ENABLED");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OldDoneIssuesCutoff)
                    .HasColumnName("OLD_DONE_ISSUES_CUTOFF")
                    .HasMaxLength(255);

                entity.Property(e => e.OwnerUserName)
                    .IsRequired()
                    .HasColumnName("OWNER_USER_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SavedFilterId).HasColumnName("SAVED_FILTER_ID");

                entity.Property(e => e.ShowDaysInColumn).HasColumnName("SHOW_DAYS_IN_COLUMN");

                entity.Property(e => e.ShowEpicAsPanel).HasColumnName("SHOW_EPIC_AS_PANEL");

                entity.Property(e => e.SprintMarkersMigrated).HasColumnName("SPRINT_MARKERS_MIGRATED");

                entity.Property(e => e.SprintsEnabled).HasColumnName("SPRINTS_ENABLED");

                entity.Property(e => e.SwimlaneStrategy)
                    .HasColumnName("SWIMLANE_STRATEGY")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao60db71Sprint>(entity =>
            {
                entity.ToTable("AO_60DB71_SPRINT");

                entity.HasIndex(e => e.Sequence)
                    .HasName("index_ao_60db71_spr1457658269");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Closed).HasColumnName("CLOSED");

                entity.Property(e => e.CompleteDate).HasColumnName("COMPLETE_DATE");

                entity.Property(e => e.EndDate).HasColumnName("END_DATE");

                entity.Property(e => e.Goal).HasColumnName("GOAL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.StartDate).HasColumnName("START_DATE");

                entity.Property(e => e.Started).HasColumnName("STARTED");
            });

            modelBuilder.Entity<Ao60db71Sprintmarker>(entity =>
            {
                entity.ToTable("AO_60DB71_SPRINTMARKER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MarkerContext).HasColumnName("MARKER_CONTEXT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao60db71Statsfield>(entity =>
            {
                entity.ToTable("AO_60DB71_STATSFIELD");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_sta1907922871");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.Property(e => e.TypeId)
                    .IsRequired()
                    .HasColumnName("TYPE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Statsfield)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_statsfield_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Subquery>(entity =>
            {
                entity.ToTable("AO_60DB71_SUBQUERY");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_sub730851836");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LongQuery)
                    .HasColumnName("LONG_QUERY")
                    .HasColumnType("ntext");

                entity.Property(e => e.Query)
                    .HasColumnName("QUERY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasColumnName("SECTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Subquery)
                    .HasForeignKey(d => d.RapidViewId)
                    .HasConstraintName("fk_ao_60db71_subquery_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Swimlane>(entity =>
            {
                entity.ToTable("AO_60DB71_SWIMLANE");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_swi1429284592");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DefaultLane).HasColumnName("DEFAULT_LANE");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LongQuery)
                    .HasColumnName("LONG_QUERY")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.Query)
                    .HasColumnName("QUERY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Swimlane)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_swimlane_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Trackingstatistic>(entity =>
            {
                entity.ToTable("AO_60DB71_TRACKINGSTATISTIC");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_tra1711190333");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FIELD_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.Property(e => e.TypeId)
                    .IsRequired()
                    .HasColumnName("TYPE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Trackingstatistic)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_trackingstatistic_rapid_view_id");
            });

            modelBuilder.Entity<Ao60db71Version>(entity =>
            {
                entity.ToTable("AO_60DB71_VERSION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StartDate).HasColumnName("START_DATE");

                entity.Property(e => e.VersionId).HasColumnName("VERSION_ID");
            });

            modelBuilder.Entity<Ao60db71Workingdays>(entity =>
            {
                entity.ToTable("AO_60DB71_WORKINGDAYS");

                entity.HasIndex(e => e.RapidViewId)
                    .HasName("index_ao_60db71_wor1205491794");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Friday).HasColumnName("FRIDAY");

                entity.Property(e => e.Monday).HasColumnName("MONDAY");

                entity.Property(e => e.RapidViewId).HasColumnName("RAPID_VIEW_ID");

                entity.Property(e => e.Saturday).HasColumnName("SATURDAY");

                entity.Property(e => e.Sunday).HasColumnName("SUNDAY");

                entity.Property(e => e.Thursday).HasColumnName("THURSDAY");

                entity.Property(e => e.Timezone)
                    .IsRequired()
                    .HasColumnName("TIMEZONE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tuesday).HasColumnName("TUESDAY");

                entity.Property(e => e.Wednesday).HasColumnName("WEDNESDAY");

                entity.HasOne(d => d.RapidView)
                    .WithMany(p => p.Ao60db71Workingdays)
                    .HasForeignKey(d => d.RapidViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ao_60db71_workingdays_rapid_view_id");
            });

            modelBuilder.Entity<Ao86ed1bGracePeriod>(entity =>
            {
                entity.ToTable("AO_86ED1B_GRACE_PERIOD");

                entity.HasIndex(e => e.Receiver)
                    .HasName("U_AO_86ED1B_GRACE_P168218652")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenUntil)
                    .HasColumnName("OPEN_UNTIL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasColumnName("RECEIVER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Ao86ed1bProjectConfig>(entity =>
            {
                entity.ToTable("AO_86ED1B_PROJECT_CONFIG");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("U_AO_86ED1B_PROJECT1832082062")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PlanningColour)
                    .HasColumnName("PLANNING_COLOUR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
            });

            modelBuilder.Entity<Ao86ed1bStreamsEntry>(entity =>
            {
                entity.ToTable("AO_86ED1B_STREAMS_ENTRY");

                entity.HasIndex(e => e.PostedDate)
                    .HasName("index_ao_86ed1b_str962764104");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Actor)
                    .HasColumnName("ACTOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EntryClass)
                    .HasColumnName("ENTRY_CLASS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType)
                    .HasColumnName("ENTRY_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate)
                    .HasColumnName("POSTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RawParamsJson)
                    .HasColumnName("RAW_PARAMS_JSON")
                    .HasColumnType("ntext");

                entity.Property(e => e.Receiver)
                    .HasColumnName("RECEIVER")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao86ed1bTimeplan>(entity =>
            {
                entity.ToTable("AO_86ED1B_TIMEPLAN");

                entity.HasIndex(e => e.Collaborator)
                    .HasName("index_ao_86ed1b_tim2080992994");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Collaborator)
                    .HasColumnName("COLLABORATOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanId).HasColumnName("PLAN_ID");

                entity.Property(e => e.PlanType)
                    .HasColumnName("PLAN_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Requester)
                    .HasColumnName("REQUESTER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reviewer)
                    .HasColumnName("REVIEWER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Seconds).HasColumnName("SECONDS");

                entity.Property(e => e.TimeType)
                    .HasColumnName("TIME_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkflowStatus)
                    .HasColumnName("WORKFLOW_STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao86ed1bTimesheetStatus>(entity =>
            {
                entity.ToTable("AO_86ED1B_TIMESHEET_STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Actor)
                    .HasColumnName("ACTOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateChanged)
                    .HasColumnName("DATE_CHANGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("DATE_CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFrom)
                    .HasColumnName("DATE_FROM")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTo)
                    .HasColumnName("DATE_TO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Period)
                    .HasColumnName("PERIOD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodType)
                    .HasColumnName("PERIOD_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodView)
                    .HasColumnName("PERIOD_VIEW")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewerUser)
                    .HasColumnName("REVIEWER_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao935429Jsuconfig>(entity =>
            {
                entity.ToTable("AO_935429_JSUCONFIG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Hash)
                    .HasColumnName("HASH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Ao935429Jsusession>(entity =>
            {
                entity.ToTable("AO_935429_JSUSESSION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromUser)
                    .HasColumnName("FROM_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToUser)
                    .HasColumnName("TO_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasColumnName("TOKEN")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ao97edabUserinvitation>(entity =>
            {
                entity.ToTable("AO_97EDAB_USERINVITATION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationKeys)
                    .HasColumnName("APPLICATION_KEYS")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasMaxLength(255);

                entity.Property(e => e.Expiry)
                    .HasColumnName("EXPIRY")
                    .HasColumnType("datetime");

                entity.Property(e => e.Redeemed).HasColumnName("REDEEMED");

                entity.Property(e => e.SenderUsername)
                    .HasColumnName("SENDER_USERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Token)
                    .HasColumnName("TOKEN")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA0b856WebHookListenerAo>(entity =>
            {
                entity.ToTable("AO_A0B856_WEB_HOOK_LISTENER_AO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Enabled).HasColumnName("ENABLED");

                entity.Property(e => e.Events)
                    .HasColumnName("EVENTS")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExcludeBody).HasColumnName("EXCLUDE_BODY");

                entity.Property(e => e.Filters)
                    .HasColumnName("FILTERS")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedUser)
                    .HasColumnName("LAST_UPDATED_USER")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("ntext");

                entity.Property(e => e.Parameters)
                    .HasColumnName("PARAMETERS")
                    .HasColumnType("ntext");

                entity.Property(e => e.RegistrationMethod)
                    .IsRequired()
                    .HasColumnName("REGISTRATION_METHOD")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<AoA44657HealthCheckEntity>(entity =>
            {
                entity.ToTable("AO_A44657_HEALTH_CHECK_ENTITY");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<AoAefed0Team>(entity =>
            {
                entity.ToTable("AO_AEFED0_TEAM");

                entity.HasIndex(e => e.Name)
                    .HasName("U_AO_AEFED0_TEAM_NAME")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AoAefed0TeamMember>(entity =>
            {
                entity.ToTable("AO_AEFED0_TEAM_MEMBER");

                entity.HasIndex(e => e.MemberKey)
                    .HasName("index_ao_aefed0_tea28350697");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberKey)
                    .IsRequired()
                    .HasColumnName("MEMBER_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MemberType)
                    .IsRequired()
                    .HasColumnName("MEMBER_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoleType)
                    .IsRequired()
                    .HasColumnName("ROLE_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AoAefed0TeamToMember>(entity =>
            {
                entity.ToTable("AO_AEFED0_TEAM_TO_MEMBER");

                entity.HasIndex(e => e.TeamId)
                    .HasName("index_ao_aefed0_tea1458208454");

                entity.HasIndex(e => e.TeamMemberId)
                    .HasName("index_ao_aefed0_tea101585109");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TeamId).HasColumnName("TEAM_ID");

                entity.Property(e => e.TeamMemberId).HasColumnName("TEAM_MEMBER_ID");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.AoAefed0TeamToMember)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("fk_ao_aefed0_team_to_member_team_id");

                entity.HasOne(d => d.TeamMember)
                    .WithMany(p => p.AoAefed0TeamToMember)
                    .HasForeignKey(d => d.TeamMemberId)
                    .HasConstraintName("fk_ao_aefed0_team_to_member_team_member_id");
            });

            modelBuilder.Entity<AoB9a0f0AppliedTemplate>(entity =>
            {
                entity.ToTable("AO_B9A0F0_APPLIED_TEMPLATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");

                entity.Property(e => e.ProjectTemplateModuleKey)
                    .HasColumnName("PROJECT_TEMPLATE_MODULE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectTemplateWebItemKey)
                    .HasColumnName("PROJECT_TEMPLATE_WEB_ITEM_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoBf4748AttachFromMail>(entity =>
            {
                entity.ToTable("AO_BF4748_ATTACH_FROM_MAIL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachId)
                    .HasColumnName("ATTACH_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ContentId)
                    .HasColumnName("CONTENT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.IssueKey)
                    .HasColumnName("ISSUE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.MessageId)
                    .HasColumnName("MESSAGE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Mime)
                    .HasColumnName("MIME")
                    .HasMaxLength(255);

                entity.Property(e => e.StoredName)
                    .HasColumnName("STORED_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UNIQUE_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoBf4748AttachUpload>(entity =>
            {
                entity.ToTable("AO_BF4748_ATTACH_UPLOAD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachId)
                    .HasColumnName("ATTACH_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Attached).HasColumnName("ATTACHED");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoBf4748DynamicForm>(entity =>
            {
                entity.ToTable("AO_BF4748_DYNAMIC_FORM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FormId)
                    .HasColumnName("FORM_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.HtmlValue)
                    .HasColumnName("HTML_VALUE")
                    .HasMaxLength(255);

                entity.Property(e => e.HtmlValueUnlm).HasColumnName("HTML_VALUE_UNLM");
            });

            modelBuilder.Entity<AoBf4748DynamicFormValue>(entity =>
            {
                entity.ToTable("AO_BF4748_DYNAMIC_FORM_VALUE");

                entity.HasIndex(e => e.DynamicFormId)
                    .HasName("index_ao_bf4748_dyn1977867235");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DynamicFormId).HasColumnName("DYNAMIC_FORM_ID");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FIELD_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.FieldValue)
                    .HasColumnName("FIELD_VALUE")
                    .HasMaxLength(255);

                entity.Property(e => e.FieldValueUnlm).HasColumnName("FIELD_VALUE_UNLM");
            });

            modelBuilder.Entity<AoBf4748MentionRequest>(entity =>
            {
                entity.ToTable("AO_BF4748_MENTION_REQUEST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MentionId)
                    .HasColumnName("MENTION_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoBf4748SdPrep>(entity =>
            {
                entity.ToTable("AO_BF4748_SD_PREP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PortalStr)
                    .HasColumnName("PORTAL_STR")
                    .HasMaxLength(255);

                entity.Property(e => e.TemplateId)
                    .HasColumnName("TEMPLATE_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoCbc281DefLibForGroup>(entity =>
            {
                entity.ToTable("AO_CBC281_DEF_LIB_FOR_GROUP");

                entity.HasIndex(e => e.LibraryId)
                    .HasName("index_ao_cbc281_def914736259");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LibraryId).HasColumnName("LIBRARY_ID");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.AoCbc281DefLibForGroup)
                    .HasForeignKey(d => d.LibraryId)
                    .HasConstraintName("fk_ao_cbc281_def_lib_for_group_library_id");
            });

            modelBuilder.Entity<AoCbc281Diagram>(entity =>
            {
                entity.ToTable("AO_CBC281_DIAGRAM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DraftId)
                    .HasColumnName("DRAFT_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IssueKey)
                    .HasColumnName("ISSUE_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Xml)
                    .HasColumnName("XML")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AoCbc281DrawioConfiguration>(entity =>
            {
                entity.ToTable("AO_CBC281_DRAWIO_CONFIGURATION");

                entity.HasIndex(e => e.Name)
                    .HasName("U_AO_CBC281_DRAWIO_1463934584")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomTemplatesCfgPageUrl).HasColumnName("CUSTOM_TEMPLATES_CFG_PAGE_URL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.NotifyOnDiagramEdit).HasColumnName("NOTIFY_ON_DIAGRAM_EDIT");

                entity.Property(e => e.ResampleThreshold).HasColumnName("RESAMPLE_THRESHOLD");

                entity.Property(e => e.ServerConfig).HasColumnName("SERVER_CONFIG");

                entity.Property(e => e.UiConfig).HasColumnName("UI_CONFIG");

                entity.Property(e => e.UseExternalImageService).HasColumnName("USE_EXTERNAL_IMAGE_SERVICE");
            });

            modelBuilder.Entity<AoCbc281DrawioDraft>(entity =>
            {
                entity.ToTable("AO_CBC281_DRAWIO_DRAFT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CeoId)
                    .HasColumnName("CEO_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.DraftId)
                    .HasColumnName("DRAFT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Xml).HasColumnName("XML");
            });

            modelBuilder.Entity<AoCbc281DrawioLibrary>(entity =>
            {
                entity.ToTable("AO_CBC281_DRAWIO_LIBRARY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnyoneCanEdit).HasColumnName("ANYONE_CAN_EDIT");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("XML");
            });

            modelBuilder.Entity<AoCff990AotransitionFailure>(entity =>
            {
                entity.ToTable("AO_CFF990_AOTRANSITION_FAILURE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrorMessages)
                    .HasColumnName("ERROR_MESSAGES")
                    .HasColumnType("ntext");

                entity.Property(e => e.FailureTime)
                    .HasColumnName("FAILURE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.IssueId).HasColumnName("ISSUE_ID");

                entity.Property(e => e.LogReferralHash)
                    .HasColumnName("LOG_REFERRAL_HASH")
                    .HasMaxLength(255);

                entity.Property(e => e.TransitionId).HasColumnName("TRANSITION_ID");

                entity.Property(e => e.TriggerId).HasColumnName("TRIGGER_ID");

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("WORKFLOW_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccBranch>(entity =>
            {
                entity.ToTable("AO_E8B6CC_BRANCH");

                entity.HasIndex(e => e.RepositoryId)
                    .HasName("index_ao_e8b6cc_bra405461593");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryId).HasColumnName("REPOSITORY_ID");
            });

            modelBuilder.Entity<AoE8b6ccBranchHeadMapping>(entity =>
            {
                entity.ToTable("AO_E8B6CC_BRANCH_HEAD_MAPPING");

                entity.HasIndex(e => e.RepositoryId)
                    .HasName("index_ao_e8b6cc_bra1368852151");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchName)
                    .HasColumnName("BRANCH_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Head)
                    .HasColumnName("HEAD")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryId).HasColumnName("REPOSITORY_ID");
            });

            modelBuilder.Entity<AoE8b6ccChangesetMapping>(entity =>
            {
                entity.ToTable("AO_E8B6CC_CHANGESET_MAPPING");

                entity.HasIndex(e => e.Author)
                    .HasName("index_ao_e8b6cc_cha897886051");

                entity.HasIndex(e => e.Node)
                    .HasName("index_ao_e8b6cc_cha1483243924");

                entity.HasIndex(e => e.RawNode)
                    .HasName("index_ao_e8b6cc_cha509722037");

                entity.HasIndex(e => e.SmartcommitAvailable)
                    .HasName("index_ao_e8b6cc_cha1086340152");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.AuthorEmail)
                    .HasColumnName("AUTHOR_EMAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Branch)
                    .HasColumnName("BRANCH")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileCount).HasColumnName("FILE_COUNT");

                entity.Property(e => e.FileDetailsJson)
                    .HasColumnName("FILE_DETAILS_JSON")
                    .HasColumnType("ntext");

                entity.Property(e => e.FilesData)
                    .HasColumnName("FILES_DATA")
                    .HasColumnType("ntext");

                entity.Property(e => e.IssueKey)
                    .HasColumnName("ISSUE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentsData)
                    .HasColumnName("PARENTS_DATA")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectKey)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.RawAuthor)
                    .HasColumnName("RAW_AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.RawNode)
                    .HasColumnName("RAW_NODE")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryId).HasColumnName("REPOSITORY_ID");

                entity.Property(e => e.SmartcommitAvailable).HasColumnName("SMARTCOMMIT_AVAILABLE");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<AoE8b6ccCommit>(entity =>
            {
                entity.ToTable("AO_E8B6CC_COMMIT");

                entity.HasIndex(e => e.DomainId)
                    .HasName("index_ao_e8b6cc_com1308336834");

                entity.HasIndex(e => e.Node)
                    .HasName("index_ao_e8b6cc_commit_node");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.AuthorAvatarUrl)
                    .HasColumnName("AUTHOR_AVATAR_URL")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DomainId).HasColumnName("DOMAIN_ID");

                entity.Property(e => e.Merge).HasColumnName("MERGE");

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(255);

                entity.Property(e => e.RawAuthor)
                    .HasColumnName("RAW_AUTHOR")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccGitHubEvent>(entity =>
            {
                entity.ToTable("AO_E8B6CC_GIT_HUB_EVENT");

                entity.HasIndex(e => e.GitHubId)
                    .HasName("index_ao_e8b6cc_git1120895454");

                entity.HasIndex(e => e.RepositoryId)
                    .HasName("index_ao_e8b6cc_git1804640320");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("CREATED_AT")
                    .HasColumnType("datetime");

                entity.Property(e => e.GitHubId)
                    .IsRequired()
                    .HasColumnName("GIT_HUB_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryId).HasColumnName("REPOSITORY_ID");

                entity.Property(e => e.SavePoint).HasColumnName("SAVE_POINT");
            });

            modelBuilder.Entity<AoE8b6ccIssueMapping>(entity =>
            {
                entity.ToTable("AO_E8B6CC_ISSUE_MAPPING");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IssueId)
                    .HasColumnName("ISSUE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectKey)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryUri)
                    .HasColumnName("REPOSITORY_URI")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccIssueMappingV2>(entity =>
            {
                entity.ToTable("AO_E8B6CC_ISSUE_MAPPING_V2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Branch)
                    .HasColumnName("BRANCH")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilesData)
                    .HasColumnName("FILES_DATA")
                    .HasColumnType("ntext");

                entity.Property(e => e.IssueId)
                    .HasColumnName("ISSUE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Node)
                    .HasColumnName("NODE")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentsData)
                    .HasColumnName("PARENTS_DATA")
                    .HasMaxLength(255);

                entity.Property(e => e.RawAuthor)
                    .HasColumnName("RAW_AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.RawNode)
                    .HasColumnName("RAW_NODE")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryId).HasColumnName("REPOSITORY_ID");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<AoE8b6ccIssueToBranch>(entity =>
            {
                entity.ToTable("AO_E8B6CC_ISSUE_TO_BRANCH");

                entity.HasIndex(e => e.BranchId)
                    .HasName("index_ao_e8b6cc_iss1325927291");

                entity.HasIndex(e => e.IssueKey)
                    .HasName("index_ao_e8b6cc_iss353204826");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.IssueKey)
                    .HasColumnName("ISSUE_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccIssueToChangeset>(entity =>
            {
                entity.ToTable("AO_E8B6CC_ISSUE_TO_CHANGESET");

                entity.HasIndex(e => e.ChangesetId)
                    .HasName("index_ao_e8b6cc_iss1229805759");

                entity.HasIndex(e => e.IssueKey)
                    .HasName("index_ao_e8b6cc_iss417950110");

                entity.HasIndex(e => e.ProjectKey)
                    .HasName("index_ao_e8b6cc_iss648895902");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangesetId).HasColumnName("CHANGESET_ID");

                entity.Property(e => e.IssueKey)
                    .HasColumnName("ISSUE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectKey)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccMessage>(entity =>
            {
                entity.ToTable("AO_E8B6CC_MESSAGE");

                entity.HasIndex(e => e.Address)
                    .HasName("index_ao_e8b6cc_mes1247039512");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(255);

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnName("PAYLOAD")
                    .HasColumnType("ntext");

                entity.Property(e => e.PayloadType)
                    .IsRequired()
                    .HasColumnName("PAYLOAD_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            });

            modelBuilder.Entity<AoE8b6ccMessageQueueItem>(entity =>
            {
                entity.ToTable("AO_E8B6CC_MESSAGE_QUEUE_ITEM");

                entity.HasIndex(e => e.MessageId)
                    .HasName("index_ao_e8b6cc_mes344532677");

                entity.HasIndex(e => e.Queue)
                    .HasName("index_ao_e8b6cc_mes60959905");

                entity.HasIndex(e => e.State)
                    .HasName("index_ao_e8b6cc_mes59146529");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastFailed)
                    .HasColumnName("LAST_FAILED")
                    .HasColumnType("datetime");

                entity.Property(e => e.MessageId).HasColumnName("MESSAGE_ID");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnName("QUEUE")
                    .HasMaxLength(255);

                entity.Property(e => e.RetriesCount).HasColumnName("RETRIES_COUNT");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasMaxLength(255);

                entity.Property(e => e.StateInfo)
                    .HasColumnName("STATE_INFO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccMessageTag>(entity =>
            {
                entity.ToTable("AO_E8B6CC_MESSAGE_TAG");

                entity.HasIndex(e => e.MessageId)
                    .HasName("index_ao_e8b6cc_mes1391090780");

                entity.HasIndex(e => e.Tag)
                    .HasName("index_ao_e8b6cc_mes1648007831");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MessageId).HasColumnName("MESSAGE_ID");

                entity.Property(e => e.Tag)
                    .HasColumnName("TAG")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccOrganizationMapping>(entity =>
            {
                entity.ToTable("AO_E8B6CC_ORGANIZATION_MAPPING");

                entity.HasIndex(e => e.DvcsType)
                    .HasName("index_ao_e8b6cc_org1513110290");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("ACCESS_TOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.AdminPassword)
                    .HasColumnName("ADMIN_PASSWORD")
                    .HasMaxLength(255);

                entity.Property(e => e.AdminUsername)
                    .HasColumnName("ADMIN_USERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ApprovalState)
                    .HasColumnName("APPROVAL_STATE")
                    .HasMaxLength(255);

                entity.Property(e => e.AutolinkNewRepos).HasColumnName("AUTOLINK_NEW_REPOS");

                entity.Property(e => e.DefaultGroupsSlugs)
                    .HasColumnName("DEFAULT_GROUPS_SLUGS")
                    .HasMaxLength(255);

                entity.Property(e => e.DvcsType)
                    .HasColumnName("DVCS_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.HostUrl)
                    .HasColumnName("HOST_URL")
                    .HasMaxLength(255);

                entity.Property(e => e.LastPolled).HasColumnName("LAST_POLLED");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.OauthKey)
                    .HasColumnName("OAUTH_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.OauthSecret)
                    .HasColumnName("OAUTH_SECRET")
                    .HasMaxLength(255);

                entity.Property(e => e.PrincipalId)
                    .HasColumnName("PRINCIPAL_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SmartcommitsForNewRepos).HasColumnName("SMARTCOMMITS_FOR_NEW_REPOS");
            });

            modelBuilder.Entity<AoE8b6ccOrgToProject>(entity =>
            {
                entity.ToTable("AO_E8B6CC_ORG_TO_PROJECT");

                entity.HasIndex(e => e.OrganizationId)
                    .HasName("index_ao_e8b6cc_org1899590324");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrganizationId).HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.ProjectKey)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.AoE8b6ccOrgToProject)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("fk_ao_e8b6cc_org_to_project_organization_id");
            });

            modelBuilder.Entity<AoE8b6ccPrIssueKey>(entity =>
            {
                entity.ToTable("AO_E8B6CC_PR_ISSUE_KEY");

                entity.HasIndex(e => e.DomainId)
                    .HasName("index_ao_e8b6cc_pr_1639282617");

                entity.HasIndex(e => e.IssueKey)
                    .HasName("index_ao_e8b6cc_pr_2106805302");

                entity.HasIndex(e => e.PullRequestId)
                    .HasName("index_ao_e8b6cc_pr_281193494");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DomainId).HasColumnName("DOMAIN_ID");

                entity.Property(e => e.IssueKey)
                    .HasColumnName("ISSUE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.PullRequestId).HasColumnName("PULL_REQUEST_ID");
            });

            modelBuilder.Entity<AoE8b6ccProjectMapping>(entity =>
            {
                entity.ToTable("AO_E8B6CC_PROJECT_MAPPING");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectKey)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryUri)
                    .HasColumnName("REPOSITORY_URI")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccProjectMappingV2>(entity =>
            {
                entity.ToTable("AO_E8B6CC_PROJECT_MAPPING_V2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("ACCESS_TOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.AdminPassword)
                    .HasColumnName("ADMIN_PASSWORD")
                    .HasMaxLength(255);

                entity.Property(e => e.AdminUsername)
                    .HasColumnName("ADMIN_USERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LastCommitDate)
                    .HasColumnName("LAST_COMMIT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjectKey)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryName)
                    .HasColumnName("REPOSITORY_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryType)
                    .HasColumnName("REPOSITORY_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryUrl)
                    .HasColumnName("REPOSITORY_URL")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccPrParticipant>(entity =>
            {
                entity.ToTable("AO_E8B6CC_PR_PARTICIPANT");

                entity.HasIndex(e => e.DomainId)
                    .HasName("index_ao_e8b6cc_pr_758084799");

                entity.HasIndex(e => e.PullRequestId)
                    .HasName("index_ao_e8b6cc_pr_1105917040");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.DomainId).HasColumnName("DOMAIN_ID");

                entity.Property(e => e.PullRequestId).HasColumnName("PULL_REQUEST_ID");

                entity.Property(e => e.Role)
                    .HasColumnName("ROLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccPrToCommit>(entity =>
            {
                entity.ToTable("AO_E8B6CC_PR_TO_COMMIT");

                entity.HasIndex(e => e.CommitId)
                    .HasName("index_ao_e8b6cc_pr_1458633226");

                entity.HasIndex(e => e.DomainId)
                    .HasName("index_ao_e8b6cc_pr_685151049");

                entity.HasIndex(e => e.RequestId)
                    .HasName("index_ao_e8b6cc_pr_1045528152");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommitId).HasColumnName("COMMIT_ID");

                entity.Property(e => e.DomainId).HasColumnName("DOMAIN_ID");

                entity.Property(e => e.RequestId).HasColumnName("REQUEST_ID");
            });

            modelBuilder.Entity<AoE8b6ccPullRequest>(entity =>
            {
                entity.ToTable("AO_E8B6CC_PULL_REQUEST");

                entity.HasIndex(e => e.DomainId)
                    .HasName("index_ao_e8b6cc_pul1230717024");

                entity.HasIndex(e => e.RemoteId)
                    .HasName("index_ao_e8b6cc_pul602811170");

                entity.HasIndex(e => e.ToRepositoryId)
                    .HasName("index_ao_e8b6cc_pul1448445182");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.CommentCount).HasColumnName("COMMENT_COUNT");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestinationBranch)
                    .HasColumnName("DESTINATION_BRANCH")
                    .HasMaxLength(255);

                entity.Property(e => e.DomainId).HasColumnName("DOMAIN_ID");

                entity.Property(e => e.ExecutedBy)
                    .HasColumnName("EXECUTED_BY")
                    .HasMaxLength(255);

                entity.Property(e => e.LastStatus)
                    .HasColumnName("LAST_STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.RemoteId).HasColumnName("REMOTE_ID");

                entity.Property(e => e.SourceBranch)
                    .HasColumnName("SOURCE_BRANCH")
                    .HasMaxLength(255);

                entity.Property(e => e.SourceRepo)
                    .HasColumnName("SOURCE_REPO")
                    .HasMaxLength(255);

                entity.Property(e => e.ToRepositoryId).HasColumnName("TO_REPOSITORY_ID");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoE8b6ccRepositoryMapping>(entity =>
            {
                entity.ToTable("AO_E8B6CC_REPOSITORY_MAPPING");

                entity.HasIndex(e => e.Linked)
                    .HasName("index_ao_e8b6cc_rep93578901");

                entity.HasIndex(e => e.OrganizationId)
                    .HasName("index_ao_e8b6cc_rep702725269");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivityLastSync)
                    .HasColumnName("ACTIVITY_LAST_SYNC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("DELETED");

                entity.Property(e => e.Fork).HasColumnName("FORK");

                entity.Property(e => e.ForkOfName)
                    .HasColumnName("FORK_OF_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ForkOfOwner)
                    .HasColumnName("FORK_OF_OWNER")
                    .HasMaxLength(255);

                entity.Property(e => e.ForkOfSlug)
                    .HasColumnName("FORK_OF_SLUG")
                    .HasMaxLength(255);

                entity.Property(e => e.LastChangesetNode)
                    .HasColumnName("LAST_CHANGESET_NODE")
                    .HasMaxLength(255);

                entity.Property(e => e.LastCommitDate)
                    .HasColumnName("LAST_COMMIT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Linked).HasColumnName("LINKED");

                entity.Property(e => e.Logo)
                    .HasColumnName("LOGO")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizationId).HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.Slug)
                    .HasColumnName("SLUG")
                    .HasMaxLength(255);

                entity.Property(e => e.SmartcommitsEnabled).HasColumnName("SMARTCOMMITS_ENABLED");

                entity.Property(e => e.UpdateLinkAuthorised).HasColumnName("UPDATE_LINK_AUTHORISED");
            });

            modelBuilder.Entity<AoE8b6ccRepoToChangeset>(entity =>
            {
                entity.ToTable("AO_E8B6CC_REPO_TO_CHANGESET");

                entity.HasIndex(e => e.ChangesetId)
                    .HasName("index_ao_e8b6cc_rep922992576");

                entity.HasIndex(e => e.RepositoryId)
                    .HasName("index_ao_e8b6cc_rep1082901832");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangesetId).HasColumnName("CHANGESET_ID");

                entity.Property(e => e.RepositoryId).HasColumnName("REPOSITORY_ID");
            });

            modelBuilder.Entity<AoE8b6ccRepoToProject>(entity =>
            {
                entity.ToTable("AO_E8B6CC_REPO_TO_PROJECT");

                entity.HasIndex(e => e.RepositoryId)
                    .HasName("index_ao_e8b6cc_rep1928770529");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectKey)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.RepositoryId).HasColumnName("REPOSITORY_ID");
            });

            modelBuilder.Entity<AoE8b6ccSyncAuditLog>(entity =>
            {
                entity.ToTable("AO_E8B6CC_SYNC_AUDIT_LOG");

                entity.HasIndex(e => e.RepoId)
                    .HasName("index_ao_e8b6cc_syn203792807");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExcTrace)
                    .HasColumnName("EXC_TRACE")
                    .HasColumnType("ntext");

                entity.Property(e => e.FirstRequestDate)
                    .HasColumnName("FIRST_REQUEST_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightTimeMs).HasColumnName("FLIGHT_TIME_MS");

                entity.Property(e => e.NumRequests).HasColumnName("NUM_REQUESTS");

                entity.Property(e => e.RepoId).HasColumnName("REPO_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SyncStatus)
                    .HasColumnName("SYNC_STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.SyncType)
                    .HasColumnName("SYNC_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalErrors).HasColumnName("TOTAL_ERRORS");
            });

            modelBuilder.Entity<AoE8b6ccSyncEvent>(entity =>
            {
                entity.ToTable("AO_E8B6CC_SYNC_EVENT");

                entity.HasIndex(e => e.RepoId)
                    .HasName("index_ao_e8b6cc_syn493078035");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventClass)
                    .IsRequired()
                    .HasColumnName("EVENT_CLASS")
                    .HasColumnType("ntext");

                entity.Property(e => e.EventDate)
                    .HasColumnName("EVENT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventJson)
                    .IsRequired()
                    .HasColumnName("EVENT_JSON")
                    .HasColumnType("ntext");

                entity.Property(e => e.RepoId).HasColumnName("REPO_ID");

                entity.Property(e => e.ScheduledSync).HasColumnName("SCHEDULED_SYNC");
            });

            modelBuilder.Entity<AoEd669cSeenAssertions>(entity =>
            {
                entity.ToTable("AO_ED669C_SEEN_ASSERTIONS");

                entity.HasIndex(e => e.AssertionId)
                    .HasName("U_AO_ED669C_SEEN_AS1055534769")
                    .IsUnique();

                entity.HasIndex(e => e.ExpiryTimestamp)
                    .HasName("index_ao_ed669c_see20117222");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssertionId)
                    .IsRequired()
                    .HasColumnName("ASSERTION_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ExpiryTimestamp).HasColumnName("EXPIRY_TIMESTAMP");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.ToTable("app_user");

                entity.HasIndex(e => e.LowerUserName)
                    .HasName("uk_lower_user_name")
                    .IsUnique();

                entity.HasIndex(e => e.UserKey)
                    .HasName("uk_user_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LowerUserName)
                    .HasColumnName("lower_user_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UserKey)
                    .HasColumnName("user_key")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AuditChangedValue>(entity =>
            {
                entity.ToTable("audit_changed_value");

                entity.HasIndex(e => e.LogId)
                    .HasName("idx_changed_value_log_id");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DeltaFrom)
                    .HasColumnName("DELTA_FROM")
                    .HasColumnType("ntext");

                entity.Property(e => e.DeltaTo)
                    .HasColumnName("DELTA_TO")
                    .HasColumnType("ntext");

                entity.Property(e => e.LogId)
                    .HasColumnName("LOG_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AuditItem>(entity =>
            {
                entity.ToTable("audit_item");

                entity.HasIndex(e => e.LogId)
                    .HasName("idx_audit_item_log_id2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LogId)
                    .HasColumnName("LOG_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectName)
                    .HasColumnName("OBJECT_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectParentId)
                    .HasColumnName("OBJECT_PARENT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectParentName)
                    .HasColumnName("OBJECT_PARENT_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("audit_log");

                entity.HasIndex(e => e.Created)
                    .HasName("idx_audit_log_created");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AuthorKey)
                    .HasColumnName("AUTHOR_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.AuthorType).HasColumnName("AUTHOR_TYPE");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.EventSourceName)
                    .HasColumnName("EVENT_SOURCE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("LONG_DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectName)
                    .HasColumnName("OBJECT_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectParentId)
                    .HasColumnName("OBJECT_PARENT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectParentName)
                    .HasColumnName("OBJECT_PARENT_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.RemoteAddress)
                    .HasColumnName("REMOTE_ADDRESS")
                    .HasMaxLength(60);

                entity.Property(e => e.SearchField)
                    .HasColumnName("SEARCH_FIELD")
                    .HasColumnType("ntext");

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Avatar>(entity =>
            {
                entity.ToTable("avatar");

                entity.HasIndex(e => new { e.Avatartype, e.Owner })
                    .HasName("avatar_index");

                entity.HasIndex(e => new { e.Filename, e.Avatartype, e.Systemavatar })
                    .HasName("avatar_filename_index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Avatartype)
                    .HasColumnName("avatartype")
                    .HasMaxLength(60);

                entity.Property(e => e.Contenttype)
                    .HasColumnName("contenttype")
                    .HasMaxLength(255);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(255);

                entity.Property(e => e.Systemavatar).HasColumnName("systemavatar");
            });

            modelBuilder.Entity<Board>(entity =>
            {
                entity.ToTable("board");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Jql)
                    .HasColumnName("JQL")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Boardproject>(entity =>
            {
                entity.HasKey(e => new { e.BoardId, e.ProjectId });

                entity.ToTable("boardproject");

                entity.HasIndex(e => e.BoardId)
                    .HasName("idx_board_board_ids");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_board_project_ids");

                entity.Property(e => e.BoardId)
                    .HasColumnName("BOARD_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Changegroup>(entity =>
            {
                entity.ToTable("changegroup");

                entity.HasIndex(e => e.Author);

                entity.HasIndex(e => e.Issueid)
                    .HasName("chggroup_issue");

                entity.HasIndex(e => new { e.Author, e.Created })
                    .HasName("chggroup_author_created");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Issueid)
                    .HasColumnName("issueid")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Changeitem>(entity =>
            {
                entity.ToTable("changeitem");

                entity.HasIndex(e => e.Field)
                    .HasName("chgitem_field");

                entity.HasIndex(e => e.Groupid)
                    .HasName("chgitem_chggrp");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Field)
                    .HasColumnName("FIELD")
                    .HasMaxLength(255);

                entity.Property(e => e.Fieldtype)
                    .HasColumnName("FIELDTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Newstring)
                    .HasColumnName("NEWSTRING")
                    .HasColumnType("ntext");

                entity.Property(e => e.Newvalue)
                    .HasColumnName("NEWVALUE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Oldstring)
                    .HasColumnName("OLDSTRING")
                    .HasColumnType("ntext");

                entity.Property(e => e.Oldvalue)
                    .HasColumnName("OLDVALUE")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Clusteredjob>(entity =>
            {
                entity.ToTable("clusteredjob");

                entity.HasIndex(e => e.JobId)
                    .HasName("clusteredjob_jobid_idx")
                    .IsUnique();

                entity.HasIndex(e => e.JobRunnerKey)
                    .HasName("clusteredjob_jrk_idx");

                entity.HasIndex(e => e.NextRun)
                    .HasName("clusteredjob_nextrun_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CronExpression)
                    .HasColumnName("CRON_EXPRESSION")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstRun)
                    .HasColumnName("FIRST_RUN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IntervalMillis)
                    .HasColumnName("INTERVAL_MILLIS")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.JobRunnerKey)
                    .HasColumnName("JOB_RUNNER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.NextRun)
                    .HasColumnName("NEXT_RUN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Parameters)
                    .HasColumnName("PARAMETERS")
                    .HasColumnType("image");

                entity.Property(e => e.SchedType)
                    .HasColumnName("SCHED_TYPE")
                    .HasMaxLength(1);

                entity.Property(e => e.TimeZone)
                    .HasColumnName("TIME_ZONE")
                    .HasMaxLength(60);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Clusterlockstatus>(entity =>
            {
                entity.ToTable("clusterlockstatus");

                entity.HasIndex(e => e.LockName)
                    .HasName("cluster_lock_name_idx")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LockName)
                    .HasColumnName("LOCK_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LockedByNode)
                    .HasColumnName("LOCKED_BY_NODE")
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Clustermessage>(entity =>
            {
                entity.ToTable("clustermessage");

                entity.HasIndex(e => new { e.SourceNode, e.DestinationNode })
                    .HasName("source_destination_node_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ClaimedByNode)
                    .HasColumnName("CLAIMED_BY_NODE")
                    .HasMaxLength(60);

                entity.Property(e => e.DestinationNode)
                    .HasColumnName("DESTINATION_NODE")
                    .HasMaxLength(60);

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasMaxLength(255);

                entity.Property(e => e.MessageTime)
                    .HasColumnName("MESSAGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceNode)
                    .HasColumnName("SOURCE_NODE")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Clusternode>(entity =>
            {
                entity.HasKey(e => e.NodeId);

                entity.ToTable("clusternode");

                entity.Property(e => e.NodeId)
                    .HasColumnName("NODE_ID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CacheListenerPort)
                    .HasColumnName("CACHE_LISTENER_PORT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(60);

                entity.Property(e => e.NodeBuildNumber)
                    .HasColumnName("NODE_BUILD_NUMBER")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NodeState)
                    .HasColumnName("NODE_STATE")
                    .HasMaxLength(60);

                entity.Property(e => e.NodeVersion)
                    .HasColumnName("NODE_VERSION")
                    .HasMaxLength(60);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Clusternodeheartbeat>(entity =>
            {
                entity.HasKey(e => e.NodeId);

                entity.ToTable("clusternodeheartbeat");

                entity.Property(e => e.NodeId)
                    .HasColumnName("NODE_ID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.DatabaseTime)
                    .HasColumnName("DATABASE_TIME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HeartbeatTime)
                    .HasColumnName("HEARTBEAT_TIME")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Clusterupgradestate>(entity =>
            {
                entity.ToTable("clusterupgradestate");

                entity.HasIndex(e => e.OrderNumber)
                    .HasName("ordernumber_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ClusterBuildNumber)
                    .HasColumnName("CLUSTER_BUILD_NUMBER")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ClusterVersion)
                    .HasColumnName("CLUSTER_VERSION")
                    .HasMaxLength(60);

                entity.Property(e => e.DatabaseTime)
                    .HasColumnName("DATABASE_TIME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Columnlayout>(entity =>
            {
                entity.ToTable("columnlayout");

                entity.HasIndex(e => e.Searchrequest)
                    .HasName("cl_searchrequest");

                entity.HasIndex(e => e.Username)
                    .HasName("cl_username");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Searchrequest)
                    .HasColumnName("SEARCHREQUEST")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Columnlayoutitem>(entity =>
            {
                entity.ToTable("columnlayoutitem");

                entity.HasIndex(e => e.Fieldidentifier)
                    .HasName("idx_cli_fieldidentifier");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Columnlayout)
                    .HasColumnName("COLUMNLAYOUT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldidentifier)
                    .HasColumnName("FIELDIDENTIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Horizontalposition)
                    .HasColumnName("HORIZONTALPOSITION")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Component>(entity =>
            {
                entity.ToTable("component");

                entity.HasIndex(e => e.Cname)
                    .HasName("idx_component_name");

                entity.HasIndex(e => e.Project)
                    .HasName("idx_component_project");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Assigneetype)
                    .HasColumnName("ASSIGNEETYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("ntext");

                entity.Property(e => e.Lead)
                    .HasColumnName("LEAD")
                    .HasMaxLength(255);

                entity.Property(e => e.Project)
                    .HasColumnName("PROJECT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Configurationcontext>(entity =>
            {
                entity.ToTable("configurationcontext");

                entity.HasIndex(e => e.Fieldconfigscheme)
                    .HasName("confcontextfieldconfigscheme");

                entity.HasIndex(e => new { e.Project, e.Customfield })
                    .HasName("confcontextprojectkey");

                entity.HasIndex(e => new { e.Projectcategory, e.Project, e.Customfield })
                    .HasName("confcontext");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Customfield)
                    .HasColumnName("customfield")
                    .HasMaxLength(255);

                entity.Property(e => e.Fieldconfigscheme)
                    .HasColumnName("FIELDCONFIGSCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Project)
                    .HasColumnName("PROJECT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Projectcategory)
                    .HasColumnName("PROJECTCATEGORY")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Customfield>(entity =>
            {
                entity.ToTable("customfield");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cfkey)
                    .HasColumnName("cfkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Cfname)
                    .HasColumnName("cfname")
                    .HasMaxLength(255);

                entity.Property(e => e.Customfieldsearcherkey)
                    .HasColumnName("CUSTOMFIELDSEARCHERKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Customfieldtypekey)
                    .HasColumnName("CUSTOMFIELDTYPEKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Defaultvalue)
                    .HasColumnName("defaultvalue")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Fieldtype)
                    .HasColumnName("FIELDTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issuetype)
                    .HasColumnName("ISSUETYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Project)
                    .HasColumnName("PROJECT")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Customfieldoption>(entity =>
            {
                entity.ToTable("customfieldoption");

                entity.HasIndex(e => e.Customfield)
                    .HasName("cf_cfoption");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Customfield)
                    .HasColumnName("CUSTOMFIELD")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Customfieldconfig)
                    .HasColumnName("CUSTOMFIELDCONFIG")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Customvalue)
                    .HasColumnName("customvalue")
                    .HasMaxLength(255);

                entity.Property(e => e.Disabled)
                    .HasColumnName("disabled")
                    .HasMaxLength(60);

                entity.Property(e => e.Optiontype)
                    .HasColumnName("optiontype")
                    .HasMaxLength(60);

                entity.Property(e => e.Parentoptionid)
                    .HasColumnName("PARENTOPTIONID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Customfieldvalue>(entity =>
            {
                entity.ToTable("customfieldvalue");

                entity.HasIndex(e => new { e.Issue, e.Customfield })
                    .HasName("cfvalue_issue");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Customfield)
                    .HasColumnName("CUSTOMFIELD")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Datevalue)
                    .HasColumnName("DATEVALUE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Issue)
                    .HasColumnName("ISSUE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Numbervalue)
                    .HasColumnName("NUMBERVALUE")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Parentkey)
                    .HasColumnName("PARENTKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Stringvalue)
                    .HasColumnName("STRINGVALUE")
                    .HasMaxLength(255);

                entity.Property(e => e.Textvalue)
                    .HasColumnName("TEXTVALUE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Valuetype)
                    .HasColumnName("VALUETYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CwdApplication>(entity =>
            {
                entity.ToTable("cwd_application");

                entity.HasIndex(e => e.LowerApplicationName)
                    .HasName("uk_application_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ApplicationName)
                    .HasColumnName("application_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ApplicationType)
                    .HasColumnName("application_type")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Credential)
                    .HasColumnName("credential")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerApplicationName)
                    .HasColumnName("lower_application_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CwdApplicationAddress>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationId, e.RemoteAddress });

                entity.ToTable("cwd_application_address");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("application_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RemoteAddress)
                    .HasColumnName("remote_address")
                    .HasMaxLength(255);

                entity.Property(e => e.EncodedAddressBinary)
                    .HasColumnName("encoded_address_binary")
                    .HasMaxLength(255);

                entity.Property(e => e.RemoteAddressMask).HasColumnName("remote_address_mask");
            });

            modelBuilder.Entity<CwdDirectory>(entity =>
            {
                entity.ToTable("cwd_directory");

                entity.HasIndex(e => e.Active)
                    .HasName("idx_directory_active");

                entity.HasIndex(e => e.DirectoryType)
                    .HasName("idx_directory_type");

                entity.HasIndex(e => e.LowerDirectoryName)
                    .HasName("uk_directory_name");

                entity.HasIndex(e => e.LowerImplClass)
                    .HasName("idx_directory_impl");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryName)
                    .HasColumnName("directory_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryPosition)
                    .HasColumnName("directory_position")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DirectoryType)
                    .HasColumnName("directory_type")
                    .HasMaxLength(60);

                entity.Property(e => e.ImplClass)
                    .HasColumnName("impl_class")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerDirectoryName)
                    .HasColumnName("lower_directory_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerImplClass)
                    .HasColumnName("lower_impl_class")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CwdDirectoryAttribute>(entity =>
            {
                entity.HasKey(e => new { e.DirectoryId, e.AttributeName });

                entity.ToTable("cwd_directory_attribute");

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AttributeName)
                    .HasColumnName("attribute_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeValue)
                    .HasColumnName("attribute_value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CwdDirectoryOperation>(entity =>
            {
                entity.HasKey(e => new { e.DirectoryId, e.OperationType });

                entity.ToTable("cwd_directory_operation");

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OperationType)
                    .HasColumnName("operation_type")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<CwdGroup>(entity =>
            {
                entity.ToTable("cwd_group");

                entity.HasIndex(e => e.DirectoryId)
                    .HasName("idx_group_dir_id");

                entity.HasIndex(e => new { e.LowerGroupName, e.Active })
                    .HasName("idx_group_active");

                entity.HasIndex(e => new { e.LowerGroupName, e.DirectoryId })
                    .HasName("uk_group_name_dir_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupType)
                    .HasColumnName("group_type")
                    .HasMaxLength(60);

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.LowerDescription)
                    .HasColumnName("lower_description")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerGroupName)
                    .HasColumnName("lower_group_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CwdGroupAttributes>(entity =>
            {
                entity.ToTable("cwd_group_attributes");

                entity.HasIndex(e => new { e.DirectoryId, e.AttributeName, e.LowerAttributeValue })
                    .HasName("idx_group_attr_dir_name_lval");

                entity.HasIndex(e => new { e.GroupId, e.AttributeName, e.LowerAttributeValue })
                    .HasName("uk_group_attr_name_lval")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AttributeName)
                    .HasColumnName("attribute_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeValue)
                    .HasColumnName("attribute_value")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LowerAttributeValue)
                    .HasColumnName("lower_attribute_value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CwdMembership>(entity =>
            {
                entity.ToTable("cwd_membership");

                entity.HasIndex(e => new { e.LowerChildName, e.MembershipType, e.DirectoryId })
                    .HasName("idx_mem_dir_child");

                entity.HasIndex(e => new { e.LowerParentName, e.MembershipType, e.DirectoryId })
                    .HasName("idx_mem_dir_parent");

                entity.HasIndex(e => new { e.ParentId, e.ChildId, e.MembershipType })
                    .HasName("uk_mem_parent_child_type")
                    .IsUnique();

                entity.HasIndex(e => new { e.LowerParentName, e.LowerChildName, e.MembershipType, e.DirectoryId })
                    .HasName("idx_mem_dir_parent_child");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChildId)
                    .HasColumnName("child_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChildName)
                    .HasColumnName("child_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupType)
                    .HasColumnName("group_type")
                    .HasMaxLength(60);

                entity.Property(e => e.LowerChildName)
                    .HasColumnName("lower_child_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerParentName)
                    .HasColumnName("lower_parent_name")
                    .HasMaxLength(255);

                entity.Property(e => e.MembershipType)
                    .HasColumnName("membership_type")
                    .HasMaxLength(60);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ParentName)
                    .HasColumnName("parent_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CwdUser>(entity =>
            {
                entity.ToTable("cwd_user");

                entity.HasIndex(e => e.LowerDisplayName)
                    .HasName("idx_display_name");

                entity.HasIndex(e => e.LowerEmailAddress)
                    .HasName("idx_email_address");

                entity.HasIndex(e => e.LowerFirstName)
                    .HasName("idx_first_name");

                entity.HasIndex(e => e.LowerLastName)
                    .HasName("idx_last_name");

                entity.HasIndex(e => new { e.ExternalId, e.DirectoryId })
                    .HasName("uk_user_externalid_dir_id");

                entity.HasIndex(e => new { e.LowerUserName, e.DirectoryId })
                    .HasName("uk_user_name_dir_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Credential)
                    .HasColumnName("CREDENTIAL")
                    .HasMaxLength(255);

                entity.Property(e => e.DeletedExternally).HasColumnName("deleted_externally");

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("display_name")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(255);

                entity.Property(e => e.ExternalId)
                    .HasColumnName("EXTERNAL_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerDisplayName)
                    .HasColumnName("lower_display_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerEmailAddress)
                    .HasColumnName("lower_email_address")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerFirstName)
                    .HasColumnName("lower_first_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerLastName)
                    .HasColumnName("lower_last_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerUserName)
                    .HasColumnName("lower_user_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CwdUserAttributes>(entity =>
            {
                entity.ToTable("cwd_user_attributes");

                entity.HasIndex(e => new { e.UserId, e.AttributeName })
                    .HasName("uk_user_attr_name_lval");

                entity.HasIndex(e => new { e.DirectoryId, e.AttributeName, e.LowerAttributeValue })
                    .HasName("idx_user_attr_dir_name_lval");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AttributeName)
                    .HasColumnName("attribute_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeValue)
                    .HasColumnName("attribute_value")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LowerAttributeValue)
                    .HasColumnName("lower_attribute_value")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Deadletter>(entity =>
            {
                entity.ToTable("deadletter");

                entity.HasIndex(e => e.LastSeen)
                    .HasName("deadletter_lastSeen");

                entity.HasIndex(e => new { e.MessageId, e.MailServerId, e.FolderName })
                    .HasName("deadletter_msg_server_folder");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FolderName)
                    .HasColumnName("FOLDER_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LastSeen)
                    .HasColumnName("LAST_SEEN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MailServerId)
                    .HasColumnName("MAIL_SERVER_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MESSAGE_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Draftworkflowscheme>(entity =>
            {
                entity.ToTable("draftworkflowscheme");

                entity.HasIndex(e => e.WorkflowSchemeId)
                    .HasName("draft_workflow_scheme_parent");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("LAST_MODIFIED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastModifiedUser)
                    .HasColumnName("LAST_MODIFIED_USER")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkflowSchemeId)
                    .HasColumnName("WORKFLOW_SCHEME_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Draftworkflowschemeentity>(entity =>
            {
                entity.ToTable("draftworkflowschemeentity");

                entity.HasIndex(e => e.Scheme)
                    .HasName("draft_workflow_scheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issuetype)
                    .HasColumnName("issuetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Scheme)
                    .HasColumnName("SCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Workflow)
                    .HasColumnName("WORKFLOW")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<EntityProperty>(entity =>
            {
                entity.ToTable("entity_property");

                entity.HasIndex(e => e.PropertyKey)
                    .HasName("entityproperty_key");

                entity.HasIndex(e => new { e.EntityName, e.EntityId })
                    .HasName("entityproperty_entity");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntityId)
                    .HasColumnName("ENTITY_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EntityName)
                    .HasColumnName("ENTITY_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.JsonValue)
                    .HasColumnName("json_value")
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyKey)
                    .HasColumnName("PROPERTY_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EntityPropertyIndexDocument>(entity =>
            {
                entity.ToTable("entity_property_index_document");

                entity.HasIndex(e => new { e.PluginKey, e.ModuleKey })
                    .HasName("entpropindexdoc_module")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Document)
                    .HasColumnName("DOCUMENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.EntityKey)
                    .HasColumnName("ENTITY_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ModuleKey)
                    .HasColumnName("MODULE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.PluginKey)
                    .HasColumnName("PLUGIN_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EntityTranslation>(entity =>
            {
                entity.ToTable("entity_translation");

                entity.HasIndex(e => e.Locale)
                    .HasName("entitytranslation_locale");

                entity.HasIndex(e => new { e.EntityName, e.EntityId, e.Locale })
                    .HasName("uk_entitytranslation")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EntityId)
                    .HasColumnName("ENTITY_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EntityName)
                    .HasColumnName("ENTITY_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Locale)
                    .HasColumnName("LOCALE")
                    .HasMaxLength(60);

                entity.Property(e => e.TransDesc)
                    .HasColumnName("TRANS_DESC")
                    .HasMaxLength(255);

                entity.Property(e => e.TransName)
                    .HasColumnName("TRANS_NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ExternalEntities>(entity =>
            {
                entity.ToTable("external_entities");

                entity.HasIndex(e => e.Name)
                    .HasName("ext_entity_name");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Entitytype)
                    .HasColumnName("entitytype")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Externalgadget>(entity =>
            {
                entity.ToTable("externalgadget");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GadgetXml)
                    .HasColumnName("GADGET_XML")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Favouriteassociations>(entity =>
            {
                entity.ToTable("favouriteassociations");

                entity.HasIndex(e => new { e.Username, e.Entitytype, e.Entityid })
                    .HasName("favourite_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Entityid)
                    .HasColumnName("entityid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Entitytype)
                    .HasColumnName("entitytype")
                    .HasMaxLength(60);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.ToTable("feature");

                entity.HasIndex(e => new { e.Id, e.UserKey })
                    .HasName("feature_id_userkey");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FeatureName)
                    .HasColumnName("FEATURE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.FeatureType)
                    .HasColumnName("FEATURE_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Fieldconfigscheme>(entity =>
            {
                entity.ToTable("fieldconfigscheme");

                entity.HasIndex(e => e.Fieldid)
                    .HasName("fcs_fieldid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Configname)
                    .HasColumnName("configname")
                    .HasMaxLength(255);

                entity.Property(e => e.Customfield)
                    .HasColumnName("CUSTOMFIELD")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Fieldid)
                    .HasColumnName("FIELDID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Fieldconfigschemeissuetype>(entity =>
            {
                entity.ToTable("fieldconfigschemeissuetype");

                entity.HasIndex(e => e.Fieldconfigscheme)
                    .HasName("fcs_scheme");

                entity.HasIndex(e => e.Issuetype)
                    .HasName("fcs_issuetype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldconfigscheme)
                    .HasColumnName("FIELDCONFIGSCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldconfiguration)
                    .HasColumnName("FIELDCONFIGURATION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issuetype)
                    .HasColumnName("ISSUETYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Fieldconfiguration>(entity =>
            {
                entity.ToTable("fieldconfiguration");

                entity.HasIndex(e => e.Fieldid)
                    .HasName("fc_fieldid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Configname)
                    .HasColumnName("configname")
                    .HasMaxLength(255);

                entity.Property(e => e.Customfield)
                    .HasColumnName("CUSTOMFIELD")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Fieldid)
                    .HasColumnName("FIELDID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Fieldlayout>(entity =>
            {
                entity.ToTable("fieldlayout");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.LayoutType)
                    .HasColumnName("layout_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Layoutscheme)
                    .HasColumnName("LAYOUTSCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Fieldlayoutitem>(entity =>
            {
                entity.ToTable("fieldlayoutitem");

                entity.HasIndex(e => e.Fieldidentifier)
                    .HasName("idx_fli_fieldidentifier");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Fieldidentifier)
                    .HasColumnName("FIELDIDENTIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Fieldlayout)
                    .HasColumnName("FIELDLAYOUT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Ishidden)
                    .HasColumnName("ISHIDDEN")
                    .HasMaxLength(60);

                entity.Property(e => e.Isrequired)
                    .HasColumnName("ISREQUIRED")
                    .HasMaxLength(60);

                entity.Property(e => e.Renderertype)
                    .HasColumnName("RENDERERTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Verticalposition)
                    .HasColumnName("VERTICALPOSITION")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Fieldlayoutscheme>(entity =>
            {
                entity.ToTable("fieldlayoutscheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Fieldlayoutschemeassociation>(entity =>
            {
                entity.ToTable("fieldlayoutschemeassociation");

                entity.HasIndex(e => new { e.Project, e.Issuetype })
                    .HasName("fl_scheme_assoc");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldlayoutscheme)
                    .HasColumnName("FIELDLAYOUTSCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issuetype)
                    .HasColumnName("ISSUETYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Project)
                    .HasColumnName("PROJECT")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Fieldlayoutschemeentity>(entity =>
            {
                entity.ToTable("fieldlayoutschemeentity");

                entity.HasIndex(e => e.Fieldlayout)
                    .HasName("fieldlayout_layout");

                entity.HasIndex(e => e.Scheme)
                    .HasName("fieldlayout_scheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldlayout)
                    .HasColumnName("FIELDLAYOUT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issuetype)
                    .HasColumnName("issuetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Scheme)
                    .HasColumnName("SCHEME")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Fieldscreen>(entity =>
            {
                entity.ToTable("fieldscreen");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Fieldscreenlayoutitem>(entity =>
            {
                entity.ToTable("fieldscreenlayoutitem");

                entity.HasIndex(e => e.Fieldidentifier)
                    .HasName("fieldscreen_field");

                entity.HasIndex(e => e.Fieldscreentab)
                    .HasName("fieldscitem_tab");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldidentifier)
                    .HasColumnName("FIELDIDENTIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Fieldscreentab)
                    .HasColumnName("FIELDSCREENTAB")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Fieldscreenscheme>(entity =>
            {
                entity.ToTable("fieldscreenscheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Fieldscreenschemeitem>(entity =>
            {
                entity.ToTable("fieldscreenschemeitem");

                entity.HasIndex(e => e.Fieldscreenscheme)
                    .HasName("screenitem_scheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldscreen)
                    .HasColumnName("FIELDSCREEN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldscreenscheme)
                    .HasColumnName("FIELDSCREENSCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Operation)
                    .HasColumnName("OPERATION")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Fieldscreentab>(entity =>
            {
                entity.ToTable("fieldscreentab");

                entity.HasIndex(e => e.Fieldscreen)
                    .HasName("fieldscreen_tab");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.Fieldscreen)
                    .HasColumnName("FIELDSCREEN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Fileattachment>(entity =>
            {
                entity.ToTable("fileattachment");

                entity.HasIndex(e => e.Issueid)
                    .HasName("attach_issue");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Filesize)
                    .HasColumnName("FILESIZE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issueid)
                    .HasColumnName("issueid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mimetype)
                    .HasColumnName("MIMETYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Thumbnailable).HasColumnName("thumbnailable");

                entity.Property(e => e.Zip).HasColumnName("zip");
            });

            modelBuilder.Entity<Filtersubscription>(entity =>
            {
                entity.ToTable("filtersubscription");

                entity.HasIndex(e => new { e.FilterID, e.Groupname })
                    .HasName("subscrptn_group");

                entity.HasIndex(e => new { e.FilterID, e.Username })
                    .HasName("subscrpt_user");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmailOnEmpty)
                    .HasColumnName("EMAIL_ON_EMPTY")
                    .HasMaxLength(10);

                entity.Property(e => e.FilterID)
                    .HasColumnName("FILTER_I_D")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(60);

                entity.Property(e => e.LastRun)
                    .HasColumnName("LAST_RUN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Gadgetuserpreference>(entity =>
            {
                entity.ToTable("gadgetuserpreference");

                entity.HasIndex(e => e.Portletconfiguration)
                    .HasName("userpref_portletconfiguration");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Portletconfiguration)
                    .HasColumnName("PORTLETCONFIGURATION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Userprefkey)
                    .HasColumnName("USERPREFKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Userprefvalue)
                    .HasColumnName("USERPREFVALUE")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Genericconfiguration>(entity =>
            {
                entity.ToTable("genericconfiguration");

                entity.HasIndex(e => new { e.Datatype, e.Datakey })
                    .HasName("type_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Datakey)
                    .HasColumnName("DATAKEY")
                    .HasMaxLength(60);

                entity.Property(e => e.Datatype)
                    .HasColumnName("DATATYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.Xmlvalue)
                    .HasColumnName("XMLVALUE")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Globalpermissionentry>(entity =>
            {
                entity.ToTable("globalpermissionentry");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GROUP_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Permission)
                    .HasColumnName("PERMISSION")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Groupbase>(entity =>
            {
                entity.ToTable("groupbase");

                entity.HasIndex(e => e.Groupname)
                    .HasName("osgroup_name");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<IssueFieldOption>(entity =>
            {
                entity.ToTable("issue_field_option");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FieldKey)
                    .HasColumnName("FIELD_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.OptionId)
                    .HasColumnName("OPTION_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OptionValue)
                    .HasColumnName("option_value")
                    .HasMaxLength(255);

                entity.Property(e => e.Properties)
                    .HasColumnName("PROPERTIES")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<IssueFieldOptionScope>(entity =>
            {
                entity.ToTable("issue_field_option_scope");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EntityId)
                    .HasColumnName("ENTITY_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.OptionId)
                    .HasColumnName("OPTION_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ScopeType)
                    .HasColumnName("SCOPE_TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Issuelink>(entity =>
            {
                entity.ToTable("issuelink");

                entity.HasIndex(e => e.Destination)
                    .HasName("issuelink_dest");

                entity.HasIndex(e => e.Linktype)
                    .HasName("issuelink_type");

                entity.HasIndex(e => e.Source)
                    .HasName("issuelink_src");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Destination)
                    .HasColumnName("DESTINATION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Linktype)
                    .HasColumnName("LINKTYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Issuelinktype>(entity =>
            {
                entity.ToTable("issuelinktype");

                entity.HasIndex(e => e.Linkname)
                    .HasName("linktypename");

                entity.HasIndex(e => e.Pstyle)
                    .HasName("linktypestyle");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Inward)
                    .HasColumnName("INWARD")
                    .HasMaxLength(255);

                entity.Property(e => e.Linkname)
                    .HasColumnName("LINKNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Outward)
                    .HasColumnName("OUTWARD")
                    .HasMaxLength(255);

                entity.Property(e => e.Pstyle)
                    .HasColumnName("pstyle")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Issuesecurityscheme>(entity =>
            {
                entity.ToTable("issuesecurityscheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Defaultlevel)
                    .HasColumnName("DEFAULTLEVEL")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Issuestatus>(entity =>
            {
                entity.ToTable("issuestatus");

                entity.HasIndex(e => e.Pname)
                    .HasName("issuestatus_pname");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Iconurl)
                    .HasColumnName("ICONURL")
                    .HasMaxLength(255);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(60);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Statuscategory)
                    .HasColumnName("STATUSCATEGORY")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Issuetype>(entity =>
            {
                entity.ToTable("issuetype");

                entity.HasIndex(e => e.Pname)
                    .HasName("issuetype_pname");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.Avatar)
                    .HasColumnName("AVATAR")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Iconurl)
                    .HasColumnName("ICONURL")
                    .HasMaxLength(255);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(60);

                entity.Property(e => e.Pstyle)
                    .HasColumnName("pstyle")
                    .HasMaxLength(60);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Issuetypescreenscheme>(entity =>
            {
                entity.ToTable("issuetypescreenscheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Issuetypescreenschemeentity>(entity =>
            {
                entity.ToTable("issuetypescreenschemeentity");

                entity.HasIndex(e => e.Fieldscreenscheme)
                    .HasName("fieldscreen_scheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldscreenscheme)
                    .HasColumnName("FIELDSCREENSCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issuetype)
                    .HasColumnName("ISSUETYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Scheme)
                    .HasColumnName("SCHEME")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Jiraaction>(entity =>
            {
                entity.ToTable("jiraaction");

                entity.HasIndex(e => new { e.Author, e.Created })
                    .HasName("action_author_created");

                entity.HasIndex(e => new { e.Issueid, e.Actiontype })
                    .HasName("action_issue");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Actionbody)
                    .HasColumnName("actionbody")
                    .HasColumnType("ntext");

                entity.Property(e => e.Actionlevel)
                    .HasColumnName("actionlevel")
                    .HasMaxLength(255);

                entity.Property(e => e.Actionnum)
                    .HasColumnName("actionnum")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Actiontype)
                    .HasColumnName("actiontype")
                    .HasMaxLength(255);

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Issueid)
                    .HasColumnName("issueid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rolelevel)
                    .HasColumnName("rolelevel")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Updateauthor)
                    .HasColumnName("UPDATEAUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Jiradraftworkflows>(entity =>
            {
                entity.ToTable("jiradraftworkflows");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descriptor)
                    .HasColumnName("DESCRIPTOR")
                    .HasColumnType("ntext");

                entity.Property(e => e.Parentname)
                    .HasColumnName("PARENTNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Jiraeventtype>(entity =>
            {
                entity.ToTable("jiraeventtype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.EventType)
                    .HasColumnName("event_type")
                    .HasMaxLength(60);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.TemplateId)
                    .HasColumnName("TEMPLATE_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Jiraissue>(entity =>
            {
                entity.ToTable("jiraissue");

                entity.HasIndex(e => e.Assignee)
                    .HasName("issue_assignee");

                entity.HasIndex(e => e.Created)
                    .HasName("issue_created");

                entity.HasIndex(e => e.Duedate)
                    .HasName("issue_duedate");

                entity.HasIndex(e => e.Issuetype)
                    .HasName("issue_type");

                entity.HasIndex(e => e.Reporter)
                    .HasName("issue_reporter");

                entity.HasIndex(e => e.Resolutiondate)
                    .HasName("issue_resolutiondate");

                entity.HasIndex(e => e.Updated)
                    .HasName("issue_updated");

                entity.HasIndex(e => e.Votes)
                    .HasName("issue_votes");

                entity.HasIndex(e => e.Watches)
                    .HasName("issue_watches");

                entity.HasIndex(e => e.WorkflowId)
                    .HasName("issue_workflow");

                entity.HasIndex(e => new { e.Issuenum, e.Project })
                    .HasName("issue_proj_num")
                    .IsUnique();

                entity.HasIndex(e => new { e.Project, e.Issuestatus })
                    .HasName("issue_proj_status");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Assignee)
                    .HasColumnName("ASSIGNEE")
                    .HasMaxLength(255);

                entity.Property(e => e.Component)
                    .HasColumnName("COMPONENT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Duedate)
                    .HasColumnName("DUEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Environment)
                    .HasColumnName("ENVIRONMENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.Fixfor)
                    .HasColumnName("FIXFOR")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issuenum)
                    .HasColumnName("issuenum")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issuestatus)
                    .HasColumnName("issuestatus")
                    .HasMaxLength(255);

                entity.Property(e => e.Issuetype)
                    .HasColumnName("issuetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Pkey)
                    .HasColumnName("pkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasMaxLength(255);

                entity.Property(e => e.Project)
                    .HasColumnName("PROJECT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Reporter)
                    .HasColumnName("REPORTER")
                    .HasMaxLength(255);

                entity.Property(e => e.Resolution)
                    .HasColumnName("RESOLUTION")
                    .HasMaxLength(255);

                entity.Property(e => e.Resolutiondate)
                    .HasColumnName("RESOLUTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Security)
                    .HasColumnName("SECURITY")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasMaxLength(255);

                entity.Property(e => e.Timeestimate)
                    .HasColumnName("TIMEESTIMATE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Timeoriginalestimate)
                    .HasColumnName("TIMEORIGINALESTIMATE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Timespent)
                    .HasColumnName("TIMESPENT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Votes)
                    .HasColumnName("VOTES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Watches)
                    .HasColumnName("WATCHES")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("WORKFLOW_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Jiraperms>(entity =>
            {
                entity.ToTable("jiraperms");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(255);

                entity.Property(e => e.Permtype)
                    .HasColumnName("permtype")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Jiraworkflows>(entity =>
            {
                entity.ToTable("jiraworkflows");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Creatorname)
                    .HasColumnName("creatorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Descriptor)
                    .HasColumnName("DESCRIPTOR")
                    .HasColumnType("ntext");

                entity.Property(e => e.Islocked)
                    .HasColumnName("ISLOCKED")
                    .HasMaxLength(60);

                entity.Property(e => e.Workflowname)
                    .HasColumnName("workflowname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Jiraworkflowstatuses>(entity =>
            {
                entity.ToTable("jiraworkflowstatuses");

                entity.HasIndex(e => e.Parentname)
                    .HasName("idx_parent_name");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Parentname)
                    .HasColumnName("parentname")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<JquartzBlobTriggers>(entity =>
            {
                entity.HasKey(e => new { e.TriggerName, e.TriggerGroup });

                entity.ToTable("JQUARTZ_BLOB_TRIGGERS");

                entity.Property(e => e.TriggerName)
                    .HasColumnName("TRIGGER_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerGroup)
                    .HasColumnName("TRIGGER_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BlobData)
                    .HasColumnName("BLOB_DATA")
                    .HasColumnType("image");

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzCalendars>(entity =>
            {
                entity.HasKey(e => e.CalendarName);

                entity.ToTable("JQUARTZ_CALENDARS");

                entity.Property(e => e.CalendarName)
                    .HasColumnName("CALENDAR_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Calendar)
                    .HasColumnName("CALENDAR")
                    .HasColumnType("image");

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzCronTriggers>(entity =>
            {
                entity.HasKey(e => new { e.TriggerName, e.TriggerGroup });

                entity.ToTable("JQUARTZ_CRON_TRIGGERS");

                entity.Property(e => e.TriggerName)
                    .HasColumnName("TRIGGER_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerGroup)
                    .HasColumnName("TRIGGER_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CronExpression)
                    .HasColumnName("CRON_EXPRESSION")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneId)
                    .HasColumnName("TIME_ZONE_ID")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzFiredTriggers>(entity =>
            {
                entity.HasKey(e => e.EntryId);

                entity.ToTable("JQUARTZ_FIRED_TRIGGERS");

                entity.HasIndex(e => new { e.SchedName, e.InstanceName })
                    .HasName("idx_qrtz_ft_trig_inst_name");

                entity.HasIndex(e => new { e.SchedName, e.JobGroup })
                    .HasName("idx_qrtz_ft_jg");

                entity.HasIndex(e => new { e.SchedName, e.TriggerGroup })
                    .HasName("idx_qrtz_ft_tg");

                entity.HasIndex(e => new { e.SchedName, e.InstanceName, e.RequestsRecovery })
                    .HasName("idx_qrtz_ft_inst_job_req_rcvry");

                entity.HasIndex(e => new { e.SchedName, e.JobName, e.JobGroup })
                    .HasName("idx_qrtz_ft_j_g");

                entity.HasIndex(e => new { e.SchedName, e.TriggerName, e.TriggerGroup })
                    .HasName("idx_qrtz_ft_t_g");

                entity.Property(e => e.EntryId)
                    .HasColumnName("ENTRY_ID")
                    .HasMaxLength(95)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FiredTime).HasColumnName("FIRED_TIME");

                entity.Property(e => e.InstanceName)
                    .HasColumnName("INSTANCE_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsNonconcurrent)
                    .HasColumnName("IS_NONCONCURRENT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsStateful)
                    .HasColumnName("IS_STATEFUL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsUpdateData)
                    .HasColumnName("IS_UPDATE_DATA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsVolatile)
                    .HasColumnName("IS_VOLATILE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JobGroup)
                    .HasColumnName("JOB_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobName)
                    .HasColumnName("JOB_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.RequestsRecovery)
                    .HasColumnName("REQUESTS_RECOVERY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SchedTime).HasColumnName("SCHED_TIME");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerGroup)
                    .HasColumnName("TRIGGER_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerName)
                    .HasColumnName("TRIGGER_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzJobDetails>(entity =>
            {
                entity.HasKey(e => new { e.JobName, e.JobGroup });

                entity.ToTable("JQUARTZ_JOB_DETAILS");

                entity.HasIndex(e => new { e.SchedName, e.JobGroup })
                    .HasName("idx_qrtz_j_grp");

                entity.HasIndex(e => new { e.SchedName, e.RequestsRecovery })
                    .HasName("idx_qrtz_j_req_recovery");

                entity.Property(e => e.JobName)
                    .HasColumnName("JOB_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobGroup)
                    .HasColumnName("JOB_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsDurable)
                    .HasColumnName("IS_DURABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsNonconcurrent)
                    .HasColumnName("IS_NONCONCURRENT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsStateful)
                    .HasColumnName("IS_STATEFUL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsUpdateData)
                    .HasColumnName("IS_UPDATE_DATA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsVolatile)
                    .HasColumnName("IS_VOLATILE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JobClassName)
                    .HasColumnName("JOB_CLASS_NAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JobData)
                    .HasColumnName("JOB_DATA")
                    .HasColumnType("image");

                entity.Property(e => e.RequestsRecovery)
                    .HasColumnName("REQUESTS_RECOVERY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzJobListeners>(entity =>
            {
                entity.HasKey(e => new { e.JobName, e.JobGroup, e.JobListener });

                entity.ToTable("JQUARTZ_JOB_LISTENERS");

                entity.Property(e => e.JobName)
                    .HasColumnName("JOB_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobGroup)
                    .HasColumnName("JOB_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobListener)
                    .HasColumnName("JOB_LISTENER")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzLocks>(entity =>
            {
                entity.HasKey(e => e.LockName);

                entity.ToTable("JQUARTZ_LOCKS");

                entity.Property(e => e.LockName)
                    .HasColumnName("LOCK_NAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzPausedTriggerGrps>(entity =>
            {
                entity.HasKey(e => e.TriggerGroup);

                entity.ToTable("JQUARTZ_PAUSED_TRIGGER_GRPS");

                entity.Property(e => e.TriggerGroup)
                    .HasColumnName("TRIGGER_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzSchedulerState>(entity =>
            {
                entity.HasKey(e => e.InstanceName);

                entity.ToTable("JQUARTZ_SCHEDULER_STATE");

                entity.Property(e => e.InstanceName)
                    .HasColumnName("INSTANCE_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CheckinInterval).HasColumnName("CHECKIN_INTERVAL");

                entity.Property(e => e.LastCheckinTime).HasColumnName("LAST_CHECKIN_TIME");

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzSimpleTriggers>(entity =>
            {
                entity.HasKey(e => new { e.TriggerName, e.TriggerGroup });

                entity.ToTable("JQUARTZ_SIMPLE_TRIGGERS");

                entity.Property(e => e.TriggerName)
                    .HasColumnName("TRIGGER_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerGroup)
                    .HasColumnName("TRIGGER_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RepeatCount).HasColumnName("REPEAT_COUNT");

                entity.Property(e => e.RepeatInterval).HasColumnName("REPEAT_INTERVAL");

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TimesTriggered).HasColumnName("TIMES_TRIGGERED");
            });

            modelBuilder.Entity<JquartzSimpropTriggers>(entity =>
            {
                entity.HasKey(e => new { e.TriggerName, e.TriggerGroup });

                entity.ToTable("JQUARTZ_SIMPROP_TRIGGERS");

                entity.Property(e => e.TriggerName)
                    .HasColumnName("TRIGGER_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerGroup)
                    .HasColumnName("TRIGGER_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BoolProp1)
                    .HasColumnName("BOOL_PROP_1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BoolProp2)
                    .HasColumnName("BOOL_PROP_2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DecProp1)
                    .HasColumnName("DEC_PROP_1")
                    .HasColumnType("numeric(13, 4)");

                entity.Property(e => e.DecProp2)
                    .HasColumnName("DEC_PROP_2")
                    .HasColumnType("numeric(13, 4)");

                entity.Property(e => e.IntProp1).HasColumnName("INT_PROP_1");

                entity.Property(e => e.IntProp2).HasColumnName("INT_PROP_2");

                entity.Property(e => e.LongProp1).HasColumnName("LONG_PROP_1");

                entity.Property(e => e.LongProp2).HasColumnName("LONG_PROP_2");

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.StrProp1)
                    .HasColumnName("STR_PROP_1")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.StrProp2)
                    .HasColumnName("STR_PROP_2")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.StrProp3)
                    .HasColumnName("STR_PROP_3")
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzTriggerListeners>(entity =>
            {
                entity.HasKey(e => new { e.TriggerGroup, e.TriggerListener });

                entity.ToTable("JQUARTZ_TRIGGER_LISTENERS");

                entity.Property(e => e.TriggerGroup)
                    .HasColumnName("TRIGGER_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerListener)
                    .HasColumnName("TRIGGER_LISTENER")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerName)
                    .HasColumnName("TRIGGER_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JquartzTriggers>(entity =>
            {
                entity.HasKey(e => new { e.TriggerName, e.TriggerGroup });

                entity.ToTable("JQUARTZ_TRIGGERS");

                entity.HasIndex(e => new { e.SchedName, e.CalendarName })
                    .HasName("idx_qrtz_t_c");

                entity.HasIndex(e => new { e.SchedName, e.JobGroup })
                    .HasName("idx_qrtz_t_jg");

                entity.HasIndex(e => new { e.SchedName, e.NextFireTime })
                    .HasName("idx_qrtz_t_next_fire_time");

                entity.HasIndex(e => new { e.SchedName, e.TriggerGroup })
                    .HasName("idx_qrtz_j_g");

                entity.HasIndex(e => new { e.SchedName, e.TriggerState })
                    .HasName("idx_qrtz_j_state");

                entity.HasIndex(e => new { e.SchedName, e.JobName, e.JobGroup })
                    .HasName("idx_qrtz_t_j");

                entity.HasIndex(e => new { e.SchedName, e.MisfireInstr, e.NextFireTime })
                    .HasName("idx_qrtz_t_nft_misfire");

                entity.HasIndex(e => new { e.SchedName, e.TriggerGroup, e.TriggerState })
                    .HasName("idx_qrtz_t_n_g_state");

                entity.HasIndex(e => new { e.SchedName, e.TriggerState, e.NextFireTime })
                    .HasName("idx_qrtz_t_nft_st");

                entity.HasIndex(e => new { e.SchedName, e.MisfireInstr, e.NextFireTime, e.TriggerState })
                    .HasName("idx_qrtz_t_nft_st_misfire");

                entity.HasIndex(e => new { e.SchedName, e.TriggerName, e.TriggerGroup, e.TriggerState })
                    .HasName("idx_qrtz_t_n_state");

                entity.HasIndex(e => new { e.SchedName, e.MisfireInstr, e.NextFireTime, e.TriggerGroup, e.TriggerState })
                    .HasName("idx_qrtz_t_nft_st_misfire_grp");

                entity.Property(e => e.TriggerName)
                    .HasColumnName("TRIGGER_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerGroup)
                    .HasColumnName("TRIGGER_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CalendarName)
                    .HasColumnName("CALENDAR_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnName("END_TIME");

                entity.Property(e => e.IsVolatile)
                    .HasColumnName("IS_VOLATILE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JobData)
                    .HasColumnName("JOB_DATA")
                    .HasColumnType("image");

                entity.Property(e => e.JobGroup)
                    .HasColumnName("JOB_GROUP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobName)
                    .HasColumnName("JOB_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MisfireInstr).HasColumnName("MISFIRE_INSTR");

                entity.Property(e => e.NextFireTime).HasColumnName("NEXT_FIRE_TIME");

                entity.Property(e => e.PrevFireTime).HasColumnName("PREV_FIRE_TIME");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.SchedName)
                    .HasColumnName("SCHED_NAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnName("START_TIME");

                entity.Property(e => e.TriggerState)
                    .HasColumnName("TRIGGER_STATE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerType)
                    .HasColumnName("TRIGGER_TYPE")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.ToTable("label");

                entity.HasIndex(e => e.Issue)
                    .HasName("label_issue");

                entity.HasIndex(e => e.Label1)
                    .HasName("label_label");

                entity.HasIndex(e => new { e.Issue, e.Fieldid })
                    .HasName("label_fieldissue");

                entity.HasIndex(e => new { e.Issue, e.Fieldid, e.Label1 })
                    .HasName("label_fieldissuelabel");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldid)
                    .HasColumnName("FIELDID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issue)
                    .HasColumnName("ISSUE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Label1)
                    .HasColumnName("LABEL")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Licenserolesdefault>(entity =>
            {
                entity.ToTable("licenserolesdefault");

                entity.HasIndex(e => e.LicenseRoleName)
                    .HasName("licenseroledefault_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LicenseRoleName)
                    .HasColumnName("LICENSE_ROLE_NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Licenserolesgroup>(entity =>
            {
                entity.ToTable("licenserolesgroup");

                entity.HasIndex(e => new { e.LicenseRoleName, e.GroupId })
                    .HasName("licenserolegroup_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GROUP_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.LicenseRoleName)
                    .HasColumnName("LICENSE_ROLE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryGroup)
                    .HasColumnName("PRIMARY_GROUP")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Listenerconfig>(entity =>
            {
                entity.ToTable("listenerconfig");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Clazz)
                    .HasColumnName("CLAZZ")
                    .HasMaxLength(255);

                entity.Property(e => e.Listenername)
                    .HasColumnName("listenername")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Mailserver>(entity =>
            {
                entity.ToTable("mailserver");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Istlsrequired)
                    .HasColumnName("ISTLSREQUIRED")
                    .HasMaxLength(60);

                entity.Property(e => e.Jndilocation)
                    .HasColumnName("JNDILOCATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Mailfrom)
                    .HasColumnName("mailfrom")
                    .HasMaxLength(255);

                entity.Property(e => e.Mailpassword)
                    .HasColumnName("mailpassword")
                    .HasMaxLength(255);

                entity.Property(e => e.Mailusername)
                    .HasColumnName("mailusername")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Prefix)
                    .HasColumnName("PREFIX")
                    .HasMaxLength(60);

                entity.Property(e => e.Protocol)
                    .HasColumnName("protocol")
                    .HasMaxLength(60);

                entity.Property(e => e.ServerType)
                    .HasColumnName("server_type")
                    .HasMaxLength(60);

                entity.Property(e => e.Servername)
                    .HasColumnName("SERVERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpPort)
                    .HasColumnName("smtp_port")
                    .HasMaxLength(60);

                entity.Property(e => e.SocksHost)
                    .HasColumnName("socks_host")
                    .HasMaxLength(60);

                entity.Property(e => e.SocksPort)
                    .HasColumnName("socks_port")
                    .HasMaxLength(60);

                entity.Property(e => e.Timeout)
                    .HasColumnName("TIMEOUT")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Managedconfigurationitem>(entity =>
            {
                entity.ToTable("managedconfigurationitem");

                entity.HasIndex(e => new { e.ItemId, e.ItemType })
                    .HasName("managedconfigitem_id_type_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("ACCESS_LEVEL")
                    .HasMaxLength(255);

                entity.Property(e => e.DescriptionKey)
                    .HasColumnName("DESCRIPTION_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemId)
                    .HasColumnName("ITEM_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemType)
                    .HasColumnName("ITEM_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Managed)
                    .HasColumnName("MANAGED")
                    .HasMaxLength(10);

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Membershipbase>(entity =>
            {
                entity.ToTable("membershipbase");

                entity.HasIndex(e => e.GroupName)
                    .HasName("mshipbase_group");

                entity.HasIndex(e => e.UserName)
                    .HasName("mshipbase_user");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MovedIssueKey>(entity =>
            {
                entity.ToTable("moved_issue_key");

                entity.HasIndex(e => e.OldIssueKey)
                    .HasName("idx_old_issue_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IssueId)
                    .HasColumnName("ISSUE_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OldIssueKey)
                    .HasColumnName("OLD_ISSUE_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NeweggProjectMaster>(entity =>
            {
                entity.ToTable("newegg_project_master");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("newegg_project_master_projectid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creater)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Detail).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasColumnName("ProjectID")
                    .HasMaxLength(255);

                entity.Property(e => e.Purpose)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Updater).HasMaxLength(255);
            });

            modelBuilder.Entity<NeweggProjectTransaction>(entity =>
            {
                entity.ToTable("newegg_project_transaction");

                entity.HasIndex(e => e.Group)
                    .HasName("newegg_project_transaction_group");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("newegg_project_transaction_projectid");

                entity.HasIndex(e => e.Status)
                    .HasName("newegg_project_transaction_status");

                entity.HasIndex(e => e.Type)
                    .HasName("newegg_project_transaction_type");

                entity.HasIndex(e => e.Value)
                    .HasName("newegg_project_transaction_value");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Creater)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Detail).HasColumnType("ntext");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasColumnName("ProjectID")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TransTime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Updater).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);
            });

            modelBuilder.Entity<Nodeassociation>(entity =>
            {
                entity.HasKey(e => new { e.SourceNodeId, e.SourceNodeEntity, e.SinkNodeId, e.SinkNodeEntity, e.AssociationType });

                entity.ToTable("nodeassociation");

                entity.HasIndex(e => new { e.SinkNodeId, e.SinkNodeEntity })
                    .HasName("node_sink");

                entity.HasIndex(e => new { e.SourceNodeId, e.SourceNodeEntity })
                    .HasName("node_source");

                entity.Property(e => e.SourceNodeId)
                    .HasColumnName("SOURCE_NODE_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SourceNodeEntity)
                    .HasColumnName("SOURCE_NODE_ENTITY")
                    .HasMaxLength(60);

                entity.Property(e => e.SinkNodeId)
                    .HasColumnName("SINK_NODE_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SinkNodeEntity)
                    .HasColumnName("SINK_NODE_ENTITY")
                    .HasMaxLength(60);

                entity.Property(e => e.AssociationType)
                    .HasColumnName("ASSOCIATION_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            });

            modelBuilder.Entity<Nodeindexcounter>(entity =>
            {
                entity.ToTable("nodeindexcounter");

                entity.HasIndex(e => new { e.NodeId, e.SendingNodeId })
                    .HasName("node_id_idx")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IndexOperationId)
                    .HasColumnName("INDEX_OPERATION_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NodeId)
                    .HasColumnName("NODE_ID")
                    .HasMaxLength(60);

                entity.Property(e => e.SendingNodeId)
                    .HasColumnName("SENDING_NODE_ID")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notification");

                entity.HasIndex(e => e.Scheme)
                    .HasName("ntfctn_scheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Event)
                    .HasColumnName("EVENT")
                    .HasMaxLength(60);

                entity.Property(e => e.EventTypeId)
                    .HasColumnName("EVENT_TYPE_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NotifParameter)
                    .HasColumnName("notif_parameter")
                    .HasMaxLength(60);

                entity.Property(e => e.NotifType)
                    .HasColumnName("notif_type")
                    .HasMaxLength(60);

                entity.Property(e => e.Scheme)
                    .HasColumnName("SCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("TEMPLATE_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Notificationinstance>(entity =>
            {
                entity.ToTable("notificationinstance");

                entity.HasIndex(e => e.Messageid)
                    .HasName("notif_messageid");

                entity.HasIndex(e => e.Source)
                    .HasName("notif_source");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Emailaddress)
                    .HasColumnName("emailaddress")
                    .HasMaxLength(255);

                entity.Property(e => e.Messageid)
                    .HasColumnName("MESSAGEID")
                    .HasMaxLength(255);

                entity.Property(e => e.Notificationtype)
                    .HasColumnName("notificationtype")
                    .HasMaxLength(60);

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Notificationscheme>(entity =>
            {
                entity.ToTable("notificationscheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Oauthconsumer>(entity =>
            {
                entity.ToTable("oauthconsumer");

                entity.HasIndex(e => e.ConsumerKey)
                    .HasName("oauth_consumer_index")
                    .IsUnique();

                entity.HasIndex(e => e.Consumerservice)
                    .HasName("oauth_consumer_service_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Callback)
                    .HasColumnName("CALLBACK")
                    .HasColumnType("ntext");

                entity.Property(e => e.ConsumerKey)
                    .HasColumnName("CONSUMER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Consumername)
                    .HasColumnName("consumername")
                    .HasMaxLength(255);

                entity.Property(e => e.Consumerservice)
                    .HasColumnName("consumerservice")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.PrivateKey)
                    .HasColumnName("PRIVATE_KEY")
                    .HasColumnType("ntext");

                entity.Property(e => e.PublicKey)
                    .HasColumnName("PUBLIC_KEY")
                    .HasColumnType("ntext");

                entity.Property(e => e.SharedSecret)
                    .HasColumnName("SHARED_SECRET")
                    .HasColumnType("ntext");

                entity.Property(e => e.SignatureMethod)
                    .HasColumnName("SIGNATURE_METHOD")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Oauthconsumertoken>(entity =>
            {
                entity.ToTable("oauthconsumertoken");

                entity.HasIndex(e => e.Token)
                    .HasName("oauth_consumer_token_index");

                entity.HasIndex(e => e.TokenKey)
                    .HasName("oauth_consumer_token_key_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ConsumerKey)
                    .HasColumnName("CONSUMER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .HasColumnName("TOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.TokenKey)
                    .HasColumnName("TOKEN_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.TokenSecret)
                    .HasColumnName("TOKEN_SECRET")
                    .HasMaxLength(255);

                entity.Property(e => e.TokenType)
                    .HasColumnName("TOKEN_TYPE")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Oauthspconsumer>(entity =>
            {
                entity.ToTable("oauthspconsumer");

                entity.HasIndex(e => e.ConsumerKey)
                    .HasName("oauth_sp_consumer_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Callback)
                    .HasColumnName("CALLBACK")
                    .HasColumnType("ntext");

                entity.Property(e => e.ConsumerKey)
                    .HasColumnName("CONSUMER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Consumername)
                    .HasColumnName("consumername")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExecutingTwoLOUser)
                    .HasColumnName("EXECUTING_TWO_L_O_USER")
                    .HasMaxLength(255);

                entity.Property(e => e.PublicKey)
                    .HasColumnName("PUBLIC_KEY")
                    .HasColumnType("ntext");

                entity.Property(e => e.ThreeLOAllowed)
                    .HasColumnName("THREE_L_O_ALLOWED")
                    .HasMaxLength(60);

                entity.Property(e => e.TwoLOAllowed)
                    .HasColumnName("TWO_L_O_ALLOWED")
                    .HasMaxLength(60);

                entity.Property(e => e.TwoLOImpersonationAllowed)
                    .HasColumnName("TWO_L_O_IMPERSONATION_ALLOWED")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Oauthsptoken>(entity =>
            {
                entity.ToTable("oauthsptoken");

                entity.HasIndex(e => e.ConsumerKey)
                    .HasName("oauth_sp_consumer_key_index");

                entity.HasIndex(e => e.Token)
                    .HasName("oauth_sp_token_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Callback)
                    .HasColumnName("CALLBACK")
                    .HasColumnType("ntext");

                entity.Property(e => e.ConsumerKey)
                    .HasColumnName("CONSUMER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionCreationTime)
                    .HasColumnName("SESSION_CREATION_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionHandle)
                    .HasColumnName("SESSION_HANDLE")
                    .HasMaxLength(255);

                entity.Property(e => e.SessionLastRenewalTime)
                    .HasColumnName("SESSION_LAST_RENEWAL_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionTimeToLive)
                    .HasColumnName("SESSION_TIME_TO_LIVE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Spauth)
                    .HasColumnName("spauth")
                    .HasMaxLength(60);

                entity.Property(e => e.Spverifier)
                    .HasColumnName("spverifier")
                    .HasMaxLength(255);

                entity.Property(e => e.Spversion)
                    .HasColumnName("spversion")
                    .HasMaxLength(60);

                entity.Property(e => e.Token)
                    .HasColumnName("TOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.TokenSecret)
                    .HasColumnName("TOKEN_SECRET")
                    .HasMaxLength(255);

                entity.Property(e => e.TokenType)
                    .HasColumnName("TOKEN_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.Ttl)
                    .HasColumnName("TTL")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Optionconfiguration>(entity =>
            {
                entity.ToTable("optionconfiguration");

                entity.HasIndex(e => new { e.Fieldid, e.Fieldconfig })
                    .HasName("fieldid_fieldconf");

                entity.HasIndex(e => new { e.Fieldid, e.Optionid })
                    .HasName("fieldid_optionid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldconfig)
                    .HasColumnName("FIELDCONFIG")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Fieldid)
                    .HasColumnName("FIELDID")
                    .HasMaxLength(60);

                entity.Property(e => e.Optionid)
                    .HasColumnName("OPTIONID")
                    .HasMaxLength(60);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<OsCurrentstep>(entity =>
            {
                entity.ToTable("OS_CURRENTSTEP");

                entity.HasIndex(e => e.EntryId)
                    .HasName("wf_entryid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ActionId).HasColumnName("ACTION_ID");

                entity.Property(e => e.Caller)
                    .HasColumnName("CALLER")
                    .HasMaxLength(60);

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntryId)
                    .HasColumnName("ENTRY_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FinishDate)
                    .HasColumnName("FINISH_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(60);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(60);

                entity.Property(e => e.StepId).HasColumnName("STEP_ID");
            });

            modelBuilder.Entity<OsCurrentstepPrev>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PreviousId });

                entity.ToTable("OS_CURRENTSTEP_PREV");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PreviousId)
                    .HasColumnName("PREVIOUS_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<OsHistorystep>(entity =>
            {
                entity.ToTable("OS_HISTORYSTEP");

                entity.HasIndex(e => e.EntryId)
                    .HasName("historystep_entryid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ActionId).HasColumnName("ACTION_ID");

                entity.Property(e => e.Caller)
                    .HasColumnName("CALLER")
                    .HasMaxLength(60);

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntryId)
                    .HasColumnName("ENTRY_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FinishDate)
                    .HasColumnName("FINISH_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(60);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(60);

                entity.Property(e => e.StepId).HasColumnName("STEP_ID");
            });

            modelBuilder.Entity<OsHistorystepPrev>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PreviousId });

                entity.ToTable("OS_HISTORYSTEP_PREV");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PreviousId)
                    .HasColumnName("PREVIOUS_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<OsWfentry>(entity =>
            {
                entity.ToTable("OS_WFENTRY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Initialized).HasColumnName("INITIALIZED");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasColumnName("STATE");
            });

            modelBuilder.Entity<Permissionscheme>(entity =>
            {
                entity.ToTable("permissionscheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Permissionschemeattribute>(entity =>
            {
                entity.ToTable("permissionschemeattribute");

                entity.HasIndex(e => e.Scheme)
                    .HasName("prmssn_scheme_attr_idx");

                entity.HasIndex(e => new { e.Scheme, e.AttributeKey })
                    .HasName("prmssn_scheme_attr_key_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AttributeKey)
                    .HasColumnName("ATTRIBUTE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeValue)
                    .HasColumnName("ATTRIBUTE_VALUE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Scheme)
                    .HasColumnName("SCHEME")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Pluginstate>(entity =>
            {
                entity.HasKey(e => e.Pluginkey);

                entity.ToTable("pluginstate");

                entity.Property(e => e.Pluginkey)
                    .HasColumnName("pluginkey")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Pluginenabled)
                    .HasColumnName("pluginenabled")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Pluginversion>(entity =>
            {
                entity.ToTable("pluginversion");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pluginkey)
                    .HasColumnName("pluginkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Pluginname)
                    .HasColumnName("pluginname")
                    .HasMaxLength(255);

                entity.Property(e => e.Pluginversion1)
                    .HasColumnName("pluginversion")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Portalpage>(entity =>
            {
                entity.ToTable("portalpage");

                entity.HasIndex(e => e.Username)
                    .HasName("ppage_username");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.FavCount)
                    .HasColumnName("FAV_COUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Layout)
                    .HasColumnName("LAYOUT")
                    .HasMaxLength(255);

                entity.Property(e => e.Pagename)
                    .HasColumnName("PAGENAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Ppversion)
                    .HasColumnName("ppversion")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Portletconfiguration>(entity =>
            {
                entity.ToTable("portletconfiguration");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Color)
                    .HasColumnName("COLOR")
                    .HasMaxLength(255);

                entity.Property(e => e.ColumnNumber).HasColumnName("COLUMN_NUMBER");

                entity.Property(e => e.DashboardModuleCompleteKey)
                    .HasColumnName("DASHBOARD_MODULE_COMPLETE_KEY")
                    .HasColumnType("ntext");

                entity.Property(e => e.GadgetXml)
                    .HasColumnName("GADGET_XML")
                    .HasColumnType("ntext");

                entity.Property(e => e.Portalpage)
                    .HasColumnName("PORTALPAGE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PortletId)
                    .HasColumnName("PORTLET_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Positionseq).HasColumnName("positionseq");
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.ToTable("priority");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Iconurl)
                    .HasColumnName("ICONURL")
                    .HasMaxLength(255);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(60);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StatusColor)
                    .HasColumnName("STATUS_COLOR")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Productlicense>(entity =>
            {
                entity.ToTable("productlicense");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.License)
                    .HasColumnName("LICENSE")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("project");

                entity.HasIndex(e => e.Pkey)
                    .HasName("project_pkey");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Assigneetype)
                    .HasColumnName("ASSIGNEETYPE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Avatar)
                    .HasColumnName("AVATAR")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Lead)
                    .HasColumnName("LEAD")
                    .HasMaxLength(255);

                entity.Property(e => e.Originalkey)
                    .HasColumnName("ORIGINALKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Pcounter)
                    .HasColumnName("pcounter")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Pkey)
                    .HasColumnName("pkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(255);

                entity.Property(e => e.Projecttype)
                    .HasColumnName("PROJECTTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Projectcategory>(entity =>
            {
                entity.ToTable("projectcategory");

                entity.HasIndex(e => e.Cname)
                    .HasName("idx_project_category_name");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Projectchangedtime>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("projectchangedtime");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IssueChangedTime)
                    .HasColumnName("ISSUE_CHANGED_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ProjectKey>(entity =>
            {
                entity.ToTable("project_key");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_all_project_ids");

                entity.HasIndex(e => e.ProjectKey1)
                    .HasName("idx_all_project_keys")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProjectKey1)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Projectrole>(entity =>
            {
                entity.ToTable("projectrole");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Projectroleactor>(entity =>
            {
                entity.ToTable("projectroleactor");

                entity.HasIndex(e => e.Pid)
                    .HasName("role_pid_idx");

                entity.HasIndex(e => new { e.Projectroleid, e.Pid })
                    .HasName("role_player_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Projectroleid)
                    .HasColumnName("PROJECTROLEID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Roletype)
                    .HasColumnName("ROLETYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Roletypeparameter)
                    .HasColumnName("ROLETYPEPARAMETER")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Projectversion>(entity =>
            {
                entity.ToTable("projectversion");

                entity.HasIndex(e => e.Project)
                    .HasName("idx_version_project");

                entity.HasIndex(e => e.Sequence)
                    .HasName("idx_version_sequence");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Archived)
                    .HasColumnName("ARCHIVED")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Project)
                    .HasColumnName("PROJECT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Released)
                    .HasColumnName("RELEASED")
                    .HasMaxLength(10);

                entity.Property(e => e.Releasedate)
                    .HasColumnName("RELEASEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255);

                entity.Property(e => e.Vname)
                    .HasColumnName("vname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Propertydata>(entity =>
            {
                entity.ToTable("propertydata");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Propertyvalue)
                    .HasColumnName("propertyvalue")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<Propertydate>(entity =>
            {
                entity.ToTable("propertydate");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Propertyvalue)
                    .HasColumnName("propertyvalue")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Propertydecimal>(entity =>
            {
                entity.ToTable("propertydecimal");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Propertyvalue)
                    .HasColumnName("propertyvalue")
                    .HasColumnType("numeric(18, 6)");
            });

            modelBuilder.Entity<Propertyentry>(entity =>
            {
                entity.ToTable("propertyentry");

                entity.HasIndex(e => e.EntityId)
                    .HasName("osproperty_all");

                entity.HasIndex(e => e.EntityName)
                    .HasName("osproperty_entityName");

                entity.HasIndex(e => e.PropertyKey)
                    .HasName("osproperty_propertyKey");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EntityId)
                    .HasColumnName("ENTITY_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EntityName)
                    .HasColumnName("ENTITY_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PropertyKey)
                    .HasColumnName("PROPERTY_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Propertytype).HasColumnName("propertytype");
            });

            modelBuilder.Entity<Propertynumber>(entity =>
            {
                entity.ToTable("propertynumber");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Propertyvalue)
                    .HasColumnName("propertyvalue")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Propertystring>(entity =>
            {
                entity.ToTable("propertystring");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Propertyvalue)
                    .HasColumnName("propertyvalue")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Propertytext>(entity =>
            {
                entity.ToTable("propertytext");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Propertyvalue)
                    .HasColumnName("propertyvalue")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<QrtzCalendars>(entity =>
            {
                entity.HasKey(e => e.CalendarName);

                entity.ToTable("qrtz_calendars");

                entity.Property(e => e.CalendarName)
                    .HasColumnName("CALENDAR_NAME")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Calendar)
                    .HasColumnName("CALENDAR")
                    .HasColumnType("ntext");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<QrtzCronTriggers>(entity =>
            {
                entity.ToTable("qrtz_cron_triggers");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CronExperssion)
                    .HasColumnName("cronExperssion")
                    .HasMaxLength(255);

                entity.Property(e => e.TriggerId)
                    .HasColumnName("trigger_id")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<QrtzFiredTriggers>(entity =>
            {
                entity.HasKey(e => e.EntryId);

                entity.ToTable("qrtz_fired_triggers");

                entity.Property(e => e.EntryId)
                    .HasColumnName("ENTRY_ID")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.FiredTime)
                    .HasColumnName("FIRED_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TriggerId)
                    .HasColumnName("trigger_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TriggerListener)
                    .HasColumnName("TRIGGER_LISTENER")
                    .HasMaxLength(255);

                entity.Property(e => e.TriggerState)
                    .HasColumnName("TRIGGER_STATE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QrtzJobDetails>(entity =>
            {
                entity.ToTable("qrtz_job_details");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ClassName)
                    .HasColumnName("CLASS_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.IsDurable)
                    .HasColumnName("IS_DURABLE")
                    .HasMaxLength(60);

                entity.Property(e => e.IsStateful)
                    .HasColumnName("IS_STATEFUL")
                    .HasMaxLength(60);

                entity.Property(e => e.JobData)
                    .HasColumnName("JOB_DATA")
                    .HasMaxLength(255);

                entity.Property(e => e.JobGroup)
                    .HasColumnName("JOB_GROUP")
                    .HasMaxLength(255);

                entity.Property(e => e.JobName)
                    .HasColumnName("JOB_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.RequestsRecovery)
                    .HasColumnName("REQUESTS_RECOVERY")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<QrtzJobListeners>(entity =>
            {
                entity.ToTable("qrtz_job_listeners");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Job)
                    .HasColumnName("JOB")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.JobListener)
                    .HasColumnName("JOB_LISTENER")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QrtzSimpleTriggers>(entity =>
            {
                entity.ToTable("qrtz_simple_triggers");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RepeatCount).HasColumnName("REPEAT_COUNT");

                entity.Property(e => e.RepeatInterval)
                    .HasColumnName("REPEAT_INTERVAL")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TimesTriggered).HasColumnName("TIMES_TRIGGERED");

                entity.Property(e => e.TriggerId)
                    .HasColumnName("trigger_id")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<QrtzTriggerListeners>(entity =>
            {
                entity.ToTable("qrtz_trigger_listeners");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TriggerId)
                    .HasColumnName("trigger_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TriggerListener)
                    .HasColumnName("TRIGGER_LISTENER")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QrtzTriggers>(entity =>
            {
                entity.ToTable("qrtz_triggers");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CalendarName)
                    .HasColumnName("CALENDAR_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .HasColumnName("JOB")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MisfireInstr).HasColumnName("MISFIRE_INSTR");

                entity.Property(e => e.NextFire)
                    .HasColumnName("NEXT_FIRE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.TriggerGroup)
                    .HasColumnName("TRIGGER_GROUP")
                    .HasMaxLength(255);

                entity.Property(e => e.TriggerName)
                    .HasColumnName("TRIGGER_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.TriggerState)
                    .HasColumnName("TRIGGER_STATE")
                    .HasMaxLength(255);

                entity.Property(e => e.TriggerType)
                    .HasColumnName("TRIGGER_TYPE")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ReindexComponent>(entity =>
            {
                entity.ToTable("reindex_component");

                entity.HasIndex(e => e.RequestId)
                    .HasName("idx_reindex_component_req_id");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AffectedIndex)
                    .HasColumnName("AFFECTED_INDEX")
                    .HasMaxLength(60);

                entity.Property(e => e.EntityType)
                    .HasColumnName("ENTITY_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.RequestId)
                    .HasColumnName("REQUEST_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ReindexRequest>(entity =>
            {
                entity.ToTable("reindex_request");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompletionTime)
                    .HasColumnName("COMPLETION_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExecutionNodeId)
                    .HasColumnName("EXECUTION_NODE_ID")
                    .HasMaxLength(60);

                entity.Property(e => e.Query)
                    .HasColumnName("QUERY")
                    .HasColumnType("ntext");

                entity.Property(e => e.RequestTime)
                    .HasColumnName("REQUEST_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(60);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Remembermetoken>(entity =>
            {
                entity.ToTable("remembermetoken");

                entity.HasIndex(e => e.Username)
                    .HasName("remembermetoken_username_index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .HasColumnName("TOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Remotelink>(entity =>
            {
                entity.ToTable("remotelink");

                entity.HasIndex(e => e.Globalid)
                    .HasName("remotelink_globalid");

                entity.HasIndex(e => new { e.Issueid, e.Globalid })
                    .HasName("remotelink_issueid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Applicationname)
                    .HasColumnName("APPLICATIONNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Applicationtype)
                    .HasColumnName("APPLICATIONTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Globalid)
                    .HasColumnName("GLOBALID")
                    .HasMaxLength(255);

                entity.Property(e => e.Icontitle)
                    .HasColumnName("ICONTITLE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Iconurl)
                    .HasColumnName("ICONURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.Issueid)
                    .HasColumnName("ISSUEID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Relationship)
                    .HasColumnName("RELATIONSHIP")
                    .HasMaxLength(255);

                entity.Property(e => e.Resolved)
                    .HasColumnName("RESOLVED")
                    .HasMaxLength(1);

                entity.Property(e => e.Statuscategorycolorname)
                    .HasColumnName("STATUSCATEGORYCOLORNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Statuscategorykey)
                    .HasColumnName("STATUSCATEGORYKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Statusdescription)
                    .HasColumnName("STATUSDESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Statusiconlink)
                    .HasColumnName("STATUSICONLINK")
                    .HasColumnType("ntext");

                entity.Property(e => e.Statusicontitle)
                    .HasColumnName("STATUSICONTITLE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Statusiconurl)
                    .HasColumnName("STATUSICONURL")
                    .HasColumnType("ntext");

                entity.Property(e => e.Statusname)
                    .HasColumnName("STATUSNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasColumnType("ntext");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Replicatedindexoperation>(entity =>
            {
                entity.ToTable("replicatedindexoperation");

                entity.HasIndex(e => new { e.NodeId, e.AffectedIndex, e.Operation, e.IndexTime })
                    .HasName("node_operation_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AffectedIds)
                    .HasColumnName("AFFECTED_IDS")
                    .HasColumnType("ntext");

                entity.Property(e => e.AffectedIndex)
                    .HasColumnName("AFFECTED_INDEX")
                    .HasMaxLength(60);

                entity.Property(e => e.EntityType)
                    .HasColumnName("ENTITY_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .HasMaxLength(255);

                entity.Property(e => e.IndexTime)
                    .HasColumnName("INDEX_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.NodeId)
                    .HasColumnName("NODE_ID")
                    .HasMaxLength(60);

                entity.Property(e => e.Operation)
                    .HasColumnName("OPERATION")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Resolution>(entity =>
            {
                entity.ToTable("resolution");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Iconurl)
                    .HasColumnName("ICONURL")
                    .HasMaxLength(255);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(60);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Rundetails>(entity =>
            {
                entity.ToTable("rundetails");

                entity.HasIndex(e => e.JobId)
                    .HasName("rundetails_jobid_idx");

                entity.HasIndex(e => e.StartTime)
                    .HasName("rundetails_starttime_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InfoMessage)
                    .HasColumnName("INFO_MESSAGE")
                    .HasMaxLength(255);

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.RunDuration)
                    .HasColumnName("RUN_DURATION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RunOutcome)
                    .HasColumnName("RUN_OUTCOME")
                    .HasMaxLength(1);

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Schemeissuesecurities>(entity =>
            {
                entity.ToTable("schemeissuesecurities");

                entity.HasIndex(e => e.Scheme)
                    .HasName("sec_scheme");

                entity.HasIndex(e => e.Security)
                    .HasName("sec_security");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Scheme)
                    .HasColumnName("SCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SecParameter)
                    .HasColumnName("sec_parameter")
                    .HasMaxLength(255);

                entity.Property(e => e.SecType)
                    .HasColumnName("sec_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Security)
                    .HasColumnName("SECURITY")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Schemeissuesecuritylevels>(entity =>
            {
                entity.ToTable("schemeissuesecuritylevels");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Scheme)
                    .HasColumnName("SCHEME")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Schemepermissions>(entity =>
            {
                entity.ToTable("schemepermissions");

                entity.HasIndex(e => e.PermissionKey)
                    .HasName("permission_key_idx");

                entity.HasIndex(e => e.Scheme)
                    .HasName("prmssn_scheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PermParameter)
                    .HasColumnName("perm_parameter")
                    .HasMaxLength(255);

                entity.Property(e => e.PermType)
                    .HasColumnName("perm_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Permission)
                    .HasColumnName("PERMISSION")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PermissionKey)
                    .HasColumnName("PERMISSION_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Scheme)
                    .HasColumnName("SCHEME")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Searchrequest>(entity =>
            {
                entity.ToTable("searchrequest");

                entity.HasIndex(e => e.Authorname)
                    .HasName("sr_author");

                entity.HasIndex(e => e.FilternameLower)
                    .HasName("searchrequest_filternameLower");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Authorname)
                    .HasColumnName("authorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.FavCount)
                    .HasColumnName("FAV_COUNT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Filtername)
                    .HasColumnName("filtername")
                    .HasMaxLength(255);

                entity.Property(e => e.FilternameLower)
                    .HasColumnName("filtername_lower")
                    .HasMaxLength(255);

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(255);

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Reqcontent)
                    .HasColumnName("reqcontent")
                    .HasColumnType("ntext");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SequenceValueItem>(entity =>
            {
                entity.HasKey(e => e.SeqName);

                entity.ToTable("SEQUENCE_VALUE_ITEM");

                entity.Property(e => e.SeqName)
                    .HasColumnName("SEQ_NAME")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.SeqId)
                    .HasColumnName("SEQ_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Serviceconfig>(entity =>
            {
                entity.ToTable("serviceconfig");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Clazz)
                    .HasColumnName("CLAZZ")
                    .HasMaxLength(255);

                entity.Property(e => e.CronExpression)
                    .HasColumnName("CRON_EXPRESSION")
                    .HasMaxLength(255);

                entity.Property(e => e.Delaytime)
                    .HasColumnName("delaytime")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Servicename)
                    .HasColumnName("servicename")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Sharepermissions>(entity =>
            {
                entity.ToTable("sharepermissions");

                entity.HasIndex(e => new { e.Entityid, e.Entitytype })
                    .HasName("share_index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Entityid)
                    .HasColumnName("entityid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Entitytype)
                    .HasColumnName("entitytype")
                    .HasMaxLength(60);

                entity.Property(e => e.Param1)
                    .HasColumnName("PARAM1")
                    .HasMaxLength(255);

                entity.Property(e => e.Param2)
                    .HasColumnName("PARAM2")
                    .HasMaxLength(60);

                entity.Property(e => e.Sharetype)
                    .HasColumnName("sharetype")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Tempattachmentsmonitor>(entity =>
            {
                entity.HasKey(e => e.TemporaryAttachmentId);

                entity.ToTable("tempattachmentsmonitor");

                entity.HasIndex(e => e.CreatedTime)
                    .HasName("idx_tam_by_created_time");

                entity.HasIndex(e => e.FormToken)
                    .HasName("idx_tam_by_form_token");

                entity.Property(e => e.TemporaryAttachmentId)
                    .HasColumnName("TEMPORARY_ATTACHMENT_ID")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.ContentType)
                    .HasColumnName("CONTENT_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("CREATED_TIME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.FileSize)
                    .HasColumnName("FILE_SIZE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FormToken)
                    .HasColumnName("FORM_TOKEN")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TrackbackPing>(entity =>
            {
                entity.ToTable("trackback_ping");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Blogname)
                    .HasColumnName("BLOGNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Excerpt)
                    .HasColumnName("EXCERPT")
                    .HasMaxLength(255);

                entity.Property(e => e.Issue)
                    .HasColumnName("ISSUE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Trustedapp>(entity =>
            {
                entity.ToTable("trustedapp");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("trustedapp_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("APPLICATION_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(255);

                entity.Property(e => e.IpMatch)
                    .HasColumnName("IP_MATCH")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PublicKey)
                    .HasColumnName("PUBLIC_KEY")
                    .HasColumnType("ntext");

                entity.Property(e => e.Timeout)
                    .HasColumnName("TIMEOUT")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(255);

                entity.Property(e => e.UrlMatch)
                    .HasColumnName("URL_MATCH")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Upgradehistory>(entity =>
            {
                entity.HasKey(e => e.Upgradeclass);

                entity.ToTable("upgradehistory");

                entity.Property(e => e.Upgradeclass)
                    .HasColumnName("UPGRADECLASS")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Downgradetaskrequired)
                    .HasColumnName("DOWNGRADETASKREQUIRED")
                    .HasMaxLength(1);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Targetbuild)
                    .HasColumnName("TARGETBUILD")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Upgradetaskhistory>(entity =>
            {
                entity.ToTable("upgradetaskhistory");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BuildNumber).HasColumnName("BUILD_NUMBER");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(60);

                entity.Property(e => e.UpgradeTaskFactoryKey)
                    .HasColumnName("UPGRADE_TASK_FACTORY_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.UpgradeType)
                    .HasColumnName("UPGRADE_TYPE")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Upgradetaskhistoryauditlog>(entity =>
            {
                entity.ToTable("upgradetaskhistoryauditlog");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Action)
                    .HasColumnName("ACTION")
                    .HasMaxLength(10);

                entity.Property(e => e.BuildNumber).HasColumnName("BUILD_NUMBER");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(60);

                entity.Property(e => e.Timeperformed)
                    .HasColumnName("TIMEPERFORMED")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpgradeTaskFactoryKey)
                    .HasColumnName("UPGRADE_TASK_FACTORY_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.UpgradeType)
                    .HasColumnName("UPGRADE_TYPE")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Upgradeversionhistory>(entity =>
            {
                entity.HasKey(e => e.Targetbuild);

                entity.ToTable("upgradeversionhistory");

                entity.Property(e => e.Targetbuild)
                    .HasColumnName("TARGETBUILD")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Targetversion)
                    .HasColumnName("TARGETVERSION")
                    .HasMaxLength(255);

                entity.Property(e => e.Timeperformed)
                    .HasColumnName("TIMEPERFORMED")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Userassociation>(entity =>
            {
                entity.HasKey(e => new { e.SourceName, e.SinkNodeId, e.SinkNodeEntity, e.AssociationType });

                entity.ToTable("userassociation");

                entity.HasIndex(e => e.SourceName)
                    .HasName("user_source");

                entity.HasIndex(e => new { e.SinkNodeId, e.SinkNodeEntity })
                    .HasName("user_sink");

                entity.Property(e => e.SourceName)
                    .HasColumnName("SOURCE_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.SinkNodeId)
                    .HasColumnName("SINK_NODE_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SinkNodeEntity)
                    .HasColumnName("SINK_NODE_ENTITY")
                    .HasMaxLength(60);

                entity.Property(e => e.AssociationType)
                    .HasColumnName("ASSOCIATION_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            });

            modelBuilder.Entity<Userbase>(entity =>
            {
                entity.ToTable("userbase");

                entity.HasIndex(e => e.Username)
                    .HasName("osuser_name");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PasswordHash)
                    .HasColumnName("PASSWORD_HASH")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Userhistoryitem>(entity =>
            {
                entity.ToTable("userhistoryitem");

                entity.HasIndex(e => new { e.Entitytype, e.Username, e.Entityid })
                    .HasName("uh_type_user_entity")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("ntext");

                entity.Property(e => e.Entityid)
                    .HasColumnName("entityid")
                    .HasMaxLength(60);

                entity.Property(e => e.Entitytype)
                    .HasColumnName("entitytype")
                    .HasMaxLength(10);

                entity.Property(e => e.Lastviewed)
                    .HasColumnName("lastviewed")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Userpickerfilter>(entity =>
            {
                entity.ToTable("userpickerfilter");

                entity.HasIndex(e => e.Customfield)
                    .HasName("upf_customfield");

                entity.HasIndex(e => e.Customfieldconfig)
                    .HasName("upf_fieldconfigid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Customfield)
                    .HasColumnName("CUSTOMFIELD")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Customfieldconfig)
                    .HasColumnName("CUSTOMFIELDCONFIG")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Userpickerfiltergroup>(entity =>
            {
                entity.ToTable("userpickerfiltergroup");

                entity.HasIndex(e => e.Userpickerfilter)
                    .HasName("cf_userpickerfiltergroup");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(255);

                entity.Property(e => e.Userpickerfilter)
                    .HasColumnName("USERPICKERFILTER")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Userpickerfilterrole>(entity =>
            {
                entity.ToTable("userpickerfilterrole");

                entity.HasIndex(e => e.Userpickerfilter)
                    .HasName("cf_userpickerfilterrole");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Projectroleid)
                    .HasColumnName("PROJECTROLEID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Userpickerfilter)
                    .HasColumnName("USERPICKERFILTER")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Versioncontrol>(entity =>
            {
                entity.ToTable("versioncontrol");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Vcsdescription)
                    .HasColumnName("vcsdescription")
                    .HasMaxLength(255);

                entity.Property(e => e.Vcsname)
                    .HasColumnName("vcsname")
                    .HasMaxLength(255);

                entity.Property(e => e.Vcstype)
                    .HasColumnName("vcstype")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Votehistory>(entity =>
            {
                entity.ToTable("votehistory");

                entity.HasIndex(e => e.Issueid)
                    .HasName("votehistory_issue_index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issueid)
                    .HasColumnName("issueid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Votes)
                    .HasColumnName("VOTES")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Workflowscheme>(entity =>
            {
                entity.ToTable("workflowscheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Workflowschemeentity>(entity =>
            {
                entity.ToTable("workflowschemeentity");

                entity.HasIndex(e => e.Scheme)
                    .HasName("workflow_scheme");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Issuetype)
                    .HasColumnName("issuetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Scheme)
                    .HasColumnName("SCHEME")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Workflow)
                    .HasColumnName("WORKFLOW")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Worklog>(entity =>
            {
                entity.ToTable("worklog");

                entity.HasIndex(e => e.Author)
                    .HasName("worklog_author");

                entity.HasIndex(e => e.Created)
                    .HasName("worklog_created");

                entity.HasIndex(e => e.Issueid)
                    .HasName("worklog_issue");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Grouplevel)
                    .HasColumnName("grouplevel")
                    .HasMaxLength(255);

                entity.Property(e => e.Issueid)
                    .HasColumnName("issueid")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Rolelevel)
                    .HasColumnName("rolelevel")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Timeworked)
                    .HasColumnName("timeworked")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Updateauthor)
                    .HasColumnName("UPDATEAUTHOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Worklogbody)
                    .HasColumnName("worklogbody")
                    .HasColumnType("ntext");
            });
        }
    }
}
