using System;
using System.Collections.Generic;
using SEA_ApiTest.Models.Attribute;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SEA_ApiTest.Models.ManageDb
{
    [DbContextConfigAttr("SQLConnection:ManageDb:Read", "ServerVersion:ManageDb:Read")]
    public class ManageReadDb : ManageDbContext,IReadDbContext
    {
        public ManageReadDb(DbContextOptions<ManageReadDb> options) : base(options)
        {
        }
        public DbContext DbContext() => this;
    }

    [DbContextConfigAttr("SQLConnection:ManageDb:Write", "ServerVersion:ManageDb:Write")]
    public class ManageWriteDb : ManageDbContext,IWriteDbContext
    {
        public ManageWriteDb(DbContextOptions<ManageWriteDb> options) : base(options)
        {
        }
        public DbContext DbContext() => this;
    }

    public partial class ManageDbContext 
    {       
        public ManageDbContext(DbContextOptions<ManageReadDb> options) : base(options)
        {
        }
        public ManageDbContext(DbContextOptions<ManageWriteDb> options) : base(options)
        {
        }
    }
}
