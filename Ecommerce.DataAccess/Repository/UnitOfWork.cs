using Ecommerce.DataAccess.Repository.IRepository;
using Eecommerce.DataAccess.Data;

namespace Ecommerce.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);

        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
