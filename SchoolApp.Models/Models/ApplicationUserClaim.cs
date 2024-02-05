using Microsoft.AspNetCore.Identity;

namespace SchoolApp.Models.Models
{
    public class ApplicationUserClaim : IdentityUserClaim<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
