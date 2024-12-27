using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SEA_ApiTest.Models.GameTpiDB
{
    public partial class GameTpiDbContext : DbContext
    {
        public GameTpiDbContext()
        {
        }

        public GameTpiDbContext(DbContextOptions<GameTpiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataTp01> DataTp01s { get; set; } = null!;
        public virtual DbSet<Game315> Game315s { get; set; } = null!;
        public virtual DbSet<GameBonusPool> GameBonusPools { get; set; } = null!;
        public virtual DbSet<GameTp01> GameTp01s { get; set; } = null!;
        public virtual DbSet<PkBonusPool> PkBonusPools { get; set; } = null!;
        public virtual DbSet<PlayerActivityDatum> PlayerActivityData { get; set; } = null!;
        public virtual DbSet<RaidersLevel> RaidersLevels { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.10.37;port=3306;database=game_tpi;user=root;password=1qasde32;max pool size=100;min pool size=5;convertzerodatetime=True", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.20-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<DataTp01>(entity =>
            {
                entity.HasKey(e => new { e.Playerid, e.Gameid, e.Level })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("data_tp_01");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Playerid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("playerid");

                entity.Property(e => e.Gameid)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("level");

                entity.Property(e => e.Data)
                    .HasColumnType("int(255)")
                    .HasColumnName("data");
            });

            modelBuilder.Entity<Game315>(entity =>
            {
                entity.HasKey(e => new { e.Playerid, e.Gameid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_315");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Playerid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("playerid");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("gameid");

                entity.Property(e => e.BetTrigger)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet_trigger")
                    .HasDefaultValueSql("'0'")
                    .HasComment("红包雨-累计下注次数触发值");

                entity.Property(e => e.Bettick)
                    .HasColumnType("tinyint(20) unsigned")
                    .HasColumnName("bettick")
                    .HasComment("下注次数");

                entity.Property(e => e.Ep)
                    .HasColumnType("int(11)")
                    .HasColumnName("ep")
                    .HasComment("充值能量点");

                entity.Property(e => e.Freetick)
                    .HasColumnType("int(255)")
                    .HasColumnName("freetick")
                    .HasComment("freespin次数");

                entity.Property(e => e.Lottery)
                    .HasColumnType("int(11)")
                    .HasColumnName("lottery")
                    .HasDefaultValueSql("'0'")
                    .HasComment("抽奖次数");

                entity.Property(e => e.TotalBetCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_bet_count")
                    .HasDefaultValueSql("'0'")
                    .HasComment("红包雨-累计下注次数");

                entity.Property(e => e.TotalBetMoney)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("total_bet_money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("红包雨-累计下注额");
            });

            modelBuilder.Entity<GameBonusPool>(entity =>
            {
                entity.HasKey(e => new { e.JpLevel, e.GameId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_bonus_pool");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.JpLevel)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("jp_level");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("game_id");

                entity.Property(e => e.BonusMoney)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bonus_money")
                    .HasDefaultValueSql("'0'");
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

                entity.Property(e => e.Bw)
                    .HasColumnType("int(11)")
                    .HasColumnName("bw")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gametime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("gametime")
                    .HasDefaultValueSql("'0'")
                    .HasComment("游戏时间，单位：秒");

                entity.Property(e => e.Lose)
                    .HasColumnType("int(11)")
                    .HasColumnName("lose")
                    .HasDefaultValueSql("'0'");

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
                    .HasColumnName("virtual_score")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Win)
                    .HasColumnType("int(11)")
                    .HasColumnName("win")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PkBonusPool>(entity =>
            {
                entity.HasKey(e => e.Type)
                    .HasName("PRIMARY");

                entity.ToTable("pk_bonus_pool");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(2)")
                    .ValueGeneratedNever()
                    .HasColumnName("type");

                entity.Property(e => e.BonusMoney)
                    .HasColumnType("bigint(11) unsigned")
                    .HasColumnName("bonus_money")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PlayerActivityDatum>(entity =>
            {
                entity.HasKey(e => e.Playerid)
                    .HasName("PRIMARY");

                entity.ToTable("player_activity_data");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Playerid)
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever()
                    .HasColumnName("playerid");

                entity.Property(e => e.Ep)
                    .HasColumnType("int(11)")
                    .HasColumnName("ep");

                entity.Property(e => e.Lottery)
                    .HasColumnType("int(20)")
                    .HasColumnName("lottery");
            });

            modelBuilder.Entity<RaidersLevel>(entity =>
            {
                entity.HasKey(e => e.Playerid)
                    .HasName("PRIMARY");

                entity.ToTable("raiders_level");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Playerid)
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever()
                    .HasColumnName("playerid");

                entity.Property(e => e.Bet)
                    .HasColumnType("int(11)")
                    .HasColumnName("bet");

                entity.Property(e => e.DragonCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("dragon_count")
                    .HasComment("龙珠数量");

                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.OpenCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("open_count")
                    .HasComment("开宝箱数量");

                entity.Property(e => e.WinCoin)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_coin");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
