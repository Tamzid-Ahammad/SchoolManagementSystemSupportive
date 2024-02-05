using Microsoft.AspNetCore.Identity;

namespace SchoolApp.Models.Models
{
    public class ApplicationUserRole: IdentityUserRole<Guid>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
        public string Discriminator { get; set; }
    }
}
