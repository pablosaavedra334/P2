using Microsoft.EntityFrameworkCore;
using P2s.Data.Entity;

namespace P2s.Data
{
    public class DataContext : DbContext

    {

        public DbSet<Country> Countres { set; get; }
        public DbSet<Product> products { set; get; }
        public DbSet<City> cities{ set; get; }
        public object City { get; internal set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {



        }

        
    }
}
