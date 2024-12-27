using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SysBulletinAutoDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<SysBulletinAuto>, IWriteModel<SysBulletinAuto>
    {
        public SysBulletinAutoDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }
        public SysBulletinAutoDAO() : base(ConfigUtil.Start().CreatDbContext<ManageWriteDb>(), ConfigUtil.Start().CreatDbContext<ManageReadDb>()) { }

        public DbContext dbw => _dbw;

        public DbSet<SysBulletinAuto> ReadDbSet() => _dbr.SysBulletinAutos;

        public DbSet<SysBulletinAuto> WriteDbSet() => _dbw.SysBulletinAutos;

        public bool CountSub(int uid)
        {
            //("update sys_bulletin_auto set re_counts=re_counts-1 where uid=" + uid + " and re_counts>0")
            (from m in _dbw.SysBulletinAutos
             where m.Uid == uid
             where m.ReCounts > 0
             select m).Foreach(m =>
             {
                 m.ReCounts = m.ReCounts - 1;
             });
            return _dbw.SaveChanges() > 0;
        }
    }
}
