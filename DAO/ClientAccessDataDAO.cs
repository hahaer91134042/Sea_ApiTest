using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class ClientAccessDataDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<ClientAccessDatum>, IWriteModel<ClientAccessDatum>
    {
        public ClientAccessDataDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<ClientAccessDatum> ReadDbSet() => _dbr.ClientAccessData;

        public DbSet<ClientAccessDatum> WriteDbSet()=>_dbw.ClientAccessData;
    }
}
