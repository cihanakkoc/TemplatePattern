using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Models
{
    public class AppUser : IdentityUser
    {
        public string PictureUrl { get; set; }

        public string Description { get; set; }
    }
}