using P2s.Data.Entity;

namespace P2s.Data.Repository
{
    public interface IRepository
    {

        IEnumerable<Product> GetProducts();

        Product GetProduct(int Id);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void RemoveProduct(Product product);

        Task<bool> SaveAllAsync();

        bool ProductExists(int id);




    }
}
