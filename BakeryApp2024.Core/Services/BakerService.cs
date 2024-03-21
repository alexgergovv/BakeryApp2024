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

        public Task CreateAsync(string userId, string phoneNumber, string email)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Baker>()
                .AnyAsync(b => b.UserId == userId);
        }

        public Task<bool> UserWithEmailExistsAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
