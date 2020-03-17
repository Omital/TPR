using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TPR.EntityFramework.Repositories
{
    public abstract class TPRRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TPRDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TPRRepositoryBase(IDbContextProvider<TPRDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TPRRepositoryBase<TEntity> : TPRRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TPRRepositoryBase(IDbContextProvider<TPRDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
