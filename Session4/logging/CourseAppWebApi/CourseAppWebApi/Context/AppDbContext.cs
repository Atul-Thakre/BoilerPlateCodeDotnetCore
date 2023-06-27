using CourseAppWebApi.Configurations;
using CourseAppWebApi.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CourseAppWebApi.Context
{
    public class AppDbContext:IdentityDbContext<APIUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> context):base(context)
        {
                
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CourseSeeding());
            builder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Course>Courses  { get; set; }

    }
}
