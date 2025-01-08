using AsiaSushiOnCSharp.Domain.Entity.Goods;

namespace AsiaSushiOnCSharp.Domain.InterfacesForRepo
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProductRepository
    {
        public Task<long> Add(Product product);

        public Task Delete(long id);

        public Task<Product> GetById(long id);

        public Task<Product> GetByName(string name);
    }
}
