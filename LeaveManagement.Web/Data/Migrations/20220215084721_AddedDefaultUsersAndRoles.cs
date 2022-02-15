using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bca31137-e1fb-3665-2443-b275eee11edb", "e4646157-e8cd-4490-97f1-cd749703558c", "User", "USER" },
                    { "fcc42137-a2bb-4559-1759-e155fae88dff", "4cf1ae71-06ee-4f07-b42f-4a63639e902c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b", 0, "624340d9-15d3-4deb-90d5-fc310a8d0efe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEIWQ00/G9CxAQ+3rxENHpgx0CCmJKtPphMQmpiTRqmRoYdNHSP62WuJlkmusA9mJ8g==", null, false, "91fbf58c-d547-4e02-9087-dece72646f61", null, false, null },
                    { "53a0387e-b4c4-4586-9022-e51f538929bd", 0, "4d5d6d24-aee7-4f34-9a9e-5da0b3569f0a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEBktY7gcyc1lJVqP+C1byhpa6YefOj5dRlgJrddGlMY8cCyY/l3l2Bc7a/sloQKhfQ==", null, false, "df307dcf-ad0f-43f1-8e42-a29cd3c61546", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fcc42137-a2bb-4559-1759-e155fae88dff", "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bca31137-e1fb-3665-2443-b275eee11edb", "53a0387e-b4c4-4586-9022-e51f538929bd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fcc42137-a2bb-4559-1759-e155fae88dff", "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bca31137-e1fb-3665-2443-b275eee11edb", "53a0387e-b4c4-4586-9022-e51f538929bd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bca31137-e1fb-3665-2443-b275eee11edb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcc42137-a2bb-4559-1759-e155fae88dff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53a0387e-b4c4-4586-9022-e51f538929bd");
        }
    }
}
