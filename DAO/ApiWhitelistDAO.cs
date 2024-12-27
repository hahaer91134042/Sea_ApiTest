using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class ApiWhitelistDAO : BaseDAO<ManageReadDb,ManageWriteDb>,IReadModel<ApiWhitelist>,IWriteModel<ApiWhitelist>
    {
        public ApiWhitelistDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public async Task<int> GetCountByIP(string ip)
        {
            return await _dbr.ApiWhitelists.Where(m => m.LimitType == 2 && m.State == 0 && m.IpAddr == ip).CountAsync();
        }

        public DbContext dbw => _dbw;

        public DbSet<ApiWhitelist> ReadDbSet() => _dbr.ApiWhitelists;

        public DbSet<ApiWhitelist> WriteDbSet() => _dbw.ApiWhitelists;


        /// <summary>
        /// 檢查IP是否在白名單內
        /// </summary>
        /// <param name="ip"></param>
        /// <returns>true=Valid</returns>
        public bool CheckIp(string ip)
        {
            return _dbr.ApiWhitelists
                .Count(m => m.LimitType == 1 && m.IpAddr == ip && m.State == 0) > 0;
            //return this.ReadCount(m => m.LimitType == 1 && m..ip_addr == ip && m.state == 0) == 0
        }
    }
}
