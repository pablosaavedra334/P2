using P2s.Data.Entity;

namespace P2s.Data.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository

    {

        public CountryRepository(DataContext context) : base(context)
        {



        }
         
    }
}
