using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Baker;
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

        public async Task CreateAsync(BecomeBakerFormModel model, string userId)
        {
            await repository.AddAsync(new Baker()
            {
                UserId = userId,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                Gender = model.Gender
            });

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Baker>()
                .AnyAsync(b => b.UserId == userId);
        }

		public async Task<IEnumerable<BakerChipModel>> GetAllAsChipModelAsync()
		{
            var bakers = await repository.AllReadOnly<Baker>()
                .Where(b => string.IsNullOrEmpty(b.Name) == false)
                .Select(b => new BakerChipModel()
                {
                    Name = b.Name,
                    PhoneNumber = b.PhoneNumber,
                    Gender = b.Gender
                })
                .ToListAsync();

            foreach (var baker in bakers)
            {
                if (baker.Gender == "Male")
                {
                    baker.ImageURL = "https://thumbs.dreamstime.com/b/male-baker-avatar-man-working-bakery-profile-user-person-people-icon-vector-illustration-isolated-220472374.jpg";
                }
                else
                {
                    baker.ImageURL = "https://cdn4.vectorstock.com/i/1000x1000/07/93/young-female-chef-avatar-character-vector-24750793.jpg";
				}
            }

            return bakers;
		}

		public async Task<int?> GetBakerIdAsync(string userId)
        {
			return (await repository.AllReadOnly<Baker>()
					.FirstOrDefaultAsync(b => b.UserId == userId))?.Id;
		}

        public async Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
        {
            return await repository.AllReadOnly<Baker>()
                .AnyAsync(b => b.PhoneNumber == phoneNumber);
        }
    }
}
