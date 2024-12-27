using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class DwRtpPreprimedDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<DwRtpPreprimed>
    {
        public DwRtpPreprimedDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbSet<DwRtpPreprimed> ReadDbSet() => _dbr.DwRtpPreprimeds;
    }
}
