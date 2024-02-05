using SchoolApp.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace SchoolApp.Models.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin> Logins { get; set; }
        public virtual ICollection<ApplicationUserToken> Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Student Student { get; set; }
        public virtual Parent Father { get; set; }
        public virtual Parent Mother { get; set; }
    }
}
