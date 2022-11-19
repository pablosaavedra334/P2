using Microsoft.AspNetCore.Identity;
using P2s.Data.Entity;

namespace P2s.Data.Helper
{
    public interface IUserHelper
    {
        Task<Usser> GetUserByEmailAsync(string email);
        Task<IdentityResult> AddUserAsync(Usser user, string password);

    }
}
