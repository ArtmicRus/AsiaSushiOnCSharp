using AsiaSushiOnCSharp.Domain.Entity.Goods;
using AsiaSushiOnCSharp.Domain.InterfacesForRepo;

namespace AsiaSushiOnCSharp.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
            
        }

        public Task<long> Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}