using SEA_ApiTest.Models.Firelog1DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LoginDAO : BaseDAO<Firelog1ReadDb,Firelog1WriteDb>, IReadModel<Login>, IWriteModel<Login>
    {
        public LoginDAO(Firelog1WriteDb dbw, Firelog1ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<Login> ReadDbSet() => _dbr.Logins;

        public DbSet<Login> WriteDbSet()=>_dbw.Logins;
    }
}
