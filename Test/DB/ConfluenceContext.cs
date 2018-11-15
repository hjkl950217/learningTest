using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Test.ConfluenceModels;

namespace Test.DB
{
    public partial class ConfluenceContext : DbContext
    {
        public ConfluenceContext()
        {
        }

        public ConfluenceContext(DbContextOptions<ConfluenceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ao05769aVisitEntity> Ao05769aVisitEntity { get; set; }
        public virtual DbSet<Ao187cccSidebarLink> Ao187cccSidebarLink { get; set; }
        public virtual DbSet<Ao21d670WhitelistRules> Ao21d670WhitelistRules { get; set; }
        public virtual DbSet<Ao21f425MessageAo> Ao21f425MessageAo { get; set; }
        public virtual DbSet<Ao21f425MessageMappingAo> Ao21f425MessageMappingAo { get; set; }
        public virtual DbSet<Ao21f425UserPropertyAo> Ao21f425UserPropertyAo { get; set; }
        public virtual DbSet<Ao26db7fEntitiesToRoomCfg> Ao26db7fEntitiesToRoomCfg { get; set; }
        public virtual DbSet<Ao26db7fEntitiesToRooms> Ao26db7fEntitiesToRooms { get; set; }
        public virtual DbSet<Ao2f1435HealthCheckStatus> Ao2f1435HealthCheckStatus { get; set; }
        public virtual DbSet<Ao2f1435Properties> Ao2f1435Properties { get; set; }
        public virtual DbSet<Ao2f1435ReadNotifications> Ao2f1435ReadNotifications { get; set; }
        public virtual DbSet<Ao38321bCustomContentLink> Ao38321bCustomContentLink { get; set; }
        public virtual DbSet<Ao429490Response> Ao429490Response { get; set; }
        public virtual DbSet<Ao429490Settings> Ao429490Settings { get; set; }
        public virtual DbSet<Ao42e351HealthCheckEntity> Ao42e351HealthCheckEntity { get; set; }
        public virtual DbSet<Ao4dc94aUserSettingKeeper> Ao4dc94aUserSettingKeeper { get; set; }
        public virtual DbSet<Ao54c900ContentBlueprintAo> Ao54c900ContentBlueprintAo { get; set; }
        public virtual DbSet<Ao54c900CTemplateRef> Ao54c900CTemplateRef { get; set; }
        public virtual DbSet<Ao54c900SpaceBlueprintAo> Ao54c900SpaceBlueprintAo { get; set; }
        public virtual DbSet<Ao563aeeActivityEntity> Ao563aeeActivityEntity { get; set; }
        public virtual DbSet<Ao563aeeActorEntity> Ao563aeeActorEntity { get; set; }
        public virtual DbSet<Ao563aeeMediaLinkEntity> Ao563aeeMediaLinkEntity { get; set; }
        public virtual DbSet<Ao563aeeObjectEntity> Ao563aeeObjectEntity { get; set; }
        public virtual DbSet<Ao563aeeTargetEntity> Ao563aeeTargetEntity { get; set; }
        public virtual DbSet<Ao57d81eDbuser> Ao57d81eDbuser { get; set; }
        public virtual DbSet<Ao57d81eGoogleUser> Ao57d81eGoogleUser { get; set; }
        public virtual DbSet<Ao5f3884FeatureDiscovery> Ao5f3884FeatureDiscovery { get; set; }
        public virtual DbSet<Ao5fb9d7AohipChatLink> Ao5fb9d7AohipChatLink { get; set; }
        public virtual DbSet<Ao5fb9d7AohipChatUser> Ao5fb9d7AohipChatUser { get; set; }
        public virtual DbSet<Ao6384abDiscovered> Ao6384abDiscovered { get; set; }
        public virtual DbSet<Ao6384abFeatureMetadataAo> Ao6384abFeatureMetadataAo { get; set; }
        public virtual DbSet<Ao6d89bfDefLibForGroup> Ao6d89bfDefLibForGroup { get; set; }
        public virtual DbSet<Ao6d89bfDrawioConfiguration> Ao6d89bfDrawioConfiguration { get; set; }
        public virtual DbSet<Ao6d89bfDrawioDraft> Ao6d89bfDrawioDraft { get; set; }
        public virtual DbSet<Ao6d89bfDrawioLibrary> Ao6d89bfDrawioLibrary { get; set; }
        public virtual DbSet<Ao7cde43Event> Ao7cde43Event { get; set; }
        public virtual DbSet<Ao7cde43FilterParam> Ao7cde43FilterParam { get; set; }
        public virtual DbSet<Ao7cde43Notification> Ao7cde43Notification { get; set; }
        public virtual DbSet<Ao7cde43NotificationScheme> Ao7cde43NotificationScheme { get; set; }
        public virtual DbSet<Ao7cde43Recipient> Ao7cde43Recipient { get; set; }
        public virtual DbSet<Ao7cde43ServerConfig> Ao7cde43ServerConfig { get; set; }
        public virtual DbSet<Ao7cde43ServerParam> Ao7cde43ServerParam { get; set; }
        public virtual DbSet<Ao84467aLpreviewProp> Ao84467aLpreviewProp { get; set; }
        public virtual DbSet<Ao88bb94BatchNotification> Ao88bb94BatchNotification { get; set; }
        public virtual DbSet<Ao92296bAorecentlyViewed> Ao92296bAorecentlyViewed { get; set; }
        public virtual DbSet<Ao9366bfActivity> Ao9366bfActivity { get; set; }
        public virtual DbSet<Ao9366bfAssignee> Ao9366bfAssignee { get; set; }
        public virtual DbSet<Ao9366bfBoard> Ao9366bfBoard { get; set; }
        public virtual DbSet<Ao9366bfCard> Ao9366bfCard { get; set; }
        public virtual DbSet<Ao9366bfCardComment> Ao9366bfCardComment { get; set; }
        public virtual DbSet<Ao9366bfList> Ao9366bfList { get; set; }
        public virtual DbSet<Ao9412a1Aonotification> Ao9412a1Aonotification { get; set; }
        public virtual DbSet<Ao9412a1Aoregistration> Ao9412a1Aoregistration { get; set; }
        public virtual DbSet<Ao9412a1Aotask> Ao9412a1Aotask { get; set; }
        public virtual DbSet<Ao9412a1Aouser> Ao9412a1Aouser { get; set; }
        public virtual DbSet<Ao9412a1UserAppLink> Ao9412a1UserAppLink { get; set; }
        public virtual DbSet<AoA0b856WebHookListenerAo> AoA0b856WebHookListenerAo { get; set; }
        public virtual DbSet<AoA3f2efAdminMessages> AoA3f2efAdminMessages { get; set; }
        public virtual DbSet<AoA3f2efBlogColumns> AoA3f2efBlogColumns { get; set; }
        public virtual DbSet<AoA3f2efCacheSettings> AoA3f2efCacheSettings { get; set; }
        public virtual DbSet<AoA3f2efCategories> AoA3f2efCategories { get; set; }
        public virtual DbSet<AoA3f2efCategorycache> AoA3f2efCategorycache { get; set; }
        public virtual DbSet<AoA3f2efCategoryChildren> AoA3f2efCategoryChildren { get; set; }
        public virtual DbSet<AoA3f2efCustomColumns> AoA3f2efCustomColumns { get; set; }
        public virtual DbSet<AoA3f2efFooter> AoA3f2efFooter { get; set; }
        public virtual DbSet<AoA3f2efLayoutBoard> AoA3f2efLayoutBoard { get; set; }
        public virtual DbSet<AoA3f2efLayoutItem> AoA3f2efLayoutItem { get; set; }
        public virtual DbSet<AoA3f2efLayoutKey> AoA3f2efLayoutKey { get; set; }
        public virtual DbSet<AoA3f2efLayoutSection> AoA3f2efLayoutSection { get; set; }
        public virtual DbSet<AoA3f2efLayoutVersion> AoA3f2efLayoutVersion { get; set; }
        public virtual DbSet<AoA3f2efLinkColumns> AoA3f2efLinkColumns { get; set; }
        public virtual DbSet<AoA3f2efLinks> AoA3f2efLinks { get; set; }
        public virtual DbSet<AoA3f2efLogoColumns> AoA3f2efLogoColumns { get; set; }
        public virtual DbSet<AoA3f2efPermission> AoA3f2efPermission { get; set; }
        public virtual DbSet<AoA3f2efSpaceSettings> AoA3f2efSpaceSettings { get; set; }
        public virtual DbSet<AoA3f2efSpaceTypes> AoA3f2efSpaceTypes { get; set; }
        public virtual DbSet<AoA3f2efUserCategories> AoA3f2efUserCategories { get; set; }
        public virtual DbSet<AoA3f2efUserRoles> AoA3f2efUserRoles { get; set; }
        public virtual DbSet<AoA3f2efViewdesigns> AoA3f2efViewdesigns { get; set; }
        public virtual DbSet<AoA8fb76ButtonStyles> AoA8fb76ButtonStyles { get; set; }
        public virtual DbSet<AoA8fb76TextboxStyles> AoA8fb76TextboxStyles { get; set; }
        public virtual DbSet<AoBaf3aaAoinlineTask> AoBaf3aaAoinlineTask { get; set; }
        public virtual DbSet<AoDc98aeAohelpTip> AoDc98aeAohelpTip { get; set; }
        public virtual DbSet<AoEd669cSeenAssertions> AoEd669cSeenAssertions { get; set; }
        public virtual DbSet<Attachmentdata> Attachmentdata { get; set; }
        public virtual DbSet<AttachmentsBackup> AttachmentsBackup { get; set; }
        public virtual DbSet<AuditAffectedObject> AuditAffectedObject { get; set; }
        public virtual DbSet<AuditChangedValue> AuditChangedValue { get; set; }
        public virtual DbSet<Auditrecord> Auditrecord { get; set; }
        public virtual DbSet<Bandana> Bandana { get; set; }
        public virtual DbSet<Bodycontent> Bodycontent { get; set; }
        public virtual DbSet<Clustersafety> Clustersafety { get; set; }
        public virtual DbSet<Confancestors> Confancestors { get; set; }
        public virtual DbSet<Confversion> Confversion { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<ContentLabel> ContentLabel { get; set; }
        public virtual DbSet<ContentPerm> ContentPerm { get; set; }
        public virtual DbSet<ContentPermSet> ContentPermSet { get; set; }
        public virtual DbSet<Contentproperties> Contentproperties { get; set; }
        public virtual DbSet<ContentRelation> ContentRelation { get; set; }
        public virtual DbSet<CwdAppDirGroupMapping> CwdAppDirGroupMapping { get; set; }
        public virtual DbSet<CwdAppDirMapping> CwdAppDirMapping { get; set; }
        public virtual DbSet<CwdAppDirOperation> CwdAppDirOperation { get; set; }
        public virtual DbSet<CwdApplication> CwdApplication { get; set; }
        public virtual DbSet<CwdApplicationAddress> CwdApplicationAddress { get; set; }
        public virtual DbSet<CwdApplicationAttribute> CwdApplicationAttribute { get; set; }
        public virtual DbSet<CwdDirectory> CwdDirectory { get; set; }
        public virtual DbSet<CwdDirectoryAttribute> CwdDirectoryAttribute { get; set; }
        public virtual DbSet<CwdDirectoryOperation> CwdDirectoryOperation { get; set; }
        public virtual DbSet<CwdGroup> CwdGroup { get; set; }
        public virtual DbSet<CwdGroupAttribute> CwdGroupAttribute { get; set; }
        public virtual DbSet<CwdMembership> CwdMembership { get; set; }
        public virtual DbSet<CwdUser> CwdUser { get; set; }
        public virtual DbSet<CwdUserAttribute> CwdUserAttribute { get; set; }
        public virtual DbSet<CwdUserCredentialRecord> CwdUserCredentialRecord { get; set; }
        public virtual DbSet<Decorator> Decorator { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<ExternalEntities> ExternalEntities { get; set; }
        public virtual DbSet<ExternalMembers> ExternalMembers { get; set; }
        public virtual DbSet<Extrnlnks> Extrnlnks { get; set; }
        public virtual DbSet<FollowConnections> FollowConnections { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Imagedetails> Imagedetails { get; set; }
        public virtual DbSet<Indexqueueentries> Indexqueueentries { get; set; }
        public virtual DbSet<Journalentry> Journalentry { get; set; }
        public virtual DbSet<Keystore> Keystore { get; set; }
        public virtual DbSet<Label> Label { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<Links> Links { get; set; }
        public virtual DbSet<LocalMembers> LocalMembers { get; set; }
        public virtual DbSet<Logininfo> Logininfo { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<OsGroup> OsGroup { get; set; }
        public virtual DbSet<OsPropertyentry> OsPropertyentry { get; set; }
        public virtual DbSet<OsUser> OsUser { get; set; }
        public virtual DbSet<OsUserGroup> OsUserGroup { get; set; }
        public virtual DbSet<Pagetemplates> Pagetemplates { get; set; }
        public virtual DbSet<Plugindata> Plugindata { get; set; }
        public virtual DbSet<Remembermetoken> Remembermetoken { get; set; }
        public virtual DbSet<SchedulerClusteredJobs> SchedulerClusteredJobs { get; set; }
        public virtual DbSet<SchedulerRunDetails> SchedulerRunDetails { get; set; }
        public virtual DbSet<Secrets> Secrets { get; set; }
        public virtual DbSet<Snapshots> Snapshots { get; set; }
        public virtual DbSet<Spacepermissions> Spacepermissions { get; set; }
        public virtual DbSet<Spaces> Spaces { get; set; }
        public virtual DbSet<Trackbacklinks> Trackbacklinks { get; set; }
        public virtual DbSet<Trustedapp> Trustedapp { get; set; }
        public virtual DbSet<Trustedapprestriction> Trustedapprestriction { get; set; }
        public virtual DbSet<UsercontentRelation> UsercontentRelation { get; set; }
        public virtual DbSet<UserMapping> UserMapping { get; set; }
        public virtual DbSet<UserRelation> UserRelation { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        // Unable to generate entity type for table 'dbo.hibernate_unique_key'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.16.89.40;database=confluence_hackathon;User id=hackathonDbo;password=hackathonDbo;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ao05769aVisitEntity>(entity =>
            {
                entity.ToTable("AO_05769A_VISIT_ENTITY");

                entity.HasIndex(e => e.ContentId)
                    .HasName("index_ao_05769a_vis87643962");

                entity.HasIndex(e => e.DeviceType)
                    .HasName("index_ao_05769a_vis1562913290");

                entity.HasIndex(e => e.UserKey)
                    .HasName("index_ao_05769a_vis2031696188");

                entity.HasIndex(e => e.VisitTime)
                    .HasName("index_ao_05769a_vis2024215078");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("CONTENT_ID");

                entity.Property(e => e.DeviceType).HasColumnName("DEVICE_TYPE");

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.VisitTime)
                    .HasColumnName("VISIT_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Ao187cccSidebarLink>(entity =>
            {
                entity.ToTable("AO_187CCC_SIDEBAR_LINK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomIconClass)
                    .HasColumnName("CUSTOM_ICON_CLASS")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomTitle)
                    .HasColumnName("CUSTOM_TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.DestPageId).HasColumnName("DEST_PAGE_ID");

                entity.Property(e => e.HardcodedUrl)
                    .HasColumnName("HARDCODED_URL")
                    .HasMaxLength(255);

                entity.Property(e => e.Hidden).HasColumnName("HIDDEN");

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.SpaceKey)
                    .HasColumnName("SPACE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.WebItemKey)
                    .HasColumnName("WEB_ITEM_KEY")
                    .HasMaxLength(255);
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
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");
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

            modelBuilder.Entity<Ao26db7fEntitiesToRoomCfg>(entity =>
            {
                entity.ToTable("AO_26DB7F_ENTITIES_TO_ROOM_CFG");

                entity.HasIndex(e => e.EntityKey)
                    .HasName("index_ao_26db7f_ent1609287474");

                entity.HasIndex(e => e.RoomId)
                    .HasName("index_ao_26db7f_ent1247500752");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EntityKey)
                    .HasColumnName("ENTITY_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.NotifyClient).HasColumnName("NOTIFY_CLIENT");

                entity.Property(e => e.RoomId)
                    .HasColumnName("ROOM_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao26db7fEntitiesToRooms>(entity =>
            {
                entity.ToTable("AO_26DB7F_ENTITIES_TO_ROOMS");

                entity.HasIndex(e => e.EntityKey)
                    .HasName("index_ao_26db7f_ent940053222");

                entity.HasIndex(e => e.RoomId)
                    .HasName("index_ao_26db7f_ent831223480");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EntityKey)
                    .HasColumnName("ENTITY_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.MessageTypeKey)
                    .HasColumnName("MESSAGE_TYPE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.RoomId)
                    .HasColumnName("ROOM_ID")
                    .HasMaxLength(255);
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

            modelBuilder.Entity<Ao429490Response>(entity =>
            {
                entity.ToTable("AO_429490_RESPONSE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer).HasColumnName("ANSWER");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PageId).HasColumnName("PAGE_ID");

                entity.Property(e => e.QuestionId)
                    .IsRequired()
                    .HasColumnName("QUESTION_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SpaceKey)
                    .IsRequired()
                    .HasColumnName("SPACE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.UtmContent)
                    .HasColumnName("UTM_CONTENT")
                    .HasMaxLength(255);

                entity.Property(e => e.UtmMedium)
                    .HasColumnName("UTM_MEDIUM")
                    .HasMaxLength(255);

                entity.Property(e => e.UtmSource)
                    .HasColumnName("UTM_SOURCE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao429490Settings>(entity =>
            {
                entity.ToTable("AO_429490_SETTINGS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Space)
                    .IsRequired()
                    .HasColumnName("SPACE")
                    .HasMaxLength(255);

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<Ao42e351HealthCheckEntity>(entity =>
            {
                entity.ToTable("AO_42E351_HEALTH_CHECK_ENTITY");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Ao4dc94aUserSettingKeeper>(entity =>
            {
                entity.ToTable("AO_4DC94A_USER_SETTING_KEEPER");

                entity.HasIndex(e => e.UserName)
                    .HasName("index_ao_4dc94a_use804191565");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Enable).HasColumnName("ENABLE");

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao54c900ContentBlueprintAo>(entity =>
            {
                entity.ToTable("AO_54C900_CONTENT_BLUEPRINT_AO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateResult)
                    .HasColumnName("CREATE_RESULT")
                    .HasMaxLength(255);

                entity.Property(e => e.HowToUseTemplate)
                    .HasColumnName("HOW_TO_USE_TEMPLATE")
                    .HasMaxLength(255);

                entity.Property(e => e.IndexDisabled).HasColumnName("INDEX_DISABLED");

                entity.Property(e => e.IndexKey)
                    .HasColumnName("INDEX_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.IndexTitleI18nKey)
                    .HasColumnName("INDEX_TITLE_I18N_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PluginClone).HasColumnName("PLUGIN_CLONE");

                entity.Property(e => e.PluginModuleKey)
                    .HasColumnName("PLUGIN_MODULE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.SpaceKey)
                    .HasColumnName("SPACE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao54c900CTemplateRef>(entity =>
            {
                entity.ToTable("AO_54C900_C_TEMPLATE_REF");

                entity.HasIndex(e => e.CbIndexParentid)
                    .HasName("index_ao_54c900_c_t667820477");

                entity.HasIndex(e => e.CbParentid)
                    .HasName("index_ao_54c900_c_t757546442");

                entity.HasIndex(e => e.ParentId)
                    .HasName("index_ao_54c900_c_t852152353");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CbIndexParentid).HasColumnName("CB_INDEX_PARENTID");

                entity.Property(e => e.CbParentid).HasColumnName("CB_PARENTID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.PluginClone).HasColumnName("PLUGIN_CLONE");

                entity.Property(e => e.PluginModuleKey)
                    .HasColumnName("PLUGIN_MODULE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.TemplateId).HasColumnName("TEMPLATE_ID");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CbIndexParent)
                    .WithMany(p => p.Ao54c900CTemplateRefCbIndexParent)
                    .HasForeignKey(d => d.CbIndexParentid)
                    .HasConstraintName("fk_ao_54c900_c_template_ref_cb_index_parentid");

                entity.HasOne(d => d.CbParent)
                    .WithMany(p => p.Ao54c900CTemplateRefCbParent)
                    .HasForeignKey(d => d.CbParentid)
                    .HasConstraintName("fk_ao_54c900_c_template_ref_cb_parentid");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fk_ao_54c900_c_template_ref_parent_id");
            });

            modelBuilder.Entity<Ao54c900SpaceBlueprintAo>(entity =>
            {
                entity.ToTable("AO_54C900_SPACE_BLUEPRINT_AO");

                entity.HasIndex(e => e.HomePageId)
                    .HasName("index_ao_54c900_spa357134289");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.HomePageId).HasColumnName("HOME_PAGE_ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PluginClone).HasColumnName("PLUGIN_CLONE");

                entity.Property(e => e.PluginModuleKey)
                    .HasColumnName("PLUGIN_MODULE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.PromotedBps)
                    .HasColumnName("PROMOTED_BPS")
                    .HasColumnType("ntext");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255);

                entity.HasOne(d => d.HomePage)
                    .WithMany(p => p.Ao54c900SpaceBlueprintAo)
                    .HasForeignKey(d => d.HomePageId)
                    .HasConstraintName("fk_ao_54c900_space_blueprint_ao_home_page_id");
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
                    .HasMaxLength(255);

                entity.Property(e => e.GeneratorId)
                    .HasColumnName("GENERATOR_ID")
                    .HasMaxLength(450);

                entity.Property(e => e.IconId).HasColumnName("ICON_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(450);

                entity.Property(e => e.IssueKey)
                    .HasColumnName("ISSUE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectId).HasColumnName("OBJECT_ID");

                entity.Property(e => e.Poster)
                    .HasColumnName("POSTER")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectKey)
                    .HasColumnName("PROJECT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Published)
                    .HasColumnName("PUBLISHED")
                    .HasColumnType("datetime");

                entity.Property(e => e.TargetId).HasColumnName("TARGET_ID");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(450);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);

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
                    .HasMaxLength(255);

                entity.Property(e => e.ProfilePageUri)
                    .HasColumnName("PROFILE_PAGE_URI")
                    .HasMaxLength(450);

                entity.Property(e => e.ProfilePictureUri)
                    .HasColumnName("PROFILE_PICTURE_URI")
                    .HasMaxLength(450);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
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
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("DISPLAY_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ImageId).HasColumnName("IMAGE_ID");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasMaxLength(450);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(450);

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasMaxLength(255);

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
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("DISPLAY_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ImageId).HasColumnName("IMAGE_ID");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasMaxLength(450);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(450);

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(450);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Ao563aeeTargetEntity)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("fk_ao_563aee_target_entity_image_id");
            });

            modelBuilder.Entity<Ao57d81eDbuser>(entity =>
            {
                entity.ToTable("AO_57D81E_DBUSER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao57d81eGoogleUser>(entity =>
            {
                entity.ToTable("AO_57D81E_GOOGLE_USER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("ACCESS_TOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.RedirectUrl)
                    .HasColumnName("REDIRECT_URL")
                    .HasMaxLength(255);

                entity.Property(e => e.RefreshToken)
                    .HasColumnName("REFRESH_TOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.SecretKey)
                    .HasColumnName("SECRET_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao5f3884FeatureDiscovery>(entity =>
            {
                entity.ToTable("AO_5F3884_FEATURE_DISCOVERY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Discovered).HasColumnName("DISCOVERED");

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
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

            modelBuilder.Entity<Ao6384abDiscovered>(entity =>
            {
                entity.ToTable("AO_6384AB_DISCOVERED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.PluginKey)
                    .HasColumnName("PLUGIN_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao6384abFeatureMetadataAo>(entity =>
            {
                entity.ToTable("AO_6384AB_FEATURE_METADATA_AO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Context)
                    .HasColumnName("CONTEXT")
                    .HasMaxLength(255);

                entity.Property(e => e.InstallationDate)
                    .HasColumnName("INSTALLATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao6d89bfDefLibForGroup>(entity =>
            {
                entity.ToTable("AO_6D89BF_DEF_LIB_FOR_GROUP");

                entity.HasIndex(e => e.LibraryId)
                    .HasName("index_ao_6d89bf_def1470471249");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LibraryId).HasColumnName("LIBRARY_ID");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.Ao6d89bfDefLibForGroup)
                    .HasForeignKey(d => d.LibraryId)
                    .HasConstraintName("fk_ao_6d89bf_def_lib_for_group_library_id");
            });

            modelBuilder.Entity<Ao6d89bfDrawioConfiguration>(entity =>
            {
                entity.ToTable("AO_6D89BF_DRAWIO_CONFIGURATION");

                entity.HasIndex(e => e.Name)
                    .HasName("U_AO_6D89BF_DRAWIO_868959772")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.ResampleThreshold).HasColumnName("RESAMPLE_THRESHOLD");

                entity.Property(e => e.UseExternalImageService).HasColumnName("USE_EXTERNAL_IMAGE_SERVICE");
            });

            modelBuilder.Entity<Ao6d89bfDrawioDraft>(entity =>
            {
                entity.ToTable("AO_6D89BF_DRAWIO_DRAFT");

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

                entity.Property(e => e.Xml)
                    .HasColumnName("XML")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Ao6d89bfDrawioLibrary>(entity =>
            {
                entity.ToTable("AO_6D89BF_DRAWIO_LIBRARY");

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
                    .HasColumnName("XML")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Ao7cde43Event>(entity =>
            {
                entity.ToTable("AO_7CDE43_EVENT");

                entity.HasIndex(e => e.NotificationId)
                    .HasName("index_ao_7cde43_eve1433596955");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventKey)
                    .HasColumnName("EVENT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.NotificationId).HasColumnName("NOTIFICATION_ID");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.Ao7cde43Event)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("fk_ao_7cde43_event_notification_id");
            });

            modelBuilder.Entity<Ao7cde43FilterParam>(entity =>
            {
                entity.ToTable("AO_7CDE43_FILTER_PARAM");

                entity.HasIndex(e => e.NotificationId)
                    .HasName("index_ao_7cde43_fil1140550715");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NotificationId).HasColumnName("NOTIFICATION_ID");

                entity.Property(e => e.ParamKey)
                    .HasColumnName("PARAM_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ParamValue)
                    .HasColumnName("PARAM_VALUE")
                    .HasColumnType("ntext");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.Ao7cde43FilterParam)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("fk_ao_7cde43_filter_param_notification_id");
            });

            modelBuilder.Entity<Ao7cde43Notification>(entity =>
            {
                entity.ToTable("AO_7CDE43_NOTIFICATION");

                entity.HasIndex(e => e.NotificationSchemeId)
                    .HasName("index_ao_7cde43_not7362182");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NotificationSchemeId).HasColumnName("NOTIFICATION_SCHEME_ID");

                entity.HasOne(d => d.NotificationScheme)
                    .WithMany(p => p.Ao7cde43Notification)
                    .HasForeignKey(d => d.NotificationSchemeId)
                    .HasConstraintName("fk_ao_7cde43_notification_notification_scheme_id");
            });

            modelBuilder.Entity<Ao7cde43NotificationScheme>(entity =>
            {
                entity.ToTable("AO_7CDE43_NOTIFICATION_SCHEME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.SchemeName)
                    .HasColumnName("SCHEME_NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao7cde43Recipient>(entity =>
            {
                entity.ToTable("AO_7CDE43_RECIPIENT");

                entity.HasIndex(e => e.NotificationId)
                    .HasName("index_ao_7cde43_rec1271577318");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Individual).HasColumnName("INDIVIDUAL");

                entity.Property(e => e.NotificationId).HasColumnName("NOTIFICATION_ID");

                entity.Property(e => e.ParamDisplay)
                    .HasColumnName("PARAM_DISPLAY")
                    .HasColumnType("ntext");

                entity.Property(e => e.ParamValue)
                    .HasColumnName("PARAM_VALUE")
                    .HasColumnType("ntext");

                entity.Property(e => e.ServerId).HasColumnName("SERVER_ID");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.Ao7cde43Recipient)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("fk_ao_7cde43_recipient_notification_id");
            });

            modelBuilder.Entity<Ao7cde43ServerConfig>(entity =>
            {
                entity.ToTable("AO_7CDE43_SERVER_CONFIG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomTemplatePath)
                    .HasColumnName("CUSTOM_TEMPLATE_PATH")
                    .HasColumnType("ntext");

                entity.Property(e => e.DefaultUserIdTemplate)
                    .HasColumnName("DEFAULT_USER_ID_TEMPLATE")
                    .HasMaxLength(255);

                entity.Property(e => e.EnabledForAllUsers).HasColumnName("ENABLED_FOR_ALL_USERS");

                entity.Property(e => e.GroupsWithAccess)
                    .HasColumnName("GROUPS_WITH_ACCESS")
                    .HasColumnType("ntext");

                entity.Property(e => e.NotificationMediumKey)
                    .HasColumnName("NOTIFICATION_MEDIUM_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ServerName)
                    .HasColumnName("SERVER_NAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao7cde43ServerParam>(entity =>
            {
                entity.ToTable("AO_7CDE43_SERVER_PARAM");

                entity.HasIndex(e => e.ServerConfigId)
                    .HasName("index_ao_7cde43_ser828034299");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParamKey)
                    .HasColumnName("PARAM_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ParamValue)
                    .HasColumnName("PARAM_VALUE")
                    .HasColumnType("ntext");

                entity.Property(e => e.ServerConfigId).HasColumnName("SERVER_CONFIG_ID");

                entity.HasOne(d => d.ServerConfig)
                    .WithMany(p => p.Ao7cde43ServerParam)
                    .HasForeignKey(d => d.ServerConfigId)
                    .HasConstraintName("fk_ao_7cde43_server_param_server_config_id");
            });

            modelBuilder.Entity<Ao84467aLpreviewProp>(entity =>
            {
                entity.ToTable("AO_84467A_LPREVIEW_PROP");

                entity.HasIndex(e => e.KeyProperty)
                    .HasName("U_AO_84467A_LPREVIE1650003426")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.KeyProperty)
                    .IsRequired()
                    .HasColumnName("KEY_PROPERTY")
                    .HasMaxLength(255);

                entity.Property(e => e.LastModDate)
                    .HasColumnName("LAST_MOD_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastModifier)
                    .IsRequired()
                    .HasColumnName("LAST_MODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Ao88bb94BatchNotification>(entity =>
            {
                entity.ToTable("AO_88BB94_BATCH_NOTIFICATION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchingColumn)
                    .IsRequired()
                    .HasColumnName("BATCHING_COLUMN")
                    .HasMaxLength(255);

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasColumnName("CONTENT_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.NotificationKey)
                    .IsRequired()
                    .HasColumnName("NOTIFICATION_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnName("PAYLOAD")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Ao92296bAorecentlyViewed>(entity =>
            {
                entity.ToTable("AO_92296B_AORECENTLY_VIEWED");

                entity.HasIndex(e => e.ContentId)
                    .HasName("index_ao_92296b_aor1216492770");

                entity.HasIndex(e => e.ContentType)
                    .HasName("index_ao_92296b_aor818798913");

                entity.HasIndex(e => e.LastViewDate)
                    .HasName("index_ao_92296b_aor205355936");

                entity.HasIndex(e => e.SpaceKey)
                    .HasName("index_ao_92296b_aor1615591099");

                entity.HasIndex(e => e.UserKey)
                    .HasName("index_ao_92296b_aor426054036");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("CONTENT_ID");

                entity.Property(e => e.ContentType)
                    .HasColumnName("CONTENT_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.LastViewDate)
                    .HasColumnName("LAST_VIEW_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpaceKey)
                    .HasColumnName("SPACE_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao9366bfActivity>(entity =>
            {
                entity.ToTable("AO_9366BF_ACTIVITY");

                entity.HasIndex(e => e.BoardId)
                    .HasName("index_ao_9366bf_act285128601");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActorId)
                    .HasColumnName("ACTOR_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BoardId).HasColumnName("BOARD_ID");

                entity.Property(e => e.Created).HasColumnName("CREATED");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Updated).HasColumnName("UPDATED");

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.Ao9366bfActivity)
                    .HasForeignKey(d => d.BoardId)
                    .HasConstraintName("fk_ao_9366bf_activity_board_id");
            });

            modelBuilder.Entity<Ao9366bfAssignee>(entity =>
            {
                entity.ToTable("AO_9366BF_ASSIGNEE");

                entity.HasIndex(e => e.CardId)
                    .HasName("index_ao_9366bf_ass1431238217");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId).HasColumnName("CARD_ID");

                entity.Property(e => e.Created).HasColumnName("CREATED");

                entity.Property(e => e.Updated).HasColumnName("UPDATED");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Ao9366bfAssignee)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("fk_ao_9366bf_assignee_card_id");
            });

            modelBuilder.Entity<Ao9366bfBoard>(entity =>
            {
                entity.ToTable("AO_9366BF_BOARD");

                entity.HasIndex(e => e.Name)
                    .HasName("index_ao_9366bf_board_name");

                entity.HasIndex(e => e.PageId)
                    .HasName("index_ao_9366bf_board_page_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnName("CREATED");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PageId).HasColumnName("PAGE_ID");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated).HasColumnName("UPDATED");
            });

            modelBuilder.Entity<Ao9366bfCard>(entity =>
            {
                entity.ToTable("AO_9366BF_CARD");

                entity.HasIndex(e => e.Archived)
                    .HasName("index_ao_9366bf_card_archived");

                entity.HasIndex(e => e.Due)
                    .HasName("index_ao_9366bf_card_due");

                entity.HasIndex(e => e.DueDate)
                    .HasName("index_ao_9366bf_card_due_date");

                entity.HasIndex(e => e.ListId)
                    .HasName("index_ao_9366bf_card_list_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Archived).HasColumnName("ARCHIVED");

                entity.Property(e => e.Created).HasColumnName("CREATED");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Due).HasColumnName("DUE");

                entity.Property(e => e.DueDate).HasColumnName("DUE_DATE");

                entity.Property(e => e.ListId).HasColumnName("LIST_ID");

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Updated).HasColumnName("UPDATED");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.Ao9366bfCard)
                    .HasForeignKey(d => d.ListId)
                    .HasConstraintName("fk_ao_9366bf_card_list_id");
            });

            modelBuilder.Entity<Ao9366bfCardComment>(entity =>
            {
                entity.ToTable("AO_9366BF_CARD_COMMENT");

                entity.HasIndex(e => e.CardId)
                    .HasName("index_ao_9366bf_car1215888232");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorId)
                    .HasColumnName("AUTHOR_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CardId).HasColumnName("CARD_ID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.Created).HasColumnName("CREATED");

                entity.Property(e => e.Updated).HasColumnName("UPDATED");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Ao9366bfCardComment)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("fk_ao_9366bf_card_comment_card_id");
            });

            modelBuilder.Entity<Ao9366bfList>(entity =>
            {
                entity.ToTable("AO_9366BF_LIST");

                entity.HasIndex(e => e.Archived)
                    .HasName("index_ao_9366bf_list_archived");

                entity.HasIndex(e => e.BoardId)
                    .HasName("index_ao_9366bf_list_board_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Archived).HasColumnName("ARCHIVED");

                entity.Property(e => e.BoardId).HasColumnName("BOARD_ID");

                entity.Property(e => e.Created).HasColumnName("CREATED");

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated).HasColumnName("UPDATED");

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.Ao9366bfList)
                    .HasForeignKey(d => d.BoardId)
                    .HasConstraintName("fk_ao_9366bf_list_board_id");
            });

            modelBuilder.Entity<Ao9412a1Aonotification>(entity =>
            {
                entity.ToTable("AO_9412A1_AONOTIFICATION");

                entity.HasIndex(e => e.Created)
                    .HasName("index_ao_9412a1_aon1547032463");

                entity.HasIndex(e => e.GlobalId)
                    .HasName("index_ao_9412a1_aon849931648");

                entity.HasIndex(e => e.User)
                    .HasName("index_ao_9412a1_aon648423710");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action)
                    .HasColumnName("ACTION")
                    .HasMaxLength(255);

                entity.Property(e => e.ActionIconUrl)
                    .HasColumnName("ACTION_ICON_URL")
                    .HasColumnType("ntext");

                entity.Property(e => e.Application)
                    .HasColumnName("APPLICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.ApplicationLinkId)
                    .HasColumnName("APPLICATION_LINK_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Entity)
                    .HasColumnName("ENTITY")
                    .HasMaxLength(255);

                entity.Property(e => e.GlobalId)
                    .HasColumnName("GLOBAL_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupingId)
                    .HasColumnName("GROUPING_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.IconUrl)
                    .HasColumnName("ICON_URL")
                    .HasColumnType("ntext");

                entity.Property(e => e.ItemIconUrl)
                    .HasColumnName("ITEM_ICON_URL")
                    .HasColumnType("ntext");

                entity.Property(e => e.ItemTitle)
                    .HasColumnName("ITEM_TITLE")
                    .HasColumnType("ntext");

                entity.Property(e => e.ItemUrl)
                    .HasColumnName("ITEM_URL")
                    .HasColumnType("ntext");

                entity.Property(e => e.Metadata)
                    .HasColumnName("METADATA")
                    .HasColumnType("ntext");

                entity.Property(e => e.Pinned).HasColumnName("PINNED");

                entity.Property(e => e.Read).HasColumnName("READ");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("ntext");

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao9412a1Aoregistration>(entity =>
            {
                entity.ToTable("AO_9412A1_AOREGISTRATION");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("ntext");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Ao9412a1Aotask>(entity =>
            {
                entity.ToTable("AO_9412A1_AOTASK");

                entity.HasIndex(e => e.GlobalId)
                    .HasName("index_ao_9412a1_aot1465568358");

                entity.HasIndex(e => e.User)
                    .HasName("index_ao_9412a1_aotask_user");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Application)
                    .HasColumnName("APPLICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.ApplicationLinkId)
                    .HasColumnName("APPLICATION_LINK_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.Entity)
                    .HasColumnName("ENTITY")
                    .HasMaxLength(255);

                entity.Property(e => e.GlobalId)
                    .HasColumnName("GLOBAL_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemIconUrl)
                    .HasColumnName("ITEM_ICON_URL")
                    .HasColumnType("ntext");

                entity.Property(e => e.ItemTitle)
                    .HasColumnName("ITEM_TITLE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Metadata)
                    .HasColumnName("METADATA")
                    .HasColumnType("ntext");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("ntext");

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao9412a1Aouser>(entity =>
            {
                entity.ToTable("AO_9412A1_AOUSER");

                entity.HasIndex(e => e.Username)
                    .HasName("U_AO_9412A1_AOUSER_USERNAME")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastReadNotificationId).HasColumnName("LAST_READ_NOTIFICATION_ID");

                entity.Property(e => e.TaskOrdering)
                    .HasColumnName("TASK_ORDERING")
                    .HasColumnType("ntext");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Ao9412a1UserAppLink>(entity =>
            {
                entity.ToTable("AO_9412A1_USER_APP_LINK");

                entity.HasIndex(e => e.ApplicationLinkId)
                    .HasName("index_ao_9412a1_use643533071");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_ao_9412a1_use1222319987");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationLinkId)
                    .HasColumnName("APPLICATION_LINK_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.AuthVerified).HasColumnName("AUTH_VERIFIED");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ao9412a1UserAppLink)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_ao_9412a1_user_app_link_user_id");
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

            modelBuilder.Entity<AoA3f2efAdminMessages>(entity =>
            {
                entity.ToTable("AO_A3F2EF_ADMIN_MESSAGES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Link)
                    .HasColumnName("LINK")
                    .HasColumnType("ntext");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Visible).HasColumnName("VISIBLE");
            });

            modelBuilder.Entity<AoA3f2efBlogColumns>(entity =>
            {
                entity.ToTable("AO_A3F2EF_BLOG_COLUMNS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("ntext");

                entity.Property(e => e.NameKey)
                    .HasColumnName("NAME_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.SelectedMode)
                    .HasColumnName("SELECTED_MODE")
                    .HasMaxLength(255);

                entity.Property(e => e.SpaceTitles)
                    .HasColumnName("SPACE_TITLES")
                    .HasColumnType("ntext");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA3f2efCacheSettings>(entity =>
            {
                entity.ToTable("AO_A3F2EF_CACHE_SETTINGS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CacheCategory).HasColumnName("CACHE_CATEGORY");

                entity.Property(e => e.CacheFooter).HasColumnName("CACHE_FOOTER");

                entity.Property(e => e.CacheGlobalMenu).HasColumnName("CACHE_GLOBAL_MENU");

                entity.Property(e => e.CacheUserCategory).HasColumnName("CACHE_USER_CATEGORY");

                entity.Property(e => e.DoCache).HasColumnName("DO_CACHE");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.LatestCategoryChange).HasColumnName("LATEST_CATEGORY_CHANGE");

                entity.Property(e => e.LatestFooterChange).HasColumnName("LATEST_FOOTER_CHANGE");

                entity.Property(e => e.LatestGlobalMenuChange).HasColumnName("LATEST_GLOBAL_MENU_CHANGE");

                entity.Property(e => e.LatestUserCategoryChange).HasColumnName("LATEST_USER_CATEGORY_CHANGE");
            });

            modelBuilder.Entity<AoA3f2efCategories>(entity =>
            {
                entity.ToTable("AO_A3F2EF_CATEGORIES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomOrder).HasColumnName("CUSTOM_ORDER");

                entity.Property(e => e.Logo)
                    .HasColumnName("LOGO")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("ntext");

                entity.Property(e => e.NameKey)
                    .HasColumnName("NAME_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentKey)
                    .HasColumnName("PARENT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.PermissionAnonymousUsers).HasColumnName("PERMISSION_ANONYMOUS_USERS");

                entity.Property(e => e.PermissionLoggedInUsers).HasColumnName("PERMISSION_LOGGED_IN_USERS");

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Target).HasColumnName("TARGET");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<AoA3f2efCategorycache>(entity =>
            {
                entity.ToTable("AO_A3F2EF_CATEGORYCACHE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdated).HasColumnName("LAST_UPDATED");

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.VisibleKeys)
                    .HasColumnName("VISIBLE_KEYS")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<AoA3f2efCategoryChildren>(entity =>
            {
                entity.ToTable("AO_A3F2EF_CATEGORY_CHILDREN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryKey)
                    .HasColumnName("CATEGORY_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA3f2efCustomColumns>(entity =>
            {
                entity.ToTable("AO_A3F2EF_CUSTOM_COLUMNS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("ntext");

                entity.Property(e => e.NameKey)
                    .HasColumnName("NAME_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA3f2efFooter>(entity =>
            {
                entity.ToTable("AO_A3F2EF_FOOTER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.Disabled).HasColumnName("DISABLED");

                entity.Property(e => e.Theme)
                    .HasColumnName("THEME")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA3f2efLayoutBoard>(entity =>
            {
                entity.ToTable("AO_A3F2EF_LAYOUT_BOARD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentKey)
                    .HasColumnName("CONTENT_KEY")
                    .HasMaxLength(450);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA3f2efLayoutItem>(entity =>
            {
                entity.ToTable("AO_A3F2EF_LAYOUT_ITEM");

                entity.HasIndex(e => e.LayoutSectionId)
                    .HasName("index_ao_a3f2ef_lay1833450665");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.DefaultParameterValue)
                    .HasColumnName("DEFAULT_PARAMETER_VALUE")
                    .HasColumnType("ntext");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ITEM_ID")
                    .HasMaxLength(450);

                entity.Property(e => e.LayoutSectionId).HasColumnName("LAYOUT_SECTION_ID");

                entity.Property(e => e.Locked).HasColumnName("LOCKED");

                entity.Property(e => e.MacroName)
                    .HasColumnName("MACRO_NAME")
                    .HasColumnType("ntext");

                entity.Property(e => e.Params)
                    .HasColumnName("PARAMS")
                    .HasColumnType("ntext");

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.HasOne(d => d.LayoutSection)
                    .WithMany(p => p.AoA3f2efLayoutItem)
                    .HasForeignKey(d => d.LayoutSectionId)
                    .HasConstraintName("fk_ao_a3f2ef_layout_item_layout_section_id");
            });

            modelBuilder.Entity<AoA3f2efLayoutKey>(entity =>
            {
                entity.ToTable("AO_A3F2EF_LAYOUT_KEY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SpaceKey)
                    .HasColumnName("SPACE_KEY")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AoA3f2efLayoutSection>(entity =>
            {
                entity.ToTable("AO_A3F2EF_LAYOUT_SECTION");

                entity.HasIndex(e => e.LayoutBoardId)
                    .HasName("index_ao_a3f2ef_lay59605066");

                entity.HasIndex(e => e.LayuoutBoardId)
                    .HasName("index_ao_a3f2ef_lay1590716713");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Group).HasColumnName("GROUP");

                entity.Property(e => e.LayoutBoardId).HasColumnName("LAYOUT_BOARD_ID");

                entity.Property(e => e.LayuoutBoardId).HasColumnName("LAYUOUT_BOARD_ID");

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.SectionId)
                    .HasColumnName("SECTION_ID")
                    .HasMaxLength(450);

                entity.Property(e => e.Width).HasColumnName("WIDTH");

                entity.HasOne(d => d.LayoutBoard)
                    .WithMany(p => p.AoA3f2efLayoutSectionLayoutBoard)
                    .HasForeignKey(d => d.LayoutBoardId)
                    .HasConstraintName("fk_ao_a3f2ef_layout_section_layout_board_id");

                entity.HasOne(d => d.LayuoutBoard)
                    .WithMany(p => p.AoA3f2efLayoutSectionLayuoutBoard)
                    .HasForeignKey(d => d.LayuoutBoardId)
                    .HasConstraintName("fk_ao_a3f2ef_layout_section_layuout_board_id");
            });

            modelBuilder.Entity<AoA3f2efLayoutVersion>(entity =>
            {
                entity.ToTable("AO_A3F2EF_LAYOUT_VERSION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasColumnType("ntext");

                entity.Property(e => e.BoardAsJson)
                    .HasColumnName("BOARD_AS_JSON")
                    .HasColumnType("ntext");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContentKey)
                    .HasColumnName("CONTENT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<AoA3f2efLinkColumns>(entity =>
            {
                entity.ToTable("AO_A3F2EF_LINK_COLUMNS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("ntext");

                entity.Property(e => e.NameKey)
                    .HasColumnName("NAME_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA3f2efLinks>(entity =>
            {
                entity.ToTable("AO_A3F2EF_LINKS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Icon)
                    .HasColumnName("ICON")
                    .HasColumnType("ntext");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectKey)
                    .HasColumnName("OBJECT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Target).HasColumnName("TARGET");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<AoA3f2efLogoColumns>(entity =>
            {
                entity.ToTable("AO_A3F2EF_LOGO_COLUMNS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Logo)
                    .HasColumnName("LOGO")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.NameKey)
                    .HasColumnName("NAME_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA3f2efPermission>(entity =>
            {
                entity.ToTable("AO_A3F2EF_PERMISSION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Groups)
                    .HasColumnName("GROUPS")
                    .HasColumnType("ntext");

                entity.Property(e => e.ObjectKey)
                    .HasColumnName("OBJECT_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.PermissionLevel)
                    .HasColumnName("PERMISSION_LEVEL")
                    .HasMaxLength(255);

                entity.Property(e => e.PermissionType)
                    .HasColumnName("PERMISSION_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Users)
                    .HasColumnName("USERS")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<AoA3f2efSpaceSettings>(entity =>
            {
                entity.ToTable("AO_A3F2EF_SPACE_SETTINGS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BreadcrumbsVisible).HasColumnName("BREADCRUMBS_VISIBLE");

                entity.Property(e => e.ChildrenVisible).HasColumnName("CHILDREN_VISIBLE");

                entity.Property(e => e.CommentsVisible).HasColumnName("COMMENTS_VISIBLE");

                entity.Property(e => e.FavouriteVisible).HasColumnName("FAVOURITE_VISIBLE");

                entity.Property(e => e.LabelsVisible).HasColumnName("LABELS_VISIBLE");

                entity.Property(e => e.LikesVisible).HasColumnName("LIKES_VISIBLE");

                entity.Property(e => e.MenuLayoutType)
                    .HasColumnName("MENU_LAYOUT_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.MetaDataVisible).HasColumnName("META_DATA_VISIBLE");

                entity.Property(e => e.SpaceGroupVisible).HasColumnName("SPACE_GROUP_VISIBLE");

                entity.Property(e => e.SpaceKey)
                    .HasColumnName("SPACE_KEY")
                    .HasMaxLength(450);

                entity.Property(e => e.SpaceLogoVisible).HasColumnName("SPACE_LOGO_VISIBLE");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(450);

                entity.Property(e => e.WatchVisible).HasColumnName("WATCH_VISIBLE");
            });

            modelBuilder.Entity<AoA3f2efSpaceTypes>(entity =>
            {
                entity.ToTable("AO_A3F2EF_SPACE_TYPES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SpaceKey)
                    .HasColumnName("SPACE_KEY")
                    .HasMaxLength(450);

                entity.Property(e => e.SpaceType)
                    .HasColumnName("SPACE_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA3f2efUserCategories>(entity =>
            {
                entity.ToTable("AO_A3F2EF_USER_CATEGORIES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupsAsJson)
                    .HasColumnName("GROUPS_AS_JSON")
                    .HasColumnType("ntext");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.RolesOnly).HasColumnName("ROLES_ONLY");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.UsersAsJson)
                    .HasColumnName("USERS_AS_JSON")
                    .HasColumnType("ntext");

                entity.Property(e => e.Visible).HasColumnName("VISIBLE");
            });

            modelBuilder.Entity<AoA3f2efUserRoles>(entity =>
            {
                entity.ToTable("AO_A3F2EF_USER_ROLES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.RoleId)
                    .HasColumnName("ROLE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA3f2efViewdesigns>(entity =>
            {
                entity.ToTable("AO_A3F2EF_VIEWDESIGNS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryKey)
                    .HasColumnName("CATEGORY_KEY")
                    .HasMaxLength(450);

                entity.Property(e => e.DesignKey)
                    .HasColumnName("DESIGN_KEY")
                    .HasMaxLength(450);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(450);

                entity.Property(e => e.VariationNameKey)
                    .HasColumnName("VARIATION_NAME_KEY")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AoA8fb76ButtonStyles>(entity =>
            {
                entity.ToTable("AO_A8FB76_BUTTON_STYLES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackgroundColor)
                    .HasColumnName("BACKGROUND_COLOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL")
                    .HasMaxLength(255);

                entity.Property(e => e.Order).HasColumnName("ORDER");

                entity.Property(e => e.TextColor)
                    .HasColumnName("TEXT_COLOR")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoA8fb76TextboxStyles>(entity =>
            {
                entity.ToTable("AO_A8FB76_TEXTBOX_STYLES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackgroundColor)
                    .HasColumnName("BACKGROUND_COLOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Icon)
                    .HasColumnName("ICON")
                    .HasMaxLength(255);

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL")
                    .HasMaxLength(255);

                entity.Property(e => e.Order).HasColumnName("ORDER");

                entity.Property(e => e.TextColor)
                    .HasColumnName("TEXT_COLOR")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AoBaf3aaAoinlineTask>(entity =>
            {
                entity.HasKey(e => e.GlobalId);

                entity.ToTable("AO_BAF3AA_AOINLINE_TASK");

                entity.HasIndex(e => e.AssigneeUserKey)
                    .HasName("index_ao_baf3aa_aoi866493194");

                entity.HasIndex(e => e.ContentId)
                    .HasName("index_ao_baf3aa_aoi1066945234");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("index_ao_baf3aa_aoi1389674752");

                entity.HasIndex(e => e.CreatorUserKey)
                    .HasName("index_ao_baf3aa_aoi1395974671");

                entity.HasIndex(e => e.DueDate)
                    .HasName("index_ao_baf3aa_aoi1978441610");

                entity.HasIndex(e => e.TaskStatus)
                    .HasName("index_ao_baf3aa_aoi1143751131");

                entity.Property(e => e.GlobalId).HasColumnName("GLOBAL_ID");

                entity.Property(e => e.AssigneeUserKey)
                    .HasColumnName("ASSIGNEE_USER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Body)
                    .HasColumnName("BODY")
                    .HasColumnType("ntext");

                entity.Property(e => e.CompleteDate)
                    .HasColumnName("COMPLETE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompleteUserKey)
                    .HasColumnName("COMPLETE_USER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.ContentId).HasColumnName("CONTENT_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("CREATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatorUserKey)
                    .HasColumnName("CREATOR_USER_KEY")
                    .HasMaxLength(255);

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TaskStatus)
                    .HasColumnName("TASK_STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AoDc98aeAohelpTip>(entity =>
            {
                entity.ToTable("AO_DC98AE_AOHELP_TIP");

                entity.HasIndex(e => e.DismissedHelpTip)
                    .HasName("index_ao_dc98ae_aoh411805038");

                entity.HasIndex(e => e.UserKey)
                    .HasName("index_ao_dc98ae_aoh1533992358");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DismissedHelpTip)
                    .HasColumnName("DISMISSED_HELP_TIP")
                    .HasMaxLength(255);

                entity.Property(e => e.UserKey)
                    .HasColumnName("USER_KEY")
                    .HasMaxLength(255);
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

            modelBuilder.Entity<Attachmentdata>(entity =>
            {
                entity.ToTable("ATTACHMENTDATA");

                entity.HasIndex(e => e.Attachmentid)
                    .HasName("UK_mxrudo8qrpxb7w28dnoo64aec")
                    .IsUnique();

                entity.HasIndex(e => new { e.Attversion, e.Attachmentid })
                    .HasName("attch_idver_idx");

                entity.Property(e => e.Attachmentdataid)
                    .HasColumnName("ATTACHMENTDATAID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Attachmentid)
                    .HasColumnName("ATTACHMENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Attversion).HasColumnName("ATTVERSION");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("image");

                entity.Property(e => e.Hibernateversion).HasColumnName("HIBERNATEVERSION");

                entity.HasOne(d => d.Attachment)
                    .WithOne(p => p.Attachmentdata)
                    .HasForeignKey<Attachmentdata>(d => d.Attachmentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKjnh4yvwen0176qsvh4rpsry2j");
            });

            modelBuilder.Entity<AttachmentsBackup>(entity =>
            {
                entity.HasKey(e => e.Attachmentid);

                entity.ToTable("ATTACHMENTS_BACKUP");

                entity.HasIndex(e => e.Pageid)
                    .HasName("att_pageid_idx");

                entity.HasIndex(e => e.Prevver)
                    .HasName("att_prevver_idx");

                entity.Property(e => e.Attachmentid)
                    .HasColumnName("ATTACHMENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AttachmentComment)
                    .HasColumnName("ATTACHMENT_COMMENT")
                    .HasMaxLength(255);

                entity.Property(e => e.Attversion).HasColumnName("ATTVERSION");

                entity.Property(e => e.Contenttype)
                    .IsRequired()
                    .HasColumnName("CONTENTTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Filesize)
                    .HasColumnName("FILESIZE")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.MinorEdit).HasColumnName("MINOR_EDIT");

                entity.Property(e => e.Pageid)
                    .HasColumnName("PAGEID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Prevver)
                    .HasColumnName("PREVVER")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.PrevverNavigation)
                    .WithMany(p => p.InversePrevverNavigation)
                    .HasForeignKey(d => d.Prevver)
                    .HasConstraintName("FK54475F9017D4A070");
            });

            modelBuilder.Entity<AuditAffectedObject>(entity =>
            {
                entity.ToTable("AUDIT_AFFECTED_OBJECT");

                entity.HasIndex(e => e.Auditrecordid)
                    .HasName("a_objects_parent_index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Auditrecordid)
                    .HasColumnName("AUDITRECORDID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Auditrecord)
                    .WithMany(p => p.AuditAffectedObject)
                    .HasForeignKey(d => d.Auditrecordid)
                    .HasConstraintName("FK_AFFECTED_OBJECT_RECORD");
            });

            modelBuilder.Entity<AuditChangedValue>(entity =>
            {
                entity.ToTable("AUDIT_CHANGED_VALUE");

                entity.HasIndex(e => e.Auditrecordid)
                    .HasName("a_values_parent_index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Auditrecordid)
                    .HasColumnName("AUDITRECORDID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Newvalue)
                    .HasColumnName("NEWVALUE")
                    .HasMaxLength(255);

                entity.Property(e => e.Oldvalue)
                    .HasColumnName("OLDVALUE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Auditrecord)
                    .WithMany(p => p.AuditChangedValue)
                    .HasForeignKey(d => d.Auditrecordid)
                    .HasConstraintName("FK_CHANGED_VALUE_RECORD");
            });

            modelBuilder.Entity<Auditrecord>(entity =>
            {
                entity.ToTable("AUDITRECORD");

                entity.HasIndex(e => e.Authorkey)
                    .HasName("a_author_key_idx");

                entity.HasIndex(e => e.Category)
                    .HasName("a_category_idx");

                entity.HasIndex(e => e.Creationdate)
                    .HasName("a_date_idx");

                entity.Property(e => e.Auditrecordid)
                    .HasColumnName("AUDITRECORDID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(255);

                entity.Property(e => e.Authorfullname)
                    .HasColumnName("AUTHORFULLNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Authorkey)
                    .HasColumnName("AUTHORKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Authorname)
                    .HasColumnName("AUTHORNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.Objectname)
                    .HasColumnName("OBJECTNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Objecttype)
                    .HasColumnName("OBJECTTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Searchstring)
                    .HasColumnName("SEARCHSTRING")
                    .HasMaxLength(4000);

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .HasMaxLength(255);

                entity.Property(e => e.Sysamdin).HasColumnName("SYSAMDIN");
            });

            modelBuilder.Entity<Bandana>(entity =>
            {
                entity.ToTable("BANDANA");

                entity.HasIndex(e => e.Bandanacontext)
                    .HasName("band_context_idx");

                entity.HasIndex(e => new { e.Bandanacontext, e.Bandanakey })
                    .HasName("band_cont_key_idx");

                entity.Property(e => e.Bandanaid)
                    .HasColumnName("BANDANAID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Bandanacontext)
                    .IsRequired()
                    .HasColumnName("BANDANACONTEXT")
                    .HasMaxLength(255);

                entity.Property(e => e.Bandanakey)
                    .IsRequired()
                    .HasColumnName("BANDANAKEY")
                    .HasMaxLength(100);

                entity.Property(e => e.Bandanavalue)
                    .HasColumnName("BANDANAVALUE")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Bodycontent>(entity =>
            {
                entity.ToTable("BODYCONTENT");

                entity.HasIndex(e => e.Contentid)
                    .HasName("body_content_idx");

                entity.Property(e => e.Bodycontentid)
                    .HasColumnName("BODYCONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Body)
                    .HasColumnName("BODY")
                    .HasColumnType("ntext");

                entity.Property(e => e.Bodytypeid).HasColumnName("BODYTYPEID");

                entity.Property(e => e.Contentid)
                    .HasColumnName("CONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Bodycontent)
                    .HasForeignKey(d => d.Contentid)
                    .HasConstraintName("FKmbyiayesfp1eiq6gmol3mk3yl");
            });

            modelBuilder.Entity<Clustersafety>(entity =>
            {
                entity.ToTable("CLUSTERSAFETY");

                entity.Property(e => e.Clustersafetyid)
                    .HasColumnName("CLUSTERSAFETYID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Safetynumber).HasColumnName("SAFETYNUMBER");
            });

            modelBuilder.Entity<Confancestors>(entity =>
            {
                entity.HasKey(e => new { e.Descendentid, e.Ancestorposition });

                entity.ToTable("CONFANCESTORS");

                entity.HasIndex(e => e.Ancestorid)
                    .HasName("c_ancestorid_idx");

                entity.Property(e => e.Descendentid)
                    .HasColumnName("DESCENDENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Ancestorposition).HasColumnName("ANCESTORPOSITION");

                entity.Property(e => e.Ancestorid)
                    .HasColumnName("ANCESTORID")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.Ancestor)
                    .WithMany(p => p.ConfancestorsAncestor)
                    .HasForeignKey(d => d.Ancestorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKsqb1af9h7fvqtgy73o8jdcuue");

                entity.HasOne(d => d.Descendent)
                    .WithMany(p => p.ConfancestorsDescendent)
                    .HasForeignKey(d => d.Descendentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKlmhsipswol8imeqsg906ih62x");
            });

            modelBuilder.Entity<Confversion>(entity =>
            {
                entity.ToTable("CONFVERSION");

                entity.HasIndex(e => e.Buildnumber)
                    .HasName("UK_osprt1myxoltvtd8yodb0besm")
                    .IsUnique();

                entity.Property(e => e.Confversionid)
                    .HasColumnName("CONFVERSIONID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Buildnumber).HasColumnName("BUILDNUMBER");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Installdate)
                    .HasColumnName("INSTALLDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Versiontag)
                    .HasColumnName("VERSIONTAG")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("CONTENT");

                entity.HasIndex(e => e.Creator)
                    .HasName("c_creator_idx");

                entity.HasIndex(e => e.Draftpageid)
                    .HasName("c_draftpageid_idx");

                entity.HasIndex(e => e.Drafttype)
                    .HasName("c_drafttype_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("c_lastmodifier_idx");

                entity.HasIndex(e => e.Lowertitle)
                    .HasName("c_ltitle_idx");

                entity.HasIndex(e => e.Messageid)
                    .HasName("c_messageid_idx");

                entity.HasIndex(e => e.Pageid)
                    .HasName("c_pageid_idx");

                entity.HasIndex(e => e.Parentccid)
                    .HasName("c_parentccid_idx");

                entity.HasIndex(e => e.Parentcommentid)
                    .HasName("c_parentcommid_idx");

                entity.HasIndex(e => e.Parentid)
                    .HasName("c_parentid_idx");

                entity.HasIndex(e => e.Prevver)
                    .HasName("c_prevver_idx");

                entity.HasIndex(e => e.Spaceid)
                    .HasName("c_spaceid_idx");

                entity.HasIndex(e => e.Title)
                    .HasName("c_title_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("c_username_idx");

                entity.HasIndex(e => new { e.Creationdate, e.Prevver, e.Spaceid, e.Contenttype, e.ContentStatus })
                    .HasName("c_si_ct_pv_cs_cd_idx");

                entity.Property(e => e.Contentid)
                    .HasColumnName("CONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ChildPosition).HasColumnName("CHILD_POSITION");

                entity.Property(e => e.ContentStatus)
                    .HasColumnName("CONTENT_STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Contenttype)
                    .IsRequired()
                    .HasColumnName("CONTENTTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Draftpageid)
                    .HasColumnName("DRAFTPAGEID")
                    .HasMaxLength(255);

                entity.Property(e => e.Draftpageversion).HasColumnName("DRAFTPAGEVERSION");

                entity.Property(e => e.Draftspacekey)
                    .HasColumnName("DRAFTSPACEKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Drafttype)
                    .HasColumnName("DRAFTTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Hibernateversion).HasColumnName("HIBERNATEVERSION");

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Lowertitle)
                    .HasColumnName("LOWERTITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Messageid)
                    .HasColumnName("MESSAGEID")
                    .HasMaxLength(255);

                entity.Property(e => e.Pageid)
                    .HasColumnName("PAGEID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Parentccid)
                    .HasColumnName("PARENTCCID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Parentcommentid)
                    .HasColumnName("PARENTCOMMENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Parentid)
                    .HasColumnName("PARENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Pluginkey)
                    .HasColumnName("PLUGINKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Pluginver)
                    .HasColumnName("PLUGINVER")
                    .HasMaxLength(255);

                entity.Property(e => e.Prevver)
                    .HasColumnName("PREVVER")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Spaceid)
                    .HasColumnName("SPACEID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.Property(e => e.Versioncomment)
                    .HasColumnName("VERSIONCOMMENT")
                    .HasColumnType("ntext");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.ContentCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_CONTENT_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.ContentLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .HasConstraintName("FK_CONTENT_LASTMODIFIER");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.InversePage)
                    .HasForeignKey(d => d.Pageid)
                    .HasConstraintName("FKwjyn6091q3l1gl7bh143ma2a");

                entity.HasOne(d => d.Parentcc)
                    .WithMany(p => p.InverseParentcc)
                    .HasForeignKey(d => d.Parentccid)
                    .HasConstraintName("FKfiyhka48c7e776qj90klbpm9q");

                entity.HasOne(d => d.Parentcomment)
                    .WithMany(p => p.InverseParentcomment)
                    .HasForeignKey(d => d.Parentcommentid)
                    .HasConstraintName("FKal6o8xwypd4mdgid9b9nw1q51");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.Parentid)
                    .HasConstraintName("FKoxtt893weujkyh0iicoxsm37v");

                entity.HasOne(d => d.PrevverNavigation)
                    .WithMany(p => p.InversePrevverNavigation)
                    .HasForeignKey(d => d.Prevver)
                    .HasConstraintName("FKk6kbb7suqeloj82nx7xdcd803");

                entity.HasOne(d => d.Space)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.Spaceid)
                    .HasConstraintName("FKlmweu06nft59g7mw1i1myorys");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.ContentUsernameNavigation)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK_CONTENT_USERNAME");
            });

            modelBuilder.Entity<ContentLabel>(entity =>
            {
                entity.ToTable("CONTENT_LABEL");

                entity.HasIndex(e => e.Attachmentid)
                    .HasName("cl_attachmentid_idx");

                entity.HasIndex(e => e.Contentid)
                    .HasName("cl_contentid_idx");

                entity.HasIndex(e => e.Labelid)
                    .HasName("cl_labelid_idx");

                entity.HasIndex(e => e.Lastmoddate)
                    .HasName("cl_lastmoddate_idx");

                entity.HasIndex(e => e.Owner)
                    .HasName("cl_owner_idx");

                entity.HasIndex(e => e.Pagetemplateid)
                    .HasName("cl_pagetemplateid_idx");

                entity.HasIndex(e => new { e.Labelableid, e.Labelabletype })
                    .HasName("cl_labelable_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Attachmentid)
                    .HasColumnName("ATTACHMENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Contentid)
                    .HasColumnName("CONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Labelableid)
                    .HasColumnName("LABELABLEID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Labelabletype)
                    .HasColumnName("LABELABLETYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Labelid)
                    .HasColumnName("LABELID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(255);

                entity.Property(e => e.Pagetemplateid)
                    .HasColumnName("PAGETEMPLATEID")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.ContentLabel)
                    .HasForeignKey(d => d.Attachmentid)
                    .HasConstraintName("FKF0E7436E34A4917E");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentLabel)
                    .HasForeignKey(d => d.Contentid)
                    .HasConstraintName("FKi8cvahsu6d2y285vtrp4nhc3w");

                entity.HasOne(d => d.Label)
                    .WithMany(p => p.ContentLabel)
                    .HasForeignKey(d => d.Labelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK91v3v5nemr532qq4gla9sj9tf");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.ContentLabel)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_CONTENT_LABEL_OWNER");

                entity.HasOne(d => d.Pagetemplate)
                    .WithMany(p => p.ContentLabel)
                    .HasForeignKey(d => d.Pagetemplateid)
                    .HasConstraintName("FK28kifokt21qd9ges0q0wv0fb9");
            });

            modelBuilder.Entity<ContentPerm>(entity =>
            {
                entity.ToTable("CONTENT_PERM");

                entity.HasIndex(e => e.CpsId)
                    .HasName("cp_os_idx");

                entity.HasIndex(e => e.Creator)
                    .HasName("cp_creator_idx");

                entity.HasIndex(e => e.Groupname)
                    .HasName("cp_gn_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("cp_lastmodifier_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("cp_un_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CpType)
                    .IsRequired()
                    .HasColumnName("CP_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.CpsId)
                    .HasColumnName("CPS_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Groupname)
                    .HasColumnName("GROUPNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Cps)
                    .WithMany(p => p.ContentPerm)
                    .HasForeignKey(d => d.CpsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKde5wl1cur1se9281gc0dsawtb");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.ContentPermCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_CONTENT_PERM_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.ContentPermLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .HasConstraintName("FK_CONTENT_PERM_LASTMODIFIER");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.ContentPermUsernameNavigation)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK_CONTENT_PERM_USERNAME");
            });

            modelBuilder.Entity<ContentPermSet>(entity =>
            {
                entity.ToTable("CONTENT_PERM_SET");

                entity.HasIndex(e => e.ContPermType)
                    .HasName("cps_permtype_idx");

                entity.HasIndex(e => e.ContentId)
                    .HasName("cps_content_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ContPermType)
                    .IsRequired()
                    .HasColumnName("CONT_PERM_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.ContentId)
                    .HasColumnName("CONTENT_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentPermSet)
                    .HasForeignKey(d => d.ContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2buunk1hor0i3k0m3nt03hw1w");
            });

            modelBuilder.Entity<Contentproperties>(entity =>
            {
                entity.HasKey(e => e.Propertyid);

                entity.ToTable("CONTENTPROPERTIES");

                entity.HasIndex(e => e.Contentid)
                    .HasName("c_contentproperties_idx");

                entity.HasIndex(e => e.Dateval)
                    .HasName("content_prop_date_idx");

                entity.HasIndex(e => e.Longval)
                    .HasName("content_prop_long_idx");

                entity.HasIndex(e => e.Propertyname)
                    .HasName("content_prop_name_idx");

                entity.HasIndex(e => e.Stringval)
                    .HasName("content_prop_str_idx");

                entity.Property(e => e.Propertyid)
                    .HasColumnName("PROPERTYID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Contentid)
                    .HasColumnName("CONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Dateval)
                    .HasColumnName("DATEVAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Longval)
                    .HasColumnName("LONGVAL")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Propertyname)
                    .IsRequired()
                    .HasColumnName("PROPERTYNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Stringval)
                    .HasColumnName("STRINGVAL")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Contentproperties)
                    .HasForeignKey(d => d.Contentid)
                    .HasConstraintName("FK3fly21xfk13rqh63txw2t6k2v");
            });

            modelBuilder.Entity<ContentRelation>(entity =>
            {
                entity.HasKey(e => e.Relationid);

                entity.ToTable("CONTENT_RELATION");

                entity.HasIndex(e => e.Creationdate)
                    .HasName("relation_c2c_cdate_idx");

                entity.HasIndex(e => e.Creator)
                    .HasName("r_c2c_creator_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("r_c2c_lastmodifier_idx");

                entity.HasIndex(e => e.Relationname)
                    .HasName("relation_c2c_relationname_idx");

                entity.HasIndex(e => e.Sourcecontentid)
                    .HasName("relation_c2c_sourcecontent_idx");

                entity.HasIndex(e => e.Sourcetype)
                    .HasName("relation_c2c_sourcetype_idx");

                entity.HasIndex(e => e.Targetcontentid)
                    .HasName("relation_c2c_targetcontent_idx");

                entity.HasIndex(e => e.Targettype)
                    .HasName("relation_c2c_targettype_idx");

                entity.HasIndex(e => new { e.Targetcontentid, e.Sourcecontentid, e.Relationname })
                    .HasName("c2c_relation_unique")
                    .IsUnique();

                entity.Property(e => e.Relationid)
                    .HasColumnName("RELATIONID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .IsRequired()
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationname)
                    .IsRequired()
                    .HasColumnName("RELATIONNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Sourcecontentid)
                    .HasColumnName("SOURCECONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Sourcetype)
                    .IsRequired()
                    .HasColumnName("SOURCETYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Targetcontentid)
                    .HasColumnName("TARGETCONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Targettype)
                    .IsRequired()
                    .HasColumnName("TARGETTYPE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.ContentRelationCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_C2CRELATION_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.ContentRelationLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_C2CRELATION_LASTMODIFIER");

                entity.HasOne(d => d.Sourcecontent)
                    .WithMany(p => p.ContentRelationSourcecontent)
                    .HasForeignKey(d => d.Sourcecontentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKe2a00urqyxmyaj3jop48ub8qd");

                entity.HasOne(d => d.Targetcontent)
                    .WithMany(p => p.ContentRelationTargetcontent)
                    .HasForeignKey(d => d.Targetcontentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKipr00838mkln699cimd7rg17x");
            });

            modelBuilder.Entity<CwdAppDirGroupMapping>(entity =>
            {
                entity.ToTable("cwd_app_dir_group_mapping");

                entity.HasIndex(e => e.AppDirMappingId)
                    .HasName("idx_app_dir_group_mapping");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("idx_app_dir_group_app");

                entity.HasIndex(e => new { e.DirectoryId, e.GroupName })
                    .HasName("idx_app_dir_group_group_dir");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AppDirMappingId)
                    .HasColumnName("app_dir_mapping_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("application_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(255);

                entity.HasOne(d => d.AppDirMapping)
                    .WithMany(p => p.CwdAppDirGroupMapping)
                    .HasForeignKey(d => d.AppDirMappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_app_dir_group_mapping");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.CwdAppDirGroupMapping)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_app_dir_group_app");

                entity.HasOne(d => d.Directory)
                    .WithMany(p => p.CwdAppDirGroupMapping)
                    .HasForeignKey(d => d.DirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_app_dir_group_dir");
            });

            modelBuilder.Entity<CwdAppDirMapping>(entity =>
            {
                entity.ToTable("cwd_app_dir_mapping");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("idx_app_dir_app");

                entity.HasIndex(e => e.DirectoryId)
                    .HasName("idx_app_dir_dir");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AllowAll)
                    .IsRequired()
                    .HasColumnName("allow_all")
                    .HasMaxLength(1);

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("application_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ListIndex).HasColumnName("list_index");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.CwdAppDirMapping)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FKstekj41875rgsw8otffrayhpl");

                entity.HasOne(d => d.Directory)
                    .WithMany(p => p.CwdAppDirMapping)
                    .HasForeignKey(d => d.DirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_app_dir_dir");
            });

            modelBuilder.Entity<CwdAppDirOperation>(entity =>
            {
                entity.HasKey(e => new { e.AppDirMappingId, e.OperationType });

                entity.ToTable("cwd_app_dir_operation");

                entity.Property(e => e.AppDirMappingId)
                    .HasColumnName("app_dir_mapping_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.OperationType)
                    .HasColumnName("operation_type")
                    .HasMaxLength(32);

                entity.HasOne(d => d.AppDirMapping)
                    .WithMany(p => p.CwdAppDirOperation)
                    .HasForeignKey(d => d.AppDirMappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_app_dir_mapping");
            });

            modelBuilder.Entity<CwdApplication>(entity =>
            {
                entity.ToTable("cwd_application");

                entity.HasIndex(e => e.Active)
                    .HasName("idx_app_active");

                entity.HasIndex(e => e.ApplicationType)
                    .HasName("idx_app_type");

                entity.HasIndex(e => e.LowerApplicationName)
                    .HasName("UK_esg7ywl12bt4wt5h1ka27m6u3")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasMaxLength(1);

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasColumnName("application_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ApplicationType)
                    .IsRequired()
                    .HasColumnName("application_type")
                    .HasMaxLength(32);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Credential)
                    .IsRequired()
                    .HasColumnName("credential")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerApplicationName)
                    .IsRequired()
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
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.RemoteAddress)
                    .HasColumnName("remote_address")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.CwdApplicationAddress)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_address");
            });

            modelBuilder.Entity<CwdApplicationAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationId, e.AttributeName });

                entity.ToTable("cwd_application_attribute");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("application_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AttributeName)
                    .HasColumnName("attribute_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeValue)
                    .HasColumnName("attribute_value")
                    .HasMaxLength(4000);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.CwdApplicationAttribute)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_application_attribute");
            });

            modelBuilder.Entity<CwdDirectory>(entity =>
            {
                entity.ToTable("cwd_directory");

                entity.HasIndex(e => e.Active)
                    .HasName("idx_dir_active");

                entity.HasIndex(e => e.DirectoryType)
                    .HasName("idx_dir_type");

                entity.HasIndex(e => e.LowerDirectoryName)
                    .HasName("UK_ojmqo7ksu5dlpaqs0b9qf0k37")
                    .IsUnique();

                entity.HasIndex(e => e.LowerImplClass)
                    .HasName("idx_dir_l_impl_class");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasMaxLength(1);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryName)
                    .IsRequired()
                    .HasColumnName("directory_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryType)
                    .IsRequired()
                    .HasColumnName("directory_type")
                    .HasMaxLength(32);

                entity.Property(e => e.ImplClass)
                    .IsRequired()
                    .HasColumnName("impl_class")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerDirectoryName)
                    .IsRequired()
                    .HasColumnName("lower_directory_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LowerImplClass)
                    .IsRequired()
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
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AttributeName)
                    .HasColumnName("attribute_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeValue)
                    .HasColumnName("attribute_value")
                    .HasMaxLength(4000);

                entity.HasOne(d => d.Directory)
                    .WithMany(p => p.CwdDirectoryAttribute)
                    .HasForeignKey(d => d.DirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_directory_attribute");
            });

            modelBuilder.Entity<CwdDirectoryOperation>(entity =>
            {
                entity.HasKey(e => new { e.DirectoryId, e.OperationType });

                entity.ToTable("cwd_directory_operation");

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.OperationType)
                    .HasColumnName("operation_type")
                    .HasMaxLength(32);

                entity.HasOne(d => d.Directory)
                    .WithMany(p => p.CwdDirectoryOperation)
                    .HasForeignKey(d => d.DirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_directory_operation");
            });

            modelBuilder.Entity<CwdGroup>(entity =>
            {
                entity.ToTable("cwd_group");

                entity.HasIndex(e => e.DirectoryId)
                    .HasName("idx_group_dir_id");

                entity.HasIndex(e => new { e.Active, e.DirectoryId })
                    .HasName("idx_group_active");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasMaxLength(1);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupType)
                    .IsRequired()
                    .HasColumnName("group_type")
                    .HasMaxLength(32);

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasMaxLength(1);

                entity.Property(e => e.LowerGroupName)
                    .IsRequired()
                    .HasColumnName("lower_group_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Directory)
                    .WithMany(p => p.CwdGroup)
                    .HasForeignKey(d => d.DirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_directory_id");
            });

            modelBuilder.Entity<CwdGroupAttribute>(entity =>
            {
                entity.ToTable("cwd_group_attribute");

                entity.HasIndex(e => e.GroupId)
                    .HasName("idx_group_attr_group_id");

                entity.HasIndex(e => new { e.DirectoryId, e.AttributeName, e.AttributeLowerValue })
                    .HasName("idx_group_attr_dir_name_lval");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AttributeLowerValue)
                    .HasColumnName("attribute_lower_value")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasColumnName("attribute_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeValue)
                    .HasColumnName("attribute_value")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.Directory)
                    .WithMany(p => p.CwdGroupAttribute)
                    .HasForeignKey(d => d.DirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group_attr_dir_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CwdGroupAttribute)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group_attr_id_group_id");
            });

            modelBuilder.Entity<CwdMembership>(entity =>
            {
                entity.ToTable("cwd_membership");

                entity.HasIndex(e => e.ChildUserId)
                    .HasName("idx_mem_dir_child_user");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_mem_dir_parent");

                entity.HasIndex(e => new { e.ChildGroupId, e.ChildUserId })
                    .HasName("idx_mem_dir_child");

                entity.HasIndex(e => new { e.ParentId, e.ChildGroupId, e.ChildUserId })
                    .HasName("idx_mem_dir_parent_child");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ChildGroupId)
                    .HasColumnName("child_group_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ChildUserId)
                    .HasColumnName("child_user_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.ChildGroup)
                    .WithMany(p => p.CwdMembershipChildGroup)
                    .HasForeignKey(d => d.ChildGroupId)
                    .HasConstraintName("fk_child_grp");

                entity.HasOne(d => d.ChildUser)
                    .WithMany(p => p.CwdMembership)
                    .HasForeignKey(d => d.ChildUserId)
                    .HasConstraintName("fk_child_user");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.CwdMembershipParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_parent_grp");
            });

            modelBuilder.Entity<CwdUser>(entity =>
            {
                entity.ToTable("cwd_user");

                entity.HasIndex(e => e.DirectoryId)
                    .HasName("idx_user_name_dir_id");

                entity.HasIndex(e => e.ExternalId)
                    .HasName("idx_user_external_id");

                entity.HasIndex(e => e.LowerUserName)
                    .HasName("idx_user_lower_user_name");

                entity.HasIndex(e => new { e.Active, e.DirectoryId })
                    .HasName("idx_user_active");

                entity.HasIndex(e => new { e.LowerDisplayName, e.DirectoryId })
                    .HasName("idx_user_lower_display_name");

                entity.HasIndex(e => new { e.LowerEmailAddress, e.DirectoryId })
                    .HasName("idx_user_lower_email_address");

                entity.HasIndex(e => new { e.LowerFirstName, e.DirectoryId })
                    .HasName("idx_user_lower_first_name");

                entity.HasIndex(e => new { e.LowerLastName, e.DirectoryId })
                    .HasName("idx_user_lower_last_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasMaxLength(1);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Credential)
                    .HasColumnName("credential")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("display_name")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(255);

                entity.Property(e => e.ExternalId)
                    .HasColumnName("external_id")
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
                    .IsRequired()
                    .HasColumnName("lower_user_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Directory)
                    .WithMany(p => p.CwdUser)
                    .HasForeignKey(d => d.DirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_dir_id");
            });

            modelBuilder.Entity<CwdUserAttribute>(entity =>
            {
                entity.ToTable("cwd_user_attribute");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_user_attr_user_id");

                entity.HasIndex(e => new { e.DirectoryId, e.AttributeName, e.AttributeLowerValue })
                    .HasName("idx_user_attr_dir_name_lval");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.AttributeLowerValue)
                    .HasColumnName("attribute_lower_value")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasColumnName("attribute_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeValue)
                    .HasColumnName("attribute_value")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryId)
                    .HasColumnName("directory_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.Directory)
                    .WithMany(p => p.CwdUserAttribute)
                    .HasForeignKey(d => d.DirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_attr_dir_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CwdUserAttribute)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_attribute_id_user_id");
            });

            modelBuilder.Entity<CwdUserCredentialRecord>(entity =>
            {
                entity.ToTable("cwd_user_credential_record");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_user_cred_record_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.ListIndex).HasColumnName("list_index");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("password_hash")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CwdUserCredentialRecord)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK2rfdh2ap00b8mholdsy1b785b");
            });

            modelBuilder.Entity<Decorator>(entity =>
            {
                entity.ToTable("DECORATOR");

                entity.HasIndex(e => e.Decoratorname)
                    .HasName("dec_name_idx");

                entity.HasIndex(e => e.Spacekey)
                    .HasName("dec_key_idx");

                entity.Property(e => e.Decoratorid)
                    .HasColumnName("DECORATORID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Body)
                    .HasColumnName("BODY")
                    .HasColumnType("ntext");

                entity.Property(e => e.Decoratorname)
                    .HasColumnName("DECORATORNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Spacekey)
                    .HasColumnName("SPACEKEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => new { e.Rev, e.History });

                entity.ToTable("EVENTS");

                entity.HasIndex(e => new { e.History, e.Rev })
                    .HasName("e_h_r_idx")
                    .IsUnique();

                entity.HasIndex(e => new { e.History, e.Partition, e.Sequence })
                    .HasName("e_h_p_s_idx")
                    .IsUnique();

                entity.Property(e => e.Rev)
                    .HasColumnName("rev")
                    .HasMaxLength(255);

                entity.Property(e => e.History)
                    .HasColumnName("history")
                    .HasMaxLength(255);

                entity.Property(e => e.Event).HasColumnName("event");

                entity.Property(e => e.Partition).HasColumnName("partition");

                entity.Property(e => e.Sequence).HasColumnName("sequence");
            });

            modelBuilder.Entity<ExternalEntities>(entity =>
            {
                entity.ToTable("external_entities");

                entity.HasIndex(e => e.Name)
                    .HasName("ext_ent_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ExternalMembers>(entity =>
            {
                entity.HasKey(e => new { e.Groupid, e.Extentityid });

                entity.ToTable("external_members");

                entity.HasIndex(e => e.Extentityid)
                    .HasName("c_extentityid_idx");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Extentityid)
                    .HasColumnName("extentityid")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.Extentity)
                    .WithMany(p => p.ExternalMembers)
                    .HasForeignKey(d => d.Extentityid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKadlkfu6a03u8f8bs82lm4qlg1");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ExternalMembers)
                    .HasForeignKey(d => d.Groupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK47k0fudqnbnsbw0yw44ucsu2r");
            });

            modelBuilder.Entity<Extrnlnks>(entity =>
            {
                entity.HasKey(e => e.Linkid);

                entity.ToTable("EXTRNLNKS");

                entity.HasIndex(e => e.Contentid)
                    .HasName("el_contentid_idx");

                entity.HasIndex(e => e.Creator)
                    .HasName("el_creator_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("el_lastmodifier_idx");

                entity.Property(e => e.Linkid)
                    .HasColumnName("LINKID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Contentid)
                    .HasColumnName("CONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Contenttype)
                    .IsRequired()
                    .HasColumnName("CONTENTTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Lowerurl)
                    .IsRequired()
                    .HasColumnName("LOWERURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(255);

                entity.Property(e => e.Viewcount).HasColumnName("VIEWCOUNT");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Extrnlnks)
                    .HasForeignKey(d => d.Contentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK5v5lw9x88vm27rvubsc130njy");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.ExtrnlnksCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_EXTRNLNKS_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.ExtrnlnksLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .HasConstraintName("FK_EXTRNLNKS_LASTMODIFIER");
            });

            modelBuilder.Entity<FollowConnections>(entity =>
            {
                entity.HasKey(e => e.Connectionid);

                entity.ToTable("FOLLOW_CONNECTIONS");

                entity.HasIndex(e => e.Followee)
                    .HasName("cn_followee_idx");

                entity.HasIndex(e => e.Follower)
                    .HasName("cn_follower_idx");

                entity.Property(e => e.Connectionid)
                    .HasColumnName("CONNECTIONID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Followee)
                    .HasColumnName("FOLLOWEE")
                    .HasMaxLength(255);

                entity.Property(e => e.Follower)
                    .HasColumnName("FOLLOWER")
                    .HasMaxLength(255);

                entity.HasOne(d => d.FolloweeNavigation)
                    .WithMany(p => p.FollowConnectionsFolloweeNavigation)
                    .HasForeignKey(d => d.Followee)
                    .HasConstraintName("FK_FOLLOW_CONNECTIONS_FOLLOWEE");

                entity.HasOne(d => d.FollowerNavigation)
                    .WithMany(p => p.FollowConnectionsFollowerNavigation)
                    .HasForeignKey(d => d.Follower)
                    .HasConstraintName("FK_FOLLOW_CONNECTIONS_FOLLOWER");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.ToTable("groups");

                entity.HasIndex(e => e.Groupname)
                    .HasName("UK_7y2xug6xwfc0qe9tg9oer6gjc")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Groupname)
                    .IsRequired()
                    .HasColumnName("groupname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Imagedetails>(entity =>
            {
                entity.HasKey(e => e.Attachmentid);

                entity.ToTable("IMAGEDETAILS");

                entity.Property(e => e.Attachmentid)
                    .HasColumnName("ATTACHMENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Height).HasColumnName("HEIGHT");

                entity.Property(e => e.Mimetype)
                    .HasColumnName("MIMETYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.Width).HasColumnName("WIDTH");

                entity.HasOne(d => d.Attachment)
                    .WithOne(p => p.Imagedetails)
                    .HasForeignKey<Imagedetails>(d => d.Attachmentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_attachment_id");
            });

            modelBuilder.Entity<Indexqueueentries>(entity =>
            {
                entity.HasKey(e => e.Entryid);

                entity.ToTable("INDEXQUEUEENTRIES");

                entity.Property(e => e.Entryid)
                    .HasColumnName("ENTRYID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Handle)
                    .HasColumnName("HANDLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Type).HasColumnName("TYPE");
            });

            modelBuilder.Entity<Journalentry>(entity =>
            {
                entity.HasKey(e => e.EntryId);

                entity.ToTable("journalentry");

                entity.HasIndex(e => e.Creationdate)
                    .HasName("j_creationdate_idx");

                entity.HasIndex(e => e.JournalName)
                    .HasName("j_j_name_idx");

                entity.Property(e => e.EntryId)
                    .HasColumnName("entry_id")
                    .HasColumnType("numeric(19, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Creationdate)
                    .HasColumnName("creationdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JournalName)
                    .HasColumnName("journal_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(2047);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Keystore>(entity =>
            {
                entity.HasKey(e => e.Keyid);

                entity.ToTable("KEYSTORE");

                entity.Property(e => e.Keyid)
                    .HasColumnName("KEYID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Algorithm)
                    .IsRequired()
                    .HasColumnName("ALGORITHM")
                    .HasMaxLength(32);

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("ALIAS")
                    .HasMaxLength(255);

                entity.Property(e => e.Keyspec)
                    .IsRequired()
                    .HasColumnName("KEYSPEC")
                    .HasColumnType("ntext");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.ToTable("LABEL");

                entity.HasIndex(e => e.Name)
                    .HasName("l_name_idx");

                entity.HasIndex(e => e.Namespace)
                    .HasName("l_namespace_idx");

                entity.HasIndex(e => e.Owner)
                    .HasName("l_owner_idx");

                entity.Property(e => e.Labelid)
                    .HasColumnName("LABELID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Namespace)
                    .HasColumnName("NAMESPACE")
                    .HasMaxLength(255);

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(255);

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.Label)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_LABEL_OWNER");
            });

            modelBuilder.Entity<Likes>(entity =>
            {
                entity.ToTable("LIKES");

                entity.HasIndex(e => e.Contentid)
                    .HasName("like_cid_idx");

                entity.HasIndex(e => e.Creationdate)
                    .HasName("like_cdate_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("like_username_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Contentid)
                    .HasColumnName("CONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.Contentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKbdoiwi70i7o3tc7hpbu4vnlmy");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LIKES_USERNAME");
            });

            modelBuilder.Entity<Links>(entity =>
            {
                entity.HasKey(e => e.Linkid);

                entity.ToTable("LINKS");

                entity.HasIndex(e => e.Contentid)
                    .HasName("l_contentid_idx");

                entity.HasIndex(e => e.Creator)
                    .HasName("links_creator_idx");

                entity.HasIndex(e => e.Destpagetitle)
                    .HasName("l_destpgtitle_idx");

                entity.HasIndex(e => e.Destspacekey)
                    .HasName("l_destspacekey_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("links_lastmodifier_idx");

                entity.HasIndex(e => e.Lowerdestpagetitle)
                    .HasName("l_ldestpgtitle_idx");

                entity.HasIndex(e => e.Lowerdestspacekey)
                    .HasName("l_ldestspacekey_idx");

                entity.Property(e => e.Linkid)
                    .HasColumnName("LINKID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Contentid)
                    .HasColumnName("CONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Destpagetitle)
                    .HasColumnName("DESTPAGETITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Destspacekey)
                    .IsRequired()
                    .HasColumnName("DESTSPACEKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Lowerdestpagetitle)
                    .HasColumnName("LOWERDESTPAGETITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Lowerdestspacekey)
                    .HasColumnName("LOWERDESTSPACEKEY")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Links)
                    .HasForeignKey(d => d.Contentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKn8mycko8frerne7brh5nr1csr");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.LinksCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_LINKS_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.LinksLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .HasConstraintName("FK_LINKS_LASTMODIFIER");
            });

            modelBuilder.Entity<LocalMembers>(entity =>
            {
                entity.HasKey(e => new { e.Groupid, e.Userid });

                entity.ToTable("local_members");

                entity.HasIndex(e => e.Userid)
                    .HasName("c_userid_idx");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.LocalMembers)
                    .HasForeignKey(d => d.Groupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKi71uomcf4f9sesibdhsmfdbgh");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LocalMembers)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrcuyoptnad1pos41gp1b1f3pi");
            });

            modelBuilder.Entity<Logininfo>(entity =>
            {
                entity.ToTable("logininfo");

                entity.HasIndex(e => e.Username)
                    .HasName("UK_cxh64nyrevdya903riaky8hs0")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Curfailed).HasColumnName("CURFAILED");

                entity.Property(e => e.Faileddate)
                    .HasColumnName("FAILEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Prevsuccessdate)
                    .HasColumnName("PREVSUCCESSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Successdate)
                    .HasColumnName("SUCCESSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Totalfailed).HasColumnName("TOTALFAILED");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithOne(p => p.Logininfo)
                    .HasForeignKey<Logininfo>(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_logininfo_USERNAME");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasKey(e => e.Notificationid);

                entity.ToTable("NOTIFICATIONS");

                entity.HasIndex(e => e.Contentid)
                    .HasName("n_contentid_idx");

                entity.HasIndex(e => e.Creator)
                    .HasName("n_creator_idx");

                entity.HasIndex(e => e.Labelid)
                    .HasName("n_labelid_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("n_lastmodifier_idx");

                entity.HasIndex(e => e.Spaceid)
                    .HasName("n_spaceid_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("n_username_idx");

                entity.Property(e => e.Notificationid)
                    .HasColumnName("NOTIFICATIONID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Contentid)
                    .HasColumnName("CONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Contenttype)
                    .HasColumnName("CONTENTTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Digest).HasColumnName("DIGEST");

                entity.Property(e => e.Labelid)
                    .HasColumnName("LABELID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Network).HasColumnName("NETWORK");

                entity.Property(e => e.Spaceid)
                    .HasColumnName("SPACEID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.Contentid)
                    .HasConstraintName("FK_NOTIFICATIONS_CONTENT");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.NotificationsCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_NOTIFICATIONS_CREATOR");

                entity.HasOne(d => d.Label)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.Labelid)
                    .HasConstraintName("FK4tccrjamrjvmd2aogl3hklpfj");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.NotificationsLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .HasConstraintName("FK_NOTIFICATIONS_LASTMODIFIER");

                entity.HasOne(d => d.Space)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.Spaceid)
                    .HasConstraintName("FKmqe1phe52xwqc4hk4ib8p9eh6");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.NotificationsUsernameNavigation)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NOTIFICATIONS_USERNAME");
            });

            modelBuilder.Entity<OsGroup>(entity =>
            {
                entity.ToTable("os_group");

                entity.HasIndex(e => e.Groupname)
                    .HasName("UK_dxfqn6n2b524nx69kq4hsgtcn")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Groupname)
                    .IsRequired()
                    .HasColumnName("groupname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OsPropertyentry>(entity =>
            {
                entity.HasKey(e => new { e.EntityName, e.EntityId, e.EntityKey });

                entity.ToTable("OS_PROPERTYENTRY");

                entity.Property(e => e.EntityName)
                    .HasColumnName("entity_name")
                    .HasMaxLength(125);

                entity.Property(e => e.EntityId)
                    .HasColumnName("entity_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.EntityKey)
                    .HasColumnName("entity_key")
                    .HasMaxLength(200);

                entity.Property(e => e.BooleanVal).HasColumnName("boolean_val");

                entity.Property(e => e.DateVal)
                    .HasColumnName("date_val")
                    .HasColumnType("datetime");

                entity.Property(e => e.DoubleVal).HasColumnName("double_val");

                entity.Property(e => e.IntVal).HasColumnName("int_val");

                entity.Property(e => e.KeyType).HasColumnName("key_type");

                entity.Property(e => e.LongVal)
                    .HasColumnName("long_val")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.StringVal)
                    .HasColumnName("string_val")
                    .HasMaxLength(255);

                entity.Property(e => e.TextVal)
                    .HasColumnName("text_val")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<OsUser>(entity =>
            {
                entity.ToTable("os_user");

                entity.HasIndex(e => e.Username)
                    .HasName("UK_fbxi8ego2k3uwg0lngdwv05j")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Passwd)
                    .HasColumnName("passwd")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OsUserGroup>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GroupId });

                entity.ToTable("os_user_group");

                entity.HasIndex(e => e.GroupId)
                    .HasName("c_groupdid_idx");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.OsUserGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKm2o7638ojnki05i3u0n5oepop");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OsUserGroup)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK6w5bwo7289k947ee5fwec30jv");
            });

            modelBuilder.Entity<Pagetemplates>(entity =>
            {
                entity.HasKey(e => e.Templateid);

                entity.ToTable("PAGETEMPLATES");

                entity.HasIndex(e => e.Creator)
                    .HasName("pt_creator_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("pt_lastmodifier_idx");

                entity.HasIndex(e => e.Prevver)
                    .HasName("pt_prevver_idx");

                entity.HasIndex(e => e.Spaceid)
                    .HasName("pt_spaceid_idx");

                entity.Property(e => e.Templateid)
                    .HasColumnName("TEMPLATEID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Bodytypeid).HasColumnName("BODYTYPEID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("ntext");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Hibernateversion).HasColumnName("HIBERNATEVERSION");

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Modulekey)
                    .HasColumnName("MODULEKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Pluginkey)
                    .HasColumnName("PLUGINKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Prevver)
                    .HasColumnName("PREVVER")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Refmodulekey)
                    .HasColumnName("REFMODULEKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Refpluginkey)
                    .HasColumnName("REFPLUGINKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Spaceid)
                    .HasColumnName("SPACEID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Templatedesc)
                    .HasColumnName("TEMPLATEDESC")
                    .HasMaxLength(255);

                entity.Property(e => e.Templatename)
                    .IsRequired()
                    .HasColumnName("TEMPLATENAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.PagetemplatesCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_PAGETEMPLATES_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.PagetemplatesLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .HasConstraintName("FK_PAGETEMPLATES_LASTMODIFIER");

                entity.HasOne(d => d.PrevverNavigation)
                    .WithMany(p => p.InversePrevverNavigation)
                    .HasForeignKey(d => d.Prevver)
                    .HasConstraintName("FK4wgwy1dqci8rcwad4tnqbglt8");

                entity.HasOne(d => d.Space)
                    .WithMany(p => p.Pagetemplates)
                    .HasForeignKey(d => d.Spaceid)
                    .HasConstraintName("FK18a1d37pvq2o9hu5x3tps97mx");
            });

            modelBuilder.Entity<Plugindata>(entity =>
            {
                entity.ToTable("PLUGINDATA");

                entity.HasIndex(e => e.Filename)
                    .HasName("UK_dg9b9idpgjdj5ljfmnld9lshn")
                    .IsUnique();

                entity.HasIndex(e => e.Pluginkey)
                    .HasName("UK_6i3f2odnxreeous9k1baxbc0a")
                    .IsUnique();

                entity.Property(e => e.Plugindataid)
                    .HasColumnName("PLUGINDATAID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("image");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("FILENAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pluginkey)
                    .IsRequired()
                    .HasColumnName("PLUGINKEY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Remembermetoken>(entity =>
            {
                entity.ToTable("remembermetoken");

                entity.HasIndex(e => e.Username)
                    .HasName("rmt_username_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SchedulerClusteredJobs>(entity =>
            {
                entity.ToTable("scheduler_clustered_jobs");

                entity.HasIndex(e => e.JobId)
                    .HasName("UK_h41yn0carypy2jdlo4oapqo7m")
                    .IsUnique();

                entity.HasIndex(e => e.JobRunnerKey)
                    .HasName("job_runner_key_idx");

                entity.HasIndex(e => e.NextRunTime)
                    .HasName("next_run_time_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.CronExpression)
                    .HasColumnName("cron_expression")
                    .HasMaxLength(255);

                entity.Property(e => e.CronTimeZone)
                    .HasColumnName("cron_time_zone")
                    .HasMaxLength(60);

                entity.Property(e => e.IntervalFirstRunTime)
                    .HasColumnName("interval_first_run_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntervalMillis)
                    .HasColumnName("interval_millis")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.JobId)
                    .HasColumnName("job_id")
                    .HasMaxLength(255);

                entity.Property(e => e.JobRunnerKey)
                    .HasColumnName("job_runner_key")
                    .HasMaxLength(255);

                entity.Property(e => e.NextRunTime)
                    .HasColumnName("next_run_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RawParameters)
                    .HasColumnName("raw_parameters")
                    .HasColumnType("image");

                entity.Property(e => e.SchedType)
                    .HasColumnName("sched_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("numeric(19, 0)");
            });

            modelBuilder.Entity<SchedulerRunDetails>(entity =>
            {
                entity.ToTable("scheduler_run_details");

                entity.HasIndex(e => e.JobId)
                    .HasName("job_id_idx");

                entity.HasIndex(e => e.StartTime)
                    .HasName("start_time_idx");

                entity.HasIndex(e => new { e.JobId, e.StartTime })
                    .HasName("job_id_start_time_idx");

                entity.HasIndex(e => new { e.StartTime, e.Outcome })
                    .HasName("start_time_outcome_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.JobId)
                    .HasColumnName("job_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(255);

                entity.Property(e => e.Outcome)
                    .HasColumnName("outcome")
                    .HasMaxLength(1);

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Secrets>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("SECRETS");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Snapshots>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("SNAPSHOTS");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Spacepermissions>(entity =>
            {
                entity.HasKey(e => e.Permid);

                entity.ToTable("SPACEPERMISSIONS");

                entity.HasIndex(e => e.Creator)
                    .HasName("sp_creator_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("sp_lastmodifier_idx");

                entity.HasIndex(e => e.Permgroupname)
                    .HasName("sp_pgname_idx");

                entity.HasIndex(e => e.Permtype)
                    .HasName("sp_permtype_idx");

                entity.HasIndex(e => e.Permusername)
                    .HasName("sp_puname_idx");

                entity.HasIndex(e => e.Spaceid)
                    .HasName("sp_spaceid_idx");

                entity.HasIndex(e => new { e.Permtype, e.Permgroupname })
                    .HasName("sp_comp_idx");

                entity.Property(e => e.Permid)
                    .HasColumnName("PERMID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Permalluserssubject)
                    .HasColumnName("PERMALLUSERSSUBJECT")
                    .HasMaxLength(255);

                entity.Property(e => e.Permgroupname)
                    .HasColumnName("PERMGROUPNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Permtype)
                    .IsRequired()
                    .HasColumnName("PERMTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Permusername)
                    .HasColumnName("PERMUSERNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Spaceid)
                    .HasColumnName("SPACEID")
                    .HasColumnType("numeric(19, 0)");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.SpacepermissionsCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_SPACEPERMISSIONS_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.SpacepermissionsLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .HasConstraintName("FK_SPACEPERMISSIONS_LASTMODIFI");

                entity.HasOne(d => d.PermusernameNavigation)
                    .WithMany(p => p.SpacepermissionsPermusernameNavigation)
                    .HasForeignKey(d => d.Permusername)
                    .HasConstraintName("FK_SPACEPERMISSIONS_PERMUSERNA");

                entity.HasOne(d => d.Space)
                    .WithMany(p => p.Spacepermissions)
                    .HasForeignKey(d => d.Spaceid)
                    .HasConstraintName("FKbi3x723m8fbgoko3s84f9oddl");
            });

            modelBuilder.Entity<Spaces>(entity =>
            {
                entity.HasKey(e => e.Spaceid);

                entity.ToTable("SPACES");

                entity.HasIndex(e => e.Creationdate)
                    .HasName("s_creationdate_idx");

                entity.HasIndex(e => e.Creator)
                    .HasName("s_creator_idx");

                entity.HasIndex(e => e.Homepage)
                    .HasName("s_homepage_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("s_lastmodifier_idx");

                entity.HasIndex(e => e.Lowerspacekey)
                    .HasName("s_lspacekey_idx");

                entity.HasIndex(e => e.Spacedescid)
                    .HasName("s_spacedescid_idx");

                entity.HasIndex(e => e.Spacekey)
                    .HasName("UK_jp1ad5yufsih5r7lqrygakpug")
                    .IsUnique();

                entity.HasIndex(e => e.Spacestatus)
                    .HasName("s_spacestatus_idx");

                entity.Property(e => e.Spaceid)
                    .HasColumnName("SPACEID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Homepage)
                    .HasColumnName("HOMEPAGE")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Lowerspacekey)
                    .IsRequired()
                    .HasColumnName("LOWERSPACEKEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Spacedescid)
                    .HasColumnName("SPACEDESCID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Spacekey)
                    .IsRequired()
                    .HasColumnName("SPACEKEY")
                    .HasMaxLength(255);

                entity.Property(e => e.Spacename)
                    .HasColumnName("SPACENAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Spacestatus)
                    .HasColumnName("SPACESTATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Spacetype)
                    .HasColumnName("SPACETYPE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.SpacesCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_SPACES_CREATOR");

                entity.HasOne(d => d.HomepageNavigation)
                    .WithMany(p => p.SpacesHomepageNavigation)
                    .HasForeignKey(d => d.Homepage)
                    .HasConstraintName("FKj4cu5838aqcbw57wy7ckt0t7o");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.SpacesLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .HasConstraintName("FK_SPACES_LASTMODIFIER");

                entity.HasOne(d => d.Spacedesc)
                    .WithMany(p => p.SpacesSpacedesc)
                    .HasForeignKey(d => d.Spacedescid)
                    .HasConstraintName("FK7ndewmrl3hqcpwc8eydn9mv8j");
            });

            modelBuilder.Entity<Trackbacklinks>(entity =>
            {
                entity.HasKey(e => e.Linkid);

                entity.ToTable("TRACKBACKLINKS");

                entity.HasIndex(e => e.Contentid)
                    .HasName("tbl_contentid_idx");

                entity.HasIndex(e => e.Creator)
                    .HasName("tbl_creator_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("tbl_lastmodifier_idx");

                entity.Property(e => e.Linkid)
                    .HasColumnName("LINKID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Blogname)
                    .HasColumnName("BLOGNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Contentid)
                    .HasColumnName("CONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Contenttype)
                    .IsRequired()
                    .HasColumnName("CONTENTTYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Excerpt)
                    .HasColumnName("EXCERPT")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Lowerurl)
                    .IsRequired()
                    .HasColumnName("LOWERURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(255);

                entity.Property(e => e.Viewcount).HasColumnName("VIEWCOUNT");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Trackbacklinks)
                    .HasForeignKey(d => d.Contentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1to6omjl8nhevcjbvpt3ed7nt");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.TrackbacklinksCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_TRACKBACKLINKS_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.TrackbacklinksLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .HasConstraintName("FK_TRACKBACKLINKS_LASTMODIFIER");
            });

            modelBuilder.Entity<Trustedapp>(entity =>
            {
                entity.ToTable("TRUSTEDAPP");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_f48dl9nadsqeudry5cyura0du")
                    .IsUnique();

                entity.HasIndex(e => e.PublicKeyId)
                    .HasName("UK_mqknjsql47jf4ue5kn4sdtbj0")
                    .IsUnique();

                entity.Property(e => e.Trustedappid)
                    .HasColumnName("TRUSTEDAPPID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PublicKeyId)
                    .HasColumnName("PUBLIC_KEY_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Timeout).HasColumnName("TIMEOUT");

                entity.HasOne(d => d.PublicKey)
                    .WithOne(p => p.Trustedapp)
                    .HasForeignKey<Trustedapp>(d => d.PublicKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKm7n581y7groa49tygapkmnfiv");
            });

            modelBuilder.Entity<Trustedapprestriction>(entity =>
            {
                entity.ToTable("TRUSTEDAPPRESTRICTION");

                entity.HasIndex(e => e.Trustedappid)
                    .HasName("c_trustedappid_idx");

                entity.Property(e => e.Trustedapprestrictionid)
                    .HasColumnName("TRUSTEDAPPRESTRICTIONID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Restriction)
                    .HasColumnName("restriction")
                    .HasMaxLength(255);

                entity.Property(e => e.Trustedappid)
                    .HasColumnName("TRUSTEDAPPID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(32);

                entity.HasOne(d => d.Trustedapp)
                    .WithMany(p => p.Trustedapprestriction)
                    .HasForeignKey(d => d.Trustedappid)
                    .HasConstraintName("FKjofk5643721eftow3njwr73aa");
            });

            modelBuilder.Entity<UsercontentRelation>(entity =>
            {
                entity.HasKey(e => e.Relationid);

                entity.ToTable("USERCONTENT_RELATION");

                entity.HasIndex(e => e.Creationdate)
                    .HasName("relation_u2c_cdate_idx");

                entity.HasIndex(e => e.Creator)
                    .HasName("r_u2c_creator_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("r_u2c_lastmodifier_idx");

                entity.HasIndex(e => e.Relationname)
                    .HasName("relation_u2c_relationname_idx");

                entity.HasIndex(e => e.Sourceuser)
                    .HasName("relation_u2c_sourceuser_idx");

                entity.HasIndex(e => e.Targetcontentid)
                    .HasName("relation_u2c_targetcontent_idx");

                entity.HasIndex(e => e.Targettype)
                    .HasName("relation_u2c_targettype_idx");

                entity.HasIndex(e => new { e.Targetcontentid, e.Sourceuser, e.Relationname })
                    .HasName("u2c_relation_unique")
                    .IsUnique();

                entity.Property(e => e.Relationid)
                    .HasColumnName("RELATIONID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .IsRequired()
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationname)
                    .IsRequired()
                    .HasColumnName("RELATIONNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Sourceuser)
                    .IsRequired()
                    .HasColumnName("SOURCEUSER")
                    .HasMaxLength(255);

                entity.Property(e => e.Targetcontentid)
                    .HasColumnName("TARGETCONTENTID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Targettype)
                    .IsRequired()
                    .HasColumnName("TARGETTYPE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.UsercontentRelationCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_U2CRELATION_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.UsercontentRelationLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_U2CRELATION_LASTMODIFIER");

                entity.HasOne(d => d.SourceuserNavigation)
                    .WithMany(p => p.UsercontentRelationSourceuserNavigation)
                    .HasForeignKey(d => d.Sourceuser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RELATION_U2CUSER");

                entity.HasOne(d => d.Targetcontent)
                    .WithMany(p => p.UsercontentRelation)
                    .HasForeignKey(d => d.Targetcontentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpwgl85a266iie5i0adu8bdbcv");
            });

            modelBuilder.Entity<UserMapping>(entity =>
            {
                entity.HasKey(e => e.UserKey);

                entity.ToTable("user_mapping");

                entity.Property(e => e.UserKey)
                    .HasColumnName("user_key")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.LowerUsername)
                    .HasColumnName("lower_username")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UserRelation>(entity =>
            {
                entity.HasKey(e => e.Relationid);

                entity.ToTable("USER_RELATION");

                entity.HasIndex(e => e.Creationdate)
                    .HasName("relation_u2u_cdate_idx");

                entity.HasIndex(e => e.Creator)
                    .HasName("r_u2u_creator_idx");

                entity.HasIndex(e => e.Lastmodifier)
                    .HasName("r_u2u_lastmodifier_idx");

                entity.HasIndex(e => e.Relationname)
                    .HasName("relation_u2u_relationname_idx");

                entity.HasIndex(e => e.Sourceuser)
                    .HasName("relation_u2u_sourceuser_idx");

                entity.HasIndex(e => e.Targetuser)
                    .HasName("relation_u2u_targetuser_idx");

                entity.HasIndex(e => new { e.Sourceuser, e.Targetuser, e.Relationname })
                    .HasName("u2u_relation_unique")
                    .IsUnique();

                entity.Property(e => e.Relationid)
                    .HasColumnName("RELATIONID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("CREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .IsRequired()
                    .HasColumnName("CREATOR")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastmoddate)
                    .HasColumnName("LASTMODDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmodifier)
                    .IsRequired()
                    .HasColumnName("LASTMODIFIER")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationname)
                    .IsRequired()
                    .HasColumnName("RELATIONNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Sourceuser)
                    .IsRequired()
                    .HasColumnName("SOURCEUSER")
                    .HasMaxLength(255);

                entity.Property(e => e.Targetuser)
                    .IsRequired()
                    .HasColumnName("TARGETUSER")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.UserRelationCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_U2URELATION_CREATOR");

                entity.HasOne(d => d.LastmodifierNavigation)
                    .WithMany(p => p.UserRelationLastmodifierNavigation)
                    .HasForeignKey(d => d.Lastmodifier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_U2URELATION_LASTMODIFIER");

                entity.HasOne(d => d.SourceuserNavigation)
                    .WithMany(p => p.UserRelationSourceuserNavigation)
                    .HasForeignKey(d => d.Sourceuser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RELATION_U2USUSER");

                entity.HasOne(d => d.TargetuserNavigation)
                    .WithMany(p => p.UserRelationTargetuserNavigation)
                    .HasForeignKey(d => d.Targetuser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RELATION_U2UTUSER");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_3g1j96g94xpk3lpxl2qbl985x")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);
            });
        }
    }
}
