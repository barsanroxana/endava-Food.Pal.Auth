using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPal.Auth.Migrations
{
    public partial class InitialCr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "69c4b28d-a70f-4852-a644-b56c85c1fff7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "client",
                column: "ConcurrencyStamp",
                value: "792ca6aa-f4a9-4227-89a2-05bed84a5e64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "delivery",
                column: "ConcurrencyStamp",
                value: "b3088346-a389-43d1-be3e-d83bb2be381b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86636d03-c8bc-4afe-b79f-d35ba9ecb08b", "AQAAAAEAACcQAAAAEERP7XFVbtoTtDZjX/s8vzYM9/o81TuHjow2dMhHkO/W/C5obAJ5/mZs9BkvkstR0g==", "d3ea4af1-6d56-4dd2-992e-a0b0d847abe6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "3d878628-26b0-4915-9b97-28fcce7c1ed2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "client",
                column: "ConcurrencyStamp",
                value: "0de8a95e-eb85-4739-b045-b1d587be1a8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "delivery",
                column: "ConcurrencyStamp",
                value: "13785cdb-44be-49df-897a-760c75afc5a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1fe2248-5183-4cdd-a88d-6a13ae1b0a41", "AQAAAAEAACcQAAAAEBuGjr+dIMc3OHCMxyppwE/FIIMwTLiIx/8MxqjRsQUZspSPstIxMOnDcK8nprvMyQ==", "887b64e2-6187-4148-bb46-de029abe8599" });
        }
    }
}
