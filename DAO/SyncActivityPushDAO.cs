using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncActivityPushDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<SyncActivityPush>, IWriteModel<SyncActivityPush>
    {
        public SyncActivityPushDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncActivityPush> ReadDbSet() => _dbr.SyncActivityPushes;

        public DbSet<SyncActivityPush> WriteDbSet()=>_dbw.SyncActivityPushes;

        public void SyncData(List<SyncActivityPush> data)
        {
            bool isChange = false;
            var nowData = _dbw.SyncActivityPushes.FirstOrDefault();//.sync_activity_push.ToList().FirstOrDefault();
            int isPush = data.FirstOrDefault()?.IsPush ?? 0;
            if (nowData != null)
            {
                //如果与当前开关不相同则修改配置表中的开关
                if (nowData.IsPush != isPush)
                    isChange = true;
            }
            _dbw.SyncActivityPushes.RemoveRange(_dbw.SyncActivityPushes);
            _dbw.SaveChanges();
            //db.Database.ExecuteSqlCommand("delete from sync_activity_push");
            _dbw.SyncActivityPushes.Add(nowData);
            _dbw.SaveChanges();
            //db.Database.ExecuteSqlCommand("insert into sync_activity_push(uid,data_desc,is_push,start_time,end_time) " +
            //    "values(" + data[0].uid + ",'" + data[0].data_desc + "'," + data[0].is_push + ",'" + data[0].start_time + "','" + data[0].end_time + "')");
            if (isChange)
            {
                _dbw.StatisServerConfigs.Where(m => m.Rid == 303)
                    .Foreach(m =>
                    {
                        m.Value1 = (isPush == 1 ? 0 : 1).ToString();
                    });
                _dbw.SaveChanges();
                //db.Database.ExecuteSqlCommand(
                //    "update statis_server_config  set value1='" + (isPush == 1 ? 0 : 1) + "' where rid=303");
            }
        }
    }
}
