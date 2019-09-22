using GetAPet.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GetAPet.Data
{
    public class GetAPetDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Announcement> Announcements { get; set; }

        public GetAPetDbContext(DbContextOptions<GetAPetDbContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Announcement>()
               .HasOne(a => a.Creator)
               .WithMany(c => c.Announcements)
               .HasForeignKey(a => a.CreatorId);

            base.OnModelCreating(builder);
        }
    }
}
