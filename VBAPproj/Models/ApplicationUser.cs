using Microsoft.AspNetCore.Identity;

namespace VBAPproj.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string FullName { get; set; }
    }
}
