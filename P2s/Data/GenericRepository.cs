using Microsoft.EntityFrameworkCore;
using P2s.Data.Entidad;

namespace P2s.Data
{
    public class GenericRepository<T> : IGenericRepository <T> where T : class, IEntity     //repositorio general  ***Generar INterfaz en "Igenericrepository"
    {
        private readonly DataContext context;

        public GenericRepository(DataContext context)  //Crear campo asiganr
        {
            this.context = context;
        }

        public async Task CreateAync(T entity)
        {
          await this.context.Set<T>().AddAsync(entity);
            await SaveAllAsync();
        }

        public async Task DeleteAsync(T entity)
        {

            this.context.Set<T>().Remove(entity);  //eliminar
            await SaveAllAsync();

        }

        public async Task<bool> ExistAscync(int id)   //BUSCA SI ES EXISTENTE EL ID
        {
            return await this.context.Set<T>().AnyAsync(e => e.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return this.context.Set<T>().AsNoTracking();  // todo lo que entre que haga un traking (muestra todo la informaccion) 
        }

        public async Task<T> GetByIdAsync(int id)  // BUSCA Y MUESRA SI EXISTE Y SI NO NO LO HARA
        {
            return await this.context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task UpdateAsync(T entity)
        {
            this.context.Set<T>().Update(entity);  //añadir
            await SaveAllAsync();
        }
        public async Task<bool> SaveAllAsync()     //crear
        {
            return await this.context.SaveChangesAsync() > 0;
        }
    }
}
