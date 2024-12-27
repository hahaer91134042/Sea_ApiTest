using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class TbDicDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<TbDic>, IWriteModel<TbDic>
    {
        public TbDicDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<TbDic> ReadDbSet() => _dbr.TbDics;

        public DbSet<TbDic> WriteDbSet()=>_dbw.TbDics;
    }
}
