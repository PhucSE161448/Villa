using Microsoft.AspNetCore.Identity;

namespace Villa.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
