namespace BakeryApp2024.Core.Contracts
{
    public interface IBakerService
    {
        Task<bool> ExistsByIdAsync(string userId);
        Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber);
        Task<bool> UserWithEmailExistsAsync(string email);
        Task CreateAsync(string userId, string phoneNumber, string email);
    }
}
