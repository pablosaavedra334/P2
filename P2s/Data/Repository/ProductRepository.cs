using P2s.Data.Entity;

namespace P2s.Data.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository

    {

        public ProductRepository(DataContext context): base (context)
        {



        }

    }
}
