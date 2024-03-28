using System.ComponentModel.DataAnnotations;

namespace BakeryApp2024.Core.Models.Baker
{
    public class BakerServiceModel
    {
        [Display(Name ="Phone number")]
        public string PhoneNumber { get; init; } = null!;
        public string Email { get; init; } = null!;
    }
}
