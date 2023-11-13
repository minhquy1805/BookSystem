using Book_System.Models;

namespace Book_System.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category> 
    {
        void Update(Category obj);


    }
}
