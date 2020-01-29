using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace CapStone.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<CapStone.Models.CampaignFinance> CampaignFinances { get; set; }

        public System.Data.Entity.DbSet<CapStone.Models.Candidate> Candidates { get; set; }

        public System.Data.Entity.DbSet<CapStone.Models.CampaignTheme> CampaignThemes { get; set; }

        public System.Data.Entity.DbSet<CapStone.Models.CampaignStaff> CampaignStaffs { get; set; }

        public System.Data.Entity.DbSet<CapStone.Models.Endorsement> Endorsements { get; set; }

        public System.Data.Entity.DbSet<CapStone.Models.Policy> Policies { get; set; }

        public System.Data.Entity.DbSet<CapStone.Models.Ads> Ads { get; set; }
    }
}