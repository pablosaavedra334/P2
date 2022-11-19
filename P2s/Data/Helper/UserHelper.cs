using Microsoft.AspNetCore.Identity;
using P2s.Data.Entity;

namespace P2s.Data.Helper
{
    public class UserHelper :IUserHelper
    {
        private readonly UserManager<Usser> userManager;

        public UserHelper(UserManager<Usser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(Usser user, string password)
        {
            return await this.userManager.CreateAsync(user, password);

        }

        public async Task<Usser> GetUserByEmailAsync(string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            return user;
        }


    }
}
