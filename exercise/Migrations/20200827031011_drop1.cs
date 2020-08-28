using Microsoft.EntityFrameworkCore.Migrations;

namespace exercise.Migrations
{
    public partial class drop1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87a4773-a12c-4196-9a33-11227349712e");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarPath", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "idDistrict", "idProvince", "idWard", "numberPhone" },
                values: new object[] { "094bd0a0-2770-43c6-8e3f-c0880a810a04", 0, "41/16 Lương Y", null, "537b6ef8-c26d-4bf6-801d-91cac7b25eb5", "xuanhoang054@gmail.com", false, "Hoang Tran", false, null, null, null, null, null, false, "e8918f3c-adf6-4cd1-a15d-533f3e816660", false, null, 1, 2, 3, "0123456789" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "094bd0a0-2770-43c6-8e3f-c0880a810a04");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarPath", "ConcurrencyStamp", "ConfirmPassword", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "idDistrict", "idProvince", "idWard", "numberPhone" },
                values: new object[] { "a87a4773-a12c-4196-9a33-11227349712e", 0, "41/16 Lương Y", null, "7433bac6-a9ea-4789-8a26-5a8b257b7285", "Qwerty!23", "xuanhoang054@gmail.com", false, "Hoang Tran", false, null, null, null, "Qwerty!23", null, null, false, "decb47e6-6c39-4d2e-bb7a-d2b10edf3d46", false, null, 1, 2, 3, "0123456789" });
        }
    }
}
