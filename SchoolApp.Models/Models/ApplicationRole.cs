using Microsoft.AspNetCore.Identity;

namespace SchoolApp.Models.Models
{
    public class ApplicationRole: IdentityRole<Guid>
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
