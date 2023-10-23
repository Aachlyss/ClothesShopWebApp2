using Microsoft.AspNetCore.Identity;

namespace ClothesShopWebApp.Models
{
    public class AppUser : IdentityUser
    {
        public int BornIn { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
