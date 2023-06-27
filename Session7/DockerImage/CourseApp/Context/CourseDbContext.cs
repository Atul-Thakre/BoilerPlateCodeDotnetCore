using CourseApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASpNetCoreIdentity.Models;
using CourseApp.Seeding;

namespace CourseApp.Context
{
    public class CourseDbContext:IdentityDbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> Context):base(Context)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        //Create table
        public DbSet <Course> Courses{ get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ASpNetCoreIdentity.Models.RegisterModel>? User { get; set; }
        public DbSet<ASpNetCoreIdentity.Models.LoginModel>? Login { get; set; }
        
    }
}
