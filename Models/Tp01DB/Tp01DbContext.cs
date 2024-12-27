using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Tp01DbContext : DbContext
    {
        public Tp01DbContext()
        {
        }

        public Tp01DbContext(DbContextOptions<Tp01DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<ActivityInfo> ActivityInfos { get; set; } = null!;
        public virtual DbSet<Ban> Bans { get; set; } = null!;
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<Bulletin> Bulletins { get; set; } = null!;
        public virtual DbSet<CfRoulette> CfRoulettes { get; set; } = null!;
        public virtual DbSet<ConfigLuckdraw> ConfigLuckdraws { get; set; } = null!;
        public virtual DbSet<ConfigShop> ConfigShops { get; set; } = null!;
        public virtual DbSet<ConfigTurntableReward> ConfigTurntableRewards { get; set; } = null!;
        public virtual DbSet<ConfigTurntableSlot> ConfigTurntableSlots { get; set; } = null!;
        public virtual DbSet<Friend> Friends { get; set; } = null!;
        public virtual DbSet<FriendAuthen> FriendAuthens { get; set; } = null!;
        public virtual DbSet<FriendList> FriendLists { get; set; } = null!;
        public virtual DbSet<GameTp01> GameTp01s { get; set; } = null!;
        public virtual DbSet<Guild> Guilds { get; set; } = null!;
        public virtual DbSet<LoginStatus> LoginStatuses { get; set; } = null!;
        public virtual DbSet<Mail> Mail { get; set; } = null!;
        public virtual DbSet<MailSy> MailSys { get; set; } = null!;
        public virtual DbSet<Notice> Notices { get; set; } = null!;
        public virtual DbSet<OnlinePlayer> OnlinePlayers { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<Rank> Ranks { get; set; } = null!;
        public virtual DbSet<RankWeek> RankWeeks { get; set; } = null!;
        public virtual DbSet<Recharge> Recharges { get; set; } = null!;
        public virtual DbSet<Replay> Replays { get; set; } = null!;
        public virtual DbSet<Shop> Shops { get; set; } = null!;
        public virtual DbSet<Suggestion> Suggestions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.10.37;port=3306;database=tp01;user=root;password=1qasde32;max pool size=100;min pool size=5;convertzerodatetime=True", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.20-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.Name })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("account");

                entity.HasIndex(e => e.SubLabel, "IX_sub_label");

                entity.HasIndex(e => new { e.ZoneId, e.Agent, e.Name }, "IX_zone_agent_name")
                    .IsUnique();

                entity.HasIndex(e => e.CreateTime, "ix_create_time");

                entity.HasIndex(e => e.LoginTime, "ix_logintime");

                entity.HasIndex(e => e.Name, "ix_name");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(11) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("player_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(36)
                    .HasColumnName("name")
                    .UseCollation("utf8_bin");

                entity.Property(e => e.Adult)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("adult")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Agent)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("agent")
                    .HasComment("0为数据库验证，渠道ID必须大于0");

                entity.Property(e => e.BillMark)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("bill_mark")
                    .HasComment("充值bill表状态标识");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("timestamp")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Device)
                    .HasMaxLength(64)
                    .HasColumnName("device")
                    .HasDefaultValueSql("''")
                    .HasComment("设备名称");

                entity.Property(e => e.Email)
                    .HasMaxLength(64)
                    .HasColumnName("email")
                    .HasDefaultValueSql("''")
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.GmLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gm_level");

                entity.Property(e => e.IpAddr)
                    .HasMaxLength(16)
                    .HasColumnName("ip_addr")
                    .HasDefaultValueSql("''")
                    .IsFixedLength()
                    .HasComment("注册ip")
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.Isguest)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("isguest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否游客 0 no,1 yes");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(16)
                    .HasColumnName("login_ip")
                    .HasDefaultValueSql("''")
                    .IsFixedLength()
                    .HasComment("录登IP地址")
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("timestamp")
                    .HasColumnName("login_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LogoutTime)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("logout_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MacAddr)
                    .HasMaxLength(32)
                    .HasColumnName("mac_addr")
                    .HasDefaultValueSql("''")
                    .IsFixedLength()
                    .HasComment("卡网地址")
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.Passwd)
                    .HasMaxLength(32)
                    .HasColumnName("passwd")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Phone)
                    .HasMaxLength(16)
                    .HasColumnName("phone")
                    .HasDefaultValueSql("''")
                    .IsFixedLength()
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.PlayTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("play_time")
                    .HasComment("总在线时间,单位分钟");

                entity.Property(e => e.Spreader)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("spreader")
                    .HasComment("推广员");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(5)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''")
                    .HasComment("子平台标签");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(64)
                    .HasColumnName("uuid")
                    .HasDefaultValueSql("''")
                    .HasComment("UUID")
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("zone_id")
                    .HasComment("分组编号，最大不超过63");
            });

            modelBuilder.Entity<ActivityInfo>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PRIMARY");

                entity.ToTable("activity_info");

                entity.HasComment("活动管理")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.RecordId)
                    .HasColumnType("int(11)")
                    .HasColumnName("record_id")
                    .HasComment("记录ID");

                entity.Property(e => e.IsShow)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_show")
                    .HasComment("是否显示 0 不显示，1 显示");

                entity.Property(e => e.LinkAddr)
                    .HasMaxLength(128)
                    .HasColumnName("link_addr")
                    .HasComment("跳转链接");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasDefaultValueSql("''")
                    .HasComment("修改人");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasDefaultValueSql("'1990-01-01 00:00:00'")
                    .HasComment("修改时间");

                entity.Property(e => e.OrderValue)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("order_value")
                    .HasDefaultValueSql("'100'")
                    .HasComment("排序权值 0-100 小则最前");

                entity.Property(e => e.PictureAddr)
                    .HasMaxLength(128)
                    .HasColumnName("picture_addr")
                    .HasComment("展示图标");
            });

            modelBuilder.Entity<Ban>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PRIMARY");

                entity.ToTable("ban");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("player_id");

                entity.Property(e => e.ChatInfo)
                    .HasMaxLength(255)
                    .HasColumnName("chat_info")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChatTime)
                    .HasColumnType("timestamp")
                    .HasColumnName("chat_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LoginInfo)
                    .HasMaxLength(255)
                    .HasColumnName("login_info")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("timestamp")
                    .HasColumnName("login_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MarkTime)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("mark_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("bill");

                entity.HasIndex(e => new { e.AgentId, e.OrderId }, "IX_agent_order")
                    .IsUnique();

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.AgentId)
                    .HasColumnType("int(3) unsigned")
                    .HasColumnName("agent_id");

                entity.Property(e => e.Channel)
                    .HasMaxLength(255)
                    .HasColumnName("channel")
                    .HasDefaultValueSql("''")
                    .HasComment("渠道名称");

                entity.Property(e => e.Diamond)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("diamond")
                    .HasComment("砖石");

                entity.Property(e => e.GoodsId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("goods_id");

                entity.Property(e => e.Mark)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("mark")
                    .HasComment("1: 游戏道具发放完毕");

                entity.Property(e => e.Memo)
                    .HasMaxLength(255)
                    .HasColumnName("memo")
                    .HasDefaultValueSql("''")
                    .HasComment("备注");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("money")
                    .HasComment("位单：RMB的分");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(64)
                    .HasColumnName("order_id")
                    .HasDefaultValueSql("''")
                    .HasComment("服务器商户订单号")
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.PayMoney)
                    .HasColumnType("int(10)")
                    .HasColumnName("pay_money")
                    .HasComment("实际金额");

                entity.Property(e => e.PayTime)
                    .HasColumnType("datetime")
                    .HasColumnName("pay_time")
                    .HasComment("支付完成时间");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(10) unsigned")
                    .HasColumnName("player_id");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(4) unsigned")
                    .HasColumnName("state")
                    .HasComment("订单状态 0 未完成，1 充值成功");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasColumnName("time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("值充时间");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(64)
                    .HasColumnName("transaction_id")
                    .HasDefaultValueSql("''")
                    .HasComment("微信或第三方渠道支付订单号")
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .HasColumnName("unit")
                    .HasDefaultValueSql("''")
                    .HasComment("货币单位");
            });

            modelBuilder.Entity<Bulletin>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("bulletin");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.BroadcastCount)
                    .HasColumnType("int(10)")
                    .HasColumnName("broadcast_count")
                    .HasComment("广播次数");

                entity.Property(e => e.BroadcastInterv)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("broadcast_interv")
                    .HasComment("广播间隔,单位：分钟");

                entity.Property(e => e.BroadcastTick)
                    .HasColumnType("timestamp")
                    .HasColumnName("broadcast_tick")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("上一次广播时间戳");

                entity.Property(e => e.Interval)
                    .HasColumnType("int(255) unsigned")
                    .HasColumnName("interval")
                    .HasComment("间隔，单位：秒");

                entity.Property(e => e.Life)
                    .HasColumnType("datetime")
                    .HasColumnName("life")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("截止时间");

                entity.Property(e => e.Location)
                    .HasColumnType("smallint(3) unsigned")
                    .HasColumnName("location")
                    .HasComment("暂时预留");

                entity.Property(e => e.Repeat)
                    .HasColumnType("int(11)")
                    .HasColumnName("repeat")
                    .HasDefaultValueSql("'1'")
                    .HasComment("循环次数，-1为无限制");

                entity.Property(e => e.Text)
                    .HasMaxLength(1024)
                    .HasColumnName("text")
                    .HasDefaultValueSql("''")
                    .HasComment("文本内容");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type")
                    .HasComment("0：纯文本，1：带转义符的超文本");
            });

            modelBuilder.Entity<CfRoulette>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("cf_roulette");

                entity.HasComment("轮盘配置--无用 18.12.20 july");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.KeyDesc)
                    .HasMaxLength(128)
                    .HasColumnName("key_desc")
                    .HasComment("说明");

                entity.Property(e => e.KeyValue)
                    .HasMaxLength(32)
                    .HasColumnName("key_value")
                    .HasComment("键值");

                entity.Property(e => e.Param)
                    .HasMaxLength(16)
                    .HasColumnName("param")
                    .HasComment("参数值");
            });

            modelBuilder.Entity<ConfigLuckdraw>(entity =>
            {
                entity.ToTable("config_luckdraw");

                entity.HasComment("幸运抽奖-抽奖次数奖励配置")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("id")
                    .HasComment("编号");

                entity.Property(e => e.GiveNum)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("give_num")
                    .HasComment("赠送次数");

                entity.Property(e => e.Recharge)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("recharge")
                    .HasComment("充值额");

                entity.Property(e => e.TotalBet)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("total_bet")
                    .HasComment("总押注额");
            });

            modelBuilder.Entity<ConfigShop>(entity =>
            {
                entity.ToTable("config_shop");

                entity.HasComment("商城配置表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DayLimit)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("day_limit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("每日购买次数限制(无限次数定义为255)");

                entity.Property(e => e.EndDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("end_date")
                    .HasComment("限制结束时间");

                entity.Property(e => e.GiveMoney)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("give_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("赠送");

                entity.Property(e => e.Icon)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("icon")
                    .HasDefaultValueSql("'0'")
                    .HasComment("商品ICON");

                entity.Property(e => e.Limit)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("limit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("购买次数限制(无限次数定义为255)");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("筹码数量");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasColumnName("name")
                    .HasComment("商品名称");

                entity.Property(e => e.Rmb)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rmb")
                    .HasDefaultValueSql("'0'")
                    .HasComment("价格");

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("start_date")
                    .HasComment("限制开始时间");

                entity.Property(e => e.Tag)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("tag")
                    .HasDefaultValueSql("'0'")
                    .HasComment("标签");
            });

            modelBuilder.Entity<ConfigTurntableReward>(entity =>
            {
                entity.HasKey(e => e.RewardId)
                    .HasName("PRIMARY");

                entity.ToTable("config_turntable_reward");

                entity.HasComment("幸运抽奖-奖励配置")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.RewardId)
                    .HasColumnType("int(5) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("reward_id")
                    .HasComment("奖励编号");

                entity.Property(e => e.RewardNum)
                    .HasColumnType("int(5) unsigned")
                    .HasColumnName("reward_num")
                    .HasDefaultValueSql("'0'")
                    .HasComment("奖励数量");

                entity.Property(e => e.RewardSubType)
                    .HasColumnType("tinyint(4) unsigned")
                    .HasColumnName("reward_sub_type")
                    .HasDefaultValueSql("'0'")
                    .HasComment("子类型(只有 reward_type=3 才有子类型1-4)");

                entity.Property(e => e.RewardType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("reward_type")
                    .HasComment("奖励类型");
            });

            modelBuilder.Entity<ConfigTurntableSlot>(entity =>
            {
                entity.HasKey(e => new { e.Turntable, e.Slot })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("config_turntable_slot");

                entity.HasComment("幸运抽奖-概率配置")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Turntable)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("turntable")
                    .HasComment("轮次");

                entity.Property(e => e.Slot)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("slot")
                    .HasComment("转盘位置");

                entity.Property(e => e.RewardId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("reward_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("weight")
                    .HasComment("权值，百分比");
            });

            modelBuilder.Entity<Friend>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.FriendId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("friend");

                entity.HasIndex(e => e.PlayerId, "IX_player_id");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("player_id");

                entity.Property(e => e.FriendId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("friend_id")
                    .HasComment("好友player_id");

                entity.Property(e => e.VigourDonateTime)
                    .HasColumnType("timestamp")
                    .HasColumnName("vigour_donate_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("体力值赠送时间");

                entity.Property(e => e.VigourRecvTime)
                    .HasColumnType("timestamp")
                    .HasColumnName("vigour_recv_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("体力值收接时间");
            });

            modelBuilder.Entity<FriendAuthen>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.AuthenId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("friend_authen");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("player_id");

                entity.Property(e => e.AuthenId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("authen_id")
                    .HasComment("需认证的角色ID");

                entity.Property(e => e.ExpiredTime)
                    .HasColumnType("timestamp")
                    .HasColumnName("expired_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("申请时间");
            });

            modelBuilder.Entity<FriendList>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PRIMARY");

                entity.ToTable("friend_list");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("player_id");

                entity.Property(e => e.Friends)
                    .HasColumnType("blob")
                    .HasColumnName("friends")
                    .HasComment("好友列表");
            });

            modelBuilder.Entity<GameTp01>(entity =>
            {
                entity.HasKey(e => e.Playerid)
                    .HasName("PRIMARY");

                entity.ToTable("game_tp_01");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Playerid)
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever()
                    .HasColumnName("playerid");

                entity.Property(e => e.Gametime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("gametime")
                    .HasDefaultValueSql("'0'")
                    .HasComment("游戏时间，单位：秒");

                entity.Property(e => e.Round)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("round")
                    .HasDefaultValueSql("'0'")
                    .HasComment("回合数");

                entity.Property(e => e.Score)
                    .HasColumnType("int(11)")
                    .HasColumnName("score")
                    .HasDefaultValueSql("'0'")
                    .HasComment("积分");

                entity.Property(e => e.VirtualScore)
                    .HasColumnType("int(20)")
                    .HasColumnName("virtual_score");
            });

            modelBuilder.Entity<Guild>(entity =>
            {
                entity.ToTable("guild");

                entity.Property(e => e.GuildId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guild_id")
                    .HasComment("公会编号");

                entity.Property(e => e.AllowAutoJoin)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("allow_auto_join")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否允许一键加入");

                entity.Property(e => e.Bank)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("bank")
                    .HasDefaultValueSql("'0'")
                    .HasComment("公会资金");

                entity.Property(e => e.Bulletin)
                    .HasMaxLength(256)
                    .HasColumnName("bulletin")
                    .HasDefaultValueSql("''")
                    .HasComment("告公信息");

                entity.Property(e => e.JoinLevel)
                    .HasColumnType("tinyint(8) unsigned")
                    .HasColumnName("join_level")
                    .HasDefaultValueSql("'0'")
                    .HasComment("加入等级要求");

                entity.Property(e => e.Leader)
                    .HasMaxLength(32)
                    .HasColumnName("leader")
                    .HasDefaultValueSql("''")
                    .HasComment("会长");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level")
                    .HasDefaultValueSql("'1'")
                    .HasComment("公会等级(大厅等级)");

                entity.Property(e => e.MemberMax)
                    .HasColumnType("smallint(8) unsigned")
                    .HasColumnName("member_max")
                    .HasDefaultValueSql("'0'")
                    .HasComment("成员数量上限");

                entity.Property(e => e.MemberNum)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("member_num")
                    .HasDefaultValueSql("'0'")
                    .HasComment("成员数量");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasComment("公会名称");
            });

            modelBuilder.Entity<LoginStatus>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PRIMARY");

                entity.ToTable("login_status");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("player_id");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time")
                    .HasComment("状态更新时间");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(255) unsigned")
                    .HasColumnName("status")
                    .HasComment("0: 未登录；1：登录");
            });

            modelBuilder.Entity<Mail>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("mail");

                entity.HasIndex(e => new { e.Uid, e.Recvid }, "IX_mailid_recvid")
                    .IsUnique();

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.ExpiredTime)
                    .HasColumnType("datetime")
                    .HasColumnName("expired_time");

                entity.Property(e => e.Item0)
                    .HasColumnType("bigint(10) unsigned")
                    .HasColumnName("item0")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item1)
                    .HasColumnType("bigint(10) unsigned")
                    .HasColumnName("item1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item2)
                    .HasColumnType("bigint(10) unsigned")
                    .HasColumnName("item2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item3)
                    .HasColumnType("bigint(10) unsigned")
                    .HasColumnName("item3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mark)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("mark")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Recvid)
                    .HasColumnType("bigint(11) unsigned")
                    .HasColumnName("recvid");

                entity.Property(e => e.SenderName)
                    .HasMaxLength(32)
                    .HasColumnName("sender_name");

                entity.Property(e => e.Sendid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("sendid");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Title)
                    .HasMaxLength(32)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<MailSy>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("mail_sys");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.ExpiredTime)
                    .HasColumnType("datetime")
                    .HasColumnName("expired_time");

                entity.Property(e => e.Item0)
                    .HasColumnType("bigint(6) unsigned")
                    .HasColumnName("item0")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item1)
                    .HasColumnType("bigint(6) unsigned")
                    .HasColumnName("item1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item2)
                    .HasColumnType("bigint(10) unsigned")
                    .HasColumnName("item2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item3)
                    .HasColumnType("bigint(10) unsigned")
                    .HasColumnName("item3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Title)
                    .HasMaxLength(32)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Notice>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("notice");

                entity.HasComment("公告");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .HasColumnName("uid")
                    .HasComment("自增编号");

                entity.Property(e => e.Isshow)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("isshow")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否显示，0 不显示，1 显示");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(16)
                    .HasColumnName("modifier")
                    .HasDefaultValueSql("''")
                    .HasComment("修改人");

                entity.Property(e => e.Modifytime)
                    .HasColumnType("datetime")
                    .HasColumnName("modifytime")
                    .HasComment("修改时间");

                entity.Property(e => e.Picture)
                    .HasMaxLength(128)
                    .HasColumnName("picture")
                    .HasDefaultValueSql("''")
                    .HasComment("图片");

                entity.Property(e => e.Text)
                    .HasMaxLength(256)
                    .HasColumnName("text")
                    .HasDefaultValueSql("''")
                    .HasComment("内容");

                entity.Property(e => e.Title)
                    .HasMaxLength(64)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasComment("标题");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'1'")
                    .HasComment("类型：1 弹框公告，2 旋转公告(特效：内容前加[1-9]。)");

                entity.Property(e => e.Url)
                    .HasMaxLength(128)
                    .HasColumnName("url")
                    .HasDefaultValueSql("''")
                    .HasComment("链接地址");
            });

            modelBuilder.Entity<OnlinePlayer>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PRIMARY");

                entity.ToTable("online_player");

                entity.HasComment("用户实时在线表，只针对进入游戏房间的玩家，非登录大厅状态，金币为带入房间的金币数")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("player_id");

                entity.Property(e => e.ClassId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("class_id")
                    .HasComment("游戏类别");

                entity.Property(e => e.Device)
                    .HasMaxLength(32)
                    .HasColumnName("device")
                    .HasDefaultValueSql("''")
                    .HasComment("设备类型：pc,android,ios")
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasComment("玩家名称")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("插入时间戳");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("player");

                entity.HasIndex(e => e.Name, "IX_name");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("player_id");

                entity.Property(e => e.BitTag)
                    .HasMaxLength(320)
                    .HasColumnName("bit_tag")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Exp)
                    .HasColumnType("int(11)")
                    .HasColumnName("exp")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FriendNum)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("friend_num")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GuildId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guild_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("公会编号");

                entity.Property(e => e.Headimage)
                    .HasColumnType("blob")
                    .HasColumnName("headimage");

                entity.Property(e => e.Image)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("image")
                    .HasDefaultValueSql("'0'")
                    .HasComment("头像框");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(6) unsigned")
                    .HasColumnName("level")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LimitOut)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("limit_out")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转出限制 0 no,1 yes");

                entity.Property(e => e.Money)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("money")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(36)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Package)
                    .HasColumnType("blob")
                    .HasColumnName("package");

                entity.Property(e => e.Rmb)
                    .HasColumnType("int(11)")
                    .HasColumnName("rmb")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Roomcard)
                    .HasColumnType("int(11)")
                    .HasColumnName("roomcard")
                    .HasDefaultValueSql("'0'")
                    .HasComment("房卡");

                entity.Property(e => e.Sex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("sex");

                entity.Property(e => e.SysMail)
                    .HasMaxLength(128)
                    .HasColumnName("sys_mail")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TagDate)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("tag_date")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VipPoint)
                    .HasColumnType("mediumint(8)")
                    .HasColumnName("vip_point")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PRIMARY");

                entity.ToTable("rank");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("player_id");

                entity.Property(e => e.Score)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("score");
            });

            modelBuilder.Entity<RankWeek>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PRIMARY");

                entity.ToTable("rank_week");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("player_id");

                entity.Property(e => e.Score)
                    .HasColumnType("int(10)")
                    .HasColumnName("score")
                    .HasComment("排行积分，可为负数");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<Recharge>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PRIMARY");

                entity.ToTable("recharge");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("player_id");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Replay>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("replay");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Player0, "IX_player0");

                entity.HasIndex(e => e.Player1, "IX_player1");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Data)
                    .HasColumnType("blob")
                    .HasColumnName("data");

                entity.Property(e => e.Format)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("format");

                entity.Property(e => e.Gameid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gameid");

                entity.Property(e => e.Player0)
                    .HasColumnType("bigint(10) unsigned")
                    .HasColumnName("player0");

                entity.Property(e => e.Player1)
                    .HasColumnType("bigint(11) unsigned")
                    .HasColumnName("player1");

                entity.Property(e => e.Player2)
                    .HasColumnType("bigint(255) unsigned")
                    .HasColumnName("player2");

                entity.Property(e => e.Player3)
                    .HasColumnType("bigint(255) unsigned")
                    .HasColumnName("player3");

                entity.Property(e => e.Roomid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("roomid");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasColumnName("time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.HasKey(e => e.GoodsId)
                    .HasName("PRIMARY");

                entity.ToTable("shop");

                entity.Property(e => e.GoodsId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("goods_id")
                    .HasComment("唯一索引");

                entity.Property(e => e.Desc)
                    .HasMaxLength(64)
                    .HasColumnName("desc")
                    .HasDefaultValueSql("''")
                    .HasComment("描述");

                entity.Property(e => e.ExchangeType)
                    .HasMaxLength(32)
                    .HasColumnName("exchange_type")
                    .HasDefaultValueSql("''")
                    .HasComment("兑换类型，支持：roomcard,rmb,item");

                entity.Property(e => e.ExchangeValue0)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("exchange_value0")
                    .HasComment("兑换数值");

                entity.Property(e => e.ExchangeValue1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("exchange_value1")
                    .HasComment("兑换数值");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image")
                    .HasDefaultValueSql("''")
                    .HasComment("商品图标");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("money")
                    .HasComment("实际金额，单位：分");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasComment("商品名称");
            });

            modelBuilder.Entity<Suggestion>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("suggestion");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Mark)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("mark");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .HasColumnName("phone")
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength();

                entity.Property(e => e.Text)
                    .HasMaxLength(1024)
                    .HasColumnName("text")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Userid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("userid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
