using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bca31137-e1fb-3665-2443-b275eee11edb",
                column: "ConcurrencyStamp",
                value: "3beb82ec-ab7e-4533-a621-03a0dba1f288");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcc42137-a2bb-4559-1759-e155fae88dff",
                column: "ConcurrencyStamp",
                value: "a9bd98ec-57f8-498e-9e4b-59cdbcc64d20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "739c25ad-270d-44a5-a4cf-a106ae948378", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENFMCRQNT9og6CB9GaDVrJR+kE0HvY3edNtNoGFM5LDnOvYrGnbJueaWS8zlN9/41w==", "5493444b-e5fa-413a-bfb0-52fca30ff86a", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53a0387e-b4c4-4586-9022-e51f538929bd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0153eb5c-ef4a-4874-af3c-5c40f1f43223", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMwOop1OHai/WH9s71uSo6QvTVMkcdwte2MEDGd73Jm8P/VFf0wPP+uNsC+iCaOVXw==", "11a53505-2091-4541-9e99-0c3fbf216b31", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bca31137-e1fb-3665-2443-b275eee11edb",
                column: "ConcurrencyStamp",
                value: "e4646157-e8cd-4490-97f1-cd749703558c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcc42137-a2bb-4559-1759-e155fae88dff",
                column: "ConcurrencyStamp",
                value: "4cf1ae71-06ee-4f07-b42f-4a63639e902c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "624340d9-15d3-4deb-90d5-fc310a8d0efe", false, null, "AQAAAAEAACcQAAAAEIWQ00/G9CxAQ+3rxENHpgx0CCmJKtPphMQmpiTRqmRoYdNHSP62WuJlkmusA9mJ8g==", "91fbf58c-d547-4e02-9087-dece72646f61", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53a0387e-b4c4-4586-9022-e51f538929bd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4d5d6d24-aee7-4f34-9a9e-5da0b3569f0a", false, null, "AQAAAAEAACcQAAAAEBktY7gcyc1lJVqP+C1byhpa6YefOj5dRlgJrddGlMY8cCyY/l3l2Bc7a/sloQKhfQ==", "df307dcf-ad0f-43f1-8e42-a29cd3c61546", null });
        }
    }
}
