using SEA_ApiTest.Models.Attribute;
using Microsoft.EntityFrameworkCore;


namespace SEA_ApiTest.Models.Tpi1DB
{
    [DbContextConfigAttr("SQLConnection:Tpi1:Read", "ServerVersion:Tpi1:Read")]
    public class Tpi1ReadDb : Tpi1DbContext, IReadDbContext
    {
        public Tpi1ReadDb(DbContextOptions<Tpi1ReadDb> options) : base(options) { }
        public DbContext DbContext() => this;
    }
    [DbContextConfigAttr("SQLConnection:Tpi1:Write", "ServerVersion:Tpi1:Write")]
    public class Tpi1WriteDb : Tpi1DbContext, IWriteDbContext
    {
        public Tpi1WriteDb(DbContextOptions<Tpi1WriteDb> options) : base(options) { }
        public DbContext DbContext() => this;
    }
    public partial class Tpi1DbContext
    {
        public Tpi1DbContext(DbContextOptions<Tpi1ReadDb> options) : base(options) { }
        public Tpi1DbContext(DbContextOptions<Tpi1WriteDb> options) : base(options) { }
    }
}
