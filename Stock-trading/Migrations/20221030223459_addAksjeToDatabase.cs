using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock_trading.Migrations
{
    public partial class addAksjeToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aksjer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<int>(nullable: false),
                    Pris = table.Column<double>(nullable: false),
                    Antall = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aksjer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aksjer");
        }
    }
}
