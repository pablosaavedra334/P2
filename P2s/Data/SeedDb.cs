using P2s.Data.Entity;

namespace P2s.Data
{
    public class SeedDb
    {
        private readonly DataContext context;

        private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedDbAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if(!this.context.products.Any())
            {
                this.AddProduct("Lavadora");
                this.AddProduct("Licuadora");
                this.AddProduct("Refrigerador");
                await this.context.SaveChangesAsync();


            }

            if (!this.context.cities.Any())
            {
                this.AddCity("La Paz");
                this.AddCity("Cochabamba");
                this.AddCity("Oruro");
                await this.context.SaveChangesAsync();


            }
        }

        private void AddCity(String name)
        {
            this.context.products.Add(new Product

            {
                Name = name,
                IsActive = true

            }

                );


        }
        private void AddProduct(String name)
        {
            this.context.products.Add(new Product

            {
                Name = name,
                Price = this.random.Next(100),
                IsActive = true,
                Stock = this.random.NextDouble()

            }

                );
                

        }
    }
}
