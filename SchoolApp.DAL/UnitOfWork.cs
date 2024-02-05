using SchoolApp.Core;
using SchoolApp.Core.IRepositories;
using SchoolApp.DAL.Repositories;
using SchoolApp.DAL.SchoolContext;

namespace SchoolApp.DAL
{
    public sealed class UnitOfWork<TEntity> : IUnitOfWork<TEntity> where TEntity : class
    {
        private readonly SchoolDbContext _context;
        private Repository<TEntity> _repository;

        public UnitOfWork(SchoolDbContext context)
        {
            _context = context;
        }
        public IRepository<TEntity> Entity => _repository ??= new Repository<TEntity>(_context);

        public int Commit() => _context.SaveChanges();
        public async Task<int> CommitAsync() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
