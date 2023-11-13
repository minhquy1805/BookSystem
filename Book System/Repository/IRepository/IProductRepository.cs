using Book_System.Models;

namespace Book_System.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product pbj);
    }
}
