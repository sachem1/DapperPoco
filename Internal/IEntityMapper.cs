
// 



// 
using System;
using Jiesen.DapperPoco.Metadata;

namespace Jiesen.DapperPoco.Internal
{
    public interface IEntityMapper
    {
        EntityTableInfo GetEntityTableInfo(Type entityType);
    }
}
