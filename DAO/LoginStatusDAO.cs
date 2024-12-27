using SEA_ApiTest.Models.Tp01DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LoginStatusDAO : BaseDAO<Tp01ReadDb, Tp01WriteDb>, IReadModel<LoginStatus>, IWriteModel<LoginStatus>
    {
        public LoginStatusDAO(Tp01WriteDb dbw, Tp01ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LoginStatus> ReadDbSet() => _dbr.LoginStatuses;

        public DbSet<LoginStatus> WriteDbSet()=>_dbw.LoginStatuses;
    }
}
