using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstTask.Migrations
{
    public partial class Seeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Completed", "Home", "Open", "PeerReviews", "Pendding" },
                values: new object[] { 1, "Pending", "Hi-Tech", "Status", "rating", "Pendding" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Completed", "Home", "Open", "PeerReviews", "Pendding" },
                values: new object[] { 2, "Pending", "Hi-Tech", "Status", "rating", "Pendding" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Completed", "Home", "Open", "PeerReviews", "Pendding" },
                values: new object[] { 3, "Pending", "Hi-Tech", "Status", "rating", "Pendding" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
