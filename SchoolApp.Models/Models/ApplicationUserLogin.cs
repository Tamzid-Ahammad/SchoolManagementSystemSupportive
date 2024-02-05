using Microsoft.AspNetCore.Identity;

namespace SchoolApp.Models.Models
{
    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
