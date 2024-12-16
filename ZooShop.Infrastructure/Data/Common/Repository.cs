using Microsoft.EntityFrameworkCore;
using ZooShop.Infrastructure.Data.Models;

namespace ZooShop.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private readonly ZooShopDbContext _context;

        public Repository(ZooShopDbContext context)
        {
            _context = context;
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return _context.Set<T>();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public Product GetProduct(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.Id == productId);
        }

        public async Task DeleteAsync<T>(object id) where T : class
        {
            T? entity = await GetByIdAsync<T>(id);

            if (entity != null)
            {
                DbSet<T>().Remove(entity);
            }
        }
    }
}
