namespace P2s.Data
{
    public interface IGenericRepository <T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int id); //busqueda compleata

        Task CreateAync(T entity);  //busqueda compleata

        Task UpdateAsync(T entity);  

        Task DeleteAsync(T entity);

        Task<bool> ExistAscync(int id);

    }
}
