using Microsoft.AspNetCore.Identity;

namespace PustokP322.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
