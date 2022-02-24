using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
