using SEA_ApiTest.Models.Attribute;
using Microsoft.EntityFrameworkCore;


namespace SEA_ApiTest.Models.Firelog1DB
{
    [DbContextConfigAttr("SQLConnection:Firelog1:Read", "ServerVersion:Firelog1:Read")]
    public class Firelog1ReadDb : Firelog1DbContext, IReadDbContext
    {
        public Firelog1ReadDb(DbContextOptions<Firelog1ReadDb> options) : base(options)
        {
        }

        public DbContext DbContext() => this;
    }

    [DbContextConfigAttr("SQLConnection:Firelog1:Write", "ServerVersion:Firelog1:Write")]
    public class Firelog1WriteDb : Firelog1DbContext, IWriteDbContext
    {
        public Firelog1WriteDb(DbContextOptions<Firelog1WriteDb> options) : base(options)
        {

        }

        public DbContext DbContext() => this;
    }

    public partial class Firelog1DbContext
    {
        public Firelog1DbContext(DbContextOptions<Firelog1ReadDb> options) : base(options)
        {
        }

        public Firelog1DbContext(DbContextOptions<Firelog1WriteDb> options) : base(options)
        {
        }
    }
}
