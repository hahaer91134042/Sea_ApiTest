using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncFileDownloadDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<SyncFileDownload>, IWriteModel<SyncFileDownload>
    {
        public SyncFileDownloadDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncFileDownload> ReadDbSet() => _dbr.SyncFileDownloads;

        public DbSet<SyncFileDownload> WriteDbSet()=>_dbw.SyncFileDownloads;
    }
}
