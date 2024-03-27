using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookDog.Data.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b47fdb3-5061-451c-94b3-ed3a83ddde00", "AQAAAAEAACcQAAAAENUN82zjIwI/JpseZtrlMj63ElDdI42qlSq9H7dYlc1Xbq23Wy+0lM1qFVnRy3tE4w==", "34b8270a-c621-4497-88b0-c082b51970f1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec5325cd-f9d8-449f-a25c-d8a8fcbcfd26", "AQAAAAEAACcQAAAAEEpxLAI7mhCmXfD452ETOY0HmuyuN20npSuFeS5s9Bsb/5QArdG65EZEuWR6WSBqOw==", "603fd292-09eb-498b-8068-cc4b2fdd10ea" });
        }
    }
}
