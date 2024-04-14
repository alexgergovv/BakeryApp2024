using BakeryApp2024.Core.Models.Admin.User;

namespace BakeryApp2024.Core.Contracts
{
    public interface IUserService
    {
        Task<string> UserFullNameAsync(string userId);

        Task<IEnumerable<UserServiceModel>> AllAsync();
    }
}
