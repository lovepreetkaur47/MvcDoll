using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcDoll.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Doll",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Doll",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Doll",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Doll");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Doll");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Doll",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
