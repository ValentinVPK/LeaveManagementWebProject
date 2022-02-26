using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "fcc42137-a2bb-4559-1759-e155fae88dff",
                    UserId = "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bca31137-e1fb-3665-2443-b275eee11edb",
                    UserId = "53a0387e-b4c4-4586-9022-e51f538929bd"
                }
            );
        }
    }
}