using EmployeeManagementSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
         
       var user=  new ApplicationUser
         {
             Id = "b9b29d97-d0e0-4d57-b0c1-45c74c1598b2",
             FirstName = "Sayali",
             LastName = "Divekar",
             UserName = "SayaliD",
             Email = "sayali@gmail.com",
             PhoneNumber = "1234567890",
             NormalizedUserName = "SAYALID",
             NormalizedEmail = "SAYALI@GMAIL.COM",
             EmailConfirmed = true,
             PhoneNumberConfirmed = true,
             //SecurityStamp = "cc0dcb92-62a6-4539-b0db-930e63f7c2b4",
             //ConcurrencyStamp = "b2033cf3-267c-4a6b-86dc-fb2d6e1aa97c",
         };
        user.PasswordHash = hasher.HashPassword(user, "Sayali@123");
        builder.HasData(user);

        //user1.PasswordHash = hasher.HashPassword(user1, "Sayali@123");

        //builder.HasData(user1);
    }
}
