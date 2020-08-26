using Microsoft.EntityFrameworkCore.Migrations;

namespace exercise.Migrations
{
    public partial class seedingCustomerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AvatarPath",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "AvatarPath", "ConfirmPassword", "Email", "FullName", "Password", "idDistrict", "idProvince", "idWard", "numberPhone" },
                values: new object[] { 1, null, "Qwerty!23", "xuanhoang054@gmail.com", "Hoang Tran", "Qwerty!23", 1, 2, 3, "0123456789" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "AvatarPath",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
