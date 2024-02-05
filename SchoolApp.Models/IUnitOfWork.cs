using SchoolApp.Core.IRepositories;

namespace SchoolApp.Core
{
    public interface IUnitOfWork<TEntity> : IDisposable where TEntity : class
    {
        IRepository<TEntity> Entity { get; }
        Task<int> CommitAsync();
        int Commit();
    }
}
