using SEA_ApiTest.Models;
using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class TbManagerLogDAO : BaseDAO<ManageReadDb,ManageWriteDb>,IReadModel<TbManagerLog>,IWriteModel<TbManagerLog>
    {
        public TbManagerLogDAO() : base(ConfigUtil.Start().CreatDbContext<ManageWriteDb>(), ConfigUtil.Start().CreatDbContext<ManageReadDb>()) { }
        public TbManagerLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        

        public int Create(TbManagerLog Obj)
        {
            _dbw.TbManagerLogs.Add(Obj);
            _dbw.SaveChanges();
            return Obj.Id;
        }

        public DbContext dbw => _dbw;
        public DbSet<TbManagerLog> ReadDbSet() => _dbr.TbManagerLogs;
        public DbSet<TbManagerLog> WriteDbSet()=>_dbw.TbManagerLogs;
    }
}
