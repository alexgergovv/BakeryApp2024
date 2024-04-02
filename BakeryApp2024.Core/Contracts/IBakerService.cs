using BakeryApp2024.Core.Models.Baker;

namespace BakeryApp2024.Core.Contracts
{
    public interface IBakerService
    {
        Task<bool> ExistsByIdAsync(string userId);
        Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber);
        Task CreateAsync(BecomeBakerFormModel baker, string userId);
        Task<int?> GetBakerIdAsync(string userId);

        Task<IEnumerable<BakerChipModel>> GetAllAsChipModelAsync();
    }
}
