using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Core.Services
{
    public class BakerService : IBakerService
    {
        private readonly IRepository repository;
        public BakerService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task CreateAsync(string userId, string name, string phoneNumber)
        {
            await repository.AddAsync(new Baker()
            {
                UserId = userId,
                Name = name,
                PhoneNumber = phoneNumber
            });

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Baker>()
                .AnyAsync(b => b.UserId == userId);
        }

        public async Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
        {
            return await repository.AllReadOnly<Baker>()
                .AnyAsync(b => b.PhoneNumber == phoneNumber);
        }
    }
}
