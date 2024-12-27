using SEA_ApiTest.Models;
using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;
using Microsoft.EntityFrameworkCore;


namespace SEA_ApiTest.DAO
{
    public abstract class BaseDAO<R,W>:IDisposable where R:DbContext,IReadDbContext  where W:DbContext,IWriteDbContext
    {        
        /// <summary>
        /// 這樣操作可能很佔記憶體空間 
        /// 可能之後改成DbSet 就可以
        /// </summary>
        protected W _dbw;
        protected R _dbr;
        private bool _disposed = false;


        public BaseDAO(W dbw, R dbr )
        {
            _dbw = dbw;
            _dbr = dbr;
        }








        /// <summary>
        /// 清除此Class的資源。
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 清除此Class的資源。
        /// </summary>
        /// <param name="disposing">是否在清理中？</param>
        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbw.Dispose();
                    _dbr.Dispose();
                }
            }

            _disposed = true;
        }
    }
}