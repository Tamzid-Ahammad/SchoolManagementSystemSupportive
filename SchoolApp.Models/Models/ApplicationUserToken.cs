using Microsoft.AspNetCore.Identity;

namespace SchoolApp.Models.Models
{
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
