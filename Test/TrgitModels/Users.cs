using System;
using System.Collections.Generic;

namespace Test.TrgitModels
{
    public partial class Users
    {
        public Users()
        {
            CiPipelineSchedules = new HashSet<CiPipelineSchedules>();
            CiTriggers = new HashSet<CiTriggers>();
            Clusters = new HashSet<Clusters>();
            Events = new HashSet<Events>();
            GcpClusters = new HashSet<GcpClusters>();
            GpgKeys = new HashSet<GpgKeys>();
            IssuesAuthor = new HashSet<Issues>();
            IssuesUpdatedBy = new HashSet<Issues>();
            LfsFileLocks = new HashSet<LfsFileLocks>();
            Members = new HashSet<Members>();
            MergeRequestMetricsLatestClosedBy = new HashSet<MergeRequestMetrics>();
            MergeRequestMetricsMergedBy = new HashSet<MergeRequestMetrics>();
            MergeRequestsAssignee = new HashSet<MergeRequests>();
            MergeRequestsAuthor = new HashSet<MergeRequests>();
            MergeRequestsMergeUser = new HashSet<MergeRequests>();
            MergeRequestsUpdatedBy = new HashSet<MergeRequests>();
            PersonalAccessTokens = new HashSet<PersonalAccessTokens>();
            ProtectedTagCreateAccessLevels = new HashSet<ProtectedTagCreateAccessLevels>();
            TodosAuthor = new HashSet<Todos>();
            TodosUser = new HashSet<Todos>();
            U2fRegistrations = new HashSet<U2fRegistrations>();
            UserCallouts = new HashSet<UserCallouts>();
            UserCustomAttributes = new HashSet<UserCustomAttributes>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string EncryptedPassword { get; set; }
        public string ResetPasswordToken { get; set; }
        public DateTime? ResetPasswordSentAt { get; set; }
        public DateTime? RememberCreatedAt { get; set; }
        public int? SignInCount { get; set; }
        public DateTime? CurrentSignInAt { get; set; }
        public DateTime? LastSignInAt { get; set; }
        public string CurrentSignInIp { get; set; }
        public string LastSignInIp { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Name { get; set; }
        public bool Admin { get; set; }
        public int ProjectsLimit { get; set; }
        public string Skype { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Bio { get; set; }
        public int? FailedAttempts { get; set; }
        public DateTime? LockedAt { get; set; }
        public string Username { get; set; }
        public bool? CanCreateGroup { get; set; }
        public bool? CanCreateTeam { get; set; }
        public string State { get; set; }
        public int ColorSchemeId { get; set; }
        public DateTime? PasswordExpiresAt { get; set; }
        public int? CreatedById { get; set; }
        public string Avatar { get; set; }
        public string ConfirmationToken { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public DateTime? ConfirmationSentAt { get; set; }
        public string UnconfirmedEmail { get; set; }
        public bool? HideNoSshKey { get; set; }
        public string WebsiteUrl { get; set; }
        public DateTime? LastCredentialCheckAt { get; set; }
        public string NotificationEmail { get; set; }
        public bool? HideNoPassword { get; set; }
        public bool? PasswordAutomaticallySet { get; set; }
        public string Location { get; set; }
        public string EncryptedOtpSecret { get; set; }
        public string EncryptedOtpSecretIv { get; set; }
        public string EncryptedOtpSecretSalt { get; set; }
        public bool OtpRequiredForLogin { get; set; }
        public string OtpBackupCodes { get; set; }
        public string PublicEmail { get; set; }
        public int? Dashboard { get; set; }
        public int? ProjectView { get; set; }
        public int? ConsumedTimestep { get; set; }
        public int? Layout { get; set; }
        public bool? HideProjectLimit { get; set; }
        public string UnlockToken { get; set; }
        public DateTime? OtpGracePeriodStartedAt { get; set; }
        public bool? External { get; set; }
        public string Organization { get; set; }
        public string IncomingEmailToken { get; set; }
        public bool RequireTwoFactorAuthenticationFromGroup { get; set; }
        public int TwoFactorGracePeriod { get; set; }
        public bool? Ghost { get; set; }
        public DateTime? LastActivityOn { get; set; }
        public bool? NotifiedOfOwnActivity { get; set; }
        public string PreferredLanguage { get; set; }
        public string RssToken { get; set; }
        public short? ThemeId { get; set; }

        public UserSyncedAttributesMetadata UserSyncedAttributesMetadata { get; set; }
        public ICollection<CiPipelineSchedules> CiPipelineSchedules { get; set; }
        public ICollection<CiTriggers> CiTriggers { get; set; }
        public ICollection<Clusters> Clusters { get; set; }
        public ICollection<Events> Events { get; set; }
        public ICollection<GcpClusters> GcpClusters { get; set; }
        public ICollection<GpgKeys> GpgKeys { get; set; }
        public ICollection<Issues> IssuesAuthor { get; set; }
        public ICollection<Issues> IssuesUpdatedBy { get; set; }
        public ICollection<LfsFileLocks> LfsFileLocks { get; set; }
        public ICollection<Members> Members { get; set; }
        public ICollection<MergeRequestMetrics> MergeRequestMetricsLatestClosedBy { get; set; }
        public ICollection<MergeRequestMetrics> MergeRequestMetricsMergedBy { get; set; }
        public ICollection<MergeRequests> MergeRequestsAssignee { get; set; }
        public ICollection<MergeRequests> MergeRequestsAuthor { get; set; }
        public ICollection<MergeRequests> MergeRequestsMergeUser { get; set; }
        public ICollection<MergeRequests> MergeRequestsUpdatedBy { get; set; }
        public ICollection<PersonalAccessTokens> PersonalAccessTokens { get; set; }
        public ICollection<ProtectedTagCreateAccessLevels> ProtectedTagCreateAccessLevels { get; set; }
        public ICollection<Todos> TodosAuthor { get; set; }
        public ICollection<Todos> TodosUser { get; set; }
        public ICollection<U2fRegistrations> U2fRegistrations { get; set; }
        public ICollection<UserCallouts> UserCallouts { get; set; }
        public ICollection<UserCustomAttributes> UserCustomAttributes { get; set; }
    }
}
