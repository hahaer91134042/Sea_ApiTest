using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Firelog1DbContext : DbContext
    {
        public Firelog1DbContext()
        {
        }

        public Firelog1DbContext(DbContextOptions<Firelog1DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<Channelerror> Channelerrors { get; set; } = null!;
        public virtual DbSet<Channellogin> Channellogins { get; set; } = null!;
        public virtual DbSet<Channelrecharge> Channelrecharges { get; set; } = null!;
        public virtual DbSet<Error> Errors { get; set; } = null!;
        public virtual DbSet<Exp> Exps { get; set; } = null!;
        public virtual DbSet<Level> Levels { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Luckdraw> Luckdraws { get; set; } = null!;
        public virtual DbSet<Money> Money { get; set; } = null!;
        public virtual DbSet<Onlineuser> Onlineusers { get; set; } = null!;
        public virtual DbSet<Rmb> Rmbs { get; set; } = null!;
        public virtual DbSet<Roomcard> Roomcards { get; set; } = null!;
        public virtual DbSet<Shopbuy> Shopbuys { get; set; } = null!;
        public virtual DbSet<Updatedatum> Updatedata { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.10.37;port=3306;database=firelog_1;user=root;password=1qasde32;max pool size=100;min pool size=5;convertzerodatetime=True", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.20-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("bill");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.AgentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("agent_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("代理id");

                entity.Property(e => e.GoodsId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("goods_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("商品id");

                entity.Property(e => e.Money)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("money")
                    .HasDefaultValueSql("'0'")
                    .HasComment("订单金额");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(256)
                    .HasColumnName("order_id")
                    .HasDefaultValueSql("''")
                    .HasComment("订单id（内部）");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("player_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("用户id");

                entity.Property(e => e.Status)
                    .HasMaxLength(256)
                    .HasColumnName("status")
                    .HasDefaultValueSql("''")
                    .HasComment("订单状态");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("时间戳");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(256)
                    .HasColumnName("transaction_id")
                    .HasDefaultValueSql("''")
                    .HasComment("交易id（外部）");
            });

            modelBuilder.Entity<Channelerror>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("channelerror");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Account)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AgentId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("AgentID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ServerID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Text)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Type)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Channellogin>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("channellogin");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Account)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AgentId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("AgentID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Code)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Info)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ServerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ServerID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<Channelrecharge>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("channelrecharge");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Account)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AgentId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("AgentID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Info)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(256)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rmb)
                    .HasColumnType("int(11)")
                    .HasColumnName("RMB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ServerID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("error");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Text)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("时间戳");

                entity.Property(e => e.Type)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Exp>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("exp");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Exp1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("Exp")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Type)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("level");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Level1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Level")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SourceLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Text)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("login");

                entity.HasIndex(e => new { e.UserId, e.UserName }, "ix_UserID_UserName");

                entity.HasIndex(e => e.Time, "ix_time");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Account)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Agent)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Device)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ip)
                    .HasMaxLength(256)
                    .HasColumnName("IP")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LobbyId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("LobbyID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MacAddr)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PlayTime)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SubLabel)
                    .HasMaxLength(256)
                    .HasColumnName("sub_label")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Type)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(256)
                    .HasColumnName("UUID")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Luckdraw>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("luckdraw");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RewardNum)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Money>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("money");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Money1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("Money")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Operation)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TargetId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("TargetID")
                    .HasDefaultValueSql("'0'")
                    .HasComment("房间ID或用户ID");

                entity.Property(e => e.TargetName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Text)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("时间戳");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Onlineuser>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("onlineuser");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.ClassId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ClassID")
                    .HasDefaultValueSql("'0'")
                    .HasComment("游戏子类型");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GameId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("GameID")
                    .HasDefaultValueSql("'0'")
                    .HasComment("游戏标识");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<Rmb>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("rmb");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Operation)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rmb1)
                    .HasColumnType("int(11)")
                    .HasColumnName("RMB")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TargetId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("TargetID")
                    .HasDefaultValueSql("'0'")
                    .HasComment("根据Operation不同定义");

                entity.Property(e => e.TargetName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Text)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Roomcard>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("roomcard");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Operation)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TargetId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("TargetID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TargetName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Text)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Shopbuy>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("shopbuy");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.GoodsId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("GoodsID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Monery)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Rmb)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Updatedatum>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("updatedata");

                entity.Property(e => e.Uid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uid");

                entity.Property(e => e.ClassId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("class_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("分类id");

                entity.Property(e => e.GameId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("game_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("游戏id");

                entity.Property(e => e.Money)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("money")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("player_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecordId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("record_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("记录id，用于快速检查");

                entity.Property(e => e.Roomcard)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("roomcard")
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
