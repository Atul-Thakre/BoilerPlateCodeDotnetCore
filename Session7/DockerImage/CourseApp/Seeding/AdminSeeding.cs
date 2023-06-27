using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Seeding
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
                 new IdentityUser
                 {
                     Id = "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                     UserName = "admin@gmail.com",
                     NormalizedUserName = "admin@gmail.com",
                     Email = "admin@gmail.com",
                     PasswordHash = hasher.HashPassword(null, "Atul@123")
                 });
        }
    }
}