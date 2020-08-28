using Microsoft.EntityFrameworkCore.Migrations;

namespace exercise.Migrations
{
    public partial class drop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "094bd0a0-2770-43c6-8e3f-c0880a810a04");

            migrationBuilder.DropColumn(
                name: "numberPhone",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarPath", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "idDistrict", "idProvince", "idWard" },
                values: new object[] { "358d5dec-08f2-44b6-b5d8-ee3223590676", 0, "41/16 Lương Y", null, "bb7dd2b4-209e-41e7-9097-ceb4d77b4873", "xuanhoang054@gmail.com", false, "Hoang Tran", false, null, null, null, null, "0123456789", false, "1259dac1-6e0b-49c0-958b-24dcd594a04d", false, null, 1, 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "358d5dec-08f2-44b6-b5d8-ee3223590676");

            migrationBuilder.AddColumn<string>(
                name: "numberPhone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarPath", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "idDistrict", "idProvince", "idWard", "numberPhone" },
                values: new object[] { "094bd0a0-2770-43c6-8e3f-c0880a810a04", 0, "41/16 Lương Y", null, "537b6ef8-c26d-4bf6-801d-91cac7b25eb5", "xuanhoang054@gmail.com", false, "Hoang Tran", false, null, null, null, null, null, false, "e8918f3c-adf6-4cd1-a15d-533f3e816660", false, null, 1, 2, 3, "0123456789" });
        }
    }
}
