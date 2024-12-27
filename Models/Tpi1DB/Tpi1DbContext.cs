using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SEA_ApiTest.Models.Tpi1DB
{
    public partial class Tpi1DbContext : DbContext
    {
        public Tpi1DbContext()
        {
        }

        public Tpi1DbContext(DbContextOptions<Tpi1DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivitySdConfig> ActivitySdConfigs { get; set; } = null!;
        public virtual DbSet<ActivitySdExchange> ActivitySdExchanges { get; set; } = null!;
        public virtual DbSet<Animalround> Animalrounds { get; set; } = null!;
        public virtual DbSet<DictionaryManaged> DictionaryManageds { get; set; } = null!;
        public virtual DbSet<Gamemoney> Gamemoneys { get; set; } = null!;
        public virtual DbSet<OpenPrivateRoom> OpenPrivateRooms { get; set; } = null!;
        public virtual DbSet<RoomInOut> RoomInOuts { get; set; } = null!;
        public virtual DbSet<RouletteRecord> RouletteRecords { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.10.37;port=3306;database=tpi_1;user=root;password=1qasde32;max pool size=100;min pool size=5;convertzerodatetime=True", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.20-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<ActivitySdConfig>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("activity_sd_config");

                entity.HasComment("双旦活动配置-圣诞、元旦");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("uid")
                    .HasComment("编号");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time")
                    .HasComment("结束时间");

                entity.Property(e => e.GameId)
                    .HasMaxLength(32)
                    .HasColumnName("game_id")
                    .HasComment("游戏编号");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time")
                    .HasComment("开始时间");
            });

            modelBuilder.Entity<ActivitySdExchange>(entity =>
            {
                entity.HasKey(e => e.CurId)
                    .HasName("PRIMARY");

                entity.ToTable("activity_sd_exchange");

                entity.HasComment("双旦活动-积分转换");

                entity.Property(e => e.CurId)
                    .HasColumnType("tinyint(4)")
                    .ValueGeneratedNever()
                    .HasColumnName("cur_id")
                    .HasComment("货币编号");

                entity.Property(e => e.Money)
                    .HasColumnType("int(11)")
                    .HasColumnName("money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("转换金额，计算小数位之前");
            });

            modelBuilder.Entity<Animalround>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("animalround");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.RoundId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShowId0)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShowId1)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShowId2)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShowId3)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShowId4)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ShowId5)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<DictionaryManaged>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PRIMARY");

                entity.ToTable("dictionary_managed");

                entity.HasComment("字典管理")
                    .HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

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
                    .HasColumnType("int(11)")
                    .HasColumnName("column_value")
                    .HasComment("字段值");

                entity.Property(e => e.LanguageId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("language_id")
                    .HasDefaultValueSql("'1'")
                    .HasComment("语言ID");

                entity.Property(e => e.TableDescribe)
                    .HasMaxLength(16)
                    .HasColumnName("table_describe")
                    .HasComment("表描述")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableName)
                    .HasMaxLength(32)
                    .HasColumnName("table_name")
                    .HasComment("表名");

                entity.Property(e => e.ValueDescribe)
                    .HasMaxLength(16)
                    .HasColumnName("value_describe")
                    .HasComment("值描述")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Gamemoney>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("gamemoney");

                entity.HasIndex(e => new { e.PlayerName, e.GameId, e.ClassId, e.Time }, "ix_PlayerName_GameID_ClassID_Time");

                entity.HasIndex(e => e.RoundId, "ix_RoundID");

                entity.HasIndex(e => new { e.SubOper, e.PlayerId, e.PlayerName, e.Time }, "ix_SubOper_PlayerID_PlayerName_Time");

                entity.HasIndex(e => e.OrderId, "ix_orderid");

                entity.HasIndex(e => e.Time, "ix_time");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.BankerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("BankerID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BattleId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("BattleID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BetMoney)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ClassId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ClassID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GameId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("GameID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Io)
                    .HasColumnType("int(11)")
                    .HasColumnName("IO")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsQueriable)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Money)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Operation)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(256)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("PlayerID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PrizeMoney)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ResultData).HasColumnType("text");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("RoomID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RoundId)
                    .HasMaxLength(256)
                    .HasColumnName("RoundID")
                    .HasDefaultValueSql("''")
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(256)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubOper)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<OpenPrivateRoom>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("open_private_room");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.BattleId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("BattleID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GameId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("GameID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("PlayerID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rmb)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("RMB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("RoomID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<RoomInOut>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("room_in_out");

                entity.HasIndex(e => new { e.PlayerId, e.PlayerName }, "ix_playerid_name");

                entity.HasIndex(e => e.Time, "ix_time");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.BattleId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("BattleID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ClassId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ClassID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GameId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("GameID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Money)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("PlayerID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("RoomID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(256)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<RouletteRecord>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("roulette_record");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.BattleId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("BattleID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ClassId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ClassID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GameId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("GameID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OwnerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("OwnerID")
                    .HasDefaultValueSql("'0'")
                    .HasComment("无房主时为0");

                entity.Property(e => e.Result)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("result")
                    .HasDefaultValueSql("'0'")
                    .HasComment("0-36");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("RoomID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
