using SEA_ApiTest.Extension;
using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class WebConfigDAO:BaseDAO<ManageReadDb,ManageWriteDb>,IReadModel<WebConfig>,IWriteModel<WebConfig>
    {
        public WebConfigDAO() : base(ConfigUtil.Start().CreatDbContext<ManageWriteDb>(), ConfigUtil.Start().CreatDbContext<ManageReadDb>()) { }
        public WebConfigDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<WebConfig> ReadDbSet()=>_dbr.WebConfigs;

        public DbSet<WebConfig> WriteDbSet()=>_dbw.WebConfigs;


        public string GetConfig(string name)
        {
            var model = _dbr.WebConfigs.Where(m => m.ParamName == name).FirstOrDefault();
            if (model == null)
                return "";
            else
                return model.ParamVal??"";
        }

        
    }
}
