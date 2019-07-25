
// 



// 
using Jiesen.DapperPoco.Adapters;

namespace Jiesen.DapperPoco.Internal
{
    public interface IDbContextServices
    {
        string ConnectionString { get; }
        ISqlAdapter SqlAdapter { get; }
        IEntityMapper EntityMapper { get; }
        ISqlGenerater SqlGenerater { get; }
    }
}
