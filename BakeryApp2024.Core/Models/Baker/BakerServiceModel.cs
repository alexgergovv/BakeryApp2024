using System.ComponentModel.DataAnnotations;

namespace BakeryApp2024.Core.Models.Baker
{
    public class BakerServiceModel
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; } = null!;

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; init; } = null!;
        public string Email { get; init; } = null!;
        public string Gender {  get; init; } = null!;
    }
}
