using Sample.Models;
using Sample.ViewModels;

namespace Sample.Services
{
    public class AuthService : IAuthService
    {
        public async Task<UserViewModel> GetByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public async Task<Role> GetRoleByNameAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string>> GetRolesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<TokenViewModel> LoginAsync(LoginViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task RegisterAsync(UserRegisterViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
