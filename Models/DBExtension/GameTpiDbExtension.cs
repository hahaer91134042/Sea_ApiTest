using SEA_ApiTest.Models.Attribute;
using Microsoft.EntityFrameworkCore;


namespace SEA_ApiTest.Models.GameTpiDB
{
    [DbContextConfigAttr("SQLConnection:GameTpi:Read", "ServerVersion:GameTpi:Read")]
    public class GameTpiReadDb : GameTpiDbContext, IReadDbContext
    {
        public GameTpiReadDb(DbContextOptions<GameTpiReadDb> options) : base(options)
        {
        }
        public DbContext DbContext() => this;
    }

    [DbContextConfigAttr("SQLConnection:GameTpi:Write", "ServerVersion:GameTpi:Write")]
    public class GameTpiWriteDb : GameTpiDbContext, IWriteDbContext
    {
        public GameTpiWriteDb(DbContextOptions<GameTpiWriteDb> options) : base(options)
        {
        }
        public DbContext DbContext() => this;
    }

    public partial class GameTpiDbContext
    {

        public GameTpiDbContext(DbContextOptions<GameTpiReadDb> options) : base(options)
        {
        }
        public GameTpiDbContext(DbContextOptions<GameTpiWriteDb> options) : base(options)
        {
        }
    }
}
