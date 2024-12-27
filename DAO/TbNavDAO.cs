using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SEA_ApiTest.DAO
{
    public class TbNavDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<TbNav>,IWriteModel<TbNav>
    {
        public TbNavDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<TbNav> ReadDbSet() => _dbr.TbNavs;

        public DbSet<TbNav> WriteDbSet()=>_dbw.TbNavs;
    }
}
