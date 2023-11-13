using Book_System.Data;
using Book_System.Models;
using Book_System.Repository.IRepository;
using System.Linq.Expressions;

namespace Book_System.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }

    }
}
