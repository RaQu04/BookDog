using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookDog.Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec5325cd-f9d8-449f-a25c-d8a8fcbcfd26", "AQAAAAEAACcQAAAAEEpxLAI7mhCmXfD452ETOY0HmuyuN20npSuFeS5s9Bsb/5QArdG65EZEuWR6WSBqOw==", "603fd292-09eb-498b-8068-cc4b2fdd10ea" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c350e09c-6b16-4339-97db-65fcbdce7e13", "AQAAAAEAACcQAAAAEOoq6HFQwAjsSVCKDiAMgZj66wVKa3JhFoiXSNo9fJjgq6kWXFVOboxTY+vo91eTxg==", "1b801f92-9f05-42f1-9b88-93d15b465dcb" });
        }
    }
}
