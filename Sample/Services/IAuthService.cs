using Sample.Models;
using Sample.ViewModels;

namespace Sample.Services
{
    public interface IAuthService
    {
        Task RegisterAsync(UserRegisterViewModel viewModel);
        Task<UserViewModel> GetByUsernameAsync(string username);
        Task<IEnumerable<string>> GetRolesAsync();
        Task<Role> GetRoleByNameAsync(string roleName);

        Task<TokenViewModel> LoginAsync(LoginViewModel viewModel);
    }
}
