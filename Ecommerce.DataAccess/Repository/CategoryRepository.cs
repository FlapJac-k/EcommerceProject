using Ecommerce.DataAccess.Repository.IRepository;
using Ecommerce.Models;
using Eecommerce.DataAccess.Data;

namespace Ecommerce.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db) {
            _db = db;
        }

        public void Update(Category category)
        {
            _db.categories.Update(category);
        }
    }
}
