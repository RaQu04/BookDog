using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookDog.Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rate",
                table: "Offer",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c350e09c-6b16-4339-97db-65fcbdce7e13", "AQAAAAEAACcQAAAAEOoq6HFQwAjsSVCKDiAMgZj66wVKa3JhFoiXSNo9fJjgq6kWXFVOboxTY+vo91eTxg==", "1b801f92-9f05-42f1-9b88-93d15b465dcb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rate",
                table: "Offer",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff716bc8-becf-4fd4-ab5a-58b532f5b2ab", "AQAAAAEAACcQAAAAEF2T8iw3+tz0cE+vCseS1XuXzHxOKuKDYjHfw4T5g2+ide52CrucHx+Nzww7r7cc0Q==", "b3ac5b0f-d1a0-4aa3-9cfa-bad21df648ba" });
        }
    }
}
