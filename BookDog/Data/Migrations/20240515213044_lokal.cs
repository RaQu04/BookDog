using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookDog.Data.Migrations
{
    public partial class lokal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3731c919-57b8-445b-a5e3-2dc2bc5361c7", "AQAAAAEAACcQAAAAEIOvct8lYg4/LPoyWqV+dEIuf8fMOKt/gtBWta7TA6aKlvuBY3xXSPp1TQZRIIMJAA==", "dbb54c3a-8cee-478f-9046-969e8e6fc45f" });
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
