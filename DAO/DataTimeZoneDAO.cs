using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SEA_ApiTest.DAO
{
    public class DataTimeZoneDAO:BaseDAO<ManageReadDb,ManageWriteDb>,IReadModel<DataTimeZone>,IWriteModel<DataTimeZone>
    {        

        public DataTimeZoneDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        /// <summary>
        /// 偏移量是否SEA_ApiTestT-4
        /// </summary>
        /// <returns>boolean of result</returns>
        public bool IsSEA_ApiTestTSub4()
        {
            var SEA_ApiTesttObj = _dbr.DataTimeZones.Where(x => x.IsUse == 1).FirstOrDefault();
            return SEA_ApiTesttObj == null ? false : SEA_ApiTesttObj.Uid == 1 ? false : true;
        }


        public void ChangeZone(int uid)
        {
            _dbw.DataTimeZones.Where(z => z.IsUse == 1)
                .Foreach(z =>
            {
                z.IsUse = 0;
            });
            _dbw.DataTimeZones.First(z=>z.Uid==uid).IsUse=1;
            _dbw.SaveChanges();
            //_dbw.Database.ExecuteSqlRaw("update data_time_zone set is_use=0");
            //_dbw.Database.ExecuteSqlRaw("update data_time_zone set is_use=1 where uid=" + uid);
        }

        public DbContext dbw => _dbw;
        public DbSet<DataTimeZone> ReadDbSet()=>_dbr.DataTimeZones;
        public DbSet<DataTimeZone> WriteDbSet() => _dbw.DataTimeZones;
    }
}
