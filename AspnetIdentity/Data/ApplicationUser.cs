using Microsoft.AspNetCore.Identity;

namespace AspnetIdentity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }

        public string? DisplayName { get; set; }
    }
}
