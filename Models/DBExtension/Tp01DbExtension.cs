using SEA_ApiTest.Models.Attribute;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.Models.Tp01DB
{
    [DbContextConfigAttr("SQLConnection:Tp01:Read", "ServerVersion:Tp01:Read")]
    public class Tp01ReadDb : Tp01DbContext, IReadDbContext
    {
        public Tp01ReadDb(DbContextOptions<Tp01ReadDb> options):base(options) { }
        public DbContext DbContext() => this;
    }
    [DbContextConfigAttr("SQLConnection:Tp01:Write", "ServerVersion:Tp01:Write")]
    public class Tp01WriteDb : Tp01DbContext, IWriteDbContext
    {
        public Tp01WriteDb(DbContextOptions<Tp01WriteDb> options) : base(options) { }
        public DbContext DbContext() => this;
    }
    public partial class Tp01DbContext
    {
        public Tp01DbContext(DbContextOptions<Tp01ReadDb> options):base(options) { }
        public Tp01DbContext(DbContextOptions<Tp01WriteDb> options) : base(options) { }
    }
}
