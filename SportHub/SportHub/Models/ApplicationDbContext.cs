using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SportHub.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Sport> Sports  { get; set; }
        public DbSet <Type> Types { get; set; }
     //   public object Type { get; internal set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}