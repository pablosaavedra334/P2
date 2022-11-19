using P2s.Data.Entity;

namespace P2s.Data.Repository
{
   
    
        public class CityRepository : GenericRepository<City>, ICityRepository

        {

            public CityRepository(DataContext context) : base(context)
            {



            }

        }

    
}
