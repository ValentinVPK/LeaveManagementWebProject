using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bca31137-e1fb-3665-2443-b275eee11edb",
                column: "ConcurrencyStamp",
                value: "3537519b-a765-4e84-b03a-bd9eb439a4be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcc42137-a2bb-4559-1759-e155fae88dff",
                column: "ConcurrencyStamp",
                value: "85b46e7c-ad33-46e9-9971-2574180c8a6a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ce3aa22-2335-4be2-927b-72ac2a934f80", "AQAAAAEAACcQAAAAELuR0Nq4EroNK3MsAnluuzmnSn2uPatGeymeS1smXfY4BdC+K6NIdtkNZGBCtYV2RA==", "0a4300d9-822d-45f6-8e9f-612ad91de2b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53a0387e-b4c4-4586-9022-e51f538929bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "079ed872-29ab-440e-9c3f-e4975f2a330a", "AQAAAAEAACcQAAAAEBlqwKaYvYDDKBpUPcx2MzL8Vim8o/3l/FHNX4f1twuJQFYxbpTCQbvh1zdjyfl8Qg==", "d7a47351-5c88-493c-813a-fa9e6efa14e2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "739c25ad-270d-44a5-a4cf-a106ae948378", "AQAAAAEAACcQAAAAENFMCRQNT9og6CB9GaDVrJR+kE0HvY3edNtNoGFM5LDnOvYrGnbJueaWS8zlN9/41w==", "5493444b-e5fa-413a-bfb0-52fca30ff86a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53a0387e-b4c4-4586-9022-e51f538929bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0153eb5c-ef4a-4874-af3c-5c40f1f43223", "AQAAAAEAACcQAAAAEMwOop1OHai/WH9s71uSo6QvTVMkcdwte2MEDGd73Jm8P/VFf0wPP+uNsC+iCaOVXw==", "11a53505-2091-4541-9e99-0c3fbf216b31" });
        }
    }
}
