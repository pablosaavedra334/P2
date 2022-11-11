using P2s.Data.Entity;

namespace P2s.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product>GetProducts()    //ordena en orden alfabetico
        {
            return this.context.products.OrderBy(p => p.Name);
        }

        public Product GetProduct (int Id)
        {

            return this.context.products.Find(Id);  ///ordena por id (no se repite)
        }

        public void AddProduct(Product product)  //"product"  es una variable
        {

            this.context.products.Add(product); //añadir en la tabla productos

        }

        public void UpdateProduct(Product product)
        {

            this.context.products.Update(product);

        }

        public void RemoveProduct(Product product)
        {

            this.context.products.Remove(product);
        }

        public async Task<bool> SaveAllAsync()
        {

            return await this.context.SaveChangesAsync() > 0;
        }

        public bool ProductExists(int id)
        {
            return this.context.products.Any(p => p.Id == id);  ///controla el id
        }
    }
}
