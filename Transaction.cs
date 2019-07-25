
// 



// 
using System.Data;

namespace Jiesen.DapperPoco
{
    /// <summary>
    ///     Transaction object helps maintain transaction depth counts
    /// </summary>
    internal class Transaction : ITransaction
    {
        private Jiesen.DapperPoco.DbContext _dbCtx;

        public Transaction(Jiesen.DapperPoco.DbContext dbCtx, IsolationLevel isolation = IsolationLevel.ReadCommitted)
        {
            _dbCtx = dbCtx;
            dbCtx.BeginTransaction(isolation);
        }

        public void Complete()
        {
            _dbCtx.CommitTransaction();
            _dbCtx = null;
        }

        public void Dispose()
        {
            _dbCtx?.RollbackTransaction();
        }
    }
}
