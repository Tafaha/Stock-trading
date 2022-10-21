using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock_trading.Migrations
{
    public partial class AddAksjeToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ENavn",
                table: "Aksje");

            migrationBuilder.AlterColumn<int>(
                name: "Navn",
                table: "Aksje",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Navn",
                table: "Aksje",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ENavn",
                table: "Aksje",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
