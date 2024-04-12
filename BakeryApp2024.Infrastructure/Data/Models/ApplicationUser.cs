using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Infrastructure.Data.Models
{
	public class ApplicationUser: IdentityUser
	{
		[Required]
		[MaxLength(UserFirstNameMaxLength)]
		[PersonalData]
		public string FirstName { get; set; } = string.Empty;

		[Required]
		[MaxLength(UserLastNameMaxLength)]
		[PersonalData]
		public string LastName { get; set; } = string.Empty;
	}
}
