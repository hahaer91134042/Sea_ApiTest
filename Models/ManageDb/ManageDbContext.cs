using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class ManageDbContext : DbContext
    {
        public ManageDbContext()
        {
        }

        public ManageDbContext(DbContextOptions<ManageDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountAdminLog> AccountAdminLogs { get; set; } = null!;
        public virtual DbSet<AccountExchangeLog> AccountExchangeLogs { get; set; } = null!;
        public virtual DbSet<AccountExchangeLogBk> AccountExchangeLogBks { get; set; } = null!;
        public virtual DbSet<AgentCreditLog> AgentCreditLogs { get; set; } = null!;
        public virtual DbSet<AgentGameList> AgentGameLists { get; set; } = null!;
        public virtual DbSet<ApiWhitelist> ApiWhitelists { get; set; } = null!;
        public virtual DbSet<ClientAccessDatum> ClientAccessData { get; set; } = null!;
        public virtual DbSet<DataTimeZone> DataTimeZones { get; set; } = null!;
        public virtual DbSet<DictionaryManaged> DictionaryManageds { get; set; } = null!;
        public virtual DbSet<DwChangeLog> DwChangeLogs { get; set; } = null!;
        public virtual DbSet<DwConfig> DwConfigs { get; set; } = null!;
        public virtual DbSet<DwConfigAuto> DwConfigAutos { get; set; } = null!;
        public virtual DbSet<DwConfigGame> DwConfigGames { get; set; } = null!;
        public virtual DbSet<DwConfigTrigger> DwConfigTriggers { get; set; } = null!;
        public virtual DbSet<DwDic> DwDics { get; set; } = null!;
        public virtual DbSet<DwGameList> DwGameLists { get; set; } = null!;
        public virtual DbSet<DwNav> DwNavs { get; set; } = null!;
        public virtual DbSet<DwRtpLog> DwRtpLogs { get; set; } = null!;
        public virtual DbSet<EventHistory> EventHistories { get; set; } = null!;
        public virtual DbSet<FreebetAdminLog> FreebetAdminLogs { get; set; } = null!;
        public virtual DbSet<FreebetLottery> FreebetLotteries { get; set; } = null!;
        public virtual DbSet<GameCurrency> GameCurrencies { get; set; } = null!;
        public virtual DbSet<GameJump> GameJumps { get; set; } = null!;
        public virtual DbSet<IpChina> IpChinas { get; set; } = null!;
        public virtual DbSet<IpdataDny> IpdataDnies { get; set; } = null!;
        public virtual DbSet<LabelStatisActive> LabelStatisActives { get; set; } = null!;
        public virtual DbSet<LabelStatisExchange> LabelStatisExchanges { get; set; } = null!;
        public virtual DbSet<LabelStatisFreebet> LabelStatisFreebets { get; set; } = null!;
        public virtual DbSet<LabelStatisFreebetLottery> LabelStatisFreebetLotteries { get; set; } = null!;
        public virtual DbSet<LabelStatisGame> LabelStatisGames { get; set; } = null!;
        public virtual DbSet<LabelStatisGameOnline> LabelStatisGameOnlines { get; set; } = null!;
        public virtual DbSet<LabelStatisJp> LabelStatisJps { get; set; } = null!;
        public virtual DbSet<LabelStatisProfit> LabelStatisProfits { get; set; } = null!;
        public virtual DbSet<LabelStatisProfitUser> LabelStatisProfitUsers { get; set; } = null!;
        public virtual DbSet<LabelStatisType> LabelStatisTypes { get; set; } = null!;
        public virtual DbSet<MessageReadLog> MessageReadLogs { get; set; } = null!;
        public virtual DbSet<PriceConfigRoulette> PriceConfigRoulettes { get; set; } = null!;
        public virtual DbSet<PriceConfigRouletteLimit> PriceConfigRouletteLimits { get; set; } = null!;
        public virtual DbSet<RedrainConfig> RedrainConfigs { get; set; } = null!;
        public virtual DbSet<RedrainReward> RedrainRewards { get; set; } = null!;
        public virtual DbSet<RoomConfigRoulette> RoomConfigRoulettes { get; set; } = null!;
        public virtual DbSet<RoomConfigRouletteLimit> RoomConfigRouletteLimits { get; set; } = null!;
        public virtual DbSet<StatisActive> StatisActives { get; set; } = null!;
        public virtual DbSet<StatisExchange> StatisExchanges { get; set; } = null!;
        public virtual DbSet<StatisExchangeUser> StatisExchangeUsers { get; set; } = null!;
        public virtual DbSet<StatisFreebet> StatisFreebets { get; set; } = null!;
        public virtual DbSet<StatisFreebetLottery> StatisFreebetLotteries { get; set; } = null!;
        public virtual DbSet<StatisFreebetUser> StatisFreebetUsers { get; set; } = null!;
        public virtual DbSet<StatisGame> StatisGames { get; set; } = null!;
        public virtual DbSet<StatisGameOnline> StatisGameOnlines { get; set; } = null!;
        public virtual DbSet<StatisGameUser> StatisGameUsers { get; set; } = null!;
        public virtual DbSet<StatisJp> StatisJps { get; set; } = null!;
        public virtual DbSet<StatisJpUser> StatisJpUsers { get; set; } = null!;
        public virtual DbSet<StatisProfit> StatisProfits { get; set; } = null!;
        public virtual DbSet<StatisProfitNow> StatisProfitNows { get; set; } = null!;
        public virtual DbSet<StatisProfitUser> StatisProfitUsers { get; set; } = null!;
        public virtual DbSet<StatisRegIpmac> StatisRegIpmacs { get; set; } = null!;
        public virtual DbSet<StatisServerConfig> StatisServerConfigs { get; set; } = null!;
        public virtual DbSet<StatisServerLog> StatisServerLogs { get; set; } = null!;
        public virtual DbSet<StatisType> StatisTypes { get; set; } = null!;
        public virtual DbSet<StatisUser> StatisUsers { get; set; } = null!;
        public virtual DbSet<SyncActivityPush> SyncActivityPushes { get; set; } = null!;
        public virtual DbSet<SyncAgentInfo> SyncAgentInfos { get; set; } = null!;
        public virtual DbSet<SyncApiInternal> SyncApiInternals { get; set; } = null!;
        public virtual DbSet<SyncApiManage> SyncApiManages { get; set; } = null!;
        public virtual DbSet<SyncFileDownload> SyncFileDownloads { get; set; } = null!;
        public virtual DbSet<SyncGameClass> SyncGameClasses { get; set; } = null!;
        public virtual DbSet<SyncGameConfig> SyncGameConfigs { get; set; } = null!;
        public virtual DbSet<SyncGameInfo> SyncGameInfos { get; set; } = null!;
        public virtual DbSet<SyncGameOpen> SyncGameOpens { get; set; } = null!;
        public virtual DbSet<SyncGameRecord> SyncGameRecords { get; set; } = null!;
        public virtual DbSet<SyncGameType> SyncGameTypes { get; set; } = null!;
        public virtual DbSet<SyncGameUrl> SyncGameUrls { get; set; } = null!;
        public virtual DbSet<SyncMessage> SyncMessages { get; set; } = null!;
        public virtual DbSet<SysBulletinAuto> SysBulletinAutos { get; set; } = null!;
        public virtual DbSet<SysBulletinAutoLog> SysBulletinAutoLogs { get; set; } = null!;
        public virtual DbSet<SysBulletinRecord> SysBulletinRecords { get; set; } = null!;
        public virtual DbSet<TbDic> TbDics { get; set; } = null!;
        public virtual DbSet<TbLang> TbLangs { get; set; } = null!;
        public virtual DbSet<TbManager> TbManagers { get; set; } = null!;
        public virtual DbSet<TbManagerLog> TbManagerLogs { get; set; } = null!;
        public virtual DbSet<TbManagerRole> TbManagerRoles { get; set; } = null!;
        public virtual DbSet<TbManagerRoleValue> TbManagerRoleValues { get; set; } = null!;
        public virtual DbSet<TbNav> TbNavs { get; set; } = null!;
        public virtual DbSet<TbNavNew> TbNavNews { get; set; } = null!;
        public virtual DbSet<UpdateVersion> UpdateVersions { get; set; } = null!;
        public virtual DbSet<UserTransferLog> UserTransferLogs { get; set; } = null!;
        public virtual DbSet<WarningConfig> WarningConfigs { get; set; } = null!;
        public virtual DbSet<WarningSafe> WarningSaves { get; set; } = null!;
        public virtual DbSet<WarningSendLog> WarningSendLogs { get; set; } = null!;
        public virtual DbSet<WarningUser> WarningUsers { get; set; } = null!;
        public virtual DbSet<WarningUserGroup> WarningUserGroups { get; set; } = null!;
        public virtual DbSet<WebConfig> WebConfigs { get; set; } = null!;
        public virtual DbSet<WebConfigLog> WebConfigLogs { get; set; } = null!;
        public virtual DbSet<DwRtpPreprimed> DwRtpPreprimeds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.10.37;port=3306;database=managedb;user=root;password=1qasde32;max pool size=100;min pool size=5;convertzerodatetime=True", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.20-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<DwRtpPreprimed>(entity =>
            {
                entity.HasKey(e => e.GameId)
                    .HasName("PRIMARY");

                entity.ToTable("dw_rtp_preprimed");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("需客製化RTP的遊戲ID");

                entity.Property(e => e.BetInit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_init")
                    .HasComment("客製化初始下注額");

                entity.Property(e => e.PrizeInit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prize_init")
                    .HasComment("客製化初始獎金額");

            });

            modelBuilder.Entity<AccountAdminLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("account_admin_log");

                entity.HasComment("用户账户操作记录");

                entity.HasIndex(e => new { e.PlayerId, e.Name }, "ix_playerid_name");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("记录编号");

                entity.Property(e => e.ChangeMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("change_money")
                    .HasComment("金额");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.Name)
                    .HasMaxLength(36)
                    .HasColumnName("name")
                    .HasComment("用户账号");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("player_id")
                    .HasComment("用户编号");

                entity.Property(e => e.ReMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("re_money")
                    .HasComment("账户余额");

                entity.Property(e => e.Reson)
                    .HasMaxLength(128)
                    .HasColumnName("reson")
                    .HasComment("修改原因");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'1'")
                    .HasComment("操作类型 1 人工，2 抽奖，5 红包雨");
            });

            modelBuilder.Entity<AccountExchangeLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("account_exchange_log");

                entity.HasComment("账户转换记录");

                entity.HasIndex(e => new { e.ExTime, e.State }, "ix_extime_state");

                entity.HasIndex(e => e.Name, "ix_name");

                entity.HasIndex(e => e.Orderid, "ix_orderid")
                    .IsUnique();

                entity.HasIndex(e => e.PlayerId, "ix_palyerid");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Device)
                    .HasMaxLength(32)
                    .HasColumnName("device")
                    .HasComment("设备")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ex_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转换金额");

                entity.Property(e => e.ExRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("ex_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转换比率");

                entity.Property(e => e.ExTime)
                    .HasColumnType("datetime")
                    .HasColumnName("ex_time")
                    .HasComment("转换时间");

                entity.Property(e => e.ExType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("ex_type")
                    .HasComment("转换类型 1 转入，2 转出");

                entity.Property(e => e.IpAddr)
                    .HasMaxLength(32)
                    .HasColumnName("ip_addr")
                    .HasComment("IP地址")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Mark)
                    .HasMaxLength(64)
                    .HasColumnName("mark")
                    .HasDefaultValueSql("''")
                    .HasComment("备注")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name")
                    .HasComment("用户账号")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(100)
                    .HasColumnName("orderid")
                    .HasDefaultValueSql("''")
                    .HasComment("订单编号 O+unix时间+8位大定随机字母数字");

                entity.Property(e => e.OutSxf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("out_sxf")
                    .HasDefaultValueSql("'0'")
                    .HasComment("出账手续费");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("player_id")
                    .HasComment("用户编号");

                entity.Property(e => e.ReCredit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("re_credit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("授信余额");

                entity.Property(e => e.ReMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("re_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("账户余额");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转换状态 0 未转换，1 成功，2 失败");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.ThreeMoney)
                    .HasPrecision(14, 4)
                    .HasColumnName("three_money")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("第三方金额");

                entity.Property(e => e.ThreeSxf)
                    .HasPrecision(14, 4)
                    .HasColumnName("three_sxf")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("第三方手续费");
            });

            modelBuilder.Entity<AccountExchangeLogBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("account_exchange_log_bk");

                entity.Property(e => e.Device)
                    .HasMaxLength(32)
                    .HasColumnName("device")
                    .HasComment("设备")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.ExMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ex_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转换金额");

                entity.Property(e => e.ExRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("ex_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转换比率");

                entity.Property(e => e.ExTime)
                    .HasColumnType("datetime")
                    .HasColumnName("ex_time")
                    .HasComment("转换时间");

                entity.Property(e => e.ExType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("ex_type")
                    .HasComment("转换类型 1 转入，2 转出");

                entity.Property(e => e.IpAddr)
                    .HasMaxLength(32)
                    .HasColumnName("ip_addr")
                    .HasComment("IP地址")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Mark)
                    .HasMaxLength(64)
                    .HasColumnName("mark")
                    .HasDefaultValueSql("''")
                    .HasComment("备注")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name")
                    .HasComment("用户账号")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Orderid)
                    .HasMaxLength(100)
                    .HasColumnName("orderid")
                    .HasDefaultValueSql("''")
                    .HasComment("订单编号 O+unix时间+8位大定随机字母数字");

                entity.Property(e => e.OutSxf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("out_sxf")
                    .HasDefaultValueSql("'0'")
                    .HasComment("出账手续费");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("player_id")
                    .HasComment("用户编号");

                entity.Property(e => e.ReCredit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("re_credit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("授信余额");

                entity.Property(e => e.ReMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("re_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("账户余额");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转换状态 0 未转换，1 成功，2 失败");

                entity.Property(e => e.ThreeMoney)
                    .HasPrecision(14, 4)
                    .HasColumnName("three_money")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("第三方金额");

                entity.Property(e => e.ThreeSxf)
                    .HasPrecision(14, 4)
                    .HasColumnName("three_sxf")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("第三方手续费");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");
            });

            modelBuilder.Entity<AgentCreditLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("agent_credit_log");

                entity.HasComment("授信操作日志");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AddCredit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_credit")
                    .HasComment("增加金额");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasColumnName("add_time")
                    .HasComment("操作时间");

                entity.Property(e => e.AgentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("agent_id")
                    .HasComment("代理编号");

                entity.Property(e => e.GAgentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("g_agent_id")
                    .HasComment("总代编号");

                entity.Property(e => e.GPlatform)
                    .HasMaxLength(32)
                    .HasColumnName("g_platform")
                    .HasComment("总代名称");

                entity.Property(e => e.GReCredit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("g_re_credit")
                    .HasComment("总代剩余");

                entity.Property(e => e.Platform)
                    .HasMaxLength(32)
                    .HasColumnName("platform")
                    .HasComment("平台名称");

                entity.Property(e => e.ReCredit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("re_credit")
                    .HasComment("剩余金额");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("类型 1  系统，2 总代");
            });

            modelBuilder.Entity<AgentGameList>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PRIMARY");

                entity.ToTable("agent_game_list");

                entity.HasComment("我的游戏")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.RecordId)
                    .HasColumnType("int(11)")
                    .HasColumnName("record_id")
                    .HasComment("记录ID，唯一");

                entity.Property(e => e.AgentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("agent_id")
                    .HasComment("代理ID");

                entity.Property(e => e.BetInit)
                    .HasColumnType("float(12,3)")
                    .HasColumnName("bet_init")
                    .HasComment("投注起始底分");

                entity.Property(e => e.BetLevel)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bet_level")
                    .HasDefaultValueSql("'1'")
                    .HasComment("投注默认等级 默认1");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.Currency)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'0'")
                    .HasComment("货币符号");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏ID");

                entity.Property(e => e.GameStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_status")
                    .HasDefaultValueSql("'0'")
                    .HasComment("游戏状态 1 正常，2 关闭");

                entity.Property(e => e.IsAccessApp)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_access_app")
                    .HasDefaultValueSql("'1'")
                    .HasComment("访问app 0 no, 1 yes");

                entity.Property(e => e.IsAccessH5)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_access_h5")
                    .HasDefaultValueSql("'1'")
                    .HasComment("访问H5 0 no, 1 yes");

                entity.Property(e => e.IsAccessWebgl)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_access_webgl")
                    .HasDefaultValueSql("'1'")
                    .HasComment("访问webgl 0 no, 1 yes");

                entity.Property(e => e.IsFreespin)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_freespin")
                    .HasDefaultValueSql("'0'")
                    .HasComment("免费投注功能开关 0 关，1 开");

                entity.Property(e => e.IsFreespinOpen)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_freespin_open")
                    .HasDefaultValueSql("'0'")
                    .HasComment("游戏参与freespin抽奖开关，0 参与-开启，1 关闭，默认开启");

                entity.Property(e => e.IsLottery)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_lottery")
                    .HasDefaultValueSql("'0'")
                    .HasComment("抽奖开关 0 关闭，1 开启");

                entity.Property(e => e.PayAmount)
                    .HasColumnType("int(11)")
                    .HasColumnName("pay_amount")
                    .HasComment("购买数量");

                entity.Property(e => e.RatioMultiple)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("ratio_multiple")
                    .HasDefaultValueSql("'1'")
                    .HasComment("游戏比倍开关 0 关闭，1  开启");

                entity.Property(e => e.RedrainBetcounts)
                    .HasMaxLength(16)
                    .HasColumnName("redrain_betcounts")
                    .HasDefaultValueSql("''")
                    .HasComment("红包雨累计投注范围");

                entity.Property(e => e.RedrainOff)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("redrain_off")
                    .HasDefaultValueSql("'0'")
                    .HasComment("红包雨开关 0 关闭，1 开启");

                entity.Property(e => e.ShowInfo)
                    .HasMaxLength(128)
                    .HasColumnName("show_info")
                    .HasDefaultValueSql("''")
                    .HasComment("提示信息 弹窗消息，空字符-无消息不弹窗")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TypeId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");

                entity.Property(e => e.UseAmount)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_amount")
                    .HasComment("已用数量");
            });

            modelBuilder.Entity<ApiWhitelist>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("api_whitelist");

                entity.HasComment("IP白名单")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.IpAddr)
                    .HasMaxLength(20)
                    .HasColumnName("ip_addr")
                    .HasComment("IP地址");

                entity.Property(e => e.LimitType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("limit_type")
                    .HasComment("限制类型 1 API,2 后台");

                entity.Property(e => e.Mark)
                    .HasMaxLength(64)
                    .HasColumnName("mark")
                    .HasDefaultValueSql("''")
                    .HasComment("备注")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("state")
                    .HasComment("状态 0 正常，1 关闭，-1 删除");
            });

            modelBuilder.Entity<ClientAccessDatum>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("client_access_data");

                entity.HasComment("客户端数据收集");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("序号");

                entity.Property(e => e.AccessId)
                    .HasMaxLength(16)
                    .HasColumnName("access_id")
                    .HasComment("访问唯一编号");

                entity.Property(e => e.Account)
                    .HasMaxLength(34)
                    .HasColumnName("account")
                    .HasComment("用户名");

                entity.Property(e => e.BonwserInfo)
                    .HasMaxLength(1024)
                    .HasColumnName("bonwser_info")
                    .HasDefaultValueSql("''")
                    .HasComment("浏览器信息");

                entity.Property(e => e.BrowserName)
                    .HasMaxLength(32)
                    .HasColumnName("browser_name")
                    .HasDefaultValueSql("''")
                    .HasComment("浏览器名称");

                entity.Property(e => e.BrowserVer)
                    .HasMaxLength(32)
                    .HasColumnName("browser_ver")
                    .HasDefaultValueSql("''")
                    .HasComment("浏览器版本");

                entity.Property(e => e.DownCost)
                    .HasColumnType("int(11)")
                    .HasColumnName("down_cost")
                    .HasDefaultValueSql("'0'")
                    .HasComment("下载耗时");

                entity.Property(e => e.DownEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("down_end")
                    .HasComment("结束下载");

                entity.Property(e => e.DownStart)
                    .HasColumnType("datetime")
                    .HasColumnName("down_start")
                    .HasComment("开始下载");

                entity.Property(e => e.FileUnrar)
                    .HasColumnType("datetime")
                    .HasColumnName("file_unrar")
                    .HasComment("文件解压");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.InsertTime)
                    .HasColumnType("datetime")
                    .HasColumnName("insert_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("写入时间");

                entity.Property(e => e.IpAddr)
                    .HasMaxLength(15)
                    .HasColumnName("ip_addr")
                    .HasDefaultValueSql("''")
                    .HasComment("IP地址");

                entity.Property(e => e.Network)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("network")
                    .HasDefaultValueSql("'0'")
                    .HasComment("上网方式 0 未知，1 4G/5G  ,2  WIFI");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'0'")
                    .HasComment("访问状态  0  未完成，1 已完成");

                entity.Property(e => e.Terminal)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("terminal")
                    .HasDefaultValueSql("'0'")
                    .HasComment("访问平台  0 未知 1 PC，2 安卓，3 IOS");

                entity.Property(e => e.UnrarCost)
                    .HasColumnType("int(11)")
                    .HasColumnName("unrar_cost")
                    .HasDefaultValueSql("'0'")
                    .HasComment("解压耗时");
            });

            modelBuilder.Entity<DataTimeZone>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("data_time_zone");

                entity.HasComment("时区");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.IsUse)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_use")
                    .HasDefaultValueSql("'0'")
                    .HasComment("当前使用  0 NO,1 YES");

                entity.Property(e => e.Timezone)
                    .HasMaxLength(10)
                    .HasColumnName("timezone")
                    .HasComment("时区");
            });

            modelBuilder.Entity<DictionaryManaged>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PRIMARY");

                entity.ToTable("dictionary_managed");

                entity.HasComment("字典管理");

                entity.HasIndex(e => e.TableName, "ix_table_name");

                entity.Property(e => e.RecordId)
                    .HasColumnType("int(11)")
                    .HasColumnName("record_id")
                    .HasComment("记录ID");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(32)
                    .HasColumnName("column_name")
                    .HasComment("字段名");

                entity.Property(e => e.ColumnValue)
                    .HasMaxLength(10)
                    .HasColumnName("column_value")
                    .HasComment("字段值");

                entity.Property(e => e.LanguageId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("language_id")
                    .HasDefaultValueSql("'1'")
                    .HasComment("语言ID");

                entity.Property(e => e.TableDescribe)
                    .HasMaxLength(64)
                    .HasColumnName("table_describe")
                    .HasComment("表描述");

                entity.Property(e => e.TableName)
                    .HasMaxLength(32)
                    .HasColumnName("table_name")
                    .HasComment("表名");

                entity.Property(e => e.ValueDescribe)
                    .HasMaxLength(128)
                    .HasColumnName("value_describe")
                    .HasComment("值描述");
            });

            modelBuilder.Entity<DwChangeLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("dw_change_log");

                entity.HasComment("档位修改记录");

                entity.HasIndex(e => e.AgentId, "ix_agentid");

                entity.HasIndex(e => new { e.ClassId, e.GameId }, "ix_classid_gameid");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AgentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("agent_id")
                    .HasComment("代理编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.DwId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dw_id")
                    .HasComment("档位编号");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(11)")
                    .HasColumnName("room_id")
                    .HasComment("房间编号");
            });

            modelBuilder.Entity<DwConfig>(entity =>
            {
                entity.HasKey(e => new { e.DwId, e.ClassId, e.GameId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("dw_config");

                entity.HasComment("档位配置");

                entity.Property(e => e.DwId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dw_id")
                    .HasComment("编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.DwName)
                    .HasMaxLength(16)
                    .HasColumnName("dw_name")
                    .HasDefaultValueSql("''")
                    .HasComment("名称");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasDefaultValueSql("''")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");
            });

            modelBuilder.Entity<DwConfigAuto>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("dw_config_auto");

                entity.HasComment("自动档位配置");

                entity.HasIndex(e => new { e.AgentId, e.ClassId, e.GameId }, "ix_agentid_classid_gameid");

                entity.HasIndex(e => e.StimeInt, "ix_stimeint");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AgentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("agent_id")
                    .HasComment("代理编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.DwId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dw_id")
                    .HasComment("档位编号");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.Stime)
                    .HasMaxLength(5)
                    .HasColumnName("stime")
                    .HasComment("开始时间");

                entity.Property(e => e.StimeInt)
                    .HasColumnType("int(11)")
                    .HasColumnName("stime_int")
                    .HasDefaultValueSql("'0'")
                    .HasComment("开始时间 整型");
            });

            modelBuilder.Entity<DwConfigGame>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("dw_config_game");

                entity.HasComment("游戏档位配置");

                entity.HasIndex(e => new { e.AgentId, e.ClassId, e.GameId }, "ix_agentid_classid_gameid");

                entity.HasIndex(e => e.IsAuto, "ix_isauto");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AgentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("agent_id")
                    .HasComment("代理编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.DwId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dw_id")
                    .HasComment("档位编号");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.IsAuto)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_auto")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否自动 0 no,1 yes");

                entity.Property(e => e.IsRead)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_read")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否读取 0 no,1 yes");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.ResetBet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reset_bet")
                    .HasDefaultValueSql("'0'")
                    .HasComment("重置下注");

                entity.Property(e => e.ResetBetcounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("reset_betcounts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("重置下注次数");

                entity.Property(e => e.ResetPrize)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reset_prize")
                    .HasDefaultValueSql("'0'")
                    .HasComment("重置派彩");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(11)")
                    .HasColumnName("room_id")
                    .HasComment("房间编号 预留");

                entity.Property(e => e.RtpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("rtp_time")
                    .HasComment("当前RTP时间");

                entity.Property(e => e.RtpVal)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("rtp_val")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("当前RTP值");

                entity.Property(e => e.TakeBetcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("take_betcount")
                    .HasDefaultValueSql("'0'")
                    .HasComment("生效下注次数");

                entity.Property(e => e.TypeId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<DwConfigTrigger>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("dw_config_trigger");

                entity.HasComment("自动切换档位触发配置");

                entity.HasIndex(e => e.GameId, "ix_gameid");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.DwId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("dw_id")
                    .HasComment("触发档位");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.TriggerVal)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger_val")
                    .HasComment("触发阀值");
            });

            modelBuilder.Entity<DwDic>(entity =>
            {
                entity.ToTable("dw_dic");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CallIndex).HasColumnName("call_index");

                entity.Property(e => e.IsNew).HasColumnName("is_new");

                entity.Property(e => e.LangId)
                    .HasColumnType("int(11)")
                    .HasColumnName("lang_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<DwGameList>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("dw_game_list");

                entity.HasComment("档位游戏列表");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");
            });

            modelBuilder.Entity<DwNav>(entity =>
            {
                entity.ToTable("dw_nav");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("action_type");

                entity.Property(e => e.IconUrl).HasColumnName("icon_url");

                entity.Property(e => e.IsHide).HasColumnName("is_hide");

                entity.Property(e => e.IsSys)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_sys");

                entity.Property(e => e.LinkUrl).HasColumnName("link_url");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.SortId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_id");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<DwRtpLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("dw_rtp_log");

                entity.HasComment("游戏RTP记录");

                entity.HasIndex(e => e.GameId, "ix_gameid");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.CountBet)
                    .HasColumnType("int(11)")
                    .HasColumnName("count_bet")
                    .HasComment("下注次数");

                entity.Property(e => e.CountPrize)
                    .HasColumnType("int(11)")
                    .HasColumnName("count_prize")
                    .HasComment("派彩次数");

                entity.Property(e => e.DwIdNew)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("dw_id_new")
                    .HasComment("档位编号_新");

                entity.Property(e => e.DwIdOld)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("dw_id_old")
                    .HasComment("档位编号_旧");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.InsertTime)
                    .HasColumnType("datetime")
                    .HasColumnName("insert_time")
                    .HasComment("记录时间");

                entity.Property(e => e.IsReset)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_reset")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否已重置 0 NO,1 YES");

                entity.Property(e => e.IsTake)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_take")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否已生产 0 NO,1 YES");

                entity.Property(e => e.Rtp)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("rtp")
                    .HasComment("RTP");

                entity.Property(e => e.TotalBet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("total_bet")
                    .HasComment("累计下注");

                entity.Property(e => e.TotalPrize)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("total_prize")
                    .HasComment("累计派彩");
            });

            modelBuilder.Entity<EventHistory>(entity =>
            {
                entity.HasKey(e => new { e.Dbname, e.Eventname, e.Starttime })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("event_history");

                entity.HasIndex(e => e.Endtime, "ix_endtime");

                entity.HasIndex(e => new { e.Starttime, e.Randno }, "ix_starttime_randno");

                entity.Property(e => e.Dbname)
                    .HasMaxLength(128)
                    .HasColumnName("dbname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eventname)
                    .HasMaxLength(128)
                    .HasColumnName("eventname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("starttime");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("endtime");

                entity.Property(e => e.Errormessage)
                    .HasMaxLength(512)
                    .HasColumnName("errormessage");

                entity.Property(e => e.Issuccess)
                    .HasColumnType("int(11)")
                    .HasColumnName("issuccess");

                entity.Property(e => e.Randno)
                    .HasColumnType("int(11)")
                    .HasColumnName("randno");
            });

            modelBuilder.Entity<FreebetAdminLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("freebet_admin_log");

                entity.HasComment("免费下注次数发放记录");

                entity.HasIndex(e => e.GameId, "ix_gameid");

                entity.HasIndex(e => new { e.PlayerId, e.Name }, "ix_playerid_name");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号  0 全部，其他 游戏编号");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("操作人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("操作时间");

                entity.Property(e => e.Name)
                    .HasMaxLength(36)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasComment("玩家账号 ");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("player_id")
                    .HasComment("玩家编号 0 全部，其他 玩家编号");

                entity.Property(e => e.SendCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("send_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("发送数量");

                entity.Property(e => e.SendType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("send_type")
                    .HasDefaultValueSql("'1'")
                    .HasComment("赠送类型 1 免费投注，2 抽奖");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'1'")
                    .HasComment("操作类型 1 人工，2 抽奖，5 红包雨");
            });

            modelBuilder.Entity<FreebetLottery>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("freebet_lottery");

                entity.HasComment("免费投注-抽奖配置");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.Nums)
                    .HasColumnType("int(11)")
                    .HasColumnName("nums")
                    .HasComment("数量");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("类型 1 点数，2 免费投注次数");

                entity.Property(e => e.Weight)
                    .HasColumnType("int(11)")
                    .HasColumnName("weight")
                    .HasComment("权值");
            });

            modelBuilder.Entity<GameCurrency>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("game_currency");

                entity.HasComment("游戏运营货币表");

                entity.Property(e => e.Uid)
                    .HasColumnType("tinyint(4)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.CurDecimal)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("cur_decimal")
                    .HasComment("小数位");

                entity.Property(e => e.CurName)
                    .HasMaxLength(10)
                    .HasColumnName("cur_name")
                    .HasComment("名称");

                entity.Property(e => e.CurNameEn)
                    .HasMaxLength(5)
                    .HasColumnName("cur_name_en")
                    .HasDefaultValueSql("''")
                    .HasComment("货币简写");

                entity.Property(e => e.CurSign)
                    .HasMaxLength(5)
                    .HasColumnName("cur_sign")
                    .HasComment("符号");
            });

            modelBuilder.Entity<GameJump>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("game_jump");

                entity.HasComment("游戏跳转");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.JumpType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("jump_type")
                    .HasDefaultValueSql("'0'")
                    .HasComment("跳转方式 0 无跳转，1 跳转页面，2 调用方法");

                entity.Property(e => e.JumpUrl)
                    .HasMaxLength(512)
                    .HasColumnName("jump_url")
                    .HasComment("跳转地址");
            });

            modelBuilder.Entity<IpChina>(entity =>
            {
                entity.HasKey(e => new { e.Sint, e.Eint })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("ip_china");

                entity.Property(e => e.Sint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sint")
                    .HasComment("开始IP整型");

                entity.Property(e => e.Eint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("eint")
                    .HasComment("结束IP整型");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .HasComment("城市");

                entity.Property(e => e.Province)
                    .HasMaxLength(30)
                    .HasComment("省份");
            });

            modelBuilder.Entity<IpdataDny>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("ipdata_dny");

                entity.HasIndex(e => e.IpFrom, "idx_ip_from");

                entity.HasIndex(e => new { e.IpFrom, e.IpTo }, "idx_ip_from_to");

                entity.HasIndex(e => e.IpTo, "idx_ip_to");

                entity.HasIndex(e => e.CityName, "ix_city_name");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid");

                entity.Property(e => e.CityCnname)
                    .HasMaxLength(128)
                    .HasColumnName("city_cnname");

                entity.Property(e => e.CityName)
                    .HasMaxLength(128)
                    .HasColumnName("city_name");

                entity.Property(e => e.CountryCnname)
                    .HasMaxLength(64)
                    .HasColumnName("country_cnname")
                    .UseCollation("utf8_bin");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .HasColumnName("country_code")
                    .IsFixedLength()
                    .UseCollation("utf8_bin");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(64)
                    .HasColumnName("country_name");

                entity.Property(e => e.IpFrom)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ip_from");

                entity.Property(e => e.IpTo)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ip_to");

                entity.Property(e => e.RegionCnname)
                    .HasMaxLength(128)
                    .HasColumnName("region_cnname");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(128)
                    .HasColumnName("region_name");
            });

            modelBuilder.Entity<LabelStatisActive>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_active");

                entity.HasComment("活跃统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Device, "ix_device");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.ActiveUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("active_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("活跃人数");

                entity.Property(e => e.AddUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("新增人数");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.Device)
                    .HasMaxLength(10)
                    .HasColumnName("device")
                    .HasComment("设备类型");

                entity.Property(e => e.FifteenKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("fifteen_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("保留15天");

                entity.Property(e => e.FiveKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("five_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("五日留存");

                entity.Property(e => e.SevenKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("seven_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("七日留存");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.ThirtyKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("thirty_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("保留30天");

                entity.Property(e => e.ThreeKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("three_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("三日留存");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1，汇总，2 按设备");

                entity.Property(e => e.YesdKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("yesd_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("次日留存");
            });

            modelBuilder.Entity<LabelStatisExchange>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_exchange");

                entity.HasComment("账户转换统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("日期");

                entity.Property(e => e.ExinCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("exin_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转入次数");

                entity.Property(e => e.ExinMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exin_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转入金额");

                entity.Property(e => e.ExinRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("exin_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转入比率");

                entity.Property(e => e.ExinThrMoney)
                    .HasPrecision(20, 2)
                    .HasColumnName("exin_thr_money")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("转入第三方金额");

                entity.Property(e => e.ExinUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("exin_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转入人数");

                entity.Property(e => e.ExoutCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("exout_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转出次数");

                entity.Property(e => e.ExoutMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exout_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转出金额");

                entity.Property(e => e.ExoutMoneyRate)
                    .HasPrecision(8, 4)
                    .HasColumnName("exout_money_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转出金额占比  转出金额/(转入金额+转出金额)百分比 保留两位小数，不四舍");

                entity.Property(e => e.ExoutRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("exout_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转出比率");

                entity.Property(e => e.ExoutThrMoney)
                    .HasPrecision(20, 2)
                    .HasColumnName("exout_thr_money")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("转出第三方金额");

                entity.Property(e => e.ExoutUserRate)
                    .HasPrecision(8, 4)
                    .HasColumnName("exout_user_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转出人数占比  转出人数/(转入人数+转出人数)百分比 保留两位小数，不四舍");

                entity.Property(e => e.ExoutUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("exout_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转出人数");

                entity.Property(e => e.OutSxf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("out_sxf")
                    .HasDefaultValueSql("'0'")
                    .HasComment("出账手续费");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏   转出金额 - 转入金额");

                entity.Property(e => e.ProftRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("proft_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比率   盈亏/转入金额 百分比 保留两位小数。不四舍");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.ThrProfit)
                    .HasPrecision(20, 2)
                    .HasColumnName("thr_profit")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("第三方盈亏");

                entity.Property(e => e.ThrProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("thr_profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("第三方盈亏率。");

                entity.Property(e => e.ThreeSxf)
                    .HasPrecision(20, 2)
                    .HasColumnName("three_sxf")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("第三方手续费");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");
            });

            modelBuilder.Entity<LabelStatisFreebet>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_freebet");

                entity.HasComment("免费下注统计-子平台");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP用户数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP点数");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("用户数");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<LabelStatisFreebetLottery>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_freebet_lottery");

                entity.HasComment("免费下注抽奖统计-标签分组");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派彩金额");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("日期");

                entity.Property(e => e.LotterySum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("抽奖金额");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");
            });

            modelBuilder.Entity<LabelStatisGame>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_game");

                entity.HasComment("游戏数据统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.ClassId, e.GameId }, "ix_class_game");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏  派奖-押注");

                entity.Property(e => e.ProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比例 (派奖-押注)/押注");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<LabelStatisGameOnline>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_game_online");

                entity.HasComment("游戏在线人数统计表 分：保存2小时数据，时：24小时，日：31日，月：12月")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.DataType, "ix_datatype");

                entity.HasIndex(e => new { e.DataType, e.StatisTime }, "ix_datatype_time");

                entity.HasIndex(e => e.Device, "ix_device");

                entity.HasIndex(e => new { e.TimeType, e.StatisTime }, "ix_timetype_statistime");

                entity.Property(e => e.RecordId)
                    .HasColumnType("int(11)")
                    .HasColumnName("record_id")
                    .HasComment("记录编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.DataType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("data_type")
                    .HasComment("数据类别 1 汇总，2 按游戏，3 按设备");

                entity.Property(e => e.Device)
                    .HasMaxLength(10)
                    .HasColumnName("device")
                    .HasComment("设备类型 ");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏ID");

                entity.Property(e => e.OnlineAmount)
                    .HasColumnType("int(11)")
                    .HasColumnName("online_amount")
                    .HasDefaultValueSql("'0'")
                    .HasComment("在线人数 单位时间最高同时在线");

                entity.Property(e => e.StatisTime)
                    .HasColumnType("datetime")
                    .HasColumnName("statis_time")
                    .HasComment("统计时间");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.TimeType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("time_type")
                    .HasComment("时间分类 1 分，2 时，3 日，4 月");
            });

            modelBuilder.Entity<LabelStatisJp>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_jp");

                entity.HasComment("JP统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.JpCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("jp_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP次数");

                entity.Property(e => e.JpSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("jp_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP点数");

                entity.Property(e => e.JpUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("jp_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP用户数");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<LabelStatisProfit>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_profit");

                entity.HasComment("结算数据统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏");

                entity.Property(e => e.ProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比例");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");
            });

            modelBuilder.Entity<LabelStatisProfitUser>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_profit_user");

                entity.HasComment("结算数据统计-用户")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => new { e.PlayerId, e.Name }, "ix_playerid_name");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasComment("用户账号")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("player_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("用户编号");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏");

                entity.Property(e => e.ProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比例");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");
            });

            modelBuilder.Entity<LabelStatisType>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("label_statis_type");

                entity.HasComment("分类数据统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.TypeId, "ix_class_game");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏");

                entity.Property(e => e.ProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比例");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<MessageReadLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("message_read_log");

                entity.HasComment("内部信息阅读记录");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("信息编号");

                entity.Property(e => e.IsUpload)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_upload")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否上传 0 no ,1 yes");

                entity.Property(e => e.ReadTime)
                    .HasColumnType("datetime")
                    .HasColumnName("read_time")
                    .HasComment("阅读时间");
            });

            modelBuilder.Entity<PriceConfigRoulette>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("price_config_roulette");

                entity.HasComment("轮盘价格配置表");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AgentLevel)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("agent_level")
                    .HasDefaultValueSql("'0'")
                    .HasComment("代理等级");

                entity.Property(e => e.AssmbleBet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("assmble_bet")
                    .HasComment("组合号码累计押注触发");

                entity.Property(e => e.AssmbleLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("assmble_limit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("组合号码累计押注限制");

                entity.Property(e => e.BankerLowerLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("banker_lower_limit")
                    .HasComment("庄家筹码下限");

                entity.Property(e => e.BankerReplenish)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("banker_replenish")
                    .HasDefaultValueSql("'0'")
                    .HasComment("庄家续筹码 0 no ,1 yes");

                entity.Property(e => e.BankerUpperLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("banker_upper_limit")
                    .HasComment("庄家筹码上限");

                entity.Property(e => e.BetChip1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_1")
                    .HasComment("押注筹码1档");

                entity.Property(e => e.BetChip2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_2")
                    .HasComment("押注筹码2档");

                entity.Property(e => e.BetChip3)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_3")
                    .HasComment("押注筹码3档");

                entity.Property(e => e.BetChip4)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_4")
                    .HasComment("押注筹码4档");

                entity.Property(e => e.BetChip5)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_5")
                    .HasComment("押注筹码5档");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.CurrencySign)
                    .HasMaxLength(10)
                    .HasColumnName("currency_sign")
                    .HasComment("货币符号");

                entity.Property(e => e.DownSafeValue)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("down_safe_value")
                    .HasDefaultValueSql("'0'")
                    .HasComment("下庄安全阀值 百分比");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.InningsMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("innings_max")
                    .HasComment("最大局数 0 无限制");

                entity.Property(e => e.IsUserBanker)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_user_banker")
                    .HasDefaultValueSql("'0'")
                    .HasComment("允许玩家上庄 0 否，1 是");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.OrderType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("order_type")
                    .HasDefaultValueSql("'1'")
                    .HasComment("排序类型   1-10  升序 【(预留) 1 置顶，2 在线人数，3 自动】");

                entity.Property(e => e.Price)
                    .HasPrecision(12, 2)
                    .HasColumnName("price")
                    .HasComment("价格");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(32)
                    .HasColumnName("room_name")
                    .HasComment("房间名称");

                entity.Property(e => e.RoomTag)
                    .HasMaxLength(10)
                    .HasColumnName("room_tag")
                    .HasComment("房间标签 比如 低， 中， 高");

                entity.Property(e => e.SingleNumberBet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_number_bet")
                    .HasComment("单号码累计押注触发");

                entity.Property(e => e.SingleNumberLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_number_limit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("单号码累计押注限制");

                entity.Property(e => e.UseDate)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("use_date")
                    .HasDefaultValueSql("'30'")
                    .HasComment("使用天数 30天=1个月");

                entity.Property(e => e.UserBankerChips)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_banker_chips")
                    .HasComment("玩家上庄筹码");

                entity.Property(e => e.UserBankerInnings)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_banker_innings")
                    .HasComment("玩家上庄局数");

                entity.Property(e => e.UsersMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("users_max")
                    .HasComment("最大人数");

                entity.Property(e => e.VipLimit)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("vip_limit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("VIP限制 (预留) 0 不限制，1 只有VIP可以进入");
            });

            modelBuilder.Entity<PriceConfigRouletteLimit>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("price_config_roulette_limit");

                entity.HasComment("轮盘价格配置限制表");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.BankerLimitUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("banker_limit_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("庄家筹码上下限修改   0 yes ,1 no");

                entity.Property(e => e.BankerReplenishUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("banker_replenish_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("庄家续筹码修改 0 yes , 1 no");

                entity.Property(e => e.BetChipUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bet_chip_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("押注筹码修改   0 yes ,1 no");

                entity.Property(e => e.BetNumberLimitUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bet_number_limit_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("累计押注号码限制修改 0 yes, 1 no");

                entity.Property(e => e.BetNumberUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bet_number_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("累计押注号码触发修改  0 yes ,1 no");

                entity.Property(e => e.DownSafeValueUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("down_safe_value_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("下庄安全阀值修改 0 yes ,1 no");

                entity.Property(e => e.InningsMaxUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("innings_max_update")
                    .HasDefaultValueSql("'1'")
                    .HasComment("最大局数修改  0 yes ,1 no");

                entity.Property(e => e.IsUserBankerUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_user_banker_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("允许玩家上庄修改   0 yes ,1 no");

                entity.Property(e => e.OrderTypeUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("order_type_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("排序类型修改   0 yes ,1 no");

                entity.Property(e => e.RoomNameUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("room_name_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("房间名称修改  0 yes ,1 no");

                entity.Property(e => e.RoomTagUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("room_tag_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("房间标签修改   0 yes ,1 no");

                entity.Property(e => e.UserBankerUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("user_banker_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("玩家上下庄条件修改   0 yes ,1 no");

                entity.Property(e => e.UsersMaxUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("users_max_update")
                    .HasDefaultValueSql("'1'")
                    .HasComment("最大人数修改   0 yes ,1 no");

                entity.Property(e => e.VipLimitUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("vip_limit_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("VIP限制修改   0 yes ,1 no");
            });

            modelBuilder.Entity<RedrainConfig>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("redrain_config");

                entity.HasComment("红包雨配置");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.FreespinPrice)
                    .HasColumnType("int(11)")
                    .HasColumnName("freespin_price")
                    .HasDefaultValueSql("'0'")
                    .HasComment("freespin换算点数");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.TotalBetcounts)
                    .HasMaxLength(16)
                    .HasColumnName("total_betcounts")
                    .HasDefaultValueSql("''")
                    .HasComment("累计投注范围");
            });

            modelBuilder.Entity<RedrainReward>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("redrain_reward");

                entity.HasComment("红包雨奖励");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.Ratio)
                    .HasPrecision(7, 4)
                    .HasColumnName("ratio")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("比例 百分比");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("类型 1 点数，2 freespin");

                entity.Property(e => e.Weight)
                    .HasColumnType("int(11)")
                    .HasColumnName("weight")
                    .HasDefaultValueSql("'0'")
                    .HasComment("权重");
            });

            modelBuilder.Entity<RoomConfigRoulette>(entity =>
            {
                entity.HasKey(e => e.RoomId)
                    .HasName("PRIMARY");

                entity.ToTable("room_config_roulette");

                entity.HasComment("轮盘房间配置表");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("room_id")
                    .HasComment("房间编号");

                entity.Property(e => e.AgentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("agent_id")
                    .HasComment("代理编号");

                entity.Property(e => e.AssmbleBet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("assmble_bet")
                    .HasComment("组合号码累计押注触发");

                entity.Property(e => e.AssmbleLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("assmble_limit")
                    .HasComment("组合号码累计押注限制");

                entity.Property(e => e.BankerChipsNow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("banker_chips_now")
                    .HasComment("当前庄家筹码");

                entity.Property(e => e.BankerCoin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("banker_coin")
                    .HasComment("设定庄家筹码值");

                entity.Property(e => e.BankerLowerLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("banker_lower_limit")
                    .HasComment("庄家筹码下限");

                entity.Property(e => e.BankerNow)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("banker_now")
                    .HasComment("当前庄家 1 系统，2 玩家");

                entity.Property(e => e.BankerReplenish)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("banker_replenish")
                    .HasDefaultValueSql("'0'")
                    .HasComment("庄家续筹码 0 no,1  yes");

                entity.Property(e => e.BankerUpperLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("banker_upper_limit")
                    .HasComment("庄家筹码上限");

                entity.Property(e => e.BetChip1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_1")
                    .HasComment("押注筹码1档");

                entity.Property(e => e.BetChip2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_2")
                    .HasComment("押注筹码2档");

                entity.Property(e => e.BetChip3)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_3")
                    .HasComment("押注筹码3档");

                entity.Property(e => e.BetChip4)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_4")
                    .HasComment("押注筹码4档");

                entity.Property(e => e.BetChip5)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_chip_5")
                    .HasComment("押注筹码5档");

                entity.Property(e => e.BuyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("buy_time")
                    .HasComment("购买时间");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.ConfigState)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("config_state")
                    .HasDefaultValueSql("'0'")
                    .HasComment("配置状态 0 未配置，1 已配置");

                entity.Property(e => e.DownSafeValue)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("down_safe_value")
                    .HasDefaultValueSql("'0'")
                    .HasComment("下庄安全阀值 百分比");

                entity.Property(e => e.ExpireTime)
                    .HasColumnType("datetime")
                    .HasColumnName("expire_time")
                    .HasComment("到期时间");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.InningsMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("innings_max")
                    .HasComment("最大局数 0  无限制");

                entity.Property(e => e.InningsNow)
                    .HasColumnType("int(11)")
                    .HasColumnName("innings_now")
                    .HasDefaultValueSql("'0'")
                    .HasComment("当前局数");

                entity.Property(e => e.IsUserBanker)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_user_banker")
                    .HasDefaultValueSql("'0'")
                    .HasComment("允许玩家上庄 0 否，1 是");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.OrderType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("order_type")
                    .HasDefaultValueSql("'1'")
                    .HasComment("排序类型   1-10  升序 【(预留) 1 置顶，2 在线人数，3 自动】");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(32)
                    .HasColumnName("room_name")
                    .HasComment("房间名称");

                entity.Property(e => e.RoomState)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("room_state")
                    .HasDefaultValueSql("'0'")
                    .HasComment("房间状态 0 正常，1 关闭,-1删除");

                entity.Property(e => e.RoomTag)
                    .HasMaxLength(10)
                    .HasColumnName("room_tag")
                    .HasComment("房间标签 比如低中高");

                entity.Property(e => e.SingleNumberBet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_number_bet")
                    .HasComment("单号码累计押注触发");

                entity.Property(e => e.SingleNumberLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_number_limit")
                    .HasComment("单号码累计押注限制");

                entity.Property(e => e.UserBankerChips)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_banker_chips")
                    .HasComment("玩家上庄筹码");

                entity.Property(e => e.UserBankerInnings)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_banker_innings")
                    .HasComment("玩家上庄局数");

                entity.Property(e => e.UsersMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("users_max")
                    .HasComment("最大人数");

                entity.Property(e => e.UsersNow)
                    .HasColumnType("int(11)")
                    .HasColumnName("users_now")
                    .HasDefaultValueSql("'0'")
                    .HasComment("当前人数");

                entity.Property(e => e.VipLimit)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("vip_limit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("VIP限制 (预留) 0 不限制，1 只有VIP可以进入");
            });

            modelBuilder.Entity<RoomConfigRouletteLimit>(entity =>
            {
                entity.HasKey(e => e.RoomId)
                    .HasName("PRIMARY");

                entity.ToTable("room_config_roulette_limit");

                entity.HasComment("轮盘房间配置限制表");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("room_id")
                    .HasComment("房间编号");

                entity.Property(e => e.BankerLimitUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("banker_limit_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("庄家筹码上下限修改   0 yes ,1 no");

                entity.Property(e => e.BankerReplenishUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("banker_replenish_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("庄家续筹码修改 1 yes ,0 no");

                entity.Property(e => e.BetChipUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bet_chip_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("押注筹码修改   0 yes ,1 no");

                entity.Property(e => e.BetNumberLimitUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bet_number_limit_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("累计押注号码限制修改 0 yes ,1 no");

                entity.Property(e => e.BetNumberUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bet_number_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("累计押注号码触发修改   0 yes ,1 no");

                entity.Property(e => e.DownSafeValueUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("down_safe_value_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("下庄安全阀值修改 0 yes ,1 no");

                entity.Property(e => e.InningsMaxUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("innings_max_update")
                    .HasDefaultValueSql("'1'")
                    .HasComment("最大局数修改   0 yes ,1 no");

                entity.Property(e => e.IsUserBankerUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_user_banker_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("允许玩家上庄修改   0 yes ,1 no");

                entity.Property(e => e.OrderTypeUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("order_type_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("排序类型修改   0 yes ,1 no");

                entity.Property(e => e.RoomNameUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("room_name_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("房间名称修改   0 yes ,1 no");

                entity.Property(e => e.RoomTagUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("room_tag_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("房间标签修改  0 yes ,1 no");

                entity.Property(e => e.UserBankerUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("user_banker_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("玩家上下庄条件修改  0 yes ,1 no");

                entity.Property(e => e.UsersMaxUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("users_max_update")
                    .HasDefaultValueSql("'1'")
                    .HasComment("最大人数修改   0 yes ,1 no");

                entity.Property(e => e.VipLimitUpdate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("vip_limit_update")
                    .HasDefaultValueSql("'0'")
                    .HasComment("VIP限制修改   0 yes ,1 no");
            });

            modelBuilder.Entity<StatisActive>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_active");

                entity.HasComment("活跃统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Device, "ix_device");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.ActiveUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("active_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("活跃人数");

                entity.Property(e => e.AddUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("新增人数");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.Device)
                    .HasMaxLength(10)
                    .HasColumnName("device")
                    .HasComment("设备类型");

                entity.Property(e => e.FifteenKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("fifteen_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("保留15天");

                entity.Property(e => e.FiveKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("five_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("五日留存");

                entity.Property(e => e.SevenKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("seven_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("七日留存");

                entity.Property(e => e.ThirtyKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("thirty_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("保留30天");

                entity.Property(e => e.ThreeKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("three_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("三日留存");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1，汇总，2 按设备");

                entity.Property(e => e.YesdKeep)
                    .HasColumnType("int(11)")
                    .HasColumnName("yesd_keep")
                    .HasDefaultValueSql("'0'")
                    .HasComment("次日留存");
            });

            modelBuilder.Entity<StatisExchange>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_exchange");

                entity.HasComment("账户转换统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("日期");

                entity.Property(e => e.ExinCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("exin_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转入次数");

                entity.Property(e => e.ExinMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exin_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转入金额");

                entity.Property(e => e.ExinRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("exin_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转入比率");

                entity.Property(e => e.ExinThrMoney)
                    .HasPrecision(20, 2)
                    .HasColumnName("exin_thr_money")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("转入第三方金额");

                entity.Property(e => e.ExinUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("exin_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转入人数");

                entity.Property(e => e.ExoutCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("exout_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转出次数");

                entity.Property(e => e.ExoutMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exout_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转出金额");

                entity.Property(e => e.ExoutMoneyRate)
                    .HasPrecision(8, 4)
                    .HasColumnName("exout_money_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转出金额占比  转出金额/(转入金额+转出金额)百分比 保留两位小数，不四舍");

                entity.Property(e => e.ExoutRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("exout_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转出比率");

                entity.Property(e => e.ExoutThrMoney)
                    .HasPrecision(20, 2)
                    .HasColumnName("exout_thr_money")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("转出第三方金额");

                entity.Property(e => e.ExoutUserRate)
                    .HasPrecision(8, 4)
                    .HasColumnName("exout_user_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转出人数占比  转出人数/(转入人数+转出人数)百分比 保留两位小数，不四舍");

                entity.Property(e => e.ExoutUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("exout_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转出人数");

                entity.Property(e => e.OutSxf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("out_sxf")
                    .HasDefaultValueSql("'0'")
                    .HasComment("出账手续费");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏   转出金额 - 转入金额");

                entity.Property(e => e.ProftRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("proft_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比率   盈亏/转入金额 百分比 保留两位小数。不四舍");

                entity.Property(e => e.ThrProfit)
                    .HasPrecision(20, 2)
                    .HasColumnName("thr_profit")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("第三方盈亏");

                entity.Property(e => e.ThrProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("thr_profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("第三方盈亏率。");

                entity.Property(e => e.ThreeSxf)
                    .HasPrecision(20, 2)
                    .HasColumnName("three_sxf")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("第三方手续费");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");
            });

            modelBuilder.Entity<StatisExchangeUser>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_exchange_user");

                entity.HasComment("账户转换统计-用户")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Name, "ix_name");

                entity.HasIndex(e => e.PlayerId, "ix_playerid");

                entity.HasIndex(e => new { e.PlayerId, e.Name }, "ix_playerid_name");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("日期");

                entity.Property(e => e.ExinCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("exin_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转入次数");

                entity.Property(e => e.ExinMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exin_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转入金额");

                entity.Property(e => e.ExinRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("exin_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转入比率");

                entity.Property(e => e.ExinThrMoney)
                    .HasPrecision(20, 2)
                    .HasColumnName("exin_thr_money")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("转入第三方金额");

                entity.Property(e => e.ExoutCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("exout_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转出次数");

                entity.Property(e => e.ExoutMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exout_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转出金额");

                entity.Property(e => e.ExoutMoneyRate)
                    .HasPrecision(8, 4)
                    .HasColumnName("exout_money_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转出金额占比  转出金额/(转入金额+转出金额)百分比 保留两位小数，不四舍");

                entity.Property(e => e.ExoutRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("exout_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转出比率");

                entity.Property(e => e.ExoutThrMoney)
                    .HasPrecision(20, 2)
                    .HasColumnName("exout_thr_money")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("转出第三方金额");

                entity.Property(e => e.ExoutUserRate)
                    .HasPrecision(8, 4)
                    .HasColumnName("exout_user_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("转出人数占比  转出人数/(转入人数+转出人数) 百分比 保留两位小数，不四舍");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name")
                    .HasComment("用户账号");

                entity.Property(e => e.OutSxf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("out_sxf")
                    .HasDefaultValueSql("'0'")
                    .HasComment("出账手续费");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("player_id")
                    .HasComment("用户编号");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏   转出金额 - 转入金额");

                entity.Property(e => e.ProftRate)
                    .HasPrecision(20, 4)
                    .HasColumnName("proft_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比率   盈亏/转入金额 百分比 保留两位小数。不四舍");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.ThrProfit)
                    .HasPrecision(20, 2)
                    .HasColumnName("thr_profit")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("第三方盈亏");

                entity.Property(e => e.ThrProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("thr_profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("第三方盈亏 率");

                entity.Property(e => e.ThreeSxf)
                    .HasPrecision(20, 2)
                    .HasColumnName("three_sxf")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("第三方手续费");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");
            });

            modelBuilder.Entity<StatisFreebet>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_freebet");

                entity.HasComment("免费下注统计");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP用户数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP点数");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("用户数");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<StatisFreebetLottery>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_freebet_lottery");

                entity.HasComment("免费下注抽奖统计");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派彩金额");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("日期");

                entity.Property(e => e.LotterySum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("抽奖金额");

                entity.Property(e => e.RedrainSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("redrain_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("红包雨金额");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");
            });

            modelBuilder.Entity<StatisFreebetUser>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_freebet_user");

                entity.HasComment("用户免费下注统计");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派彩次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派彩金额");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasComment("用户数");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.DataType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("data_type")
                    .HasComment("汇总类型 1 用户汇总，2 用户 明细");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name")
                    .HasComment("用户名");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("player_id")
                    .HasComment("用户编号");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<StatisGame>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_game");

                entity.HasComment("游戏数据统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.ClassId, e.GameId }, "ix_class_game");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏  派奖-押注");

                entity.Property(e => e.ProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比例 (派奖-押注)/押注");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<StatisGameOnline>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PRIMARY");

                entity.ToTable("statis_game_online");

                entity.HasComment("游戏在线人数统计表 分：保存2小时数据，时：24小时，日：31日，月：12月")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.DataType, "ix_datatype");

                entity.HasIndex(e => new { e.DataType, e.StatisTime }, "ix_datatype_time");

                entity.HasIndex(e => e.Device, "ix_device");

                entity.HasIndex(e => e.TimeType, "ix_timetype");

                entity.Property(e => e.RecordId)
                    .HasColumnType("int(11)")
                    .HasColumnName("record_id")
                    .HasComment("记录编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.DataType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("data_type")
                    .HasComment("数据类别 1 汇总，2 按游戏，3 按设备");

                entity.Property(e => e.Device)
                    .HasMaxLength(10)
                    .HasColumnName("device")
                    .HasComment("设备类型 ");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏ID");

                entity.Property(e => e.OnlineAmount)
                    .HasColumnType("int(11)")
                    .HasColumnName("online_amount")
                    .HasDefaultValueSql("'0'")
                    .HasComment("在线人数 单位时间最高同时在线");

                entity.Property(e => e.StatisTime)
                    .HasColumnType("datetime")
                    .HasColumnName("statis_time")
                    .HasComment("统计时间");

                entity.Property(e => e.TimeType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("time_type")
                    .HasComment("时间分类 1 分，2 时，3 日，4 月");
            });

            modelBuilder.Entity<StatisGameUser>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_game_user");

                entity.HasComment("游戏数据统计-用户")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.ClassId, e.GameId }, "ix_class_game");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => new { e.Date, e.Type }, "ix_date_type");

                entity.HasIndex(e => new { e.PlayerId, e.Name }, "ix_playerid_name");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasComment("用户账号")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("player_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("用户编号");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏");

                entity.Property(e => e.ProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比例");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<StatisJp>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_jp");

                entity.HasComment("JP统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.JpCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("jp_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP次数");

                entity.Property(e => e.JpSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("jp_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP点数");

                entity.Property(e => e.JpUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("jp_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP用户数");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<StatisJpUser>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_jp_user");

                entity.HasComment("JP统计-用户")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.JpCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("jp_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP次数");

                entity.Property(e => e.JpSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("jp_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("JP点数");

                entity.Property(e => e.JpType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("jp_type")
                    .HasComment("JP类型  1 用户汇总，2 用户 明细");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name")
                    .HasComment("用户名");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("player_id")
                    .HasComment("用户编号");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<StatisProfit>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_profit");

                entity.HasComment("结算数据统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏");

                entity.Property(e => e.ProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比例");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");
            });

            modelBuilder.Entity<StatisProfitNow>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_profit_now");

                entity.HasComment("时实盈亏-后台总览使用");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("序号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasComment("派彩次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasComment("派彩金额");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasComment("下注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasComment("下注金额");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.InsertTime)
                    .HasColumnType("datetime")
                    .HasColumnName("insert_time")
                    .HasComment("插入时间");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("player_id")
                    .HasComment("用户编号");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasComment("子标签");
            });

            modelBuilder.Entity<StatisProfitUser>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_profit_user");

                entity.HasComment("结算数据统计-用户")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => new { e.PlayerId, e.Name }, "ix_playerid_name");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasComment("用户账号")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("player_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("用户编号");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏");

                entity.Property(e => e.ProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比例");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");
            });

            modelBuilder.Entity<StatisRegIpmac>(entity =>
            {
                entity.HasKey(e => new { e.Uid, e.IpMac })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("statis_reg_ipmac");

                entity.HasComment("注册IPMAC地址统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.IpMac)
                    .HasMaxLength(64)
                    .HasColumnName("ip_mac")
                    .HasComment("IPMAC地址")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AllCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("all_count")
                    .HasComment("总数量");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime")
                    .HasComment("最后更新时间");

                entity.Property(e => e.DayCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("day_count")
                    .HasComment("当天数量");
            });

            modelBuilder.Entity<StatisServerConfig>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_server_config");

                entity.HasComment("统计服务配置");

                entity.Property(e => e.Rid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("rid")
                    .HasComment("编号");

                entity.Property(e => e.Creater)
                    .HasMaxLength(16)
                    .HasColumnName("creater")
                    .HasComment("创建人");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime")
                    .HasComment("创建时间");

                entity.Property(e => e.ServerDesc)
                    .HasMaxLength(256)
                    .HasColumnName("server_desc")
                    .HasComment("值描述");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(64)
                    .HasColumnName("server_name")
                    .HasComment("服务名称");

                entity.Property(e => e.Value1)
                    .HasMaxLength(64)
                    .HasColumnName("value1")
                    .HasComment("值1");

                entity.Property(e => e.Value2)
                    .HasMaxLength(64)
                    .HasColumnName("value2")
                    .HasComment("值2");

                entity.Property(e => e.Value3)
                    .HasMaxLength(64)
                    .HasColumnName("value3")
                    .HasComment("值3");

                entity.Property(e => e.Value4)
                    .HasMaxLength(64)
                    .HasColumnName("value4")
                    .HasComment("值4");
            });

            modelBuilder.Entity<StatisServerLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_server_log");

                entity.HasComment("服务日志")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.SrvId, e.SrvName }, "ix_srvname_srvid");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.CostTime)
                    .HasPrecision(11, 3)
                    .HasColumnName("cost_time")
                    .HasComment("消耗时间 秒");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time")
                    .HasComment("结束时间");

                entity.Property(e => e.Error)
                    .HasMaxLength(256)
                    .HasColumnName("error")
                    .HasComment("异常错误")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SrvId)
                    .HasColumnType("int(11)")
                    .HasColumnName("srv_id")
                    .HasComment("服务编号");

                entity.Property(e => e.SrvName)
                    .HasMaxLength(64)
                    .HasColumnName("srv_name")
                    .HasComment("服务名称")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time")
                    .HasComment("开始时间");
            });

            modelBuilder.Entity<StatisType>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("statis_type");

                entity.HasComment("分类数据统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.TypeId, "ix_class_game");

                entity.HasIndex(e => e.Date, "ix_date");

                entity.HasIndex(e => e.Type, "ix_type");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AwardCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖次数");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("派奖");

                entity.Property(e => e.BetCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注次数");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注");

                entity.Property(e => e.BetUsers)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_users")
                    .HasDefaultValueSql("'0'")
                    .HasComment("投注人数");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasComment("数据日期");

                entity.Property(e => e.Profit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("盈亏");

                entity.Property(e => e.ProfitRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("profit_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("盈亏比例");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("数据类型 1 日数据，2 月数据");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<StatisUser>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PRIMARY");

                entity.ToTable("statis_user");

                entity.HasComment("用户数据统计")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("player_id")
                    .HasComment("用户编号");

                entity.Property(e => e.AwardMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("award_max")
                    .HasDefaultValueSql("'0'")
                    .HasComment("最大派奖");

                entity.Property(e => e.AwardSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("award_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("累计派奖");

                entity.Property(e => e.AwardsSum)
                    .HasColumnType("int(11)")
                    .HasColumnName("awards_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("累计派奖次数");

                entity.Property(e => e.BetMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_max")
                    .HasDefaultValueSql("'0'")
                    .HasComment("最大投注");

                entity.Property(e => e.BetSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bet_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("累计投注");

                entity.Property(e => e.BetsSum)
                    .HasColumnType("int(11)")
                    .HasColumnName("bets_sum")
                    .HasDefaultValueSql("'0'")
                    .HasComment("累计投注次数");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("更新时间");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name")
                    .HasComment("用户账号")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.WinRate)
                    .HasPrecision(8, 4)
                    .HasColumnName("win_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("胜率");
            });

            modelBuilder.Entity<SyncActivityPush>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sync_activity_push");

                entity.HasComment("活动数据推送开关");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.DataDesc)
                    .HasMaxLength(32)
                    .HasColumnName("data_desc")
                    .HasComment("数据描述 用户投注数据");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time")
                    .HasComment("结束时间");

                entity.Property(e => e.IsPush)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_push")
                    .HasComment("推送开关  0 no,1 yes");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time")
                    .HasComment("开始时间");
            });

            modelBuilder.Entity<SyncAgentInfo>(entity =>
            {
                entity.HasKey(e => e.AgentId)
                    .HasName("PRIMARY");

                entity.ToTable("sync_agent_info");

                entity.HasComment("代理信息表")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.AgentId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("agent_id")
                    .HasComment("代理ID");

                entity.Property(e => e.BigjpState)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bigjp_state")
                    .HasDefaultValueSql("'0'")
                    .HasComment("大JP状态 0 正常（默认），1 限制出大JP");

                entity.Property(e => e.CcFixed)
                    .HasPrecision(12, 4)
                    .HasColumnName("cc_fixed")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("出账手续费定额");

                entity.Property(e => e.CcRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("cc_rate")
                    .HasDefaultValueSql("'0.0000'")
                    .HasComment("出账手续费");

                entity.Property(e => e.ChangeLogo)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("change_logo")
                    .HasDefaultValueSql("'1'")
                    .HasComment("后台&客户端LOGO切换 值1：1 SEA，2 欧洲gamedivision");

                entity.Property(e => e.ChipRate)
                    .HasPrecision(12, 4)
                    .HasColumnName("chip_rate")
                    .HasComment("货币转换率");

                entity.Property(e => e.CreditLine)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("credit_line")
                    .HasComment("授信额度");

                entity.Property(e => e.CurId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cur_id")
                    .HasComment("货币编号");

                entity.Property(e => e.DomainName)
                    .HasMaxLength(128)
                    .HasColumnName("domain_name")
                    .HasDefaultValueSql("''")
                    .HasComment("代理域名，调用接口用");

                entity.Property(e => e.FatherId)
                    .HasColumnType("int(11)")
                    .HasColumnName("father_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("上级代理编号");

                entity.Property(e => e.GameSrvIp)
                    .HasMaxLength(128)
                    .HasColumnName("game_srv_ip")
                    .HasComment("Game服务器地址");

                entity.Property(e => e.GameSrvPort)
                    .HasMaxLength(16)
                    .HasColumnName("game_srv_port")
                    .HasComment("Game服务器端口");

                entity.Property(e => e.HdDecimal)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("hd_decimal")
                    .HasDefaultValueSql("'0'")
                    .HasComment("后台小数位 0无小数");

                entity.Property(e => e.IsFreespin)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_freespin")
                    .HasDefaultValueSql("'0'")
                    .HasComment("freespin显示开关 0 NO，1 YES ");

                entity.Property(e => e.JpClose)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("jp_close")
                    .HasComment("Jackpot开关，0 关闭，1 开启");

                entity.Property(e => e.LuckdrawOff)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("luckdraw_off")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转盘抽奖开关 0 关闭，1 开启");

                entity.Property(e => e.NowCredit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("now_credit")
                    .HasComment("当前额度");

                entity.Property(e => e.Platform)
                    .HasMaxLength(32)
                    .HasColumnName("platform")
                    .HasComment("平台名称")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RedenvelopeOff)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("redenvelope_off")
                    .HasDefaultValueSql("'0'")
                    .HasComment("红包雨开关 0 关闭，1 开启");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'0'")
                    .HasComment("代理状态 0 正常，1 关闭，-1 删除");

                entity.Property(e => e.SystemCode)
                    .HasMaxLength(64)
                    .HasColumnName("system_code")
                    .HasComment("系统码");

                entity.Property(e => e.TrustCode)
                    .HasMaxLength(64)
                    .HasColumnName("trust_code")
                    .HasComment("信任码");

                entity.Property(e => e.WebSrvIp)
                    .HasMaxLength(128)
                    .HasColumnName("web_srv_ip")
                    .HasComment("Web服务器地址");
            });

            modelBuilder.Entity<SyncApiInternal>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sync_api_internal");

                entity.HasComment("内部接口")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.ApiInfo)
                    .HasMaxLength(64)
                    .HasColumnName("api_info")
                    .HasComment("用途")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ApiName)
                    .HasMaxLength(32)
                    .HasColumnName("api_name")
                    .HasComment("名称")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ApiPath)
                    .HasMaxLength(32)
                    .HasColumnName("api_path")
                    .HasComment("调用名")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ApiSource)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("api_source")
                    .HasComment("来源 1 代理，2 游戏");

                entity.Property(e => e.DocumentUrl)
                    .HasMaxLength(128)
                    .HasColumnName("document_url")
                    .HasComment("接口文档")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TrustCode)
                    .HasMaxLength(32)
                    .HasColumnName("trust_code")
                    .HasComment("信任码")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<SyncApiManage>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sync_api_manage");

                entity.HasComment("接口管理")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.ApiInfo)
                    .HasMaxLength(64)
                    .HasColumnName("api_info")
                    .HasComment("用途")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ApiName)
                    .HasMaxLength(32)
                    .HasColumnName("api_name")
                    .HasComment("接口名称")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ApiType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("api_type")
                    .HasComment("接口类型 1 web,2 game");

                entity.Property(e => e.CallSource)
                    .HasMaxLength(64)
                    .HasColumnName("call_source")
                    .HasComment("调用源")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DocumentUrl)
                    .HasMaxLength(128)
                    .HasColumnName("document_url")
                    .HasComment("接口文档")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.IpLimit)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("ip_limit")
                    .HasComment("IP限制 0 no ,1 yes");
            });

            modelBuilder.Entity<SyncFileDownload>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sync_file_download");

                entity.HasComment("文档下载管理")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.DownloadUrl)
                    .HasMaxLength(128)
                    .HasColumnName("download_url")
                    .HasComment("下载地址")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FileName)
                    .HasMaxLength(64)
                    .HasColumnName("file_name")
                    .HasComment("文档名称")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FileNameEn)
                    .HasMaxLength(128)
                    .HasColumnName("file_name_en")
                    .HasComment("文档名称-英文");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("更新时间");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .HasColumnName("version")
                    .HasComment("版本号")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<SyncGameClass>(entity =>
            {
                entity.HasKey(e => new { e.ClassId, e.LanguageId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sync_game_class");

                entity.HasComment("游戏分类表")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("类型编号");

                entity.Property(e => e.LanguageId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("language_id")
                    .HasComment("语言编号");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(64)
                    .HasColumnName("class_name")
                    .HasComment("分类名称")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Describe)
                    .HasMaxLength(128)
                    .HasColumnName("describe")
                    .HasDefaultValueSql("''")
                    .HasComment("分类描述")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Param1)
                    .HasMaxLength(128)
                    .HasColumnName("param1")
                    .HasDefaultValueSql("''")
                    .HasComment("备用1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Param2)
                    .HasMaxLength(128)
                    .HasColumnName("param2")
                    .HasDefaultValueSql("''")
                    .HasComment("备用2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<SyncGameConfig>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sync_game_config");

                entity.HasComment("游戏配置表")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.BasisBet)
                    .HasColumnType("int(11)")
                    .HasColumnName("basis_bet")
                    .HasDefaultValueSql("'1'")
                    .HasComment("基础底分 彩票类使用");

                entity.Property(e => e.BetLevel)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bet_level")
                    .HasDefaultValueSql("'1'")
                    .HasComment("投注默认等级 默认1");

                entity.Property(e => e.BigCard)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("big_card")
                    .HasDefaultValueSql("'1'")
                    .HasComment("大卡显示倍数");

                entity.Property(e => e.BigGif)
                    .HasMaxLength(128)
                    .HasColumnName("big_gif")
                    .HasComment("大展示图");

                entity.Property(e => e.CallPath)
                    .HasMaxLength(128)
                    .HasColumnName("call_path")
                    .HasComment("调用路径");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.FreeTimes)
                    .HasColumnType("int(11)")
                    .HasColumnName("free_times")
                    .HasDefaultValueSql("'0'")
                    .HasComment("免费次数 -1 不支持，其他 次数");

                entity.Property(e => e.FreeWeight)
                    .HasColumnType("int(11)")
                    .HasColumnName("free_weight")
                    .HasDefaultValueSql("'0'")
                    .HasComment("免费次数-游戏权重");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Label)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("label")
                    .HasDefaultValueSql("'1'")
                    .HasComment("标签 1 new,2 hot,3 折扣,4 free");

                entity.Property(e => e.LogoUrl)
                    .HasMaxLength(128)
                    .HasColumnName("logo_url")
                    .HasComment("图标");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_id")
                    .HasComment("排序 升序0-100");

                entity.Property(e => e.ShowUrl)
                    .HasMaxLength(128)
                    .HasColumnName("show_url")
                    .HasComment("展示页面");

                entity.Property(e => e.SmallGif)
                    .HasMaxLength(128)
                    .HasColumnName("small_gif")
                    .HasComment("小展示图");

                entity.Property(e => e.SupportApp)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("support_app")
                    .HasDefaultValueSql("'0'")
                    .HasComment("支持APP 0 no,1 yes");

                entity.Property(e => e.SupportH5)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("support_h5")
                    .HasDefaultValueSql("'0'")
                    .HasComment("支持H5 0 no,1 yes");

                entity.Property(e => e.SupportWebgl)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("support_webgl")
                    .HasDefaultValueSql("'0'")
                    .HasComment("支持WebGL 0 no,1 yes");

                entity.Property(e => e.TypeId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");
            });

            modelBuilder.Entity<SyncGameInfo>(entity =>
            {
                entity.HasKey(e => new { e.GameId, e.LanguageId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sync_game_info");

                entity.HasComment("游戏信息")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.GameId, e.LanguageId }, "ix_gameid_languageid")
                    .IsUnique();

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("language_id")
                    .HasDefaultValueSql("'1'")
                    .HasComment("语言编号");

                entity.Property(e => e.GameName)
                    .HasMaxLength(64)
                    .HasColumnName("game_name")
                    .HasComment("游戏名称")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Introduction)
                    .HasMaxLength(256)
                    .HasColumnName("introduction")
                    .HasDefaultValueSql("''")
                    .HasComment("游戏介绍")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<SyncGameOpen>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sync_game_open");

                entity.HasComment("代理开放游戏配置")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => new { e.ClassId, e.GameId }, "ix_classid_gameid");

                entity.HasIndex(e => e.TypeId, "ix_typeid");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.BetInit)
                    .HasPrecision(12, 3)
                    .HasColumnName("bet_init")
                    .HasComment("投注起始底分");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_id")
                    .HasComment("分类编号");

                entity.Property(e => e.Currency)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'0'")
                    .HasComment("货币符号");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.TypeId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type_id")
                    .HasComment("产品分类编号");

                entity.Property(e => e.Value1)
                    .HasMaxLength(64)
                    .HasColumnName("value1")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Value10)
                    .HasMaxLength(128)
                    .HasColumnName("value10")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值10")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Value2)
                    .HasMaxLength(64)
                    .HasColumnName("value2")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Value3)
                    .HasMaxLength(64)
                    .HasColumnName("value3")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Value4)
                    .HasMaxLength(64)
                    .HasColumnName("value4")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值4")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Value5)
                    .HasMaxLength(64)
                    .HasColumnName("value5")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值5")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Value6)
                    .HasMaxLength(64)
                    .HasColumnName("value6")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值6")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Value7)
                    .HasMaxLength(64)
                    .HasColumnName("value7")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值7")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Value8)
                    .HasMaxLength(64)
                    .HasColumnName("value8")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值8")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Value9)
                    .HasMaxLength(128)
                    .HasColumnName("value9")
                    .HasDefaultValueSql("''")
                    .HasComment("备用值9")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<SyncGameRecord>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sync_game_record");

                entity.HasComment("游戏记录推送同步")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Counts)
                    .HasColumnType("int(11)")
                    .HasColumnName("counts")
                    .HasDefaultValueSql("'0'")
                    .HasComment("记录数量");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time")
                    .HasComment("结束时间");

                entity.Property(e => e.GameUid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("game_uid")
                    .HasComment("本次记录ID");

                entity.Property(e => e.LastGameUid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("last_game_uid")
                    .HasComment("上次记录ID");

                entity.Property(e => e.PushCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("push_counts")
                    .HasDefaultValueSql("'1'")
                    .HasComment("推送次数");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'0'")
                    .HasComment("推送状态 0 开始推送，1 成功，2 失败");

                entity.Property(e => e.SuccessUid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("success_uid")
                    .HasDefaultValueSql("'0'")
                    .HasComment("当前成功推送uid");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<SyncGameType>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.LanguageId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sync_game_type");

                entity.HasComment("产品分类")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type_id")
                    .HasComment("分类编号");

                entity.Property(e => e.LanguageId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("language_id")
                    .HasComment("语言编号");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(128)
                    .HasColumnName("image_name")
                    .HasDefaultValueSql("''")
                    .HasComment("图片地址")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(64)
                    .HasColumnName("type_name")
                    .HasComment("名称")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<SyncGameUrl>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sync_game_url");

                entity.HasComment("游戏域名配置");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.GameUrl)
                    .HasMaxLength(128)
                    .HasColumnName("game_url")
                    .HasComment("游戏域名");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .HasColumnName("ipaddress")
                    .HasComment("IP地址");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.Sort)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("sort")
                    .HasDefaultValueSql("'10'")
                    .HasComment("排序  1-10 升序，同ucr_uid,url_type排序");

                entity.Property(e => e.Usetype)
                    .HasMaxLength(5)
                    .HasColumnName("usetype")
                    .HasComment("用户  h5  H5访问，webgl WebGL访问");
            });

            modelBuilder.Entity<SyncMessage>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sync_message");

                entity.HasComment("内部信息同步表");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content")
                    .HasComment("内容");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.Title)
                    .HasMaxLength(512)
                    .HasColumnName("title")
                    .HasComment("标题");
            });

            modelBuilder.Entity<SysBulletinAuto>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sys_bulletin_auto");

                entity.HasComment("跑马灯自动消息");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Counts)
                    .HasColumnType("int(11)")
                    .HasColumnName("counts")
                    .HasComment("播放次数");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date")
                    .HasComment("结束日期");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("0全部游戏，1 随机游戏，其他-游戏编号");

                entity.Property(e => e.IsMoney)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("随机金额 0 no,1 yes");

                entity.Property(e => e.IsName)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_name")
                    .HasDefaultValueSql("'0'")
                    .HasComment("随机用户名 0 no,1 yes");

                entity.Property(e => e.Life)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("life")
                    .HasComment("单播次数 1-3次");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.MoneyRange)
                    .HasMaxLength(16)
                    .HasColumnName("money_range")
                    .HasComment("金额范围");

                entity.Property(e => e.ReCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("re_counts")
                    .HasComment("剩余次数");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date")
                    .HasComment("开始日期");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'0'")
                    .HasComment("状态  0 关闭，1 开启，-1 删除");

                entity.Property(e => e.Text)
                    .HasMaxLength(2048)
                    .HasColumnName("text")
                    .HasComment("消息内容");
            });

            modelBuilder.Entity<SysBulletinAutoLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sys_bulletin_auto_log");

                entity.HasComment("跑马灯自动消息日志");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.AutoUid)
                    .HasColumnType("int(11)")
                    .HasColumnName("auto_uid")
                    .HasComment("自动消息编号");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.SendState)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("send_state")
                    .HasComment("发送状态 0 失败，1 成功");

                entity.Property(e => e.SendTime)
                    .HasColumnType("datetime")
                    .HasColumnName("send_time")
                    .HasComment("发送时间");

                entity.Property(e => e.Text)
                    .HasMaxLength(2048)
                    .HasColumnName("text")
                    .HasDefaultValueSql("''")
                    .HasComment("消息内容");
            });

            modelBuilder.Entity<SysBulletinRecord>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("sys_bulletin_record");

                entity.HasComment("系统跑马灯记录(系统游戏消息)");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Life)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("life")
                    .HasDefaultValueSql("'1'")
                    .HasComment("循环次数");

                entity.Property(e => e.SendTime)
                    .HasColumnType("datetime")
                    .HasColumnName("send_time")
                    .HasComment("发送时间");

                entity.Property(e => e.Sender)
                    .HasMaxLength(16)
                    .HasColumnName("sender")
                    .HasComment("发送人");

                entity.Property(e => e.Showtype)
                    .HasColumnType("int(11)")
                    .HasColumnName("showtype")
                    .HasDefaultValueSql("'0'")
                    .HasComment("显示类型 0 全部游戏，game_id 单独游戏，多游戏则写多条记录");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("state")
                    .HasComment("状态 1 成功，2 失败");

                entity.Property(e => e.Text)
                    .HasMaxLength(512)
                    .HasColumnName("text")
                    .HasComment("消息内容");
            });

            modelBuilder.Entity<TbDic>(entity =>
            {
                entity.ToTable("tb_dic");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CallIndex).HasColumnName("call_index");

                entity.Property(e => e.IsNew).HasColumnName("is_new");

                entity.Property(e => e.LangId)
                    .HasColumnType("int(11)")
                    .HasColumnName("lang_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<TbLang>(entity =>
            {
                entity.ToTable("tb_lang");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasColumnName("add_time");

                entity.Property(e => e.AppId)
                    .HasColumnType("int(11)")
                    .HasColumnName("app_id");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<TbManager>(entity =>
            {
                entity.ToTable("tb_manager");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasColumnName("add_time");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.IpLimit)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("ip_limit")
                    .HasDefaultValueSql("'1'")
                    .HasComment("IP限制开关 0 关闭 1 开启");

                entity.Property(e => e.IsControl)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_control");

                entity.Property(e => e.IsLock).HasColumnName("is_lock");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.RoleType)
                    .HasColumnType("int(11)")
                    .HasColumnName("role_type");

                entity.Property(e => e.Salt).HasColumnName("salt");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");
            });

            modelBuilder.Entity<TbManagerLog>(entity =>
            {
                entity.ToTable("tb_manager_log");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionType).HasColumnName("action_type");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasColumnName("add_time");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserIp).HasColumnName("user_ip");

                entity.Property(e => e.UserName).HasColumnName("user_name");
            });

            modelBuilder.Entity<TbManagerRole>(entity =>
            {
                entity.ToTable("tb_manager_role");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IsHide)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_hide");

                entity.Property(e => e.IsSys)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_sys");

                entity.Property(e => e.IsSysHide)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_sys_hide")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否隐藏权限组 0 NO，1 YES");

                entity.Property(e => e.RoleName).HasColumnName("role_name");

                entity.Property(e => e.RoleType)
                    .HasColumnType("int(11)")
                    .HasColumnName("role_type");
            });

            modelBuilder.Entity<TbManagerRoleValue>(entity =>
            {
                entity.ToTable("tb_manager_role_value");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.NavName).HasColumnName("nav_name");

                entity.Property(e => e.RoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("role_id");
            });

            modelBuilder.Entity<TbNav>(entity =>
            {
                entity.ToTable("tb_nav");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("action_type");

                entity.Property(e => e.IconUrl).HasColumnName("icon_url");

                entity.Property(e => e.IsHide).HasColumnName("is_hide");

                entity.Property(e => e.IsSys)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_sys");

                entity.Property(e => e.LinkUrl).HasColumnName("link_url");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.SortId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_id");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<TbNavNew>(entity =>
            {
                entity.ToTable("tb_nav_new");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("action_type");

                entity.Property(e => e.IconUrl).HasColumnName("icon_url");

                entity.Property(e => e.IsHide).HasColumnName("is_hide");

                entity.Property(e => e.IsSys)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_sys");

                entity.Property(e => e.LinkUrl).HasColumnName("link_url");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.SortId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_id");

                entity.Property(e => e.SubTitle).HasColumnName("sub_title");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<UpdateVersion>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PRIMARY");

                entity.ToTable("update_version");

                entity.Property(e => e.Rid)
                    .HasColumnType("int(11)")
                    .HasColumnName("rid")
                    .HasComment("记录编号");

                entity.Property(e => e.Info)
                    .HasMaxLength(32)
                    .HasColumnName("info")
                    .HasComment("说明");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time")
                    .HasComment("更新时间");

                entity.Property(e => e.Version)
                    .HasMaxLength(16)
                    .HasColumnName("version")
                    .HasComment("版本号");
            });

            modelBuilder.Entity<UserTransferLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("user_transfer_log");

                entity.HasComment("红包转 账记录");

                entity.HasIndex(e => e.IsOpen, "ix_is_open");

                entity.HasIndex(e => e.RecPlayerid, "ix_rec_playerid");

                entity.HasIndex(e => new { e.RecPlayerid, e.OpenPwd }, "ix_recid_pwd")
                    .IsUnique();

                entity.HasIndex(e => e.SendPlayerid, "ix_send_playerid");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.IsOpen)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_open")
                    .HasComment("是否已打开  0 未打开，1 已打开");

                entity.Property(e => e.OpenPwd)
                    .HasMaxLength(6)
                    .HasColumnName("open_pwd")
                    .HasComment("打开红包密码 随机6位数据+大家字母");

                entity.Property(e => e.OpenTime)
                    .HasColumnType("datetime")
                    .HasColumnName("open_time")
                    .HasComment("打开时间");

                entity.Property(e => e.RecMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rec_money")
                    .HasComment("接收红包金额");

                entity.Property(e => e.RecName)
                    .HasMaxLength(32)
                    .HasColumnName("rec_name")
                    .HasComment("接收人昵称");

                entity.Property(e => e.RecPlayerRemoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rec_player_remoney")
                    .HasComment("接收人余额");

                entity.Property(e => e.RecPlayerid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rec_playerid")
                    .HasComment("接收人ID");

                entity.Property(e => e.SendMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("send_money")
                    .HasComment("发送红包金额");

                entity.Property(e => e.SendName)
                    .HasMaxLength(32)
                    .HasColumnName("send_name")
                    .HasComment("发送人昵称");

                entity.Property(e => e.SendPlayerRemoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("send_player_remoney")
                    .HasComment("发送人余额");

                entity.Property(e => e.SendPlayerid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("send_playerid")
                    .HasComment("发送人ID");

                entity.Property(e => e.SendTime)
                    .HasColumnType("datetime")
                    .HasColumnName("send_time")
                    .HasComment("发送时间");
            });

            modelBuilder.Entity<WarningConfig>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("warning_config");

                entity.HasComment("警告通知配置");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.ContentFrom)
                    .HasMaxLength(128)
                    .HasColumnName("content_from")
                    .HasComment("通知内容格式");

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(128)
                    .HasColumnName("email_from")
                    .HasComment("邮件内容格式");

                entity.Property(e => e.IsRead)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_read")
                    .HasDefaultValueSql("'0'")
                    .HasComment("服务器是否已读取配置 0 no,1 yes ");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改日期");

                entity.Property(e => e.ReadTime)
                    .HasColumnType("datetime")
                    .HasColumnName("read_time")
                    .HasComment("服务器读取配置时间");

                entity.Property(e => e.Rule)
                    .HasMaxLength(128)
                    .HasColumnName("rule")
                    .HasComment("规则说明");

                entity.Property(e => e.SafeUid)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("safe_uid")
                    .HasComment("安全等级编号");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("state")
                    .HasComment("状态 0 关闭，1 开启");

                entity.Property(e => e.Title)
                    .HasMaxLength(64)
                    .HasColumnName("title")
                    .HasComment("标题 用于通知开头");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("类型 1 游戏，2，服务器，3 风控，4 日常，5 行为，6 备用一，7 备用二，8 其他");

                entity.Property(e => e.UserGpUid)
                    .HasMaxLength(32)
                    .HasColumnName("user_gp_uid")
                    .HasComment("通知对象编号 U:1001;G2001");

                entity.Property(e => e.Val1)
                    .HasColumnType("int(11)")
                    .HasColumnName("val1")
                    .HasComment("配置值1");

                entity.Property(e => e.Val2)
                    .HasColumnType("int(11)")
                    .HasColumnName("val2")
                    .HasComment("配置值2");

                entity.Property(e => e.Val3)
                    .HasColumnType("int(11)")
                    .HasColumnName("val3")
                    .HasComment("配置值3");

                entity.Property(e => e.Val4)
                    .HasMaxLength(32)
                    .HasColumnName("val4")
                    .HasComment("配置值4");
            });

            modelBuilder.Entity<WarningSafe>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("warning_safe");

                entity.HasComment("警告通知安全等级");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.SafeName)
                    .HasMaxLength(32)
                    .HasColumnName("safe_name")
                    .HasComment("名称");
            });

            modelBuilder.Entity<WarningSendLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("warning_send_log");

                entity.HasComment("警告通知发送日志");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Account)
                    .HasMaxLength(34)
                    .HasColumnName("account")
                    .HasComment("用户账号");

                entity.Property(e => e.EmailState)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("email_state")
                    .HasComment("邮箱通知状态 0 no,1 yes");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.IsRead)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_read")
                    .HasComment("是否已读 0 no 1 yes ");

                entity.Property(e => e.NowVal1)
                    .HasMaxLength(32)
                    .HasColumnName("now_val1")
                    .HasComment("当前值1");

                entity.Property(e => e.PhoneState)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("phone_state")
                    .HasComment("手机通知状态 0 no ,1 yes");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("player_id")
                    .HasComment("用户编号");

                entity.Property(e => e.SafeName)
                    .HasMaxLength(32)
                    .HasColumnName("safe_name")
                    .HasComment("安全等级名称");

                entity.Property(e => e.SendTime)
                    .HasColumnType("datetime")
                    .HasColumnName("send_time")
                    .HasComment("发送时间");

                entity.Property(e => e.Val1)
                    .HasColumnType("int(11)")
                    .HasColumnName("val1")
                    .HasComment("值1");

                entity.Property(e => e.Val2)
                    .HasColumnType("int(11)")
                    .HasColumnName("val2")
                    .HasComment("值2");

                entity.Property(e => e.Val3)
                    .HasColumnType("int(11)")
                    .HasColumnName("val3")
                    .HasComment("值3");

                entity.Property(e => e.Val4)
                    .HasMaxLength(32)
                    .HasColumnName("val4")
                    .HasComment("值4");

                entity.Property(e => e.WarningTitle)
                    .HasMaxLength(64)
                    .HasColumnName("warning_title")
                    .HasComment("通知标题");

                entity.Property(e => e.WarningUid)
                    .HasColumnType("int(11)")
                    .HasColumnName("warning_uid")
                    .HasComment("警告通知编号");
            });

            modelBuilder.Entity<WarningUser>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("warning_user");

                entity.HasComment("警告通知人员信息");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.Email)
                    .HasMaxLength(32)
                    .HasColumnName("email")
                    .HasComment("邮箱");

                entity.Property(e => e.GroupUid)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_uid")
                    .HasComment("分组-部门");

                entity.Property(e => e.Job)
                    .HasMaxLength(32)
                    .HasColumnName("job")
                    .HasComment("岗位");

                entity.Property(e => e.Name)
                    .HasMaxLength(16)
                    .HasColumnName("name")
                    .HasComment("姓名");

                entity.Property(e => e.Phone)
                    .HasMaxLength(32)
                    .HasColumnName("phone")
                    .HasComment("手机号");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("类型 1 系统 ，2 本地");
            });

            modelBuilder.Entity<WarningUserGroup>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("warning_user_group");

                entity.HasComment("警告通知人员分组");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(32)
                    .HasColumnName("group_name")
                    .HasComment("分组名称");
            });

            modelBuilder.Entity<WebConfig>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("web_config");

                entity.HasComment("web参数配置");

                entity.HasIndex(e => new { e.ParamName, e.ParamVal }, "ix_param_name");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.CheckCode)
                    .HasMaxLength(32)
                    .HasColumnName("check_code")
                    .HasDefaultValueSql("''")
                    .HasComment("校验码 由md5(type + param_desc + param_name + param_val + comment)组成");

                entity.Property(e => e.Comment)
                    .HasMaxLength(128)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''")
                    .HasComment("注释");

                //目前沒用
                //entity.Property(e => e.IsMust)
                //    .HasColumnType("tinyint(4)")
                //    .HasColumnName("is_must")
                //    .HasDefaultValueSql("'0'")
                //    .HasComment("是否代理必要参数 0 no ,1 yes");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.ParamDesc)
                    .HasMaxLength(32)
                    .HasColumnName("param_desc")
                    .HasDefaultValueSql("''")
                    .HasComment("参数描述");

                entity.Property(e => e.ParamName)
                    .HasMaxLength(32)
                    .HasColumnName("param_name")
                    .HasDefaultValueSql("''")
                    .HasComment("调用名称");

                entity.Property(e => e.ParamVal)
                    .HasMaxLength(512)
                    .HasColumnName("param_val")
                    .HasDefaultValueSql("''")
                    .HasComment("参数");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'1'")
                    .HasComment("类型  1 公共，2 本地");
            });

            modelBuilder.Entity<WebConfigLog>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("web_config_log");

                entity.HasComment("web参数修改日志");

                entity.HasIndex(e => new { e.ParamName, e.ParamVal }, "ix_param_name");

                entity.HasIndex(e => e.ParamUid, "ix_param_uid");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("序号");

                entity.Property(e => e.CheckCode)
                    .HasMaxLength(32)
                    .HasColumnName("check_code")
                    .HasComment("校验码由md5(type + param_desc + param_name + param_val + comment)组成");

                entity.Property(e => e.Comment)
                    .HasMaxLength(128)
                    .HasColumnName("comment")
                    .HasComment("注释");

                entity.Property(e => e.IsMust)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_must")
                    .HasComment("代理必要参数");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("修改时间");

                entity.Property(e => e.ParamDesc)
                    .HasMaxLength(32)
                    .HasColumnName("param_desc")
                    .HasComment("参数描述");

                entity.Property(e => e.ParamName)
                    .HasMaxLength(32)
                    .HasColumnName("param_name")
                    .HasComment("调用名称");

                entity.Property(e => e.ParamUid)
                    .HasColumnType("int(11)")
                    .HasColumnName("param_uid")
                    .HasComment("参数编号");

                entity.Property(e => e.ParamVal)
                    .HasMaxLength(512)
                    .HasColumnName("param_val")
                    .HasComment("参数");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasComment("类型  1 公共，2 本地");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
