using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPal.Auth.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "f7e2b649-ec5c-48eb-bd24-747c1f3eafc0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "client",
                column: "ConcurrencyStamp",
                value: "f30a8c80-b2ca-4b40-9817-9b96328ca273");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "delivery",
                column: "ConcurrencyStamp",
                value: "3d44da47-a7c3-4951-b085-511c7dad857a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "505a5e1e-5c3f-4c54-9ad9-a209605829f7", "AQAAAAEAACcQAAAAEPC8YG0BeVgnnnnMhmI+yKydS3+myt8s+fzgwk6AmPGHlsM3uRoC1+4rHYtZrv5AdQ==", "2807097e-ca68-4c00-ba20-c06b00833c92" });
        }
    }
}
