using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace datasource.Repositories
{
    public class UserRepository
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserRepository(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        // Create operation
        public async Task<IdentityResult> CreateUserAsync(IdentityUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            return result;
        }

        // Read operation
        public IQueryable<IdentityUser> GetAllUsers()
        {
            return _userManager.Users;
        }

        public async Task<IdentityUser> GetUserByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        public async Task<IdentityUser> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        // Update operation
        public async Task<IdentityResult> UpdateUserAsync(IdentityUser user)
        {
            var result = await _userManager.UpdateAsync(user);
            return result;
        }

        // Delete operation
        public async Task<IdentityResult> DeleteUserAsync(IdentityUser user)
        {
            var result = await _userManager.DeleteAsync(user);
            return result;
        }
    }
}
