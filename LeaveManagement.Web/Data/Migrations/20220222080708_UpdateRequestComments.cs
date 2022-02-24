using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bca31137-e1fb-3665-2443-b275eee11edb",
                column: "ConcurrencyStamp",
                value: "5058dfa5-fafa-48a9-8c05-243c965482ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcc42137-a2bb-4559-1759-e155fae88dff",
                column: "ConcurrencyStamp",
                value: "a194b1f5-a1ad-45ab-863a-78db674a66f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8bb939e-009b-41fc-842f-ac50ffe78621", "AQAAAAEAACcQAAAAEP/2hefx2gahEvHOBKXYXTykR6uHjpUpBop6IKDl/S9ijStkFYHNCNAOEMV8tXf5tg==", "a010d071-1d42-4c98-9cec-c9819914bdd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53a0387e-b4c4-4586-9022-e51f538929bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "291104b9-ea66-48cc-add6-bc46deab3829", "AQAAAAEAACcQAAAAELdD5WWy9qKt4qBO7JvQm/NpW/k80SfvMdB1gUAtiBIWaZ4B2kaeB15Ma9LmHQPs5w==", "94f4ddf2-64f6-4a62-8352-822706b408b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bca31137-e1fb-3665-2443-b275eee11edb",
                column: "ConcurrencyStamp",
                value: "0d7a5b11-9a2e-4c5e-ad9c-37bacb3c3ebd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcc42137-a2bb-4559-1759-e155fae88dff",
                column: "ConcurrencyStamp",
                value: "f429be33-2cc7-44cf-bc30-0013594c874e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b26271e-dd3e-4f5e-ba7b-d930f90ca86b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6885d6ce-f504-4916-bcde-06a7352a7a16", "AQAAAAEAACcQAAAAEOok1a99TQJ6YjQ8flqLmmimEFpnRb5WD084E9E4uGEYFbO392hNfF6s2NAH+225YA==", "7c6e0850-ddb6-4310-8d16-aded21e4454e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53a0387e-b4c4-4586-9022-e51f538929bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11039338-9868-4f29-9596-a00fe3b0bb14", "AQAAAAEAACcQAAAAEKpmcUJtoAgtiUFdEtQ7nCyAaj3KD1x2SyNDqZjd7Gw8wHd78cICE7oGUMfiIZioJw==", "6b7b2847-9f3e-43ee-b10a-7a75a864b553" });
        }
    }
}
