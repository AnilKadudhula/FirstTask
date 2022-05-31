using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstTask.Migrations
{
    public partial class Intal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Home = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Open = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Completed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pendding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeerReviews = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
