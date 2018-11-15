using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Test.TrgitModels
{
    public partial class gitlabhq_productionContext : DbContext
    {
        public gitlabhq_productionContext()
        {
        }

        public gitlabhq_productionContext(DbContextOptions<gitlabhq_productionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbuseReports> AbuseReports { get; set; }
        public virtual DbSet<Appearances> Appearances { get; set; }
        public virtual DbSet<ApplicationSettings> ApplicationSettings { get; set; }
        public virtual DbSet<AuditEvents> AuditEvents { get; set; }
        public virtual DbSet<AwardEmoji> AwardEmoji { get; set; }
        public virtual DbSet<Badges> Badges { get; set; }
        public virtual DbSet<Boards> Boards { get; set; }
        public virtual DbSet<BroadcastMessages> BroadcastMessages { get; set; }
        public virtual DbSet<ChatNames> ChatNames { get; set; }
        public virtual DbSet<ChatTeams> ChatTeams { get; set; }
        public virtual DbSet<CiBuilds> CiBuilds { get; set; }
        public virtual DbSet<CiBuildTraceSectionNames> CiBuildTraceSectionNames { get; set; }
        public virtual DbSet<CiBuildTraceSections> CiBuildTraceSections { get; set; }
        public virtual DbSet<CiGroupVariables> CiGroupVariables { get; set; }
        public virtual DbSet<CiJobArtifacts> CiJobArtifacts { get; set; }
        public virtual DbSet<CiPipelines> CiPipelines { get; set; }
        public virtual DbSet<CiPipelineSchedules> CiPipelineSchedules { get; set; }
        public virtual DbSet<CiPipelineScheduleVariables> CiPipelineScheduleVariables { get; set; }
        public virtual DbSet<CiPipelineVariables> CiPipelineVariables { get; set; }
        public virtual DbSet<CiRunnerProjects> CiRunnerProjects { get; set; }
        public virtual DbSet<CiRunners> CiRunners { get; set; }
        public virtual DbSet<CiStages> CiStages { get; set; }
        public virtual DbSet<CiTriggerRequests> CiTriggerRequests { get; set; }
        public virtual DbSet<CiTriggers> CiTriggers { get; set; }
        public virtual DbSet<CiVariables> CiVariables { get; set; }
        public virtual DbSet<ClusterPlatformsKubernetes> ClusterPlatformsKubernetes { get; set; }
        public virtual DbSet<ClusterProjects> ClusterProjects { get; set; }
        public virtual DbSet<ClusterProvidersGcp> ClusterProvidersGcp { get; set; }
        public virtual DbSet<Clusters> Clusters { get; set; }
        public virtual DbSet<ClustersApplicationsHelm> ClustersApplicationsHelm { get; set; }
        public virtual DbSet<ClustersApplicationsIngress> ClustersApplicationsIngress { get; set; }
        public virtual DbSet<ClustersApplicationsPrometheus> ClustersApplicationsPrometheus { get; set; }
        public virtual DbSet<ClustersApplicationsRunners> ClustersApplicationsRunners { get; set; }
        public virtual DbSet<ContainerRepositories> ContainerRepositories { get; set; }
        public virtual DbSet<ConversationalDevelopmentIndexMetrics> ConversationalDevelopmentIndexMetrics { get; set; }
        public virtual DbSet<DeployKeysProjects> DeployKeysProjects { get; set; }
        public virtual DbSet<Deployments> Deployments { get; set; }
        public virtual DbSet<Emails> Emails { get; set; }
        public virtual DbSet<Environments> Environments { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<FeatureGates> FeatureGates { get; set; }
        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<ForkedProjectLinks> ForkedProjectLinks { get; set; }
        public virtual DbSet<ForkNetworkMembers> ForkNetworkMembers { get; set; }
        public virtual DbSet<ForkNetworks> ForkNetworks { get; set; }
        public virtual DbSet<GcpClusters> GcpClusters { get; set; }
        public virtual DbSet<GpgKeys> GpgKeys { get; set; }
        public virtual DbSet<GpgKeySubkeys> GpgKeySubkeys { get; set; }
        public virtual DbSet<GpgSignatures> GpgSignatures { get; set; }
        public virtual DbSet<GroupCustomAttributes> GroupCustomAttributes { get; set; }
        public virtual DbSet<Identities> Identities { get; set; }
        public virtual DbSet<IssueMetrics> IssueMetrics { get; set; }
        public virtual DbSet<Issues> Issues { get; set; }
        public virtual DbSet<Keys> Keys { get; set; }
        public virtual DbSet<LabelLinks> LabelLinks { get; set; }
        public virtual DbSet<LabelPriorities> LabelPriorities { get; set; }
        public virtual DbSet<Labels> Labels { get; set; }
        public virtual DbSet<LfsFileLocks> LfsFileLocks { get; set; }
        public virtual DbSet<LfsObjects> LfsObjects { get; set; }
        public virtual DbSet<LfsObjectsProjects> LfsObjectsProjects { get; set; }
        public virtual DbSet<Lists> Lists { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<MergeRequestDiffs> MergeRequestDiffs { get; set; }
        public virtual DbSet<MergeRequestMetrics> MergeRequestMetrics { get; set; }
        public virtual DbSet<MergeRequests> MergeRequests { get; set; }
        public virtual DbSet<MergeRequestsClosingIssues> MergeRequestsClosingIssues { get; set; }
        public virtual DbSet<Milestones> Milestones { get; set; }
        public virtual DbSet<Namespaces> Namespaces { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<NotificationSettings> NotificationSettings { get; set; }
        public virtual DbSet<OauthAccessGrants> OauthAccessGrants { get; set; }
        public virtual DbSet<OauthAccessTokens> OauthAccessTokens { get; set; }
        public virtual DbSet<OauthApplications> OauthApplications { get; set; }
        public virtual DbSet<OauthOpenidRequests> OauthOpenidRequests { get; set; }
        public virtual DbSet<PagesDomains> PagesDomains { get; set; }
        public virtual DbSet<PersonalAccessTokens> PersonalAccessTokens { get; set; }
        public virtual DbSet<ProjectAutoDevops> ProjectAutoDevops { get; set; }
        public virtual DbSet<ProjectCustomAttributes> ProjectCustomAttributes { get; set; }
        public virtual DbSet<ProjectFeatures> ProjectFeatures { get; set; }
        public virtual DbSet<ProjectGroupLinks> ProjectGroupLinks { get; set; }
        public virtual DbSet<ProjectImportData> ProjectImportData { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<ProjectStatistics> ProjectStatistics { get; set; }
        public virtual DbSet<ProtectedBranches> ProtectedBranches { get; set; }
        public virtual DbSet<ProtectedBranchMergeAccessLevels> ProtectedBranchMergeAccessLevels { get; set; }
        public virtual DbSet<ProtectedBranchPushAccessLevels> ProtectedBranchPushAccessLevels { get; set; }
        public virtual DbSet<ProtectedTagCreateAccessLevels> ProtectedTagCreateAccessLevels { get; set; }
        public virtual DbSet<ProtectedTags> ProtectedTags { get; set; }
        public virtual DbSet<RedirectRoutes> RedirectRoutes { get; set; }
        public virtual DbSet<Releases> Releases { get; set; }
        public virtual DbSet<Routes> Routes { get; set; }
        public virtual DbSet<SentNotifications> SentNotifications { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Snippets> Snippets { get; set; }
        public virtual DbSet<SpamLogs> SpamLogs { get; set; }
        public virtual DbSet<Subscriptions> Subscriptions { get; set; }
        public virtual DbSet<SystemNoteMetadata> SystemNoteMetadata { get; set; }
        public virtual DbSet<Taggings> Taggings { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<Timelogs> Timelogs { get; set; }
        public virtual DbSet<Todos> Todos { get; set; }
        public virtual DbSet<TrendingProjects> TrendingProjects { get; set; }
        public virtual DbSet<U2fRegistrations> U2fRegistrations { get; set; }
        public virtual DbSet<Uploads> Uploads { get; set; }
        public virtual DbSet<UserAgentDetails> UserAgentDetails { get; set; }
        public virtual DbSet<UserCallouts> UserCallouts { get; set; }
        public virtual DbSet<UserCustomAttributes> UserCustomAttributes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersStarProjects> UsersStarProjects { get; set; }
        public virtual DbSet<UserSyncedAttributesMetadata> UserSyncedAttributesMetadata { get; set; }
        public virtual DbSet<WebHookLogs> WebHookLogs { get; set; }
        public virtual DbSet<WebHooks> WebHooks { get; set; }

        // Unable to generate entity type for table 'public.push_event_payloads'. Please see the warning messages.
        // Unable to generate entity type for table 'public.issue_assignees'. Please see the warning messages.
        // Unable to generate entity type for table 'public.merge_request_diff_commits'. Please see the warning messages.
        // Unable to generate entity type for table 'public.schema_migrations'. Please see the warning messages.
        // Unable to generate entity type for table 'public.merge_request_diff_files'. Please see the warning messages.
        // Unable to generate entity type for table 'public.project_authorizations'. Please see the warning messages.
        // Unable to generate entity type for table 'public.user_interacted_projects'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=10.16.89.141;port=7432;Database=gitlabhq_production;Username=postgres;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_trgm");

            modelBuilder.Entity<AbuseReports>(entity =>
            {
                entity.ToTable("abuse_reports");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.MessageHtml).HasColumnName("message_html");

                entity.Property(e => e.ReporterId).HasColumnName("reporter_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Appearances>(entity =>
            {
                entity.ToTable("appearances");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.HeaderLogo)
                    .HasColumnName("header_logo")
                    .HasColumnType("character varying");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("character varying");

                entity.Property(e => e.NewProjectGuidelines).HasColumnName("new_project_guidelines");

                entity.Property(e => e.NewProjectGuidelinesHtml).HasColumnName("new_project_guidelines_html");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<ApplicationSettings>(entity =>
            {
                entity.ToTable("application_settings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdminNotificationEmail)
                    .HasColumnName("admin_notification_email")
                    .HasColumnType("character varying");

                entity.Property(e => e.AfterSignOutPath)
                    .HasColumnName("after_sign_out_path")
                    .HasColumnType("character varying");

                entity.Property(e => e.AfterSignUpText).HasColumnName("after_sign_up_text");

                entity.Property(e => e.AfterSignUpTextHtml).HasColumnName("after_sign_up_text_html");

                entity.Property(e => e.AkismetApiKey)
                    .HasColumnName("akismet_api_key")
                    .HasColumnType("character varying");

                entity.Property(e => e.AkismetEnabled)
                    .HasColumnName("akismet_enabled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AllowLocalRequestsFromHooksAndServices).HasColumnName("allow_local_requests_from_hooks_and_services");

                entity.Property(e => e.AuthorizedKeysEnabled)
                    .IsRequired()
                    .HasColumnName("authorized_keys_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AutoDevopsDomain)
                    .HasColumnName("auto_devops_domain")
                    .HasColumnType("character varying");

                entity.Property(e => e.AutoDevopsEnabled).HasColumnName("auto_devops_enabled");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.CircuitbreakerAccessRetries)
                    .HasColumnName("circuitbreaker_access_retries")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.CircuitbreakerCheckInterval)
                    .HasColumnName("circuitbreaker_check_interval")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CircuitbreakerFailureCountThreshold)
                    .HasColumnName("circuitbreaker_failure_count_threshold")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.CircuitbreakerFailureResetTime)
                    .HasColumnName("circuitbreaker_failure_reset_time")
                    .HasDefaultValueSql("1800");

                entity.Property(e => e.CircuitbreakerStorageTimeout)
                    .HasColumnName("circuitbreaker_storage_timeout")
                    .HasDefaultValueSql("15");

                entity.Property(e => e.ClientsideSentryDsn)
                    .HasColumnName("clientside_sentry_dsn")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClientsideSentryEnabled).HasColumnName("clientside_sentry_enabled");

                entity.Property(e => e.ContainerRegistryTokenExpireDelay)
                    .HasColumnName("container_registry_token_expire_delay")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DefaultArtifactsExpireIn)
                    .IsRequired()
                    .HasColumnName("default_artifacts_expire_in")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'0'::character varying");

                entity.Property(e => e.DefaultBranchProtection)
                    .HasColumnName("default_branch_protection")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.DefaultGroupVisibility).HasColumnName("default_group_visibility");

                entity.Property(e => e.DefaultProjectVisibility).HasColumnName("default_project_visibility");

                entity.Property(e => e.DefaultProjectsLimit).HasColumnName("default_projects_limit");

                entity.Property(e => e.DefaultSnippetVisibility).HasColumnName("default_snippet_visibility");

                entity.Property(e => e.DisabledOauthSignInSources).HasColumnName("disabled_oauth_sign_in_sources");

                entity.Property(e => e.DomainBlacklist).HasColumnName("domain_blacklist");

                entity.Property(e => e.DomainBlacklistEnabled)
                    .HasColumnName("domain_blacklist_enabled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.DomainWhitelist).HasColumnName("domain_whitelist");

                entity.Property(e => e.DsaKeyRestriction).HasColumnName("dsa_key_restriction");

                entity.Property(e => e.EcdsaKeyRestriction).HasColumnName("ecdsa_key_restriction");

                entity.Property(e => e.Ed25519KeyRestriction).HasColumnName("ed25519_key_restriction");

                entity.Property(e => e.EmailAuthorInBody)
                    .HasColumnName("email_author_in_body")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EnabledGitAccessProtocol)
                    .HasColumnName("enabled_git_access_protocol")
                    .HasColumnType("character varying");

                entity.Property(e => e.GitalyTimeoutDefault)
                    .HasColumnName("gitaly_timeout_default")
                    .HasDefaultValueSql("55");

                entity.Property(e => e.GitalyTimeoutFast)
                    .HasColumnName("gitaly_timeout_fast")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.GitalyTimeoutMedium)
                    .HasColumnName("gitaly_timeout_medium")
                    .HasDefaultValueSql("30");

                entity.Property(e => e.GravatarEnabled).HasColumnName("gravatar_enabled");

                entity.Property(e => e.HashedStorageEnabled).HasColumnName("hashed_storage_enabled");

                entity.Property(e => e.HealthCheckAccessToken)
                    .HasColumnName("health_check_access_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.HelpPageHideCommercialContent)
                    .HasColumnName("help_page_hide_commercial_content")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.HelpPageSupportUrl)
                    .HasColumnName("help_page_support_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.HelpPageText).HasColumnName("help_page_text");

                entity.Property(e => e.HelpPageTextHtml).HasColumnName("help_page_text_html");

                entity.Property(e => e.HomePageUrl)
                    .HasColumnName("home_page_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.HousekeepingBitmapsEnabled)
                    .IsRequired()
                    .HasColumnName("housekeeping_bitmaps_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.HousekeepingEnabled)
                    .IsRequired()
                    .HasColumnName("housekeeping_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.HousekeepingFullRepackPeriod)
                    .HasColumnName("housekeeping_full_repack_period")
                    .HasDefaultValueSql("50");

                entity.Property(e => e.HousekeepingGcPeriod)
                    .HasColumnName("housekeeping_gc_period")
                    .HasDefaultValueSql("200");

                entity.Property(e => e.HousekeepingIncrementalRepackPeriod)
                    .HasColumnName("housekeeping_incremental_repack_period")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.HtmlEmailsEnabled)
                    .HasColumnName("html_emails_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ImportSources).HasColumnName("import_sources");

                entity.Property(e => e.KodingEnabled).HasColumnName("koding_enabled");

                entity.Property(e => e.KodingUrl)
                    .HasColumnName("koding_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.MaxArtifactsSize)
                    .HasColumnName("max_artifacts_size")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.MaxAttachmentSize)
                    .HasColumnName("max_attachment_size")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.MaxPagesSize)
                    .HasColumnName("max_pages_size")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.MetricsEnabled)
                    .HasColumnName("metrics_enabled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.MetricsHost)
                    .HasColumnName("metrics_host")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'localhost'::character varying");

                entity.Property(e => e.MetricsMethodCallThreshold)
                    .HasColumnName("metrics_method_call_threshold")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.MetricsPacketSize)
                    .HasColumnName("metrics_packet_size")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MetricsPoolSize)
                    .HasColumnName("metrics_pool_size")
                    .HasDefaultValueSql("16");

                entity.Property(e => e.MetricsPort)
                    .HasColumnName("metrics_port")
                    .HasDefaultValueSql("8089");

                entity.Property(e => e.MetricsSampleInterval)
                    .HasColumnName("metrics_sample_interval")
                    .HasDefaultValueSql("15");

                entity.Property(e => e.MetricsTimeout)
                    .HasColumnName("metrics_timeout")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.PagesDomainVerificationEnabled)
                    .IsRequired()
                    .HasColumnName("pages_domain_verification_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PasswordAuthenticationEnabledForGit)
                    .IsRequired()
                    .HasColumnName("password_authentication_enabled_for_git")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PasswordAuthenticationEnabledForWeb).HasColumnName("password_authentication_enabled_for_web");

                entity.Property(e => e.PerformanceBarAllowedGroupId).HasColumnName("performance_bar_allowed_group_id");

                entity.Property(e => e.PlantumlEnabled).HasColumnName("plantuml_enabled");

                entity.Property(e => e.PlantumlUrl)
                    .HasColumnName("plantuml_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.PollingIntervalMultiplier)
                    .HasColumnName("polling_interval_multiplier")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ProjectExportEnabled)
                    .IsRequired()
                    .HasColumnName("project_export_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PrometheusMetricsEnabled).HasColumnName("prometheus_metrics_enabled");

                entity.Property(e => e.RecaptchaEnabled)
                    .HasColumnName("recaptcha_enabled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RecaptchaPrivateKey)
                    .HasColumnName("recaptcha_private_key")
                    .HasColumnType("character varying");

                entity.Property(e => e.RecaptchaSiteKey)
                    .HasColumnName("recaptcha_site_key")
                    .HasColumnType("character varying");

                entity.Property(e => e.RepositoryChecksEnabled)
                    .HasColumnName("repository_checks_enabled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RepositoryStorages)
                    .HasColumnName("repository_storages")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'default'::character varying");

                entity.Property(e => e.RequireTwoFactorAuthentication)
                    .HasColumnName("require_two_factor_authentication")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RestrictedVisibilityLevels).HasColumnName("restricted_visibility_levels");

                entity.Property(e => e.RsaKeyRestriction).HasColumnName("rsa_key_restriction");

                entity.Property(e => e.RunnersRegistrationToken)
                    .HasColumnName("runners_registration_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.SendUserConfirmationEmail)
                    .HasColumnName("send_user_confirmation_email")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SentryDsn)
                    .HasColumnName("sentry_dsn")
                    .HasColumnType("character varying");

                entity.Property(e => e.SentryEnabled)
                    .HasColumnName("sentry_enabled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SessionExpireDelay)
                    .HasColumnName("session_expire_delay")
                    .HasDefaultValueSql("10080");

                entity.Property(e => e.SharedRunnersEnabled)
                    .IsRequired()
                    .HasColumnName("shared_runners_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SharedRunnersText).HasColumnName("shared_runners_text");

                entity.Property(e => e.SharedRunnersTextHtml).HasColumnName("shared_runners_text_html");

                entity.Property(e => e.SidekiqThrottlingEnabled)
                    .HasColumnName("sidekiq_throttling_enabled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SidekiqThrottlingFactor).HasColumnName("sidekiq_throttling_factor");

                entity.Property(e => e.SidekiqThrottlingQueues)
                    .HasColumnName("sidekiq_throttling_queues")
                    .HasColumnType("character varying");

                entity.Property(e => e.SignInText).HasColumnName("sign_in_text");

                entity.Property(e => e.SignInTextHtml).HasColumnName("sign_in_text_html");

                entity.Property(e => e.SignupEnabled).HasColumnName("signup_enabled");

                entity.Property(e => e.TerminalMaxSessionTime).HasColumnName("terminal_max_session_time");

                entity.Property(e => e.ThrottleAuthenticatedApiEnabled).HasColumnName("throttle_authenticated_api_enabled");

                entity.Property(e => e.ThrottleAuthenticatedApiPeriodInSeconds)
                    .HasColumnName("throttle_authenticated_api_period_in_seconds")
                    .HasDefaultValueSql("3600");

                entity.Property(e => e.ThrottleAuthenticatedApiRequestsPerPeriod)
                    .HasColumnName("throttle_authenticated_api_requests_per_period")
                    .HasDefaultValueSql("7200");

                entity.Property(e => e.ThrottleAuthenticatedWebEnabled).HasColumnName("throttle_authenticated_web_enabled");

                entity.Property(e => e.ThrottleAuthenticatedWebPeriodInSeconds)
                    .HasColumnName("throttle_authenticated_web_period_in_seconds")
                    .HasDefaultValueSql("3600");

                entity.Property(e => e.ThrottleAuthenticatedWebRequestsPerPeriod)
                    .HasColumnName("throttle_authenticated_web_requests_per_period")
                    .HasDefaultValueSql("7200");

                entity.Property(e => e.ThrottleUnauthenticatedEnabled).HasColumnName("throttle_unauthenticated_enabled");

                entity.Property(e => e.ThrottleUnauthenticatedPeriodInSeconds)
                    .HasColumnName("throttle_unauthenticated_period_in_seconds")
                    .HasDefaultValueSql("3600");

                entity.Property(e => e.ThrottleUnauthenticatedRequestsPerPeriod)
                    .HasColumnName("throttle_unauthenticated_requests_per_period")
                    .HasDefaultValueSql("3600");

                entity.Property(e => e.TwoFactorGracePeriod)
                    .HasColumnName("two_factor_grace_period")
                    .HasDefaultValueSql("48");

                entity.Property(e => e.UniqueIpsLimitEnabled).HasColumnName("unique_ips_limit_enabled");

                entity.Property(e => e.UniqueIpsLimitPerUser).HasColumnName("unique_ips_limit_per_user");

                entity.Property(e => e.UniqueIpsLimitTimeWindow).HasColumnName("unique_ips_limit_time_window");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UsagePingEnabled)
                    .IsRequired()
                    .HasColumnName("usage_ping_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UserDefaultExternal).HasColumnName("user_default_external");

                entity.Property(e => e.UserOauthApplications)
                    .HasColumnName("user_oauth_applications")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("character varying");

                entity.Property(e => e.VersionCheckEnabled)
                    .HasColumnName("version_check_enabled")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<AuditEvents>(entity =>
            {
                entity.ToTable("audit_events");

                entity.HasIndex(e => new { e.EntityId, e.EntityType })
                    .HasName("index_audit_events_on_entity_id_and_entity_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasColumnName("entity_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<AwardEmoji>(entity =>
            {
                entity.ToTable("award_emoji");

                entity.HasIndex(e => new { e.AwardableType, e.AwardableId })
                    .HasName("index_award_emoji_on_awardable_type_and_awardable_id");

                entity.HasIndex(e => new { e.UserId, e.Name })
                    .HasName("index_award_emoji_on_user_id_and_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AwardableId).HasColumnName("awardable_id");

                entity.Property(e => e.AwardableType)
                    .HasColumnName("awardable_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Badges>(entity =>
            {
                entity.ToTable("badges");

                entity.HasIndex(e => e.GroupId)
                    .HasName("index_badges_on_group_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_badges_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnName("image_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("link_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Badges)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rails_9df4a56538");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Badges)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rails_5a7c055bdc");
            });

            modelBuilder.Entity<Boards>(entity =>
            {
                entity.ToTable("boards");

                entity.HasIndex(e => e.GroupId)
                    .HasName("index_boards_on_group_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_boards_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Boards)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rails_1e9a074a35");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Boards)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_f15266b5f9");
            });

            modelBuilder.Entity<BroadcastMessages>(entity =>
            {
                entity.ToTable("broadcast_messages");

                entity.HasIndex(e => new { e.StartsAt, e.EndsAt, e.Id })
                    .HasName("index_broadcast_messages_on_starts_at_and_ends_at_and_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EndsAt).HasColumnName("ends_at");

                entity.Property(e => e.Font)
                    .HasColumnName("font")
                    .HasMaxLength(255);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.MessageHtml)
                    .IsRequired()
                    .HasColumnName("message_html");

                entity.Property(e => e.StartsAt).HasColumnName("starts_at");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ChatNames>(entity =>
            {
                entity.ToTable("chat_names");

                entity.HasIndex(e => new { e.UserId, e.ServiceId })
                    .HasName("index_chat_names_on_user_id_and_service_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceId, e.TeamId, e.ChatId })
                    .HasName("index_chat_names_on_service_id_and_team_id_and_chat_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChatId)
                    .IsRequired()
                    .HasColumnName("chat_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.ChatName)
                    .HasColumnName("chat_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.LastUsedAt).HasColumnName("last_used_at");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.TeamDomain)
                    .HasColumnName("team_domain")
                    .HasColumnType("character varying");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ChatTeams>(entity =>
            {
                entity.ToTable("chat_teams");

                entity.HasIndex(e => e.NamespaceId)
                    .HasName("index_chat_teams_on_namespace_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.NamespaceId).HasColumnName("namespace_id");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Namespace)
                    .WithOne(p => p.ChatTeams)
                    .HasForeignKey<ChatTeams>(d => d.NamespaceId)
                    .HasConstraintName("fk_rails_3b543909cb");
            });

            modelBuilder.Entity<CiBuilds>(entity =>
            {
                entity.ToTable("ci_builds");

                entity.HasIndex(e => e.ArtifactsExpireAt)
                    .HasName("index_ci_builds_on_artifacts_expire_at")
                    .HasFilter("(artifacts_file <> ''::text)");

                entity.HasIndex(e => e.AutoCanceledById)
                    .HasName("index_ci_builds_on_auto_canceled_by_id");

                entity.HasIndex(e => e.Protected)
                    .HasName("index_ci_builds_on_protected");

                entity.HasIndex(e => e.RunnerId)
                    .HasName("index_ci_builds_on_runner_id");

                entity.HasIndex(e => e.StageId)
                    .HasName("index_ci_builds_on_stage_id");

                entity.HasIndex(e => e.Status)
                    .HasName("index_ci_builds_on_status");

                entity.HasIndex(e => e.Token)
                    .HasName("index_ci_builds_on_token")
                    .IsUnique();

                entity.HasIndex(e => e.UpdatedAt)
                    .HasName("index_ci_builds_on_updated_at");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_ci_builds_on_user_id");

                entity.HasIndex(e => new { e.ProjectId, e.Id })
                    .HasName("index_ci_builds_on_project_id_and_id");

                entity.HasIndex(e => new { e.CommitId, e.StageIdx, e.CreatedAt })
                    .HasName("index_ci_builds_on_commit_id_and_stage_idx_and_created_at");

                entity.HasIndex(e => new { e.CommitId, e.Status, e.Type })
                    .HasName("index_ci_builds_on_commit_id_and_status_and_type");

                entity.HasIndex(e => new { e.CommitId, e.Type, e.Ref })
                    .HasName("index_ci_builds_on_commit_id_and_type_and_ref");

                entity.HasIndex(e => new { e.Status, e.Type, e.RunnerId })
                    .HasName("index_ci_builds_on_status_and_type_and_runner_id");

                entity.HasIndex(e => new { e.CommitId, e.Type, e.Name, e.Ref })
                    .HasName("index_ci_builds_on_commit_id_and_type_and_name_and_ref");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowFailure).HasColumnName("allow_failure");

                entity.Property(e => e.ArtifactsExpireAt).HasColumnName("artifacts_expire_at");

                entity.Property(e => e.ArtifactsFile).HasColumnName("artifacts_file");

                entity.Property(e => e.ArtifactsMetadata).HasColumnName("artifacts_metadata");

                entity.Property(e => e.ArtifactsSize).HasColumnName("artifacts_size");

                entity.Property(e => e.AutoCanceledById).HasColumnName("auto_canceled_by_id");

                entity.Property(e => e.Commands).HasColumnName("commands");

                entity.Property(e => e.CommitId).HasColumnName("commit_id");

                entity.Property(e => e.Coverage).HasColumnName("coverage");

                entity.Property(e => e.CoverageRegex)
                    .HasColumnName("coverage_regex")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Environment)
                    .HasColumnName("environment")
                    .HasColumnType("character varying");

                entity.Property(e => e.ErasedAt).HasColumnName("erased_at");

                entity.Property(e => e.ErasedById).HasColumnName("erased_by_id");

                entity.Property(e => e.FailureReason).HasColumnName("failure_reason");

                entity.Property(e => e.FinishedAt).HasColumnName("finished_at");

                entity.Property(e => e.LockVersion).HasColumnName("lock_version");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Options).HasColumnName("options");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Protected).HasColumnName("protected");

                entity.Property(e => e.QueuedAt).HasColumnName("queued_at");

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasColumnType("character varying");

                entity.Property(e => e.Retried).HasColumnName("retried");

                entity.Property(e => e.RunnerId).HasColumnName("runner_id");

                entity.Property(e => e.Stage)
                    .HasColumnName("stage")
                    .HasColumnType("character varying");

                entity.Property(e => e.StageId).HasColumnName("stage_id");

                entity.Property(e => e.StageIdx).HasColumnName("stage_idx");

                entity.Property(e => e.StartedAt).HasColumnName("started_at");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("character varying");

                entity.Property(e => e.Tag).HasColumnName("tag");

                entity.Property(e => e.TargetUrl)
                    .HasColumnName("target_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("character varying");

                entity.Property(e => e.Trace).HasColumnName("trace");

                entity.Property(e => e.TriggerRequestId).HasColumnName("trigger_request_id");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.When)
                    .HasColumnName("when")
                    .HasColumnType("character varying");

                entity.Property(e => e.YamlVariables).HasColumnName("yaml_variables");

                entity.HasOne(d => d.AutoCanceledBy)
                    .WithMany(p => p.CiBuilds)
                    .HasForeignKey(d => d.AutoCanceledById)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_a2141b1522");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiBuilds)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_befce0568a");

                entity.HasOne(d => d.StageNavigation)
                    .WithMany(p => p.CiBuilds)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_3a9eaa254d");
            });

            modelBuilder.Entity<CiBuildTraceSectionNames>(entity =>
            {
                entity.ToTable("ci_build_trace_section_names");

                entity.HasIndex(e => new { e.ProjectId, e.Name })
                    .HasName("index_ci_build_trace_section_names_on_project_id_and_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiBuildTraceSectionNames)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_rails_f8cd72cd26");
            });

            modelBuilder.Entity<CiBuildTraceSections>(entity =>
            {
                entity.ToTable("ci_build_trace_sections");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_ci_build_trace_sections_on_project_id");

                entity.HasIndex(e => e.SectionNameId)
                    .HasName("index_ci_build_trace_sections_on_section_name_id");

                entity.HasIndex(e => new { e.BuildId, e.SectionNameId })
                    .HasName("index_ci_build_trace_sections_on_build_id_and_section_name_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.ByteEnd).HasColumnName("byte_end");

                entity.Property(e => e.ByteStart).HasColumnName("byte_start");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.SectionNameId).HasColumnName("section_name_id");

                entity.HasOne(d => d.Build)
                    .WithMany(p => p.CiBuildTraceSections)
                    .HasForeignKey(d => d.BuildId)
                    .HasConstraintName("fk_4ebe41f502");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiBuildTraceSections)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_rails_ab7c104e26");

                entity.HasOne(d => d.SectionName)
                    .WithMany(p => p.CiBuildTraceSections)
                    .HasForeignKey(d => d.SectionNameId)
                    .HasConstraintName("fk_264e112c66");
            });

            modelBuilder.Entity<CiGroupVariables>(entity =>
            {
                entity.ToTable("ci_group_variables");

                entity.HasIndex(e => new { e.GroupId, e.Key })
                    .HasName("index_ci_group_variables_on_group_id_and_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.EncryptedValue).HasColumnName("encrypted_value");

                entity.Property(e => e.EncryptedValueIv)
                    .HasColumnName("encrypted_value_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedValueSalt)
                    .HasColumnName("encrypted_value_salt")
                    .HasColumnType("character varying");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.Protected).HasColumnName("protected");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CiGroupVariables)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("fk_33ae4d58d8");
            });

            modelBuilder.Entity<CiJobArtifacts>(entity =>
            {
                entity.ToTable("ci_job_artifacts");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_ci_job_artifacts_on_project_id");

                entity.HasIndex(e => new { e.ExpireAt, e.JobId })
                    .HasName("index_ci_job_artifacts_on_expire_at_and_job_id");

                entity.HasIndex(e => new { e.JobId, e.FileType })
                    .HasName("index_ci_job_artifacts_on_job_id_and_file_type")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ExpireAt)
                    .HasColumnName("expire_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileSha256).HasColumnName("file_sha256");

                entity.Property(e => e.FileType).HasColumnName("file_type");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.CiJobArtifacts)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("fk_rails_c5137cb2c1");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiJobArtifacts)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_rails_9862d392f9");
            });

            modelBuilder.Entity<CiPipelines>(entity =>
            {
                entity.ToTable("ci_pipelines");

                entity.HasIndex(e => e.AutoCanceledById)
                    .HasName("index_ci_pipelines_on_auto_canceled_by_id");

                entity.HasIndex(e => e.PipelineScheduleId)
                    .HasName("index_ci_pipelines_on_pipeline_schedule_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_ci_pipelines_on_project_id");

                entity.HasIndex(e => e.Status)
                    .HasName("index_ci_pipelines_on_status");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_ci_pipelines_on_user_id");

                entity.HasIndex(e => new { e.ProjectId, e.Sha })
                    .HasName("index_ci_pipelines_on_project_id_and_sha");

                entity.HasIndex(e => new { e.ProjectId, e.Ref, e.Status, e.Id })
                    .HasName("index_ci_pipelines_on_project_id_and_ref_and_status_and_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutoCanceledById).HasColumnName("auto_canceled_by_id");

                entity.Property(e => e.BeforeSha)
                    .HasColumnName("before_sha")
                    .HasColumnType("character varying");

                entity.Property(e => e.CommittedAt).HasColumnName("committed_at");

                entity.Property(e => e.ConfigSource).HasColumnName("config_source");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.FailureReason).HasColumnName("failure_reason");

                entity.Property(e => e.FinishedAt).HasColumnName("finished_at");

                entity.Property(e => e.LockVersion).HasColumnName("lock_version");

                entity.Property(e => e.PipelineScheduleId).HasColumnName("pipeline_schedule_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Protected).HasColumnName("protected");

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sha)
                    .HasColumnName("sha")
                    .HasColumnType("character varying");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.StartedAt).HasColumnName("started_at");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("character varying");

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.YamlErrors).HasColumnName("yaml_errors");

                entity.HasOne(d => d.AutoCanceledBy)
                    .WithMany(p => p.InverseAutoCanceledBy)
                    .HasForeignKey(d => d.AutoCanceledById)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_262d4c2d19");

                entity.HasOne(d => d.PipelineSchedule)
                    .WithMany(p => p.CiPipelines)
                    .HasForeignKey(d => d.PipelineScheduleId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_3d34ab2e06");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiPipelines)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_86635dbd80");
            });

            modelBuilder.Entity<CiPipelineSchedules>(entity =>
            {
                entity.ToTable("ci_pipeline_schedules");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_ci_pipeline_schedules_on_project_id");

                entity.HasIndex(e => new { e.NextRunAt, e.Active })
                    .HasName("index_ci_pipeline_schedules_on_next_run_at_and_active");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Cron)
                    .HasColumnName("cron")
                    .HasColumnType("character varying");

                entity.Property(e => e.CronTimezone)
                    .HasColumnName("cron_timezone")
                    .HasColumnType("character varying");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.NextRunAt).HasColumnName("next_run_at");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.CiPipelineSchedules)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_9ea99f58d2");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiPipelineSchedules)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_8ead60fcc4");
            });

            modelBuilder.Entity<CiPipelineScheduleVariables>(entity =>
            {
                entity.ToTable("ci_pipeline_schedule_variables");

                entity.HasIndex(e => new { e.PipelineScheduleId, e.Key })
                    .HasName("index_ci_pipeline_schedule_variables_on_schedule_id_and_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.EncryptedValue).HasColumnName("encrypted_value");

                entity.Property(e => e.EncryptedValueIv)
                    .HasColumnName("encrypted_value_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedValueSalt)
                    .HasColumnName("encrypted_value_salt")
                    .HasColumnType("character varying");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.PipelineScheduleId).HasColumnName("pipeline_schedule_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.PipelineSchedule)
                    .WithMany(p => p.CiPipelineScheduleVariables)
                    .HasForeignKey(d => d.PipelineScheduleId)
                    .HasConstraintName("fk_41c35fda51");
            });

            modelBuilder.Entity<CiPipelineVariables>(entity =>
            {
                entity.ToTable("ci_pipeline_variables");

                entity.HasIndex(e => new { e.PipelineId, e.Key })
                    .HasName("index_ci_pipeline_variables_on_pipeline_id_and_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EncryptedValue).HasColumnName("encrypted_value");

                entity.Property(e => e.EncryptedValueIv)
                    .HasColumnName("encrypted_value_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedValueSalt)
                    .HasColumnName("encrypted_value_salt")
                    .HasColumnType("character varying");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.PipelineId).HasColumnName("pipeline_id");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Pipeline)
                    .WithMany(p => p.CiPipelineVariables)
                    .HasForeignKey(d => d.PipelineId)
                    .HasConstraintName("fk_f29c5f4380");
            });

            modelBuilder.Entity<CiRunnerProjects>(entity =>
            {
                entity.ToTable("ci_runner_projects");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_ci_runner_projects_on_project_id");

                entity.HasIndex(e => e.RunnerId)
                    .HasName("index_ci_runner_projects_on_runner_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.RunnerId).HasColumnName("runner_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiRunnerProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_4478a6f1e4");
            });

            modelBuilder.Entity<CiRunners>(entity =>
            {
                entity.ToTable("ci_runners");

                entity.HasIndex(e => e.ContactedAt)
                    .HasName("index_ci_runners_on_contacted_at");

                entity.HasIndex(e => e.IsShared)
                    .HasName("index_ci_runners_on_is_shared");

                entity.HasIndex(e => e.Locked)
                    .HasName("index_ci_runners_on_locked");

                entity.HasIndex(e => e.Token)
                    .HasName("index_ci_runners_on_token");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessLevel).HasColumnName("access_level");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Architecture)
                    .HasColumnName("architecture")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContactedAt).HasColumnName("contacted_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsShared)
                    .HasColumnName("is_shared")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Platform)
                    .HasColumnName("platform")
                    .HasColumnType("character varying");

                entity.Property(e => e.Revision)
                    .HasColumnName("revision")
                    .HasColumnType("character varying");

                entity.Property(e => e.RunUntagged)
                    .IsRequired()
                    .HasColumnName("run_untagged")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<CiStages>(entity =>
            {
                entity.ToTable("ci_stages");

                entity.HasIndex(e => e.PipelineId)
                    .HasName("index_ci_stages_on_pipeline_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_ci_stages_on_project_id");

                entity.HasIndex(e => new { e.PipelineId, e.Name })
                    .HasName("index_ci_stages_on_pipeline_id_and_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.LockVersion).HasColumnName("lock_version");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PipelineId).HasColumnName("pipeline_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Pipeline)
                    .WithMany(p => p.CiStages)
                    .HasForeignKey(d => d.PipelineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_fb57e6cc56");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiStages)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_2360681d1d");
            });

            modelBuilder.Entity<CiTriggerRequests>(entity =>
            {
                entity.ToTable("ci_trigger_requests");

                entity.HasIndex(e => e.CommitId)
                    .HasName("index_ci_trigger_requests_on_commit_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommitId).HasColumnName("commit_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.TriggerId).HasColumnName("trigger_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Variables).HasColumnName("variables");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.CiTriggerRequests)
                    .HasForeignKey(d => d.TriggerId)
                    .HasConstraintName("fk_b8ec8b7245");
            });

            modelBuilder.Entity<CiTriggers>(entity =>
            {
                entity.ToTable("ci_triggers");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_ci_triggers_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasColumnType("character varying");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.CiTriggers)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_e8e10d1964");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiTriggers)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_e3e63f966e");
            });

            modelBuilder.Entity<CiVariables>(entity =>
            {
                entity.ToTable("ci_variables");

                entity.HasIndex(e => new { e.ProjectId, e.Key, e.EnvironmentScope })
                    .HasName("index_ci_variables_on_project_id_and_key_and_environment_scope")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EncryptedValue).HasColumnName("encrypted_value");

                entity.Property(e => e.EncryptedValueIv)
                    .HasColumnName("encrypted_value_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedValueSalt)
                    .HasColumnName("encrypted_value_salt")
                    .HasColumnType("character varying");

                entity.Property(e => e.EnvironmentScope)
                    .IsRequired()
                    .HasColumnName("environment_scope")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'*'::character varying");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Protected).HasColumnName("protected");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CiVariables)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_ada5eb64b3");
            });

            modelBuilder.Entity<ClusterPlatformsKubernetes>(entity =>
            {
                entity.ToTable("cluster_platforms_kubernetes");

                entity.HasIndex(e => e.ClusterId)
                    .HasName("index_cluster_platforms_kubernetes_on_cluster_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiUrl).HasColumnName("api_url");

                entity.Property(e => e.CaCert).HasColumnName("ca_cert");

                entity.Property(e => e.ClusterId).HasColumnName("cluster_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.EncryptedPassword).HasColumnName("encrypted_password");

                entity.Property(e => e.EncryptedPasswordIv)
                    .HasColumnName("encrypted_password_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedToken).HasColumnName("encrypted_token");

                entity.Property(e => e.EncryptedTokenIv)
                    .HasColumnName("encrypted_token_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.Namespace)
                    .HasColumnName("namespace")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Cluster)
                    .WithOne(p => p.ClusterPlatformsKubernetes)
                    .HasForeignKey<ClusterPlatformsKubernetes>(d => d.ClusterId)
                    .HasConstraintName("fk_rails_e1e2cf841a");
            });

            modelBuilder.Entity<ClusterProjects>(entity =>
            {
                entity.ToTable("cluster_projects");

                entity.HasIndex(e => e.ClusterId)
                    .HasName("index_cluster_projects_on_cluster_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_cluster_projects_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClusterId).HasColumnName("cluster_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Cluster)
                    .WithMany(p => p.ClusterProjects)
                    .HasForeignKey(d => d.ClusterId)
                    .HasConstraintName("fk_rails_a5a958bca1");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ClusterProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_rails_8b8c5caf07");
            });

            modelBuilder.Entity<ClusterProvidersGcp>(entity =>
            {
                entity.ToTable("cluster_providers_gcp");

                entity.HasIndex(e => e.ClusterId)
                    .HasName("index_cluster_providers_gcp_on_cluster_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClusterId).HasColumnName("cluster_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.EncryptedAccessToken).HasColumnName("encrypted_access_token");

                entity.Property(e => e.EncryptedAccessTokenIv)
                    .HasColumnName("encrypted_access_token_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.Endpoint)
                    .HasColumnName("endpoint")
                    .HasColumnType("character varying");

                entity.Property(e => e.GcpProjectId)
                    .IsRequired()
                    .HasColumnName("gcp_project_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.MachineType)
                    .HasColumnName("machine_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.NumNodes).HasColumnName("num_nodes");

                entity.Property(e => e.OperationId)
                    .HasColumnName("operation_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusReason).HasColumnName("status_reason");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasColumnName("zone")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Cluster)
                    .WithOne(p => p.ClusterProvidersGcp)
                    .HasForeignKey<ClusterProvidersGcp>(d => d.ClusterId)
                    .HasConstraintName("fk_rails_5c2c3bc814");
            });

            modelBuilder.Entity<Clusters>(entity =>
            {
                entity.ToTable("clusters");

                entity.HasIndex(e => e.Enabled)
                    .HasName("index_clusters_on_enabled");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_clusters_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EnvironmentScope)
                    .IsRequired()
                    .HasColumnName("environment_scope")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'*'::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlatformType).HasColumnName("platform_type");

                entity.Property(e => e.ProviderType).HasColumnName("provider_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Clusters)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_rails_ac3a663d79");
            });

            modelBuilder.Entity<ClustersApplicationsHelm>(entity =>
            {
                entity.ToTable("clusters_applications_helm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClusterId).HasColumnName("cluster_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusReason).HasColumnName("status_reason");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Cluster)
                    .WithMany(p => p.ClustersApplicationsHelm)
                    .HasForeignKey(d => d.ClusterId)
                    .HasConstraintName("fk_rails_3e2b1c06bc");
            });

            modelBuilder.Entity<ClustersApplicationsIngress>(entity =>
            {
                entity.ToTable("clusters_applications_ingress");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClusterId).HasColumnName("cluster_id");

                entity.Property(e => e.ClusterIp)
                    .HasColumnName("cluster_ip")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ExternalIp)
                    .HasColumnName("external_ip")
                    .HasColumnType("character varying");

                entity.Property(e => e.IngressType).HasColumnName("ingress_type");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusReason).HasColumnName("status_reason");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Cluster)
                    .WithMany(p => p.ClustersApplicationsIngress)
                    .HasForeignKey(d => d.ClusterId)
                    .HasConstraintName("fk_rails_753a7b41c1");
            });

            modelBuilder.Entity<ClustersApplicationsPrometheus>(entity =>
            {
                entity.ToTable("clusters_applications_prometheus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClusterId).HasColumnName("cluster_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusReason).HasColumnName("status_reason");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Cluster)
                    .WithMany(p => p.ClustersApplicationsPrometheus)
                    .HasForeignKey(d => d.ClusterId)
                    .HasConstraintName("fk_rails_557e773639");
            });

            modelBuilder.Entity<ClustersApplicationsRunners>(entity =>
            {
                entity.ToTable("clusters_applications_runners");

                entity.HasIndex(e => e.ClusterId)
                    .HasName("index_clusters_applications_runners_on_cluster_id")
                    .IsUnique();

                entity.HasIndex(e => e.RunnerId)
                    .HasName("index_clusters_applications_runners_on_runner_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClusterId).HasColumnName("cluster_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Privileged)
                    .IsRequired()
                    .HasColumnName("privileged")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.RunnerId).HasColumnName("runner_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusReason).HasColumnName("status_reason");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Cluster)
                    .WithOne(p => p.ClustersApplicationsRunners)
                    .HasForeignKey<ClustersApplicationsRunners>(d => d.ClusterId)
                    .HasConstraintName("fk_rails_22388594e9");

                entity.HasOne(d => d.Runner)
                    .WithMany(p => p.ClustersApplicationsRunners)
                    .HasForeignKey(d => d.RunnerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_02de2ded36");
            });

            modelBuilder.Entity<ContainerRepositories>(entity =>
            {
                entity.ToTable("container_repositories");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_container_repositories_on_project_id");

                entity.HasIndex(e => new { e.ProjectId, e.Name })
                    .HasName("index_container_repositories_on_project_id_and_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ContainerRepositories)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_32f7bf5aad");
            });

            modelBuilder.Entity<ConversationalDevelopmentIndexMetrics>(entity =>
            {
                entity.ToTable("conversational_development_index_metrics");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.InstanceBoards).HasColumnName("instance_boards");

                entity.Property(e => e.InstanceCiPipelines).HasColumnName("instance_ci_pipelines");

                entity.Property(e => e.InstanceDeployments).HasColumnName("instance_deployments");

                entity.Property(e => e.InstanceEnvironments).HasColumnName("instance_environments");

                entity.Property(e => e.InstanceIssues).HasColumnName("instance_issues");

                entity.Property(e => e.InstanceMergeRequests).HasColumnName("instance_merge_requests");

                entity.Property(e => e.InstanceMilestones).HasColumnName("instance_milestones");

                entity.Property(e => e.InstanceNotes).HasColumnName("instance_notes");

                entity.Property(e => e.InstanceProjectsPrometheusActive).HasColumnName("instance_projects_prometheus_active");

                entity.Property(e => e.InstanceServiceDeskIssues).HasColumnName("instance_service_desk_issues");

                entity.Property(e => e.LeaderBoards).HasColumnName("leader_boards");

                entity.Property(e => e.LeaderCiPipelines).HasColumnName("leader_ci_pipelines");

                entity.Property(e => e.LeaderDeployments).HasColumnName("leader_deployments");

                entity.Property(e => e.LeaderEnvironments).HasColumnName("leader_environments");

                entity.Property(e => e.LeaderIssues).HasColumnName("leader_issues");

                entity.Property(e => e.LeaderMergeRequests).HasColumnName("leader_merge_requests");

                entity.Property(e => e.LeaderMilestones).HasColumnName("leader_milestones");

                entity.Property(e => e.LeaderNotes).HasColumnName("leader_notes");

                entity.Property(e => e.LeaderProjectsPrometheusActive).HasColumnName("leader_projects_prometheus_active");

                entity.Property(e => e.LeaderServiceDeskIssues).HasColumnName("leader_service_desk_issues");

                entity.Property(e => e.PercentageBoards).HasColumnName("percentage_boards");

                entity.Property(e => e.PercentageCiPipelines).HasColumnName("percentage_ci_pipelines");

                entity.Property(e => e.PercentageDeployments).HasColumnName("percentage_deployments");

                entity.Property(e => e.PercentageEnvironments).HasColumnName("percentage_environments");

                entity.Property(e => e.PercentageIssues).HasColumnName("percentage_issues");

                entity.Property(e => e.PercentageMergeRequests).HasColumnName("percentage_merge_requests");

                entity.Property(e => e.PercentageMilestones).HasColumnName("percentage_milestones");

                entity.Property(e => e.PercentageNotes).HasColumnName("percentage_notes");

                entity.Property(e => e.PercentageProjectsPrometheusActive).HasColumnName("percentage_projects_prometheus_active");

                entity.Property(e => e.PercentageServiceDeskIssues).HasColumnName("percentage_service_desk_issues");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<DeployKeysProjects>(entity =>
            {
                entity.ToTable("deploy_keys_projects");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_deploy_keys_projects_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CanPush).HasColumnName("can_push");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeployKeyId).HasColumnName("deploy_key_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DeployKeysProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_58a901ca7e");
            });

            modelBuilder.Entity<Deployments>(entity =>
            {
                entity.ToTable("deployments");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("index_deployments_on_created_at");

                entity.HasIndex(e => new { e.EnvironmentId, e.Id })
                    .HasName("index_deployments_on_environment_id_and_id");

                entity.HasIndex(e => new { e.ProjectId, e.Iid })
                    .HasName("index_deployments_on_project_id_and_iid")
                    .IsUnique();

                entity.HasIndex(e => new { e.EnvironmentId, e.Iid, e.ProjectId })
                    .HasName("index_deployments_on_environment_id_and_iid_and_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeployableId).HasColumnName("deployable_id");

                entity.Property(e => e.DeployableType)
                    .HasColumnName("deployable_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.EnvironmentId).HasColumnName("environment_id");

                entity.Property(e => e.Iid).HasColumnName("iid");

                entity.Property(e => e.OnStop)
                    .HasColumnName("on_stop")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Ref)
                    .IsRequired()
                    .HasColumnName("ref")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sha)
                    .IsRequired()
                    .HasColumnName("sha")
                    .HasColumnType("character varying");

                entity.Property(e => e.Tag).HasColumnName("tag");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Deployments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_b9a3851b82");
            });

            modelBuilder.Entity<Emails>(entity =>
            {
                entity.ToTable("emails");

                entity.HasIndex(e => e.ConfirmationToken)
                    .HasName("index_emails_on_confirmation_token")
                    .IsUnique();

                entity.HasIndex(e => e.Email)
                    .HasName("index_emails_on_email")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("index_emails_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConfirmationSentAt)
                    .HasColumnName("confirmation_sent_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ConfirmationToken)
                    .HasColumnName("confirmation_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.ConfirmedAt)
                    .HasColumnName("confirmed_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Environments>(entity =>
            {
                entity.ToTable("environments");

                entity.HasIndex(e => new { e.ProjectId, e.Name })
                    .HasName("index_environments_on_project_id_and_name")
                    .IsUnique();

                entity.HasIndex(e => new { e.ProjectId, e.Slug })
                    .HasName("index_environments_on_project_id_and_slug")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EnvironmentType)
                    .HasColumnName("environment_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExternalUrl)
                    .HasColumnName("external_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("character varying");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'available'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Environments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_d1c8c1da6a");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.ToTable("events");

                entity.HasIndex(e => e.Action)
                    .HasName("index_events_on_action");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("index_events_on_author_id");

                entity.HasIndex(e => new { e.ProjectId, e.Id })
                    .HasName("index_events_on_project_id_and_id");

                entity.HasIndex(e => new { e.TargetType, e.TargetId })
                    .HasName("index_events_on_target_type_and_target_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TargetType)
                    .HasColumnName("target_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("fk_edfd187b6f");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rails_f601258b28");
            });

            modelBuilder.Entity<FeatureGates>(entity =>
            {
                entity.ToTable("feature_gates");

                entity.HasIndex(e => new { e.FeatureKey, e.Key, e.Value })
                    .HasName("index_feature_gates_on_feature_key_and_key_and_value")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.FeatureKey)
                    .IsRequired()
                    .HasColumnName("feature_key")
                    .HasColumnType("character varying");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Features>(entity =>
            {
                entity.ToTable("features");

                entity.HasIndex(e => e.Key)
                    .HasName("index_features_on_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ForkedProjectLinks>(entity =>
            {
                entity.ToTable("forked_project_links");

                entity.HasIndex(e => e.ForkedToProjectId)
                    .HasName("index_forked_project_links_on_forked_to_project_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ForkedFromProjectId).HasColumnName("forked_from_project_id");

                entity.Property(e => e.ForkedToProjectId).HasColumnName("forked_to_project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.ForkedToProject)
                    .WithOne(p => p.ForkedProjectLinks)
                    .HasForeignKey<ForkedProjectLinks>(d => d.ForkedToProjectId)
                    .HasConstraintName("fk_434510edb0");
            });

            modelBuilder.Entity<ForkNetworkMembers>(entity =>
            {
                entity.ToTable("fork_network_members");

                entity.HasIndex(e => e.ForkNetworkId)
                    .HasName("index_fork_network_members_on_fork_network_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_fork_network_members_on_project_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ForkNetworkId).HasColumnName("fork_network_id");

                entity.Property(e => e.ForkedFromProjectId).HasColumnName("forked_from_project_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.ForkNetwork)
                    .WithMany(p => p.ForkNetworkMembers)
                    .HasForeignKey(d => d.ForkNetworkId)
                    .HasConstraintName("fk_rails_a40860a1ca");

                entity.HasOne(d => d.ForkedFromProject)
                    .WithMany(p => p.ForkNetworkMembersForkedFromProject)
                    .HasForeignKey(d => d.ForkedFromProjectId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_b01280dae4");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.ForkNetworkMembersProject)
                    .HasForeignKey<ForkNetworkMembers>(d => d.ProjectId)
                    .HasConstraintName("fk_rails_efccadc4ec");
            });

            modelBuilder.Entity<ForkNetworks>(entity =>
            {
                entity.ToTable("fork_networks");

                entity.HasIndex(e => e.RootProjectId)
                    .HasName("index_fork_networks_on_root_project_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeletedRootProjectName)
                    .HasColumnName("deleted_root_project_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.RootProjectId).HasColumnName("root_project_id");

                entity.HasOne(d => d.RootProject)
                    .WithOne(p => p.ForkNetworks)
                    .HasForeignKey<ForkNetworks>(d => d.RootProjectId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_e7b436b2b5");
            });

            modelBuilder.Entity<GcpClusters>(entity =>
            {
                entity.ToTable("gcp_clusters");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_gcp_clusters_on_project_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CaCert).HasColumnName("ca_cert");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EncryptedGcpToken).HasColumnName("encrypted_gcp_token");

                entity.Property(e => e.EncryptedGcpTokenIv)
                    .HasColumnName("encrypted_gcp_token_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedKubernetesToken).HasColumnName("encrypted_kubernetes_token");

                entity.Property(e => e.EncryptedKubernetesTokenIv)
                    .HasColumnName("encrypted_kubernetes_token_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedPassword).HasColumnName("encrypted_password");

                entity.Property(e => e.EncryptedPasswordIv)
                    .HasColumnName("encrypted_password_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.Endpoint)
                    .HasColumnName("endpoint")
                    .HasColumnType("character varying");

                entity.Property(e => e.GcpClusterName)
                    .IsRequired()
                    .HasColumnName("gcp_cluster_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.GcpClusterSize).HasColumnName("gcp_cluster_size");

                entity.Property(e => e.GcpClusterZone)
                    .IsRequired()
                    .HasColumnName("gcp_cluster_zone")
                    .HasColumnType("character varying");

                entity.Property(e => e.GcpMachineType)
                    .HasColumnName("gcp_machine_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.GcpOperationId)
                    .HasColumnName("gcp_operation_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.GcpProjectId)
                    .IsRequired()
                    .HasColumnName("gcp_project_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ProjectNamespace)
                    .HasColumnName("project_namespace")
                    .HasColumnType("character varying");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusReason).HasColumnName("status_reason");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.GcpClusters)
                    .HasForeignKey<GcpClusters>(d => d.ProjectId)
                    .HasConstraintName("fk_rails_b1dbe50e98");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.GcpClusters)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_rails_41d556eb65");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GcpClusters)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_rails_dc6f095aad");
            });

            modelBuilder.Entity<GpgKeys>(entity =>
            {
                entity.ToTable("gpg_keys");

                entity.HasIndex(e => e.Fingerprint)
                    .HasName("index_gpg_keys_on_fingerprint")
                    .IsUnique();

                entity.HasIndex(e => e.PrimaryKeyid)
                    .HasName("index_gpg_keys_on_primary_keyid")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("index_gpg_keys_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Fingerprint).HasColumnName("fingerprint");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.PrimaryKeyid).HasColumnName("primary_keyid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GpgKeys)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rails_9d1f5d8719");
            });

            modelBuilder.Entity<GpgKeySubkeys>(entity =>
            {
                entity.ToTable("gpg_key_subkeys");

                entity.HasIndex(e => e.Fingerprint)
                    .HasName("index_gpg_key_subkeys_on_fingerprint")
                    .IsUnique();

                entity.HasIndex(e => e.GpgKeyId)
                    .HasName("index_gpg_key_subkeys_on_gpg_key_id");

                entity.HasIndex(e => e.Keyid)
                    .HasName("index_gpg_key_subkeys_on_keyid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fingerprint).HasColumnName("fingerprint");

                entity.Property(e => e.GpgKeyId).HasColumnName("gpg_key_id");

                entity.Property(e => e.Keyid).HasColumnName("keyid");

                entity.HasOne(d => d.GpgKey)
                    .WithMany(p => p.GpgKeySubkeys)
                    .HasForeignKey(d => d.GpgKeyId)
                    .HasConstraintName("fk_rails_8b2c90b046");
            });

            modelBuilder.Entity<GpgSignatures>(entity =>
            {
                entity.ToTable("gpg_signatures");

                entity.HasIndex(e => e.CommitSha)
                    .HasName("index_gpg_signatures_on_commit_sha")
                    .IsUnique();

                entity.HasIndex(e => e.GpgKeyId)
                    .HasName("index_gpg_signatures_on_gpg_key_id");

                entity.HasIndex(e => e.GpgKeyPrimaryKeyid)
                    .HasName("index_gpg_signatures_on_gpg_key_primary_keyid");

                entity.HasIndex(e => e.GpgKeySubkeyId)
                    .HasName("index_gpg_signatures_on_gpg_key_subkey_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_gpg_signatures_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommitSha).HasColumnName("commit_sha");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.GpgKeyId).HasColumnName("gpg_key_id");

                entity.Property(e => e.GpgKeyPrimaryKeyid).HasColumnName("gpg_key_primary_keyid");

                entity.Property(e => e.GpgKeySubkeyId).HasColumnName("gpg_key_subkey_id");

                entity.Property(e => e.GpgKeyUserEmail).HasColumnName("gpg_key_user_email");

                entity.Property(e => e.GpgKeyUserName).HasColumnName("gpg_key_user_name");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.VerificationStatus).HasColumnName("verification_status");

                entity.HasOne(d => d.GpgKey)
                    .WithMany(p => p.GpgSignatures)
                    .HasForeignKey(d => d.GpgKeyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_rails_c97176f5f7");

                entity.HasOne(d => d.GpgKeySubkey)
                    .WithMany(p => p.GpgSignatures)
                    .HasForeignKey(d => d.GpgKeySubkeyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_rails_19d4f1c6f9");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.GpgSignatures)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rails_11ae8cb9a7");
            });

            modelBuilder.Entity<GroupCustomAttributes>(entity =>
            {
                entity.ToTable("group_custom_attributes");

                entity.HasIndex(e => new { e.GroupId, e.Key })
                    .HasName("index_group_custom_attributes_on_group_id_and_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("index_group_custom_attributes_on_key_and_value");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupCustomAttributes)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("fk_rails_246e0db83a");
            });

            modelBuilder.Entity<Identities>(entity =>
            {
                entity.ToTable("identities");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_identities_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ExternUid)
                    .HasColumnName("extern_uid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<IssueMetrics>(entity =>
            {
                entity.ToTable("issue_metrics");

                entity.HasIndex(e => e.IssueId)
                    .HasName("index_issue_metrics");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.FirstAddedToBoardAt).HasColumnName("first_added_to_board_at");

                entity.Property(e => e.FirstAssociatedWithMilestoneAt).HasColumnName("first_associated_with_milestone_at");

                entity.Property(e => e.FirstMentionedInCommitAt).HasColumnName("first_mentioned_in_commit_at");

                entity.Property(e => e.IssueId).HasColumnName("issue_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Issue)
                    .WithMany(p => p.IssueMetrics)
                    .HasForeignKey(d => d.IssueId)
                    .HasConstraintName("fk_rails_4bb543d85d");
            });

            modelBuilder.Entity<Issues>(entity =>
            {
                entity.ToTable("issues");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("index_issues_on_author_id");

                entity.HasIndex(e => e.Confidential)
                    .HasName("index_issues_on_confidential");

                entity.HasIndex(e => e.Description)
                    .HasName("index_issues_on_description_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.MilestoneId)
                    .HasName("index_issues_on_milestone_id");

                entity.HasIndex(e => e.MovedToId)
                    .HasName("index_issues_on_moved_to_id")
                    .HasFilter("(moved_to_id IS NOT NULL)");

                entity.HasIndex(e => e.RelativePosition)
                    .HasName("index_issues_on_relative_position");

                entity.HasIndex(e => e.State)
                    .HasName("index_issues_on_state");

                entity.HasIndex(e => e.Title)
                    .HasName("index_issues_on_title_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.UpdatedAt)
                    .HasName("index_issues_on_updated_at");

                entity.HasIndex(e => e.UpdatedById)
                    .HasName("index_issues_on_updated_by_id")
                    .HasFilter("(updated_by_id IS NOT NULL)");

                entity.HasIndex(e => new { e.ProjectId, e.Iid })
                    .HasName("index_issues_on_project_id_and_iid")
                    .IsUnique();

                entity.HasIndex(e => new { e.ProjectId, e.CreatedAt, e.Id, e.State })
                    .HasName("index_issues_on_project_id_and_created_at_and_id_and_state");

                entity.HasIndex(e => new { e.ProjectId, e.DueDate, e.Id, e.State })
                    .HasName("idx_issues_on_project_id_and_due_date_and_id_and_state_partial")
                    .HasFilter("(due_date IS NOT NULL)");

                entity.HasIndex(e => new { e.ProjectId, e.UpdatedAt, e.Id, e.State })
                    .HasName("index_issues_on_project_id_and_updated_at_and_id_and_state");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.ClosedAt)
                    .HasColumnName("closed_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Confidential).HasColumnName("confidential");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.DiscussionLocked).HasColumnName("discussion_locked");

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasColumnType("date");

                entity.Property(e => e.Iid).HasColumnName("iid");

                entity.Property(e => e.LastEditedAt).HasColumnName("last_edited_at");

                entity.Property(e => e.LastEditedById).HasColumnName("last_edited_by_id");

                entity.Property(e => e.LockVersion).HasColumnName("lock_version");

                entity.Property(e => e.MilestoneId).HasColumnName("milestone_id");

                entity.Property(e => e.MovedToId).HasColumnName("moved_to_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.RelativePosition).HasColumnName("relative_position");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255);

                entity.Property(e => e.TimeEstimate).HasColumnName("time_estimate");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.TitleHtml).HasColumnName("title_html");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.IssuesAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_05f1e72feb");

                entity.HasOne(d => d.Milestone)
                    .WithMany(p => p.Issues)
                    .HasForeignKey(d => d.MilestoneId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_96b1dd429c");

                entity.HasOne(d => d.MovedTo)
                    .WithMany(p => p.InverseMovedTo)
                    .HasForeignKey(d => d.MovedToId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_a194299be1");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Issues)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_899c8f3231");

                entity.HasOne(d => d.UpdatedBy)
                    .WithMany(p => p.IssuesUpdatedBy)
                    .HasForeignKey(d => d.UpdatedById)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_ffed080f01");
            });

            modelBuilder.Entity<Keys>(entity =>
            {
                entity.ToTable("keys");

                entity.HasIndex(e => e.Fingerprint)
                    .HasName("index_keys_on_fingerprint")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("index_keys_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Fingerprint)
                    .HasColumnName("fingerprint")
                    .HasMaxLength(255);

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.LastUsedAt).HasColumnName("last_used_at");

                entity.Property(e => e.Public).HasColumnName("public");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<LabelLinks>(entity =>
            {
                entity.ToTable("label_links");

                entity.HasIndex(e => e.LabelId)
                    .HasName("index_label_links_on_label_id");

                entity.HasIndex(e => new { e.TargetId, e.TargetType })
                    .HasName("index_label_links_on_target_id_and_target_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.LabelId).HasColumnName("label_id");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TargetType)
                    .HasColumnName("target_type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<LabelPriorities>(entity =>
            {
                entity.ToTable("label_priorities");

                entity.HasIndex(e => e.Priority)
                    .HasName("index_label_priorities_on_priority");

                entity.HasIndex(e => new { e.ProjectId, e.LabelId })
                    .HasName("index_label_priorities_on_project_id_and_label_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.LabelId).HasColumnName("label_id");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Label)
                    .WithMany(p => p.LabelPriorities)
                    .HasForeignKey(d => d.LabelId)
                    .HasConstraintName("fk_rails_e161058b0f");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.LabelPriorities)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_rails_ef916d14fa");
            });

            modelBuilder.Entity<Labels>(entity =>
            {
                entity.ToTable("labels");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_labels_on_project_id");

                entity.HasIndex(e => e.Template)
                    .HasName("index_labels_on_template")
                    .HasFilter("template");

                entity.HasIndex(e => e.Title)
                    .HasName("index_labels_on_title");

                entity.HasIndex(e => new { e.Type, e.ProjectId })
                    .HasName("index_labels_on_type_and_project_id");

                entity.HasIndex(e => new { e.GroupId, e.ProjectId, e.Title })
                    .HasName("index_labels_on_group_id_and_project_id_and_title")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Template)
                    .HasColumnName("template")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Labels)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rails_c1ac5161d8");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Labels)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_7de4989a69");
            });

            modelBuilder.Entity<LfsFileLocks>(entity =>
            {
                entity.ToTable("lfs_file_locks");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_lfs_file_locks_on_user_id");

                entity.HasIndex(e => new { e.ProjectId, e.Path })
                    .HasName("index_lfs_file_locks_on_project_id_and_path")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(511);

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.LfsFileLocks)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_rails_43df7a0412");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LfsFileLocks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_27a1d98fa8");
            });

            modelBuilder.Entity<LfsObjects>(entity =>
            {
                entity.ToTable("lfs_objects");

                entity.HasIndex(e => e.Oid)
                    .HasName("index_lfs_objects_on_oid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasColumnType("character varying");

                entity.Property(e => e.Oid)
                    .IsRequired()
                    .HasColumnName("oid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<LfsObjectsProjects>(entity =>
            {
                entity.ToTable("lfs_objects_projects");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_lfs_objects_projects_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.LfsObjectId).HasColumnName("lfs_object_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Lists>(entity =>
            {
                entity.ToTable("lists");

                entity.HasIndex(e => e.LabelId)
                    .HasName("index_lists_on_label_id");

                entity.HasIndex(e => new { e.BoardId, e.LabelId })
                    .HasName("index_lists_on_board_id_and_label_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BoardId).HasColumnName("board_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.LabelId).HasColumnName("label_id");

                entity.Property(e => e.ListType)
                    .HasColumnName("list_type")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.Lists)
                    .HasForeignKey(d => d.BoardId)
                    .HasConstraintName("fk_0d3f677137");

                entity.HasOne(d => d.Label)
                    .WithMany(p => p.Lists)
                    .HasForeignKey(d => d.LabelId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_7a5553d60f");
            });

            modelBuilder.Entity<Members>(entity =>
            {
                entity.ToTable("members");

                entity.HasIndex(e => e.AccessLevel)
                    .HasName("index_members_on_access_level");

                entity.HasIndex(e => e.InviteToken)
                    .HasName("index_members_on_invite_token")
                    .IsUnique();

                entity.HasIndex(e => e.RequestedAt)
                    .HasName("index_members_on_requested_at");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_members_on_user_id");

                entity.HasIndex(e => new { e.SourceId, e.SourceType })
                    .HasName("index_members_on_source_id_and_source_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessLevel).HasColumnName("access_level");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnName("expires_at")
                    .HasColumnType("date");

                entity.Property(e => e.InviteAcceptedAt).HasColumnName("invite_accepted_at");

                entity.Property(e => e.InviteEmail)
                    .HasColumnName("invite_email")
                    .HasColumnType("character varying");

                entity.Property(e => e.InviteToken)
                    .HasColumnName("invite_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.NotificationLevel).HasColumnName("notification_level");

                entity.Property(e => e.RequestedAt).HasColumnName("requested_at");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasColumnName("source_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_2e88fb7ce9");
            });

            modelBuilder.Entity<MergeRequestDiffs>(entity =>
            {
                entity.ToTable("merge_request_diffs");

                entity.HasIndex(e => new { e.MergeRequestId, e.Id })
                    .HasName("index_merge_request_diffs_on_merge_request_id_and_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BaseCommitSha)
                    .HasColumnName("base_commit_sha")
                    .HasColumnType("character varying");

                entity.Property(e => e.CommitsCount).HasColumnName("commits_count");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.HeadCommitSha)
                    .HasColumnName("head_commit_sha")
                    .HasColumnType("character varying");

                entity.Property(e => e.MergeRequestId).HasColumnName("merge_request_id");

                entity.Property(e => e.RealSize)
                    .HasColumnName("real_size")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartCommitSha)
                    .HasColumnName("start_commit_sha")
                    .HasColumnType("character varying");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.MergeRequest)
                    .WithMany(p => p.MergeRequestDiffs)
                    .HasForeignKey(d => d.MergeRequestId)
                    .HasConstraintName("fk_8483f3258f");
            });

            modelBuilder.Entity<MergeRequestMetrics>(entity =>
            {
                entity.ToTable("merge_request_metrics");

                entity.HasIndex(e => e.FirstDeployedToProductionAt)
                    .HasName("index_merge_request_metrics_on_first_deployed_to_production_at");

                entity.HasIndex(e => e.MergeRequestId)
                    .HasName("index_merge_request_metrics");

                entity.HasIndex(e => e.PipelineId)
                    .HasName("index_merge_request_metrics_on_pipeline_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.FirstDeployedToProductionAt).HasColumnName("first_deployed_to_production_at");

                entity.Property(e => e.LatestBuildFinishedAt).HasColumnName("latest_build_finished_at");

                entity.Property(e => e.LatestBuildStartedAt).HasColumnName("latest_build_started_at");

                entity.Property(e => e.LatestClosedAt)
                    .HasColumnName("latest_closed_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.LatestClosedById).HasColumnName("latest_closed_by_id");

                entity.Property(e => e.MergeRequestId).HasColumnName("merge_request_id");

                entity.Property(e => e.MergedAt).HasColumnName("merged_at");

                entity.Property(e => e.MergedById).HasColumnName("merged_by_id");

                entity.Property(e => e.PipelineId).HasColumnName("pipeline_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.LatestClosedBy)
                    .WithMany(p => p.MergeRequestMetricsLatestClosedBy)
                    .HasForeignKey(d => d.LatestClosedById)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_ae440388cc");

                entity.HasOne(d => d.MergeRequest)
                    .WithMany(p => p.MergeRequestMetrics)
                    .HasForeignKey(d => d.MergeRequestId)
                    .HasConstraintName("fk_rails_e6d7c24d1b");

                entity.HasOne(d => d.MergedBy)
                    .WithMany(p => p.MergeRequestMetricsMergedBy)
                    .HasForeignKey(d => d.MergedById)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_7f28d925f3");

                entity.HasOne(d => d.Pipeline)
                    .WithMany(p => p.MergeRequestMetrics)
                    .HasForeignKey(d => d.PipelineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rails_33ae169d48");
            });

            modelBuilder.Entity<MergeRequests>(entity =>
            {
                entity.ToTable("merge_requests");

                entity.HasIndex(e => e.AssigneeId)
                    .HasName("index_merge_requests_on_assignee_id");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("index_merge_requests_on_author_id");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("index_merge_requests_on_created_at");

                entity.HasIndex(e => e.Description)
                    .HasName("index_merge_requests_on_description_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.HeadPipelineId)
                    .HasName("index_merge_requests_on_head_pipeline_id");

                entity.HasIndex(e => e.LatestMergeRequestDiffId)
                    .HasName("index_merge_requests_on_latest_merge_request_diff_id");

                entity.HasIndex(e => e.MergeUserId)
                    .HasName("index_merge_requests_on_merge_user_id")
                    .HasFilter("(merge_user_id IS NOT NULL)");

                entity.HasIndex(e => e.MilestoneId)
                    .HasName("index_merge_requests_on_milestone_id");

                entity.HasIndex(e => e.SourceBranch)
                    .HasName("index_merge_requests_on_source_branch");

                entity.HasIndex(e => e.TargetBranch)
                    .HasName("index_merge_requests_on_target_branch");

                entity.HasIndex(e => e.Title)
                    .HasName("index_merge_requests_on_title_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.UpdatedById)
                    .HasName("index_merge_requests_on_updated_by_id")
                    .HasFilter("(updated_by_id IS NOT NULL)");

                entity.HasIndex(e => new { e.SourceProjectId, e.SourceBranch })
                    .HasName("index_merge_requests_on_source_project_id_and_source_branch")
                    .HasFilter("((state)::text = 'opened'::text)");

                entity.HasIndex(e => new { e.TargetProjectId, e.Iid })
                    .HasName("index_merge_requests_on_target_project_id_and_iid")
                    .IsUnique();

                entity.HasIndex(e => new { e.TargetProjectId, e.MergeCommitSha, e.Id })
                    .HasName("index_merge_requests_on_tp_id_and_merge_commit_sha_and_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowMaintainerToPush).HasColumnName("allow_maintainer_to_push");

                entity.Property(e => e.AssigneeId).HasColumnName("assignee_id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.DiscussionLocked).HasColumnName("discussion_locked");

                entity.Property(e => e.HeadPipelineId).HasColumnName("head_pipeline_id");

                entity.Property(e => e.Iid).HasColumnName("iid");

                entity.Property(e => e.InProgressMergeCommitSha)
                    .HasColumnName("in_progress_merge_commit_sha")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastEditedAt).HasColumnName("last_edited_at");

                entity.Property(e => e.LastEditedById).HasColumnName("last_edited_by_id");

                entity.Property(e => e.LatestMergeRequestDiffId).HasColumnName("latest_merge_request_diff_id");

                entity.Property(e => e.LockVersion).HasColumnName("lock_version");

                entity.Property(e => e.MergeCommitSha)
                    .HasColumnName("merge_commit_sha")
                    .HasColumnType("character varying");

                entity.Property(e => e.MergeError).HasColumnName("merge_error");

                entity.Property(e => e.MergeJid)
                    .HasColumnName("merge_jid")
                    .HasColumnType("character varying");

                entity.Property(e => e.MergeParams).HasColumnName("merge_params");

                entity.Property(e => e.MergeStatus)
                    .IsRequired()
                    .HasColumnName("merge_status")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'unchecked'::character varying");

                entity.Property(e => e.MergeUserId).HasColumnName("merge_user_id");

                entity.Property(e => e.MergeWhenPipelineSucceeds).HasColumnName("merge_when_pipeline_succeeds");

                entity.Property(e => e.MilestoneId).HasColumnName("milestone_id");

                entity.Property(e => e.RebaseCommitSha)
                    .HasColumnName("rebase_commit_sha")
                    .HasColumnType("character varying");

                entity.Property(e => e.SourceBranch)
                    .IsRequired()
                    .HasColumnName("source_branch")
                    .HasMaxLength(255);

                entity.Property(e => e.SourceProjectId).HasColumnName("source_project_id");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'opened'::character varying");

                entity.Property(e => e.TargetBranch)
                    .IsRequired()
                    .HasColumnName("target_branch")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetProjectId).HasColumnName("target_project_id");

                entity.Property(e => e.TimeEstimate).HasColumnName("time_estimate");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.TitleHtml).HasColumnName("title_html");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.HasOne(d => d.Assignee)
                    .WithMany(p => p.MergeRequestsAssignee)
                    .HasForeignKey(d => d.AssigneeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_6149611a04");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.MergeRequestsAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_e719a85f8a");

                entity.HasOne(d => d.HeadPipeline)
                    .WithMany(p => p.MergeRequests)
                    .HasForeignKey(d => d.HeadPipelineId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_fd82eae0b9");

                entity.HasOne(d => d.LatestMergeRequestDiff)
                    .WithMany(p => p.MergeRequests)
                    .HasForeignKey(d => d.LatestMergeRequestDiffId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_06067f5644");

                entity.HasOne(d => d.MergeUser)
                    .WithMany(p => p.MergeRequestsMergeUser)
                    .HasForeignKey(d => d.MergeUserId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_ad525e1f87");

                entity.HasOne(d => d.Milestone)
                    .WithMany(p => p.MergeRequests)
                    .HasForeignKey(d => d.MilestoneId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_6a5165a692");

                entity.HasOne(d => d.SourceProject)
                    .WithMany(p => p.MergeRequestsSourceProject)
                    .HasForeignKey(d => d.SourceProjectId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_3308fe130c");

                entity.HasOne(d => d.TargetProject)
                    .WithMany(p => p.MergeRequestsTargetProject)
                    .HasForeignKey(d => d.TargetProjectId)
                    .HasConstraintName("fk_a6963e8447");

                entity.HasOne(d => d.UpdatedBy)
                    .WithMany(p => p.MergeRequestsUpdatedBy)
                    .HasForeignKey(d => d.UpdatedById)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_641731faff");
            });

            modelBuilder.Entity<MergeRequestsClosingIssues>(entity =>
            {
                entity.ToTable("merge_requests_closing_issues");

                entity.HasIndex(e => e.IssueId)
                    .HasName("index_merge_requests_closing_issues_on_issue_id");

                entity.HasIndex(e => e.MergeRequestId)
                    .HasName("index_merge_requests_closing_issues_on_merge_request_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.IssueId).HasColumnName("issue_id");

                entity.Property(e => e.MergeRequestId).HasColumnName("merge_request_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Issue)
                    .WithMany(p => p.MergeRequestsClosingIssues)
                    .HasForeignKey(d => d.IssueId)
                    .HasConstraintName("fk_rails_f8540692be");

                entity.HasOne(d => d.MergeRequest)
                    .WithMany(p => p.MergeRequestsClosingIssues)
                    .HasForeignKey(d => d.MergeRequestId)
                    .HasConstraintName("fk_rails_458eda8667");
            });

            modelBuilder.Entity<Milestones>(entity =>
            {
                entity.ToTable("milestones");

                entity.HasIndex(e => e.Description)
                    .HasName("index_milestones_on_description_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.DueDate)
                    .HasName("index_milestones_on_due_date");

                entity.HasIndex(e => e.GroupId)
                    .HasName("index_milestones_on_group_id");

                entity.HasIndex(e => e.Title)
                    .HasName("index_milestones_on_title_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => new { e.ProjectId, e.Iid })
                    .HasName("index_milestones_on_project_id_and_iid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasColumnType("date");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Iid).HasColumnName("iid");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.TitleHtml).HasColumnName("title_html");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Milestones)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_95650a40d4");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Milestones)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_9bd0a0c791");
            });

            modelBuilder.Entity<Namespaces>(entity =>
            {
                entity.ToTable("namespaces");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("index_namespaces_on_created_at");

                entity.HasIndex(e => e.Name)
                    .HasName("index_namespaces_on_name_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("index_namespaces_on_owner_id");

                entity.HasIndex(e => e.Path)
                    .HasName("index_namespaces_on_path_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.RequireTwoFactorAuthentication)
                    .HasName("index_namespaces_on_require_two_factor_authentication");

                entity.HasIndex(e => e.Type)
                    .HasName("index_namespaces_on_type");

                entity.HasIndex(e => new { e.Name, e.ParentId })
                    .HasName("index_namespaces_on_name_and_parent_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.ParentId, e.Id })
                    .HasName("index_namespaces_on_parent_id_and_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasMaxLength(255);

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.LfsEnabled).HasColumnName("lfs_enabled");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasMaxLength(255);

                entity.Property(e => e.RequestAccessEnabled).HasColumnName("request_access_enabled");

                entity.Property(e => e.RequireTwoFactorAuthentication).HasColumnName("require_two_factor_authentication");

                entity.Property(e => e.ShareWithGroupLock)
                    .HasColumnName("share_with_group_lock")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.TwoFactorGracePeriod)
                    .HasColumnName("two_factor_grace_period")
                    .HasDefaultValueSql("48");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VisibilityLevel)
                    .HasColumnName("visibility_level")
                    .HasDefaultValueSql("20");
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.ToTable("notes");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("index_notes_on_author_id");

                entity.HasIndex(e => e.CommitId)
                    .HasName("index_notes_on_commit_id");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("index_notes_on_created_at");

                entity.HasIndex(e => e.DiscussionId)
                    .HasName("index_notes_on_discussion_id");

                entity.HasIndex(e => e.LineCode)
                    .HasName("index_notes_on_line_code");

                entity.HasIndex(e => e.Note)
                    .HasName("index_notes_on_note_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.NoteableType)
                    .HasName("index_notes_on_noteable_type");

                entity.HasIndex(e => e.UpdatedAt)
                    .HasName("index_notes_on_updated_at");

                entity.HasIndex(e => new { e.NoteableId, e.NoteableType })
                    .HasName("index_notes_on_noteable_id_and_noteable_type");

                entity.HasIndex(e => new { e.ProjectId, e.NoteableType })
                    .HasName("index_notes_on_project_id_and_noteable_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attachment)
                    .HasColumnName("attachment")
                    .HasMaxLength(255);

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.ChangePosition).HasColumnName("change_position");

                entity.Property(e => e.CommitId)
                    .HasColumnName("commit_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DiscussionId)
                    .HasColumnName("discussion_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.LineCode)
                    .HasColumnName("line_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.NoteHtml).HasColumnName("note_html");

                entity.Property(e => e.NoteableId).HasColumnName("noteable_id");

                entity.Property(e => e.NoteableType)
                    .HasColumnName("noteable_type")
                    .HasMaxLength(255);

                entity.Property(e => e.OriginalPosition).HasColumnName("original_position");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ResolvedAt).HasColumnName("resolved_at");

                entity.Property(e => e.ResolvedById).HasColumnName("resolved_by_id");

                entity.Property(e => e.ResolvedByPush).HasColumnName("resolved_by_push");

                entity.Property(e => e.StDiff).HasColumnName("st_diff");

                entity.Property(e => e.System).HasColumnName("system");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_99e097b079");
            });

            modelBuilder.Entity<NotificationSettings>(entity =>
            {
                entity.ToTable("notification_settings");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_notification_settings_on_user_id");

                entity.HasIndex(e => new { e.SourceId, e.SourceType })
                    .HasName("index_notification_settings_on_source_id_and_source_type");

                entity.HasIndex(e => new { e.UserId, e.SourceId, e.SourceType })
                    .HasName("index_notifications_on_user_id_and_source_id_and_source_type")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CloseIssue).HasColumnName("close_issue");

                entity.Property(e => e.CloseMergeRequest).HasColumnName("close_merge_request");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.FailedPipeline).HasColumnName("failed_pipeline");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.MergeMergeRequest).HasColumnName("merge_merge_request");

                entity.Property(e => e.NewIssue).HasColumnName("new_issue");

                entity.Property(e => e.NewMergeRequest).HasColumnName("new_merge_request");

                entity.Property(e => e.NewNote).HasColumnName("new_note");

                entity.Property(e => e.ReassignIssue).HasColumnName("reassign_issue");

                entity.Property(e => e.ReassignMergeRequest).HasColumnName("reassign_merge_request");

                entity.Property(e => e.ReopenIssue).HasColumnName("reopen_issue");

                entity.Property(e => e.ReopenMergeRequest).HasColumnName("reopen_merge_request");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.SourceType)
                    .HasColumnName("source_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.SuccessPipeline).HasColumnName("success_pipeline");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<OauthAccessGrants>(entity =>
            {
                entity.ToTable("oauth_access_grants");

                entity.HasIndex(e => e.Token)
                    .HasName("index_oauth_access_grants_on_token")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ExpiresIn).HasColumnName("expires_in");

                entity.Property(e => e.RedirectUri)
                    .IsRequired()
                    .HasColumnName("redirect_uri");

                entity.Property(e => e.ResourceOwnerId).HasColumnName("resource_owner_id");

                entity.Property(e => e.RevokedAt).HasColumnName("revoked_at");

                entity.Property(e => e.Scopes)
                    .HasColumnName("scopes")
                    .HasColumnType("character varying");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<OauthAccessTokens>(entity =>
            {
                entity.ToTable("oauth_access_tokens");

                entity.HasIndex(e => e.RefreshToken)
                    .HasName("index_oauth_access_tokens_on_refresh_token")
                    .IsUnique();

                entity.HasIndex(e => e.ResourceOwnerId)
                    .HasName("index_oauth_access_tokens_on_resource_owner_id");

                entity.HasIndex(e => e.Token)
                    .HasName("index_oauth_access_tokens_on_token")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ExpiresIn).HasColumnName("expires_in");

                entity.Property(e => e.RefreshToken)
                    .HasColumnName("refresh_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.ResourceOwnerId).HasColumnName("resource_owner_id");

                entity.Property(e => e.RevokedAt).HasColumnName("revoked_at");

                entity.Property(e => e.Scopes)
                    .HasColumnName("scopes")
                    .HasColumnType("character varying");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<OauthApplications>(entity =>
            {
                entity.ToTable("oauth_applications");

                entity.HasIndex(e => e.Uid)
                    .HasName("index_oauth_applications_on_uid")
                    .IsUnique();

                entity.HasIndex(e => new { e.OwnerId, e.OwnerType })
                    .HasName("index_oauth_applications_on_owner_id_and_owner_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.OwnerType)
                    .HasColumnName("owner_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.RedirectUri)
                    .IsRequired()
                    .HasColumnName("redirect_uri");

                entity.Property(e => e.Scopes)
                    .IsRequired()
                    .HasColumnName("scopes")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Secret)
                    .IsRequired()
                    .HasColumnName("secret")
                    .HasColumnType("character varying");

                entity.Property(e => e.Trusted).HasColumnName("trusted");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("uid")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<OauthOpenidRequests>(entity =>
            {
                entity.ToTable("oauth_openid_requests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessGrantId).HasColumnName("access_grant_id");

                entity.Property(e => e.Nonce)
                    .IsRequired()
                    .HasColumnName("nonce")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.AccessGrant)
                    .WithMany(p => p.OauthOpenidRequests)
                    .HasForeignKey(d => d.AccessGrantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_oauth_openid_requests_oauth_access_grants_access_grant_id");
            });

            modelBuilder.Entity<PagesDomains>(entity =>
            {
                entity.ToTable("pages_domains");

                entity.HasIndex(e => e.Domain)
                    .HasName("index_pages_domains_on_domain")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_pages_domains_on_project_id");

                entity.HasIndex(e => e.VerifiedAt)
                    .HasName("index_pages_domains_on_verified_at");

                entity.HasIndex(e => new { e.ProjectId, e.EnabledUntil })
                    .HasName("index_pages_domains_on_project_id_and_enabled_until");

                entity.HasIndex(e => new { e.VerifiedAt, e.EnabledUntil })
                    .HasName("index_pages_domains_on_verified_at_and_enabled_until");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Certificate).HasColumnName("certificate");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasColumnType("character varying");

                entity.Property(e => e.EnabledUntil)
                    .HasColumnName("enabled_until")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.EncryptedKey).HasColumnName("encrypted_key");

                entity.Property(e => e.EncryptedKeyIv)
                    .HasColumnName("encrypted_key_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedKeySalt)
                    .HasColumnName("encrypted_key_salt")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.VerificationCode)
                    .IsRequired()
                    .HasColumnName("verification_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.VerifiedAt)
                    .HasColumnName("verified_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.PagesDomains)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_ea2f6dfc6f");
            });

            modelBuilder.Entity<PersonalAccessTokens>(entity =>
            {
                entity.ToTable("personal_access_tokens");

                entity.HasIndex(e => e.Token)
                    .HasName("index_personal_access_tokens_on_token")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("index_personal_access_tokens_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnName("expires_at")
                    .HasColumnType("date");

                entity.Property(e => e.Impersonation).HasColumnName("impersonation");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Revoked)
                    .HasColumnName("revoked")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Scopes)
                    .IsRequired()
                    .HasColumnName("scopes")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'--- []
'::character varying");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PersonalAccessTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_08903b8f38");
            });

            modelBuilder.Entity<ProjectAutoDevops>(entity =>
            {
                entity.ToTable("project_auto_devops");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_project_auto_devops_on_project_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasColumnType("character varying");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.ProjectAutoDevops)
                    .HasForeignKey<ProjectAutoDevops>(d => d.ProjectId)
                    .HasConstraintName("fk_rails_45436b12b2");
            });

            modelBuilder.Entity<ProjectCustomAttributes>(entity =>
            {
                entity.ToTable("project_custom_attributes");

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("index_project_custom_attributes_on_key_and_value");

                entity.HasIndex(e => new { e.ProjectId, e.Key })
                    .HasName("index_project_custom_attributes_on_project_id_and_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectCustomAttributes)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_rails_719c3dccc5");
            });

            modelBuilder.Entity<ProjectFeatures>(entity =>
            {
                entity.ToTable("project_features");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_project_features_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuildsAccessLevel).HasColumnName("builds_access_level");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.IssuesAccessLevel).HasColumnName("issues_access_level");

                entity.Property(e => e.MergeRequestsAccessLevel).HasColumnName("merge_requests_access_level");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.RepositoryAccessLevel)
                    .HasColumnName("repository_access_level")
                    .HasDefaultValueSql("20");

                entity.Property(e => e.SnippetsAccessLevel).HasColumnName("snippets_access_level");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.WikiAccessLevel).HasColumnName("wiki_access_level");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectFeatures)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_18513d9b92");
            });

            modelBuilder.Entity<ProjectGroupLinks>(entity =>
            {
                entity.ToTable("project_group_links");

                entity.HasIndex(e => e.GroupId)
                    .HasName("index_project_group_links_on_group_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_project_group_links_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnName("expires_at")
                    .HasColumnType("date");

                entity.Property(e => e.GroupAccess)
                    .HasColumnName("group_access")
                    .HasDefaultValueSql("30");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectGroupLinks)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_daa8cee94c");
            });

            modelBuilder.Entity<ProjectImportData>(entity =>
            {
                entity.ToTable("project_import_data");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_project_import_data_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.EncryptedCredentials).HasColumnName("encrypted_credentials");

                entity.Property(e => e.EncryptedCredentialsIv)
                    .HasColumnName("encrypted_credentials_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedCredentialsSalt)
                    .HasColumnName("encrypted_credentials_salt")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectImportData)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_ffb9ee3a10");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.ToTable("projects");

                entity.HasIndex(e => e.CiId)
                    .HasName("index_projects_on_ci_id");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("index_projects_on_created_at");

                entity.HasIndex(e => e.CreatorId)
                    .HasName("index_projects_on_creator_id");

                entity.HasIndex(e => e.Description)
                    .HasName("index_projects_on_description_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.Id)
                    .HasName("index_projects_on_id_partial_for_visibility")
                    .IsUnique()
                    .HasFilter("(visibility_level = ANY (ARRAY[10, 20]))");

                entity.HasIndex(e => e.LastActivityAt)
                    .HasName("index_projects_on_last_activity_at");

                entity.HasIndex(e => e.LastRepositoryCheckFailed)
                    .HasName("index_projects_on_last_repository_check_failed");

                entity.HasIndex(e => e.LastRepositoryUpdatedAt)
                    .HasName("index_projects_on_last_repository_updated_at");

                entity.HasIndex(e => e.Name)
                    .HasName("index_projects_on_name_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.NamespaceId)
                    .HasName("index_projects_on_namespace_id");

                entity.HasIndex(e => e.Path)
                    .HasName("index_projects_on_path_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.PendingDelete)
                    .HasName("index_projects_on_pending_delete");

                entity.HasIndex(e => e.RepositoryStorage)
                    .HasName("index_projects_on_repository_storage");

                entity.HasIndex(e => e.RunnersToken)
                    .HasName("index_projects_on_runners_token");

                entity.HasIndex(e => e.StarCount)
                    .HasName("index_projects_on_star_count");

                entity.HasIndex(e => e.VisibilityLevel)
                    .HasName("index_projects_on_visibility_level");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.AutoCancelPendingPipelines)
                    .HasColumnName("auto_cancel_pending_pipelines")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasColumnType("character varying");

                entity.Property(e => e.BuildAllowGitFetch)
                    .IsRequired()
                    .HasColumnName("build_allow_git_fetch")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.BuildCoverageRegex)
                    .HasColumnName("build_coverage_regex")
                    .HasColumnType("character varying");

                entity.Property(e => e.BuildTimeout)
                    .HasColumnName("build_timeout")
                    .HasDefaultValueSql("3600");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.CiConfigPath)
                    .HasColumnName("ci_config_path")
                    .HasColumnType("character varying");

                entity.Property(e => e.CiId).HasColumnName("ci_id");

                entity.Property(e => e.ContainerRegistryEnabled).HasColumnName("container_registry_enabled");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DeleteError).HasColumnName("delete_error");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.HasExternalIssueTracker).HasColumnName("has_external_issue_tracker");

                entity.Property(e => e.HasExternalWiki).HasColumnName("has_external_wiki");

                entity.Property(e => e.ImportError).HasColumnName("import_error");

                entity.Property(e => e.ImportJid)
                    .HasColumnName("import_jid")
                    .HasColumnType("character varying");

                entity.Property(e => e.ImportSource)
                    .HasColumnName("import_source")
                    .HasColumnType("character varying");

                entity.Property(e => e.ImportStatus)
                    .HasColumnName("import_status")
                    .HasMaxLength(255);

                entity.Property(e => e.ImportType)
                    .HasColumnName("import_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.ImportUrl)
                    .HasColumnName("import_url")
                    .HasMaxLength(255);

                entity.Property(e => e.JobsCacheIndex).HasColumnName("jobs_cache_index");

                entity.Property(e => e.LastActivityAt).HasColumnName("last_activity_at");

                entity.Property(e => e.LastRepositoryCheckAt).HasColumnName("last_repository_check_at");

                entity.Property(e => e.LastRepositoryCheckFailed).HasColumnName("last_repository_check_failed");

                entity.Property(e => e.LastRepositoryUpdatedAt).HasColumnName("last_repository_updated_at");

                entity.Property(e => e.LfsEnabled).HasColumnName("lfs_enabled");

                entity.Property(e => e.MergeRequestsFfOnlyEnabled).HasColumnName("merge_requests_ff_only_enabled");

                entity.Property(e => e.MergeRequestsRebaseEnabled).HasColumnName("merge_requests_rebase_enabled");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NamespaceId).HasColumnName("namespace_id");

                entity.Property(e => e.OnlyAllowMergeIfAllDiscussionsAreResolved).HasColumnName("only_allow_merge_if_all_discussions_are_resolved");

                entity.Property(e => e.OnlyAllowMergeIfPipelineSucceeds).HasColumnName("only_allow_merge_if_pipeline_succeeds");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(255);

                entity.Property(e => e.PendingDelete)
                    .HasColumnName("pending_delete")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PrintingMergeRequestLinkEnabled)
                    .IsRequired()
                    .HasColumnName("printing_merge_request_link_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PublicBuilds)
                    .IsRequired()
                    .HasColumnName("public_builds")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.RepositoryReadOnly).HasColumnName("repository_read_only");

                entity.Property(e => e.RepositoryStorage)
                    .IsRequired()
                    .HasColumnName("repository_storage")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'default'::character varying");

                entity.Property(e => e.RequestAccessEnabled).HasColumnName("request_access_enabled");

                entity.Property(e => e.ResolveOutdatedDiffDiscussions).HasColumnName("resolve_outdated_diff_discussions");

                entity.Property(e => e.RunnersToken)
                    .HasColumnName("runners_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.SharedRunnersEnabled)
                    .IsRequired()
                    .HasColumnName("shared_runners_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StarCount).HasColumnName("star_count");

                entity.Property(e => e.StorageVersion).HasColumnName("storage_version");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VisibilityLevel).HasColumnName("visibility_level");
            });

            modelBuilder.Entity<ProjectStatistics>(entity =>
            {
                entity.ToTable("project_statistics");

                entity.HasIndex(e => e.NamespaceId)
                    .HasName("index_project_statistics_on_namespace_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_project_statistics_on_project_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuildArtifactsSize).HasColumnName("build_artifacts_size");

                entity.Property(e => e.CommitCount).HasColumnName("commit_count");

                entity.Property(e => e.LfsObjectsSize).HasColumnName("lfs_objects_size");

                entity.Property(e => e.NamespaceId).HasColumnName("namespace_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.RepositorySize).HasColumnName("repository_size");

                entity.Property(e => e.StorageSize).HasColumnName("storage_size");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.ProjectStatistics)
                    .HasForeignKey<ProjectStatistics>(d => d.ProjectId)
                    .HasConstraintName("fk_rails_12c471002f");
            });

            modelBuilder.Entity<ProtectedBranches>(entity =>
            {
                entity.ToTable("protected_branches");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_protected_branches_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProtectedBranches)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_7a9c6d93e7");
            });

            modelBuilder.Entity<ProtectedBranchMergeAccessLevels>(entity =>
            {
                entity.ToTable("protected_branch_merge_access_levels");

                entity.HasIndex(e => e.ProtectedBranchId)
                    .HasName("index_protected_branch_merge_access");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("access_level")
                    .HasDefaultValueSql("40");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ProtectedBranchId).HasColumnName("protected_branch_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.ProtectedBranch)
                    .WithMany(p => p.ProtectedBranchMergeAccessLevels)
                    .HasForeignKey(d => d.ProtectedBranchId)
                    .HasConstraintName("fk_8a3072ccb3");
            });

            modelBuilder.Entity<ProtectedBranchPushAccessLevels>(entity =>
            {
                entity.ToTable("protected_branch_push_access_levels");

                entity.HasIndex(e => e.ProtectedBranchId)
                    .HasName("index_protected_branch_push_access");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("access_level")
                    .HasDefaultValueSql("40");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ProtectedBranchId).HasColumnName("protected_branch_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.ProtectedBranch)
                    .WithMany(p => p.ProtectedBranchPushAccessLevels)
                    .HasForeignKey(d => d.ProtectedBranchId)
                    .HasConstraintName("fk_9ffc86a3d9");
            });

            modelBuilder.Entity<ProtectedTagCreateAccessLevels>(entity =>
            {
                entity.ToTable("protected_tag_create_access_levels");

                entity.HasIndex(e => e.ProtectedTagId)
                    .HasName("index_protected_tag_create_access");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_protected_tag_create_access_levels_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("access_level")
                    .HasDefaultValueSql("40");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ProtectedTagId).HasColumnName("protected_tag_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ProtectedTagCreateAccessLevels)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("fk_rails_b4eb82fe3c");

                entity.HasOne(d => d.ProtectedTag)
                    .WithMany(p => p.ProtectedTagCreateAccessLevels)
                    .HasForeignKey(d => d.ProtectedTagId)
                    .HasConstraintName("fk_f7dfda8c51");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProtectedTagCreateAccessLevels)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_2349b78b91");
            });

            modelBuilder.Entity<ProtectedTags>(entity =>
            {
                entity.ToTable("protected_tags");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_protected_tags_on_project_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProtectedTags)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_8e4af87648");
            });

            modelBuilder.Entity<RedirectRoutes>(entity =>
            {
                entity.ToTable("redirect_routes");

                entity.HasIndex(e => e.Path)
                    .HasName("index_redirect_routes_on_path")
                    .IsUnique();

                entity.HasIndex(e => new { e.SourceType, e.SourceId })
                    .HasName("index_redirect_routes_on_source_type_and_source_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("character varying");

                entity.Property(e => e.Permanent).HasColumnName("permanent");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasColumnName("source_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Releases>(entity =>
            {
                entity.ToTable("releases");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_releases_on_project_id");

                entity.HasIndex(e => new { e.ProjectId, e.Tag })
                    .HasName("index_releases_on_project_id_and_tag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Releases)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_47fe2a0596");
            });

            modelBuilder.Entity<Routes>(entity =>
            {
                entity.ToTable("routes");

                entity.HasIndex(e => e.Path)
                    .HasName("index_routes_on_path_text_pattern_ops");

                entity.HasIndex(e => new { e.SourceType, e.SourceId })
                    .HasName("index_routes_on_source_type_and_source_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("character varying");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasColumnName("source_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<SentNotifications>(entity =>
            {
                entity.ToTable("sent_notifications");

                entity.HasIndex(e => e.ReplyKey)
                    .HasName("index_sent_notifications_on_reply_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommitId)
                    .HasColumnName("commit_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.InReplyToDiscussionId)
                    .HasColumnName("in_reply_to_discussion_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.LineCode)
                    .HasColumnName("line_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.NoteType)
                    .HasColumnName("note_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.NoteableId).HasColumnName("noteable_id");

                entity.Property(e => e.NoteableType)
                    .HasColumnName("noteable_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.Property(e => e.ReplyKey)
                    .IsRequired()
                    .HasColumnName("reply_key")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.ToTable("services");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_services_on_project_id");

                entity.HasIndex(e => e.Template)
                    .HasName("index_services_on_template");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'common'::character varying");

                entity.Property(e => e.CommitEvents)
                    .IsRequired()
                    .HasColumnName("commit_events")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ConfidentialIssuesEvents)
                    .IsRequired()
                    .HasColumnName("confidential_issues_events")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Default)
                    .HasColumnName("default")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IssuesEvents)
                    .HasColumnName("issues_events")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.JobEvents).HasColumnName("job_events");

                entity.Property(e => e.MergeRequestsEvents)
                    .HasColumnName("merge_requests_events")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.NoteEvents)
                    .IsRequired()
                    .HasColumnName("note_events")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PipelineEvents).HasColumnName("pipeline_events");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Properties).HasColumnName("properties");

                entity.Property(e => e.PushEvents)
                    .HasColumnName("push_events")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TagPushEvents)
                    .HasColumnName("tag_push_events")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Template)
                    .HasColumnName("template")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.WikiPageEvents)
                    .HasColumnName("wiki_page_events")
                    .HasDefaultValueSql("true");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_71cce407f9");
            });

            modelBuilder.Entity<Snippets>(entity =>
            {
                entity.ToTable("snippets");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("index_snippets_on_author_id");

                entity.HasIndex(e => e.FileName)
                    .HasName("index_snippets_on_file_name_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_snippets_on_project_id");

                entity.HasIndex(e => e.Title)
                    .HasName("index_snippets_on_title_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.UpdatedAt)
                    .HasName("index_snippets_on_updated_at");

                entity.HasIndex(e => e.VisibilityLevel)
                    .HasName("index_snippets_on_visibility_level");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CachedMarkdownVersion).HasColumnName("cached_markdown_version");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.ContentHtml).HasColumnName("content_html");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.TitleHtml).HasColumnName("title_html");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.VisibilityLevel).HasColumnName("visibility_level");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Snippets)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_be41fd4bb7");
            });

            modelBuilder.Entity<SpamLogs>(entity =>
            {
                entity.ToTable("spam_logs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.NoteableType)
                    .HasColumnName("noteable_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.RecaptchaVerified).HasColumnName("recaptcha_verified");

                entity.Property(e => e.SourceIp)
                    .HasColumnName("source_ip")
                    .HasColumnType("character varying");

                entity.Property(e => e.SubmittedAsHam).HasColumnName("submitted_as_ham");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserAgent)
                    .HasColumnName("user_agent")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ViaApi).HasColumnName("via_api");
            });

            modelBuilder.Entity<Subscriptions>(entity =>
            {
                entity.ToTable("subscriptions");

                entity.HasIndex(e => new { e.SubscribableId, e.SubscribableType, e.UserId, e.ProjectId })
                    .HasName("index_subscriptions_on_subscribable_and_user_id_and_project_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.SubscribableId).HasColumnName("subscribable_id");

                entity.Property(e => e.SubscribableType)
                    .HasColumnName("subscribable_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_rails_d0c8bda804");
            });

            modelBuilder.Entity<SystemNoteMetadata>(entity =>
            {
                entity.ToTable("system_note_metadata");

                entity.HasIndex(e => e.NoteId)
                    .HasName("index_system_note_metadata_on_note_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("character varying");

                entity.Property(e => e.CommitCount).HasColumnName("commit_count");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.NoteId).HasColumnName("note_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Note)
                    .WithOne(p => p.SystemNoteMetadata)
                    .HasForeignKey<SystemNoteMetadata>(d => d.NoteId)
                    .HasConstraintName("fk_d83a918cb1");
            });

            modelBuilder.Entity<Taggings>(entity =>
            {
                entity.ToTable("taggings");

                entity.HasIndex(e => e.TagId)
                    .HasName("index_taggings_on_tag_id");

                entity.HasIndex(e => new { e.TaggableId, e.TaggableType })
                    .HasName("index_taggings_on_taggable_id_and_taggable_type");

                entity.HasIndex(e => new { e.TaggableId, e.TaggableType, e.Context })
                    .HasName("index_taggings_on_taggable_id_and_taggable_type_and_context");

                entity.HasIndex(e => new { e.TagId, e.TaggableId, e.TaggableType, e.Context, e.TaggerId, e.TaggerType })
                    .HasName("taggings_idx")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Context)
                    .HasColumnName("context")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.Property(e => e.TaggableId).HasColumnName("taggable_id");

                entity.Property(e => e.TaggableType)
                    .HasColumnName("taggable_type")
                    .HasMaxLength(255);

                entity.Property(e => e.TaggerId).HasColumnName("tagger_id");

                entity.Property(e => e.TaggerType)
                    .HasColumnName("tagger_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.ToTable("tags");

                entity.HasIndex(e => e.Name)
                    .HasName("index_tags_on_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.TaggingsCount)
                    .HasColumnName("taggings_count")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Timelogs>(entity =>
            {
                entity.ToTable("timelogs");

                entity.HasIndex(e => e.IssueId)
                    .HasName("index_timelogs_on_issue_id");

                entity.HasIndex(e => e.MergeRequestId)
                    .HasName("index_timelogs_on_merge_request_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_timelogs_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.IssueId).HasColumnName("issue_id");

                entity.Property(e => e.MergeRequestId).HasColumnName("merge_request_id");

                entity.Property(e => e.SpentAt)
                    .HasColumnName("spent_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.TimeSpent).HasColumnName("time_spent");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Issue)
                    .WithMany(p => p.Timelogs)
                    .HasForeignKey(d => d.IssueId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_timelogs_issues_issue_id");

                entity.HasOne(d => d.MergeRequest)
                    .WithMany(p => p.Timelogs)
                    .HasForeignKey(d => d.MergeRequestId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_timelogs_merge_requests_merge_request_id");
            });

            modelBuilder.Entity<Todos>(entity =>
            {
                entity.ToTable("todos");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("index_todos_on_author_id");

                entity.HasIndex(e => e.CommitId)
                    .HasName("index_todos_on_commit_id");

                entity.HasIndex(e => e.NoteId)
                    .HasName("index_todos_on_note_id");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_todos_on_project_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_todos_on_user_id");

                entity.HasIndex(e => new { e.TargetType, e.TargetId })
                    .HasName("index_todos_on_target_type_and_target_id");

                entity.HasIndex(e => new { e.UserId, e.Id })
                    .HasName("index_todos_on_user_id_and_id_pending")
                    .HasFilter("((state)::text = 'pending'::text)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.CommitId)
                    .HasColumnName("commit_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.NoteId).HasColumnName("note_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("character varying");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TargetType)
                    .IsRequired()
                    .HasColumnName("target_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.TodosAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("fk_ccf0373936");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_91d1f47b13");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_45054f9c45");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TodosUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_d94154aa95");
            });

            modelBuilder.Entity<TrendingProjects>(entity =>
            {
                entity.ToTable("trending_projects");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_trending_projects_on_project_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.Project)
                    .WithOne(p => p.TrendingProjects)
                    .HasForeignKey<TrendingProjects>(d => d.ProjectId)
                    .HasConstraintName("fk_rails_09feecd872");
            });

            modelBuilder.Entity<U2fRegistrations>(entity =>
            {
                entity.ToTable("u2f_registrations");

                entity.HasIndex(e => e.KeyHandle)
                    .HasName("index_u2f_registrations_on_key_handle");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_u2f_registrations_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Certificate).HasColumnName("certificate");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.KeyHandle)
                    .HasColumnName("key_handle")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PublicKey)
                    .HasColumnName("public_key")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.U2fRegistrations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_bfe6a84544");
            });

            modelBuilder.Entity<Uploads>(entity =>
            {
                entity.ToTable("uploads");

                entity.HasIndex(e => e.Checksum)
                    .HasName("index_uploads_on_checksum");

                entity.HasIndex(e => new { e.ModelId, e.ModelType })
                    .HasName("index_uploads_on_model_id_and_model_type");

                entity.HasIndex(e => new { e.Uploader, e.Path })
                    .HasName("index_uploads_on_uploader_and_path");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Checksum)
                    .HasColumnName("checksum")
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ModelId).HasColumnName("model_id");

                entity.Property(e => e.ModelType)
                    .HasColumnName("model_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.MountPoint)
                    .HasColumnName("mount_point")
                    .HasColumnType("character varying");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasMaxLength(511);

                entity.Property(e => e.Secret)
                    .HasColumnName("secret")
                    .HasColumnType("character varying");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Uploader)
                    .IsRequired()
                    .HasColumnName("uploader")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<UserAgentDetails>(entity =>
            {
                entity.ToTable("user_agent_details");

                entity.HasIndex(e => new { e.SubjectId, e.SubjectType })
                    .HasName("index_user_agent_details_on_subject_id_and_subject_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasColumnType("character varying");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.SubjectType)
                    .IsRequired()
                    .HasColumnName("subject_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Submitted).HasColumnName("submitted");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasColumnName("user_agent")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<UserCallouts>(entity =>
            {
                entity.ToTable("user_callouts");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_user_callouts_on_user_id");

                entity.HasIndex(e => new { e.UserId, e.FeatureName })
                    .HasName("index_user_callouts_on_user_id_and_feature_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FeatureName).HasColumnName("feature_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCallouts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_ddfdd80f3d");
            });

            modelBuilder.Entity<UserCustomAttributes>(entity =>
            {
                entity.ToTable("user_custom_attributes");

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("index_user_custom_attributes_on_key_and_value");

                entity.HasIndex(e => new { e.UserId, e.Key })
                    .HasName("index_user_custom_attributes_on_user_id_and_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCustomAttributes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_47b91868a8");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Admin)
                    .HasName("index_users_on_admin");

                entity.HasIndex(e => e.ConfirmationToken)
                    .HasName("index_users_on_confirmation_token")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("index_users_on_created_at");

                entity.HasIndex(e => e.Email)
                    .HasName("index_users_on_email_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.Ghost)
                    .HasName("index_users_on_ghost");

                entity.HasIndex(e => e.IncomingEmailToken)
                    .HasName("index_users_on_incoming_email_token");

                entity.HasIndex(e => e.Name)
                    .HasName("index_users_on_name_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.HasIndex(e => e.ResetPasswordToken)
                    .HasName("index_users_on_reset_password_token")
                    .IsUnique();

                entity.HasIndex(e => e.RssToken)
                    .HasName("index_users_on_rss_token");

                entity.HasIndex(e => e.State)
                    .HasName("index_users_on_state");

                entity.HasIndex(e => e.Username)
                    .HasName("index_users_on_username_trigram")
                    .ForNpgsqlHasMethod("gin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasMaxLength(255);

                entity.Property(e => e.Bio)
                    .HasColumnName("bio")
                    .HasMaxLength(255);

                entity.Property(e => e.CanCreateGroup)
                    .IsRequired()
                    .HasColumnName("can_create_group")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.CanCreateTeam)
                    .IsRequired()
                    .HasColumnName("can_create_team")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ColorSchemeId)
                    .HasColumnName("color_scheme_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ConfirmationSentAt).HasColumnName("confirmation_sent_at");

                entity.Property(e => e.ConfirmationToken)
                    .HasColumnName("confirmation_token")
                    .HasMaxLength(255);

                entity.Property(e => e.ConfirmedAt).HasColumnName("confirmed_at");

                entity.Property(e => e.ConsumedTimestep).HasColumnName("consumed_timestep");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrentSignInAt).HasColumnName("current_sign_in_at");

                entity.Property(e => e.CurrentSignInIp)
                    .HasColumnName("current_sign_in_ip")
                    .HasMaxLength(255);

                entity.Property(e => e.Dashboard)
                    .HasColumnName("dashboard")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.EncryptedOtpSecret)
                    .HasColumnName("encrypted_otp_secret")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedOtpSecretIv)
                    .HasColumnName("encrypted_otp_secret_iv")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedOtpSecretSalt)
                    .HasColumnName("encrypted_otp_secret_salt")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedPassword)
                    .IsRequired()
                    .HasColumnName("encrypted_password")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.External)
                    .HasColumnName("external")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FailedAttempts)
                    .HasColumnName("failed_attempts")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ghost).HasColumnName("ghost");

                entity.Property(e => e.HideNoPassword)
                    .HasColumnName("hide_no_password")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.HideNoSshKey)
                    .HasColumnName("hide_no_ssh_key")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.HideProjectLimit)
                    .HasColumnName("hide_project_limit")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IncomingEmailToken)
                    .HasColumnName("incoming_email_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastActivityOn)
                    .HasColumnName("last_activity_on")
                    .HasColumnType("date");

                entity.Property(e => e.LastCredentialCheckAt).HasColumnName("last_credential_check_at");

                entity.Property(e => e.LastSignInAt).HasColumnName("last_sign_in_at");

                entity.Property(e => e.LastSignInIp)
                    .HasColumnName("last_sign_in_ip")
                    .HasMaxLength(255);

                entity.Property(e => e.Layout)
                    .HasColumnName("layout")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Linkedin)
                    .IsRequired()
                    .HasColumnName("linkedin")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("character varying");

                entity.Property(e => e.LockedAt).HasColumnName("locked_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NotificationEmail)
                    .HasColumnName("notification_email")
                    .HasColumnType("character varying");

                entity.Property(e => e.NotifiedOfOwnActivity).HasColumnName("notified_of_own_activity");

                entity.Property(e => e.Organization)
                    .HasColumnName("organization")
                    .HasColumnType("character varying");

                entity.Property(e => e.OtpBackupCodes).HasColumnName("otp_backup_codes");

                entity.Property(e => e.OtpGracePeriodStartedAt).HasColumnName("otp_grace_period_started_at");

                entity.Property(e => e.OtpRequiredForLogin).HasColumnName("otp_required_for_login");

                entity.Property(e => e.PasswordAutomaticallySet)
                    .HasColumnName("password_automatically_set")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PasswordExpiresAt).HasColumnName("password_expires_at");

                entity.Property(e => e.PreferredLanguage)
                    .HasColumnName("preferred_language")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectView)
                    .HasColumnName("project_view")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProjectsLimit).HasColumnName("projects_limit");

                entity.Property(e => e.PublicEmail)
                    .IsRequired()
                    .HasColumnName("public_email")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.RememberCreatedAt).HasColumnName("remember_created_at");

                entity.Property(e => e.RequireTwoFactorAuthenticationFromGroup).HasColumnName("require_two_factor_authentication_from_group");

                entity.Property(e => e.ResetPasswordSentAt).HasColumnName("reset_password_sent_at");

                entity.Property(e => e.ResetPasswordToken)
                    .HasColumnName("reset_password_token")
                    .HasMaxLength(255);

                entity.Property(e => e.RssToken)
                    .HasColumnName("rss_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.SignInCount)
                    .HasColumnName("sign_in_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Skype)
                    .IsRequired()
                    .HasColumnName("skype")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255);

                entity.Property(e => e.ThemeId).HasColumnName("theme_id");

                entity.Property(e => e.Twitter)
                    .IsRequired()
                    .HasColumnName("twitter")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.TwoFactorGracePeriod)
                    .HasColumnName("two_factor_grace_period")
                    .HasDefaultValueSql("48");

                entity.Property(e => e.UnconfirmedEmail)
                    .HasColumnName("unconfirmed_email")
                    .HasMaxLength(255);

                entity.Property(e => e.UnlockToken)
                    .HasColumnName("unlock_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);

                entity.Property(e => e.WebsiteUrl)
                    .IsRequired()
                    .HasColumnName("website_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<UsersStarProjects>(entity =>
            {
                entity.ToTable("users_star_projects");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_users_star_projects_on_project_id");

                entity.HasIndex(e => new { e.UserId, e.ProjectId })
                    .HasName("index_users_star_projects_on_user_id_and_project_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.UsersStarProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_22cd27ddfc");
            });

            modelBuilder.Entity<UserSyncedAttributesMetadata>(entity =>
            {
                entity.ToTable("user_synced_attributes_metadata");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_user_synced_attributes_metadata_on_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmailSynced)
                    .HasColumnName("email_synced")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.LocationSynced)
                    .HasColumnName("location_synced")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.NameSynced)
                    .HasColumnName("name_synced")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserSyncedAttributesMetadata)
                    .HasForeignKey<UserSyncedAttributesMetadata>(d => d.UserId)
                    .HasConstraintName("fk_rails_0f4aa0981f");
            });

            modelBuilder.Entity<WebHookLogs>(entity =>
            {
                entity.ToTable("web_hook_logs");

                entity.HasIndex(e => e.WebHookId)
                    .HasName("index_web_hook_logs_on_web_hook_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ExecutionDuration).HasColumnName("execution_duration");

                entity.Property(e => e.InternalErrorMessage)
                    .HasColumnName("internal_error_message")
                    .HasColumnType("character varying");

                entity.Property(e => e.RequestData).HasColumnName("request_data");

                entity.Property(e => e.RequestHeaders).HasColumnName("request_headers");

                entity.Property(e => e.ResponseBody).HasColumnName("response_body");

                entity.Property(e => e.ResponseHeaders).HasColumnName("response_headers");

                entity.Property(e => e.ResponseStatus)
                    .HasColumnName("response_status")
                    .HasColumnType("character varying");

                entity.Property(e => e.Trigger)
                    .HasColumnName("trigger")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("character varying");

                entity.Property(e => e.WebHookId).HasColumnName("web_hook_id");

                entity.HasOne(d => d.WebHook)
                    .WithMany(p => p.WebHookLogs)
                    .HasForeignKey(d => d.WebHookId)
                    .HasConstraintName("fk_rails_666826e111");
            });

            modelBuilder.Entity<WebHooks>(entity =>
            {
                entity.ToTable("web_hooks");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("index_web_hooks_on_project_id");

                entity.HasIndex(e => e.Type)
                    .HasName("index_web_hooks_on_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConfidentialIssuesEvents).HasColumnName("confidential_issues_events");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EnableSslVerification)
                    .HasColumnName("enable_ssl_verification")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.IssuesEvents).HasColumnName("issues_events");

                entity.Property(e => e.JobEvents).HasColumnName("job_events");

                entity.Property(e => e.MergeRequestsEvents).HasColumnName("merge_requests_events");

                entity.Property(e => e.NoteEvents).HasColumnName("note_events");

                entity.Property(e => e.PipelineEvents).HasColumnName("pipeline_events");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.PushEvents)
                    .IsRequired()
                    .HasColumnName("push_events")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.RepositoryUpdateEvents).HasColumnName("repository_update_events");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.TagPushEvents)
                    .HasColumnName("tag_push_events")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'ProjectHook'::character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(2000);

                entity.Property(e => e.WikiPageEvents).HasColumnName("wiki_page_events");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.WebHooks)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_0c8ca6d9d1");
            });
        }
    }
}
