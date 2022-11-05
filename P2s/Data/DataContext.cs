using Microsoft.EntityFrameworkCore;
using P2s.Data.Entity;

namespace P2s.Data
{
    public class DataContext : DbContext



    {

        public DbSet<Country> Countres { set; get; }
        public DbSet<Product> products { set; get; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {



        }

        
    }
}
